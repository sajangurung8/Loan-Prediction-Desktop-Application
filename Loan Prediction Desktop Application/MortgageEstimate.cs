using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    public class MortgageEstimate
    {
        public double Principal { get; set; }
        public double YearlyRate { get; set; }
        public double InterestRate { get; set; }
        public double ActualIntrestRate { get; set; }
        public double Term { get; set; }
        public double NumOfPayments { get; set; }
        public double MonthlyPayment { get; set; }

        public double[,] PaymentData { get; set; }
        public MortgageEstimate(double Principal, double YearlyRate, double Term)
        {
            this.Principal = Principal;
            this.YearlyRate = YearlyRate;
            this.ActualIntrestRate = YearlyRate;
            this.InterestRate = YearlyRate / 1200;
            this.Term = Term;
            this.NumOfPayments = this.Term * 12;
            this.MonthlyPayment=GetMonthlyPayment();
        }

        public double GetMonthlyPayment()
        {
            this.MonthlyPayment = (this.Principal * (this.InterestRate * Math.Pow((1 + this.InterestRate), this.NumOfPayments))) / ((Math.Pow((this.InterestRate + 1), this.NumOfPayments) - 1));
            return this.MonthlyPayment;
        }

        public double[,] CreateReport()
        {
            double[,] paymentData = new double[360, 5];
            double payment = this.MonthlyPayment;
            double intrestPaid = 0, remainingPrincipal = this.Principal;
            int j = 0;
            for (int i = 0; i < 360; i++)
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

        public double[] GetInfoByPaymentMonth(int month)
        {
            this.CreateReport();
            double[] paymentInfo = new double[5];
            for(int i=0; i<5; i++)
            {
                paymentInfo[i] = this.PaymentData[month-1, i];
            }
            return paymentInfo;
        }

        public void GetReport()
        {
            Console.WriteLine("Principal: {0:C2}\nIntrest Rate: {1}%\nTerm: {2} Years\nMonthly Payment: {3:C2}", this.Principal, this.ActualIntrestRate, this.Term, this.MonthlyPayment);
        }
    }
}

