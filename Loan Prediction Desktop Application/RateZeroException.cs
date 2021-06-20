using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    [Serializable]
    public class RateZeroException: Exception
    {
        public RateZeroException() { }
        public RateZeroException(string message): base(message) { }
        public RateZeroException(string message, Exception inner) : base(message, inner) { }
    }
}
