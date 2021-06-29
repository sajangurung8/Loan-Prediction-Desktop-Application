using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Prediction_Desktop_Application
{
    
    public partial class GetMonthlyPayment : Form
    {
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
        static float monthlyPayment = 0;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        public GetMonthlyPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                monthlyPayment = float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Components of Monthly Payment can only be numeric!");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public float GetPayment()
        {
            return monthlyPayment;
        }
    }
}
