using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Prediction_Desktop_Application
{
    public class BankInfo
    {
        public string bankName { get; set; }
        public string url { get; set; }
        public string tableId { get; set; }

        public string tableIdName { get; set; }

        public string rowId { get; set; }

        public string rowIdName { get; set; }
        public string rowDataId { get; set; }
        public string rowDataIdName { get; set; }
        public int[] rowIdIndex { get; set; }
        public BankInfo(string bankName, string url, string tableId, string tableIdName, string rowId, string rowIdName, int[] rowIdIndex, string rowDataId, string rowDataIdName)
        {
            this.bankName = bankName;
            this.url = url;
            this.tableId = tableId;
            this.tableIdName = tableIdName;
            this.rowId = rowId;
            this.rowIdName = rowIdName;
            this.rowIdIndex = rowIdIndex;
            this.rowDataId = rowDataId;
            this.rowDataIdName = rowDataIdName;
        }
    }
}
