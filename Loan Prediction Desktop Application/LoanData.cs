using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    class LoanData
    {
        [LoadColumn(0)]
        public float MonthlyIncome;

        [LoadColumn(1)]
        public float MortgageOrRent;

        [LoadColumn(2)]
        public float ChildSupport;

        [LoadColumn(3)]
        public float AutoPayments;

        [LoadColumn(4)]
        public float CreditCardPayments;

        [LoadColumn(5)]
        public float CreditScore;

        [LoadColumn(6)]
        public float DebtIncomeRatio;

    }
}
