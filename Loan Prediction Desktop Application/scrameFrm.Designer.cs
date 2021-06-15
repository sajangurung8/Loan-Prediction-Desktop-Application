
namespace Loan_Prediction_Desktop_Application
{
    public partial class scrameFrm
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
        private void InitializeComponent()
        {
            this.nfLabel = new System.Windows.Forms.Label();
            this.usaaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ratesLabel = new System.Windows.Forms.Label();
            this.thirtyLabel = new System.Windows.Forms.Label();
            this.fifteenLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.nf30 = new System.Windows.Forms.Label();
            this.us30 = new System.Windows.Forms.Label();
            this.vu30 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nfLabel
            // 
            this.nfLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.nfLabel.Location = new System.Drawing.Point(12, 163);
            this.nfLabel.Name = "nfLabel";
            this.nfLabel.Size = new System.Drawing.Size(194, 37);
            this.nfLabel.TabIndex = 3;
            this.nfLabel.Text = "Navy Federal\r\n\r\n";
            this.nfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usaaLabel
            // 
            this.usaaLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usaaLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.usaaLabel.Location = new System.Drawing.Point(12, 236);
            this.usaaLabel.Name = "usaaLabel";
            this.usaaLabel.Size = new System.Drawing.Size(159, 37);
            this.usaaLabel.TabIndex = 3;
            this.usaaLabel.Text = "USAA";
            this.usaaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veterans United";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ratesLabel
            // 
            this.ratesLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratesLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.ratesLabel.Location = new System.Drawing.Point(213, 9);
            this.ratesLabel.Name = "ratesLabel";
            this.ratesLabel.Size = new System.Drawing.Size(306, 37);
            this.ratesLabel.TabIndex = 3;
            this.ratesLabel.Text = "Todays rates";
            this.ratesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirtyLabel
            // 
            this.thirtyLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirtyLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.thirtyLabel.Location = new System.Drawing.Point(213, 111);
            this.thirtyLabel.Name = "thirtyLabel";
            this.thirtyLabel.Size = new System.Drawing.Size(104, 37);
            this.thirtyLabel.TabIndex = 3;
            this.thirtyLabel.Text = "30 Years";
            this.thirtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifteenLabel
            // 
            this.fifteenLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifteenLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.fifteenLabel.Location = new System.Drawing.Point(353, 111);
            this.fifteenLabel.Name = "fifteenLabel";
            this.fifteenLabel.Size = new System.Drawing.Size(104, 37);
            this.fifteenLabel.TabIndex = 3;
            this.fifteenLabel.Text = "15 Years";
            this.fifteenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.changeLabel.Location = new System.Drawing.Point(485, 111);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(201, 37);
            this.changeLabel.TabIndex = 3;
            this.changeLabel.Text = "Change since last visit";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nf30
            // 
            this.nf30.AutoSize = true;
            this.nf30.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nf30.Location = new System.Drawing.Point(229, 163);
            this.nf30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nf30.Name = "nf30";
            this.nf30.Size = new System.Drawing.Size(71, 21);
            this.nf30.TabIndex = 4;
            this.nf30.Text = "Scraping";
            this.nf30.Click += new System.EventHandler(this.nf30_Click);
            // 
            // us30
            // 
            this.us30.AutoSize = true;
            this.us30.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.us30.Location = new System.Drawing.Point(229, 236);
            this.us30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.us30.Name = "us30";
            this.us30.Size = new System.Drawing.Size(71, 21);
            this.us30.TabIndex = 4;
            this.us30.Text = "Scraping";
            this.us30.Click += new System.EventHandler(this.nf30_Click);
            // 
            // vu30
            // 
            this.vu30.AutoSize = true;
            this.vu30.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vu30.Location = new System.Drawing.Point(229, 309);
            this.vu30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vu30.Name = "vu30";
            this.vu30.Size = new System.Drawing.Size(71, 21);
            this.vu30.TabIndex = 4;
            this.vu30.Text = "Scraping";
            this.vu30.Click += new System.EventHandler(this.nf30_Click);
            // 
            // scrameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(731, 523);
            this.Controls.Add(this.vu30);
            this.Controls.Add(this.us30);
            this.Controls.Add(this.nf30);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usaaLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.fifteenLabel);
            this.Controls.Add(this.thirtyLabel);
            this.Controls.Add(this.ratesLabel);
            this.Controls.Add(this.nfLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "scrameFrm";
            this.Text = "scrameFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label nfLabel;
        private System.Windows.Forms.Label usaaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ratesLabel;
        private System.Windows.Forms.Label thirtyLabel;
        private System.Windows.Forms.Label fifteenLabel;
        private System.Windows.Forms.Label changeLabel;
        public System.Windows.Forms.Label nf30;
        public System.Windows.Forms.Label us30;
        public System.Windows.Forms.Label vu30;
    }
}