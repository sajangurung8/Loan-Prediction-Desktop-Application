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
    public partial class scrameFrm : Form
    {
        //ctor
        public scrameFrm()
        {
            InitializeComponent();
            this.historyUpdateButton.Visible = false;
        }

        // event handler for history update button
        private void historyUpdateButton_Click(object sender, EventArgs e)
        {  
            string[] data = appFrame.GetNewHistory();
            RateHistoryUpdater writer = new RateHistoryUpdater();
            if (writer.updateHistory(data))
            {
                this.statusLabel.Text = "Status: Scrape and History Update Complete.";
                appFrame.historyUpdated = true;
            }
            else
                this.statusLabel.Text = "Status: Scrape Complete, History update unsuccessful.";
        }
    }
}
