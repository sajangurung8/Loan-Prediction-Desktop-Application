using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Prediction_Desktop_Application
{   
    public partial class compareFrm : Form
    {
        public MortgageEstimate myMortgage;
       //ctor
        public compareFrm()
        {
            InitializeComponent();
            thirtyRadioBtn.Checked = true;
            loanProgressBar.Visible = false;
        }

        // click event handler for estimate button
        private void estimateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double p = double.Parse(loanAmmountTB.Text);
                double r = double.Parse(intrestRateTB.Text);
                double t = (thirtyRadioBtn.Checked) ? 30.0 : 15.0;

                if (p < 0 || r < 0) throw new ContainsNegativeException("Loan ammount and rate must be positive");
                if (r == 0) throw new RateZeroException("Intrest rate cannot be 0. I dont think a bank will lend you money for free.");
                this.myMortgage = new MortgageEstimate(p, r, t);

                loanDataLabel.ForeColor = Color.FromArgb(227, 227, 227);
                loanDataLabel.Text = myMortgage.GetReport();
                loanTrackBar.Enabled = true;

                if (fifteenRadioBtn.Checked)
                {
                    loanTrackBar.Maximum = 15;
                }
                else
                {
                    loanTrackBar.Maximum = 30;
                }
            }catch (ArgumentNullException){
                MessageBox.Show("All input feild must be filled");
            }
            catch (FormatException)
            {
                MessageBox.Show("All input must be numeric");
            }catch (ContainsNegativeException E)
            {
                MessageBox.Show(E.Message);
            }catch (RateZeroException E)
            {
                MessageBox.Show(E.Message);
            }


        }

        // event handler for check button for lowest rate
        private void useLowestCB_CheckedChanged(object sender, EventArgs e)
        {
            if (useLowestCB.Checked && thirtyRadioBtn.Checked)
            {
                double i = appFrame.GetLowestRate30();
                intrestRateTB.Text = (i.Equals(10))?"Scrape has not begun": i.ToString();    
            }
            else if(useLowestCB.Checked && fifteenRadioBtn.Checked)
            {
                double i = appFrame.GetLowestRate15();
                intrestRateTB.Text = (intrestRateTB.Equals(10)) ? "Scrape has not begun" : i.ToString();
            }else
                intrestRateTB.Text = "";
        }

        // event handler for track bar 
        private void loanTrackBar_Scroll(object sender, EventArgs e)
        {
            loanProgressBar.Visible = true;
            numOfYearLbl.Text = loanTrackBar.Value.ToString();
            double[] paymentData = myMortgage.GetInfoByPaymentMonth(loanTrackBar.Value * 12);
            principalSoFarLbl.Text = $"{paymentData[4]:C2}";
            intrestSoFarLbl.Text = $"{paymentData[2]:C2}";
            
            loanProgressBar.Value = (int)((myMortgage.Principal - paymentData[4]) / myMortgage.Principal * 100);
        }

        // event handler for radio button for 15 years
        private void fifteenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (useLowestCB.Checked && !appFrame.GetLowestRate15().Equals(10))
                intrestRateTB.Text = appFrame.GetLowestRate15().ToString();
        }

        // event handler for 30 years
        private void thirtyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (useLowestCB.Checked && !appFrame.GetLowestRate30().Equals(10))
                intrestRateTB.Text = appFrame.GetLowestRate30().ToString(); 

        }
    }
}
