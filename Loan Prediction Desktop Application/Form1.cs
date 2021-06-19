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
        public static bool loadComplete1 = false, loadComplete2 = false, loadComplete3 = false;
        public static bool firstload = true;
        public static double lowestIntrestRate30 = 10, lowestIntrestRate15 = 10;
        public static double intNF30 = 0;
        public static double intNF15=0;
        public static double intUS30 = 0, intUS15=0;
        public static double intVS30 = 0, intVS15=0;

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
            s1.Show();

            if (firstload)
            {
                GetHtmlAsync("Navy Federal", s1.nf30,s1.nf15, s1.statusLabel);
                GetHtmlAsync("USAA", s1.us30, s1.us15, s1.statusLabel);
                GetHtmlAsync("Veterans United", s1.vu30, s1.vu15, s1.statusLabel);
                firstload = false;
            }
            else
            {
                s1.statusLabel.Text = "Status: Complete";
                s1.nf30.Text = intNF30.ToString() + "%";
                s1.nf15.Text = intNF15.ToString() + "%";
                s1.us15.Text = "Rate N/A on site";
                s1.us30.Text = intUS30.ToString() + "%";
                s1.vu30.Text = intVS30.ToString() + "%";
                s1.vu15.Text = intVS15.ToString() + "%";

            }


        }

        private static async void GetHtmlAsync(string bankSelection, System.Windows.Forms.Label obj1, System.Windows.Forms.Label obj2, System.Windows.Forms.Label status)
        {

            Dictionary<string, BankInfo> bankDisct = new Dictionary<string, BankInfo>();

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


            BankInfo bank = bankDisct[bankSelection];

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(bank.url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var RateTable = htmlDocument.DocumentNode.Descendants("table")
                .Where(node => node.GetAttributeValue(bank.tableId, "")
                .Equals(bank.tableIdName)).ToList();

            var Rates = RateTable[0].Descendants("tr")
                .Where(node => node.GetAttributeValue(bank.rowId, "")
                .Equals(bank.rowIdName)).ToList();
            string[] value = new string[2] {"",""};
            int counter = 0;
            foreach (int item in bank.rowIdIndex)
            {
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
            if (intrestRate[1] < lowestIntrestRate15)
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
                status.Text = "Status: Complete";
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
