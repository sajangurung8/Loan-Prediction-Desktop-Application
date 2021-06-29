using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Prediction_Desktop_Application
{
    public partial class predictForm : Form
    {
        // feilds used for ML function
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "loandataset.txt");
        static MLContext mlContext = new MLContext(seed: 0);
        static IDataView dataView;
        static ITransformer model;
        static bool trainedModel = false;


        //ctor
        public predictForm()
        {
            InitializeComponent();
        }

        // method returns true if all the feilds in the form are filled out correctly
        private bool CheckFeilds()
        {
            float checker;
            try {
                checker = float.Parse(monthlyIncomeTB.Text);
                checker = float.Parse(monthlyPaymentTB.Text);
                checker = float.Parse(acsTb.Text);
                checker = float.Parse(autoLoanPaymentTb.Text);
                checker = float.Parse(ccPayment.Text);
                checker = float.Parse(creditScore.Text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Feild could not be converted: "+e.Message);
                return false;
            }
            return true;
        }

        // method to train ML model using data from loandataset.txt in data folder
        private void TrainMlModel()
        {
            // reads data from the file and loads individual data form each line
            dataView = mlContext.Data.LoadFromTextFile<LoanData>(_dataPath, hasHeader: false, separatorChar: ',');

            // naming the columns
            string loanColumnName = "Features";

            // creating pipeline for the model with clustering model with 3 clusters
            var pipeline = mlContext.Transforms.Concatenate(loanColumnName,
                "MonthlyIncome",
                "MortgageOrRent",
                "ChildSupport",
                "AutoPayments",
                "CreditCardPayments",
                "CreditScore",
                "DebtIncomeRatio").Append(mlContext.Clustering.Trainers.KMeans(loanColumnName, numberOfClusters: 3));

            // trining the model
            model = pipeline.Fit(dataView);
        }

        // click event handler for predictNowButton
        private void predictNowButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFeilds())
                {
                    LoanData myData = new LoanData
                    {
                        MonthlyIncome = float.Parse(monthlyIncomeTB.Text),
                        MortgageOrRent = float.Parse(monthlyPaymentTB.Text),
                        ChildSupport = float.Parse(acsTb.Text),
                        AutoPayments = float.Parse(autoLoanPaymentTb.Text),
                        CreditCardPayments = float.Parse(ccPayment.Text),
                        CreditScore = float.Parse(creditScore.Text),
                        DebtIncomeRatio = (float)Math.Round((decimal.Parse(monthlyIncomeTB.Text) + decimal.Parse(monthlyPaymentTB.Text) + decimal.Parse(acsTb.Text) + decimal.Parse(autoLoanPaymentTb.Text) + decimal.Parse(ccPayment.Text)) / decimal.Parse(monthlyIncomeTB.Text) * 100, 2)
                    };
                    if (myData.MonthlyIncome <= (myData.MortgageOrRent + myData.ChildSupport + myData.AutoPayments + myData.CreditCardPayments))
                        throw new IncomeRatioException("Expenditure exceeds or is equal to Income");

                    if (!trainedModel)
                    {
                        TrainMlModel();
                        trainedModel = true;
                    }

                    var predictor = mlContext.Model.CreatePredictionEngine<LoanData, ApprovalOddsPrediction>(model);

                    var prediction = predictor.Predict(myData);
                    string sugestion = "";
                    if (prediction.PredictedClusterId.Equals(1))
                    {
                        sugestion = "";
                        predictOutPutLabel.ForeColor = Color.FromArgb(255, 255, 0);
                        predictOutPutLabel.Text = "You might be approved if you maintain your current credit standings.";
                        if (myData.CreditScore < 680)
                        {
                            sugestion = sugestion + "Having a higher credit score can help you qualify for a better rate\n";
                        }
                        if (myData.DebtIncomeRatio > 30)
                        {
                            sugestion = sugestion + "Your Debt to income ratio is on the margin,\n you might want to consider paying off some of your credit.";
                        }
                        outputSugestionLabel.ForeColor = Color.FromArgb(227, 227, 227);
                        outputSugestionLabel.Text = sugestion;
                    }
                    else if (prediction.PredictedClusterId.Equals(2))
                    {
                        sugestion = "";
                        predictOutPutLabel.ForeColor = Color.FromArgb(0, 255, 0);
                        predictOutPutLabel.Text = "It is more than likely you will be approved for \nthe loan you performed this calculation on.";
                        outputSugestionLabel.ForeColor = Color.FromArgb(227, 227, 227);
                        outputSugestionLabel.Text = sugestion;

                    }
                    else
                    {
                        sugestion = "";
                        predictOutPutLabel.ForeColor = Color.FromArgb(255, 0, 0);
                        predictOutPutLabel.Text = "Depending on the inputs you have made, I do not think you will qualify.";

                        if (myData.CreditScore < 620)
                        {
                            sugestion = sugestion + "Your credit Score is below the minimum of most VA Lenders require\n";
                        }
                        if (myData.DebtIncomeRatio > 39)
                        {
                            sugestion = sugestion + "Your Debt to income ratio is too high, try paying off outstanding credit or\nlower your loan ammount for the loan";
                        }
                        outputSugestionLabel.ForeColor = Color.FromArgb(227, 227, 227);
                        outputSugestionLabel.Text = sugestion;
                    }


                }
                else
                {
                    MessageBox.Show("All input feild must be filled and numbers in correct format");
                }
            }
            catch (IncomeRatioException ie)
            {
                MessageBox.Show(ie.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("One of your input is not in correct format!");
            }
        }
        // click event handler for getPaymentButton
        private void getPaymentBtn_Click(object sender, EventArgs e)
        {
            GetMonthlyPayment f1 = new GetMonthlyPayment();
            f1.ShowDialog();
            monthlyPaymentTB.Text = f1.GetPayment().ToString();
        }
    }
}
