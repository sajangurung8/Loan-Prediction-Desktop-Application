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
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "loandataset.txt");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "LoanClusteringModel.zip");
        static MLContext mlContext = new MLContext(seed: 0);
        

        public predictForm()
        {
            InitializeComponent();
        }

        private void predictNowButton_Click(object sender, EventArgs e)
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

                IDataView dataView = mlContext.Data.LoadFromTextFile<LoanData>(_dataPath, hasHeader: false, separatorChar: ',');

                string loanColumnName = "Features";

                var pipeline = mlContext.Transforms.Concatenate(loanColumnName,
                    "MonthlyIncome",
                    "MortgageOrRent",
                    "ChildSupport",
                    "AutoPayments",
                    "CreditCardPayments",
                    "CreditScore",
                    "DebtIncomeRatio").Append(mlContext.Clustering.Trainers.KMeans(loanColumnName, numberOfClusters: 3));

                var model = pipeline.Fit(dataView);

                using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    mlContext.Model.Save(model, dataView.Schema, fileStream);
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
                    sugestion = sugestion + "Your Debt to income ratio is on the margin, you might want to consider paying off some of your credit.";
                }
                outputSugestionLabel.ForeColor = Color.FromArgb(227, 227, 227);
                outputSugestionLabel.Text = sugestion;
            }
            else if (prediction.PredictedClusterId.Equals(2))
            {
                sugestion = "";
                predictOutPutLabel.ForeColor = Color.FromArgb(0, 255, 0);
                predictOutPutLabel.Text = "It is more than likely you will be approved for the loan you performed this calculation on.";
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
    }
}
