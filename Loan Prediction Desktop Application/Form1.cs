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
    public partial class Form1 : Form
    {
        public static bool firstload = true;

        public static double lowestIntrestRate = 10;
        public static double intNF30 = 0;
        public static double intUS30 = 0;
        public static double intVS30 = 0;

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
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0,0, Width, Height, 25,25));

            this.canvasPnl.Controls.Clear();
            frmMain welcome = new frmMain() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            welcome.FormBorderStyle = FormBorderStyle.None;
            this.canvasPnl.Controls.Add(welcome);
            welcome.Show();

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
                GetHtmlAsync("Navy Federal", s1.nf30);
                GetHtmlAsync("USAA", s1.us30);
                GetHtmlAsync("Veterans United", s1.vu30);
                firstload = false;
            }
            else
            {
                s1.nf30.Text = intNF30.ToString() + "%";
                s1.us30.Text = intUS30.ToString() + "%";
                s1.vu30.Text = intVS30.ToString() + "%";
            }


        }

        private static async void GetHtmlAsync(string bankSelection, System.Windows.Forms.Label obj)
        {

            Dictionary<string, BankInfo> bankDisct = new Dictionary<string, BankInfo>();

            bankDisct.Add("Navy Federal", new BankInfo(
                "Navy Federal",
                "https://www.navyfederal.org/loans-cards/mortgage/mortgage-rates/va-loans.html",
                "class",
                "table-resp",
                "",
                "",
                2,
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
                0,
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
                2,
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

            var RowData = Rates[bank.rowIdIndex].Descendants("td")
                 .Where(node => node.GetAttributeValue(bank.rowDataId, "")
                 .Equals(bank.rowDataIdName));
            string value = "";
            if (bank.bankName == "Veterans United")
            {
                string inHtml = "";
                foreach (var data in RowData)
                {
                    inHtml = data.InnerHtml.Trim();

                    for (int i = 0; i < 4; i++)
                    {
                        value = value + inHtml[i];
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
                        value = value + inHtml[i];
                    }
                    Console.WriteLine(value);
                    break;
                }
            }
            if (bank.bankName == "Navy Federal")
            {

                foreach (var data in RowData)
                    value = data.InnerHtml;
                Console.WriteLine(value);
            }

            double intrestRate = 0;
            if (bank.bankName == "Veterans United")
                intrestRate = double.Parse(value);
            if (bank.bankName == "Navy Federal" || bank.bankName == "USAA")
                intrestRate = double.Parse(value.Remove(5, 1));
            obj.Text = intrestRate.ToString() +"%";
            if(intrestRate<lowestIntrestRate)
                lowestIntrestRate = intrestRate;
            if (bankSelection.Equals("Navy Federal"))
                intNF30 = intrestRate;
            if (bankSelection.Equals("USAA"))
                intUS30 = intrestRate;
            if (bankSelection.Equals("Veterans United"))
                intVS30 = intrestRate;
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            compareBtn.BackColor = Color.FromArgb(46, 51, 73);
            scrapeBtn.BackColor = Color.FromArgb(24, 30, 54);
            predictBtn.BackColor = Color.FromArgb(24, 30, 54);
            titleLbl.Text = "Lets play with diffrent components of a loan";

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
