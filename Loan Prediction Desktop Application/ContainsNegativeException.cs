using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    [Serializable]
    public class ContainsNegativeException: Exception
    {
        public ContainsNegativeException() { }
        public ContainsNegativeException(string message): base(message)
        {

        }
        public ContainsNegativeException(string message, Exception inner) : base(message, inner) { }
    }
}
