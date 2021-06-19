using System.Runtime.InteropServices;

namespace Loan_Prediction_Desktop_Application
{
    partial class appFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.scrapeBtn = new System.Windows.Forms.Button();
            this.compareBtn = new System.Windows.Forms.Button();
            this.predictBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titleLbl = new System.Windows.Forms.Label();
            this.canvasPnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 1100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.scrapeBtn);
            this.flowLayoutPanel1.Controls.Add(this.compareBtn);
            this.flowLayoutPanel1.Controls.Add(this.predictBtn);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 369);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(372, 731);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // scrapeBtn
            // 
            this.scrapeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrapeBtn.FlatAppearance.BorderSize = 0;
            this.scrapeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrapeBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrapeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.scrapeBtn.Location = new System.Drawing.Point(6, 6);
            this.scrapeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.scrapeBtn.Name = "scrapeBtn";
            this.scrapeBtn.Size = new System.Drawing.Size(372, 113);
            this.scrapeBtn.TabIndex = 0;
            this.scrapeBtn.Text = "Scrape";
            this.scrapeBtn.UseVisualStyleBackColor = true;
            this.scrapeBtn.Click += new System.EventHandler(this.scrapeBtn_Click);
            // 
            // compareBtn
            // 
            this.compareBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.compareBtn.FlatAppearance.BorderSize = 0;
            this.compareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compareBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.compareBtn.Location = new System.Drawing.Point(6, 131);
            this.compareBtn.Margin = new System.Windows.Forms.Padding(6);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(372, 113);
            this.compareBtn.TabIndex = 0;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // predictBtn
            // 
            this.predictBtn.FlatAppearance.BorderSize = 0;
            this.predictBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.predictBtn.Location = new System.Drawing.Point(6, 256);
            this.predictBtn.Margin = new System.Windows.Forms.Padding(6);
            this.predictBtn.Name = "predictBtn";
            this.predictBtn.Size = new System.Drawing.Size(372, 113);
            this.predictBtn.TabIndex = 0;
            this.predictBtn.Text = "Predict";
            this.predictBtn.UseVisualStyleBackColor = true;
            this.predictBtn.Click += new System.EventHandler(this.predictBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.minimizeBtn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.exitBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(6, 381);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 350);
            this.panel4.TabIndex = 1;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimizeBtn.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.minimizeBtn.Location = new System.Drawing.Point(18, 275);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(152, 52);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "Minimize";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 90);
            this.label3.TabIndex = 1;
            this.label3.Text = "Designed and Developed by\r\nSajan Gurung\r\nCopyRight © 2021";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.exitBtn.Location = new System.Drawing.Point(186, 275);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(152, 52);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseMnemonic = false;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logoBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 379);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 392);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(20, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "An Estimating tool designed for \r\nveterans to compare, estimate \r\nand predict Hom" +
    "e loans";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Blue;
            this.logoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoBox.Location = new System.Drawing.Point(0, 0);
            this.logoBox.Margin = new System.Windows.Forms.Padding(6);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(372, 263);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Silver;
            this.titleLbl.Location = new System.Drawing.Point(432, 17);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(1294, 65);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "SCRAPE2COMPARE Loan Estimator Windows Applicaton";
            this.titleLbl.Click += new System.EventHandler(this.titleLbl_Click);
            // 
            // canvasPnl
            // 
            this.canvasPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canvasPnl.Location = new System.Drawing.Point(372, 94);
            this.canvasPnl.Margin = new System.Windows.Forms.Padding(6);
            this.canvasPnl.Name = "canvasPnl";
            this.canvasPnl.Size = new System.Drawing.Size(1462, 1006);
            this.canvasPnl.TabIndex = 2;
            this.canvasPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPnl_Paint);
            // 
            // appFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1834, 1100);
            this.Controls.Add(this.canvasPnl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "appFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrape 2 Compare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button scrapeBtn;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Button predictBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel canvasPnl;
    }
}

