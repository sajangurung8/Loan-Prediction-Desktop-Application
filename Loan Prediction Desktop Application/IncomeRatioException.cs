using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    class IncomeRatioException: Exception
    {
        public IncomeRatioException() {}

        public IncomeRatioException(string message): base(message){}
        public IncomeRatioException(string message, Exception inner): base(message, inner){}
    }
}
