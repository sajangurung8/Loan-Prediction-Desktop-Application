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
        public compareFrm()
        {
            InitializeComponent();
            thirtyRadioBtn.Checked = true;
        }

        private void yearsLabel_Click(object sender, EventArgs e)
        {

        }

        private void estimateBtn_Click(object sender, EventArgs e)
        {
            double p = double.Parse(loanAmmountTB.Text);
            double r = double.Parse(intrestRateTB.Text);
            double t = (thirtyRadioBtn.Checked) ? 30.0 : 15.0;

            MortgageEstimate myMortgage = new MortgageEstimate(p, r,t);

            loanDataLabel.ForeColor = Color.FromArgb(227,227,227);
            loanDataLabel.Text = myMortgage.GetReport();

           
        }

        private void useLowestCB_CheckedChanged(object sender, EventArgs e)
        {
            if (useLowestCB.Checked && thirtyRadioBtn.Checked)
            {
                double i = Form1.GetLowestRate30();
                intrestRateTB.Text = (i.Equals(10))?"Scrape has not begun": i.ToString();    
            }
            else if(useLowestCB.Checked && fifteenRadioBtn.Checked)
            {
                double i = Form1.GetLowestRate15();
                intrestRateTB.Text = (intrestRateTB.Equals(10)) ? "Scrape has not begun" : intrestRateTB.ToString();
            }else
                intrestRateTB.Text = "Enter custom rate";
        }

        private void loanAmmountTB_TextChanged(object sender, EventArgs e)
        {
            if(loanAmmountTB.Text.Equals("Principal"))
                loanAmmountTB.Text = "";
        }
    }
}
