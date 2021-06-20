﻿using System;
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
        public compareFrm()
        {
            InitializeComponent();
            thirtyRadioBtn.Checked = true;
            loanProgressBar.Visible = false;
        }

        private void yearsLabel_Click(object sender, EventArgs e)
        {

        }

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
                intrestRateTB.Text = (intrestRateTB.Equals(10)) ? "Scrape has not begun" : intrestRateTB.ToString();
            }else
                intrestRateTB.Text = "Enter custom rate";
        }

        private void loanAmmountTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void loanTrackBar_Scroll(object sender, EventArgs e)
        {
            loanProgressBar.Visible = true;
            numOfYearLbl.Text = loanTrackBar.Value.ToString();
            double[] paymentData = myMortgage.GetInfoByPaymentMonth(loanTrackBar.Value * 12);
            principalSoFarLbl.Text = $"{paymentData[4]:C2}";
            intrestSoFarLbl.Text = $"{paymentData[2]:C2}";
            
            loanProgressBar.Value = (int)((myMortgage.Principal - paymentData[4]) / myMortgage.Principal * 100);
        }

        private void fifteenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void thirtyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void compareFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
