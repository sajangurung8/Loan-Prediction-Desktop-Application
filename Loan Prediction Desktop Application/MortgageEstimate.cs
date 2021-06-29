using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    // Class defination for MortgaeEstimate class, This is where all the calculations are done
    public class MortgageEstimate
    {
        // fields for loan components
        public double Principal { get; set; }
        public double YearlyRate { get; set; }
        public double InterestRate { get; set; }
        public double ActualIntrestRate { get; set; }
        public double Term { get; set; }
        public double NumOfPayments { get; set; }
        public double MonthlyPayment { get; set; }

        public double[,] PaymentData { get; set; }

        //ctor
        public MortgageEstimate(double Principal, double YearlyRate, double Term)
        {
            this.Principal = Principal;
            this.YearlyRate = YearlyRate;
            this.ActualIntrestRate = YearlyRate;
            this.InterestRate = YearlyRate / 1200;
            this.Term = Term;
            this.NumOfPayments = this.Term * 12;
            this.MonthlyPayment=GetMonthlyPayment();
            this.PaymentData = CreateReport(this.NumOfPayments);
        }

        // mthod to ge monthly payment
        public double GetMonthlyPayment()
        {
            this.MonthlyPayment = (this.Principal * (this.InterestRate * Math.Pow((1 + this.InterestRate), this.NumOfPayments))) / ((Math.Pow((this.InterestRate + 1), this.NumOfPayments) - 1));
            return this.MonthlyPayment;
        }

        // method to generate report and store in a 2D array
        public double[,] CreateReport(double NumOfPayments)
        {
            double[,] paymentData;
            if (NumOfPayments == 360)
                paymentData = new double[360, 5];
            else
                paymentData = new double[180, 5];
            double payment = this.MonthlyPayment;
            double intrestPaid = 0, remainingPrincipal = this.Principal;
            int j = 0;
            for (int i = 0; i < NumOfPayments; i++)
            {
                paymentData[i, j] = payment;
                j++;
                paymentData[i, j] = this.InterestRate * remainingPrincipal;
                intrestPaid += paymentData[i, j];
                j++;
                paymentData[i, j] = intrestPaid;
                j++;
                paymentData[i, j] = payment - paymentData[i, j - 2];

                remainingPrincipal -= paymentData[i, j];
                j++;
                paymentData[i, j] = remainingPrincipal;

                j = 0;
            }
            this.PaymentData = paymentData;
            return paymentData;

        }

        //method to get info by month
        public double[] GetInfoByPaymentMonth(int month)
        {
            this.CreateReport(this.NumOfPayments);
            double[] paymentInfo = new double[5];
            if (month == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    paymentInfo[i] = this.PaymentData[0, i];
                }
            }
            else
            {
                
                for (int i = 0; i < 5; i++)
                {
                    paymentInfo[i] = this.PaymentData[month - 1, i];
                }
            }
            return paymentInfo;
        }

        // method to get report about the loan
        public string GetReport()
        {
            if(this.NumOfPayments == 360)
                return $"Principal: {this.Principal:C2}\nIntrest Rate: {this.ActualIntrestRate}%\nTerm: {this.Term} Years\nMonthly Payment: {this.MonthlyPayment:C2}\n\nBy the end of this loan \nperiod you will have paid\n{this.PaymentData[359,2]:C2} in Intrest";
            else
                return $"Principal: {this.Principal:C2}\nIntrest Rate: {this.ActualIntrestRate}%\nTerm: {this.Term} Years\nMonthly Payment: {this.MonthlyPayment:C2}\n\nBy the end of this loan \nperiod you will have paid\n{this.PaymentData[179, 2]:C2} in Intrest";
        }
    }
}

