using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HtmlAgilityPack;
using System.Net.Http;


namespace Loan_Prediction_Desktop_Application
{
    public partial class appFrame : Form
    {
        public static bool loadComplete1 = false, loadComplete2 = false, loadComplete3 = false, noData = false, historyUpdated = false;
        public static bool firstload = true;
        public static double lowestIntrestRate30 = 10, lowestIntrestRate15 = 10;
        public static double intNF30 = 0;
        public static double intNF15=0;
        public static double intUS30 = 0, intUS15=0;
        public static double intVS30 = 0, intVS15=0;
        public static string[] previousData;
        public static string change1NF = "", change2NF = "", change1US = "", change1VU = "", change2VU = "";
        public static string changeDateNF="", changeDateUS="", changeDateVU="";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
                );
        public appFrame()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 25,25));

            this.canvasPnl.Controls.Clear();
            frmMain welcome = new frmMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome.FormBorderStyle = FormBorderStyle.None;
            this.canvasPnl.Controls.Add(welcome);
            welcome.Show();

        }

        public static string[] GetNewHistory()
        {
            string todayDate = DateTime.Now.ToString("MM/dd/yyyy");
            string nfData = $"{todayDate} NavyFederal {intNF30} {intNF15}";
            string usData = $"{todayDate} USAA {intUS30}";
            string vuData = $"{todayDate} VeteransUnited {intVS30} {intVS15}";
            string[] data = new string[3] { nfData, usData, vuData };
            return data;
        }

        public static double GetLowestRate30()
        {
            return lowestIntrestRate30;
        }

        public static double GetLowestRate15()
        {
            return lowestIntrestRate15;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void scrapeBtn_Click(object sender, EventArgs e)
        {
            scrapeBtn.BackColor = Color.FromArgb(46,51,73);
            compareBtn.BackColor = Color.FromArgb(24, 30, 54);
            predictBtn.BackColor = Color.FromArgb(24, 30, 54);
            titleLbl.Text = "Let's Scrape Lender Websites";


            this.canvasPnl.Controls.Clear();
            scrameFrm s1 = new scrameFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            s1.FormBorderStyle = FormBorderStyle.None;
            this.canvasPnl.Controls.Add(s1);
            if (loadComplete1 && loadComplete2 && loadComplete3 && !historyUpdated)
            {
                s1.historyUpdateButton.Visible = true;
            }
            s1.Show();
            RateHistoryUpdater watcher = new RateHistoryUpdater();
            previousData = watcher.checkHistory();
            noData = (previousData.Length <= 1) ? true : false;

            if (firstload)
            {
                
                GetHtmlAsync("Navy Federal", s1.nf30,s1.nf15, s1.changeInNF,s1.statusLabel, s1.historyUpdateButton);
                GetHtmlAsync("USAA", s1.us30, s1.us15, s1.changeInUS, s1.statusLabel, s1.historyUpdateButton);
                GetHtmlAsync("Veterans United", s1.vu30, s1.vu15, s1.changeInVU, s1.statusLabel, s1.historyUpdateButton);
                firstload = false;
            }
            else
            {
                previousData = watcher.checkHistory();
                s1.statusLabel.Text = "Status: Complete";
                s1.nf30.Text = intNF30.ToString() + "%";
                s1.nf15.Text = intNF15.ToString() + "%";
                s1.us15.Text = "Rate N/A on site";
                s1.us30.Text = intUS30.ToString() + "%";
                s1.vu30.Text = intVS30.ToString() + "%";
                s1.vu15.Text = intVS15.ToString() + "%";
                s1.changeInNF.Text = $"Change since {changeDateNF}\n{change1NF}\n{change2NF}";
                s1.changeInUS.Text = $"Change since {changeDateUS}\n{change1US}";
                s1.changeInVU.Text = $"Change since {changeDateVU}\n{change1VU}\n{change2VU}";
                
            }


        }

        private static async void GetHtmlAsync(string bankSelection, System.Windows.Forms.Label obj1, System.Windows.Forms.Label obj2, System.Windows.Forms.Label obj3, System.Windows.Forms.Label status, System.Windows.Forms.Button btn)
        {
            // creating dictionary for lender data
            Dictionary<string, BankInfo> bankDisct = new Dictionary<string, BankInfo>();

            // adding all 3 lender data to disctionary
            bankDisct.Add("Navy Federal", new BankInfo(
                "Navy Federal",
                "https://www.navyfederal.org/loans-cards/mortgage/mortgage-rates/va-loans.html",
                "class",
                "table-resp",
                "",
                "",
                new int[2]{ 2,1 },
                "data-th",
                "Interest Rates As Low As"
                ));

            bankDisct.Add("USAA", new BankInfo(
                "USAA",
                "https://www.usaa.com/inet/wc/bank-real-estate-mortgage-rates?wa_ref=pub_global_products_bank_mortgage#",
                "id",
                "rates-va-fixed",
                "class",
                "va fallback",
                new int[1] { 0 },
                "",
                ""
                ));
            bankDisct.Add("Veterans United", new BankInfo(
                "Veterans United",
                "https://www.veteransunited.com/va-loans/va-mortgage-rates/",
                "id",
                "rates_table",
                "",
                "",
                new int[2] { 2,4 },
                "",
                ""
                ));

            // gets lender detail form use selection
            BankInfo bank = bankDisct[bankSelection];

            // creates a class to sending HTTP Request and receiving HTTP response
            var httpClient = new HttpClient();
            // sends a GET request to the url and returns the responce in string format asynchronously
            var html = await httpClient.GetStringAsync(bank.url);

            //uses html agility pack to parse html
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            // gets loan rates table from html
            var RateTable = htmlDocument.DocumentNode.Descendants("table")
                .Where(node => node.GetAttributeValue(bank.tableId, "")
                .Equals(bank.tableIdName)).ToList();
            // gets the rows for rates table
            var Rates = RateTable[0].Descendants("tr")
                .Where(node => node.GetAttributeValue(bank.rowId, "")
                .Equals(bank.rowIdName)).ToList();
            string[] value = new string[2] {"",""};
            int counter = 0;
            foreach (int item in bank.rowIdIndex)
            {
                // gets data from specific cell in the table for 30 years or 15 years
                var RowData = Rates[item].Descendants("td")
                     .Where(node => node.GetAttributeValue(bank.rowDataId, "")
                     .Equals(bank.rowDataIdName));
                
                if (bank.bankName == "Veterans United")
                {
                    string inHtml = "";
                    foreach (var data in RowData)
                    {
                        inHtml = data.InnerHtml.Trim();

                        for (int i = 0; i < 4; i++)
                        {
                            value[counter] = value[counter] + inHtml[i];
                        }
                        Console.WriteLine(value);
                        break;
                    }
                }
                if (bank.bankName == "USAA")
                {
                    string inHtml = "";
                    foreach (var data in RowData)
                    {
                        inHtml = data.InnerHtml;

                        for (int i = inHtml.Length - 6; i < inHtml.Length; i++)
                        {
                            value[counter] = value[counter] + inHtml[i];
                        }
                        Console.WriteLine(value);
                        break;
                    }
                }
                if (bank.bankName == "Navy Federal")
                {

                    foreach (var data in RowData)
                        value[counter] = data.InnerHtml;
                    
                }
                counter++;
            }

            double[] intrestRate = new double[2];
            if (bank.bankName == "Veterans United")
            {
                for (int i = 0; i < 2; i++)
                    intrestRate[i] = double.Parse(value[i]);
            }
            if (bank.bankName == "Navy Federal" || bank.bankName == "USAA")
            {
                for (int j = 0; j < 2; j++)
                {
                    if ((bank.bankName == "USAA") && (j == 1))
                        break;
                    intrestRate[j] = double.Parse(value[j].Remove(5, 1));
                }
            }
            obj1.Text = intrestRate[0].ToString() +"%";
            obj2.Text = intrestRate[1].ToString() + "%";
            
            if(intrestRate[0]<lowestIntrestRate30)
                lowestIntrestRate30 = intrestRate[0];
            if ((intrestRate[1] < lowestIntrestRate15) && bankSelection!="USAA")
                lowestIntrestRate15 = intrestRate[1];
            if (bankSelection.Equals("Navy Federal"))
            {
                intNF30 = intrestRate[0];
                intNF15 = intrestRate[1];
                loadComplete1 = true;
            }
            if (bankSelection.Equals("USAA"))
            {
                intUS30 = intrestRate[0];
                loadComplete2 = true;
            }
            if (bankSelection.Equals("Veterans United"))
            {
                intVS30 = intrestRate[0];
                intVS15 = intrestRate[1];
                loadComplete3 = true;
            }
            if (loadComplete1 && loadComplete2 && loadComplete3)
            {
                status.Text = "Status: Complete";
                btn.Visible = true;
            }
            if (bankSelection.Equals("USAA")) obj2.Text = "Rate N/A on site";

            if (!noData)
            {
                if(bankSelection=="Navy Federal")
                {
                    foreach(string line in previousData)
                    {
                        string[] myData = line.Split(' ');
                        if (myData[1].Equals("NavyFederal"))
                        { 
                            double change30 = intNF30 - double.Parse(myData[2]);
                            double change15 = intNF15 - double.Parse(myData[3]);
                            changeDateNF = myData[0];
                            if (change30 > 0)
                            {
                                change1NF = $"30 year rate increased by {Math.Abs(change30)}";
                            }else if(change30 == 0)
                            {
                                change1NF = $"No change in 30 year rate";
                            }
                            else{
                                change1NF = $"30 year rate decreased by {Math.Abs(change15)}";
                            }
                            if (change15 > 0)
                            {
                                change2NF = $"15 year rate increased by {Math.Abs(change15)}";
                            }
                            else if (change30 == 0)
                            {
                                change2NF = $"No change in 30 year rate";
                            }
                            else
                            {
                                change2NF = $"15 year rate decreased by {Math.Abs(change15)}";
                            }
                            obj3.Text = $"Change since {changeDateNF}\n{change1NF}\n{change2NF}";

                        }
                    }
                }else if (bankSelection == "USAA")
                {
                    foreach (string line in previousData)
                    {
                        string[] myData = line.Split(' ');
                        if (myData[1].Equals("USAA"))
                        {
                            double change30 = intUS30 - double.Parse(myData[2]);
                            changeDateUS = myData[0];
                            if (change30 > 0)
                            {
                                change1US = $"30 year rate increased by {Math.Abs(change30)}";
                            }
                            else if (change30 == 0)
                            {
                                change1US = $"No change in 30 year rate";
                            }
                            else
                            {
                                change1US = $"30 year rate decreased by {Math.Abs(change30)}";
                            }

                            obj3.Text = $"Change since {changeDateUS}\n{change1US}";

                        }
                    }
                }
                

                else if (bankSelection == "Veterans United")
                {
                    foreach (string line in previousData)
                    {
                        string[] myData = line.Split(' ');
                        if (myData[1].Equals("VeteransUnited"))
                        {
                            changeDateVU = myData[0];
                            double change30 = intVS30 - double.Parse(myData[2]);
                            double change15 = intVS15 - double.Parse(myData[3]);
                            if (change30 > 0)
                            {
                                change1VU = $"30 year rate increased by {Math.Abs(change30)}";
                            }
                            else if (change30 == 0)
                            {
                                change1VU = $"No change in 30 year rate";
                            }
                            else
                            {
                                change1VU = $"30 year rate decreased by {Math.Abs(change30)}";
                            }
                            if (change15 > 0)
                            {
                                change2VU = $"15 year rate increased by {Math.Abs(change15)}";
                            }
                            else if (change15 == 0)
                            {
                                change2VU = $"No change in 15 year rate";
                            }
                            else
                            {
                                change2VU = $"15 year rate decreased by {Math.Abs(change15)}";
                            }
                            obj3.Text = $"Change since {changeDateVU}\n{change1VU}\n{change2VU}";
                        }
                    }
                }
            }
            else
            {
                obj3.Text = "History not found";
            }
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            compareBtn.BackColor = Color.FromArgb(46, 51, 73);
            scrapeBtn.BackColor = Color.FromArgb(24, 30, 54);
            predictBtn.BackColor = Color.FromArgb(24, 30, 54);
            titleLbl.Text = "Let's play with diffrent components of a loan";

            this.canvasPnl.Controls.Clear();
            compareFrm s2 = new compareFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            s2.FormBorderStyle = FormBorderStyle.None;
            this.canvasPnl.Controls.Add(s2);
            s2.Show();

        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            predictBtn.BackColor = Color.FromArgb(46, 51, 73);
            compareBtn.BackColor = Color.FromArgb(24, 30, 54);
            scrapeBtn.BackColor = Color.FromArgb(24, 30, 54);
            titleLbl.Text = "Let's see if you will qualify for a Home Loan";

            this.canvasPnl.Controls.Clear();
            predictForm predictCanvas = new predictForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            predictCanvas.FormBorderStyle = FormBorderStyle.None;
            this.canvasPnl.Controls.Add(predictCanvas);
            predictCanvas.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titleLbl_Click(object sender, EventArgs e)
        {

        }

        private void canvasPnl_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
