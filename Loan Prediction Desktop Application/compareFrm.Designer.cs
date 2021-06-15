
namespace Loan_Prediction_Desktop_Application
{
    partial class compareFrm
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
            this.principalLabel = new System.Windows.Forms.Label();
            this.intrestLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.loanAmmountTB = new System.Windows.Forms.TextBox();
            this.intrestRateTB = new System.Windows.Forms.TextBox();
            this.useLowestCB = new System.Windows.Forms.CheckBox();
            this.thirtyRadioBtn = new System.Windows.Forms.RadioButton();
            this.fifteenRadioBtn = new System.Windows.Forms.RadioButton();
            this.loanEstimateDisplayPanel = new System.Windows.Forms.Panel();
            this.displayTitle = new System.Windows.Forms.Label();
            this.loanDataLabel = new System.Windows.Forms.Label();
            this.estimateBtn = new System.Windows.Forms.Button();
            this.loanEstimateDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.principalLabel.Location = new System.Drawing.Point(78, 50);
            this.principalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(240, 45);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Loan Ammount";
            // 
            // intrestLabel
            // 
            this.intrestLabel.AutoSize = true;
            this.intrestLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrestLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.intrestLabel.Location = new System.Drawing.Point(136, 115);
            this.intrestLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.intrestLabel.Name = "intrestLabel";
            this.intrestLabel.Size = new System.Drawing.Size(183, 45);
            this.intrestLabel.TabIndex = 0;
            this.intrestLabel.Text = "Intrest Rate";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.yearsLabel.Location = new System.Drawing.Point(226, 219);
            this.yearsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(90, 45);
            this.yearsLabel.TabIndex = 0;
            this.yearsLabel.Text = "Term";
            this.yearsLabel.Click += new System.EventHandler(this.yearsLabel_Click);
            // 
            // loanAmmountTB
            // 
            this.loanAmmountTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.loanAmmountTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanAmmountTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.loanAmmountTB.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanAmmountTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loanAmmountTB.Location = new System.Drawing.Point(346, 56);
            this.loanAmmountTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loanAmmountTB.Multiline = true;
            this.loanAmmountTB.Name = "loanAmmountTB";
            this.loanAmmountTB.Size = new System.Drawing.Size(220, 38);
            this.loanAmmountTB.TabIndex = 1;
            this.loanAmmountTB.Text = "Principal";
            this.loanAmmountTB.TextChanged += new System.EventHandler(this.loanAmmountTB_TextChanged);
            // 
            // intrestRateTB
            // 
            this.intrestRateTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.intrestRateTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intrestRateTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.intrestRateTB.Location = new System.Drawing.Point(346, 117);
            this.intrestRateTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.intrestRateTB.Multiline = true;
            this.intrestRateTB.Name = "intrestRateTB";
            this.intrestRateTB.Size = new System.Drawing.Size(220, 38);
            this.intrestRateTB.TabIndex = 1;
            this.intrestRateTB.Text = "Rate";
            // 
            // useLowestCB
            // 
            this.useLowestCB.AutoSize = true;
            this.useLowestCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useLowestCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useLowestCB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.useLowestCB.Location = new System.Drawing.Point(346, 167);
            this.useLowestCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.useLowestCB.Name = "useLowestCB";
            this.useLowestCB.Size = new System.Drawing.Size(376, 40);
            this.useLowestCB.TabIndex = 2;
            this.useLowestCB.Text = "Use Lowest Rate from Scrape";
            this.useLowestCB.UseVisualStyleBackColor = true;
            this.useLowestCB.CheckedChanged += new System.EventHandler(this.useLowestCB_CheckedChanged);
            // 
            // thirtyRadioBtn
            // 
            this.thirtyRadioBtn.AutoSize = true;
            this.thirtyRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirtyRadioBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirtyRadioBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.thirtyRadioBtn.Location = new System.Drawing.Point(346, 227);
            this.thirtyRadioBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.thirtyRadioBtn.Name = "thirtyRadioBtn";
            this.thirtyRadioBtn.Size = new System.Drawing.Size(138, 40);
            this.thirtyRadioBtn.TabIndex = 3;
            this.thirtyRadioBtn.TabStop = true;
            this.thirtyRadioBtn.Text = "30 Years";
            this.thirtyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // fifteenRadioBtn
            // 
            this.fifteenRadioBtn.AutoSize = true;
            this.fifteenRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fifteenRadioBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifteenRadioBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fifteenRadioBtn.Location = new System.Drawing.Point(492, 227);
            this.fifteenRadioBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fifteenRadioBtn.Name = "fifteenRadioBtn";
            this.fifteenRadioBtn.Size = new System.Drawing.Size(138, 40);
            this.fifteenRadioBtn.TabIndex = 3;
            this.fifteenRadioBtn.TabStop = true;
            this.fifteenRadioBtn.Text = "15 Years";
            this.fifteenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // loanEstimateDisplayPanel
            // 
            this.loanEstimateDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loanEstimateDisplayPanel.Controls.Add(this.loanDataLabel);
            this.loanEstimateDisplayPanel.Controls.Add(this.displayTitle);
            this.loanEstimateDisplayPanel.Location = new System.Drawing.Point(839, 29);
            this.loanEstimateDisplayPanel.Name = "loanEstimateDisplayPanel";
            this.loanEstimateDisplayPanel.Size = new System.Drawing.Size(595, 487);
            this.loanEstimateDisplayPanel.TabIndex = 4;
            // 
            // displayTitle
            // 
            this.displayTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.displayTitle.Location = new System.Drawing.Point(0, 0);
            this.displayTitle.Name = "displayTitle";
            this.displayTitle.Size = new System.Drawing.Size(591, 75);
            this.displayTitle.TabIndex = 0;
            this.displayTitle.Text = "Your Estimate and Loan Data";
            this.displayTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loanDataLabel
            // 
            this.loanDataLabel.AutoSize = true;
            this.loanDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.loanDataLabel.Location = new System.Drawing.Point(63, 91);
            this.loanDataLabel.Name = "loanDataLabel";
            this.loanDataLabel.Size = new System.Drawing.Size(336, 74);
            this.loanDataLabel.TabIndex = 1;
            this.loanDataLabel.Text = "Fill out loan data and\r\npress Estimate button.";
            // 
            // estimateBtn
            // 
            this.estimateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.estimateBtn.Font = new System.Drawing.Font("Nirmala UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.estimateBtn.Location = new System.Drawing.Point(342, 298);
            this.estimateBtn.Name = "estimateBtn";
            this.estimateBtn.Size = new System.Drawing.Size(263, 101);
            this.estimateBtn.TabIndex = 5;
            this.estimateBtn.Text = "Estimate";
            this.estimateBtn.UseVisualStyleBackColor = true;
            this.estimateBtn.Click += new System.EventHandler(this.estimateBtn_Click);
            // 
            // compareFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1462, 1006);
            this.Controls.Add(this.estimateBtn);
            this.Controls.Add(this.loanEstimateDisplayPanel);
            this.Controls.Add(this.fifteenRadioBtn);
            this.Controls.Add(this.thirtyRadioBtn);
            this.Controls.Add(this.useLowestCB);
            this.Controls.Add(this.intrestRateTB);
            this.Controls.Add(this.loanAmmountTB);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.intrestLabel);
            this.Controls.Add(this.principalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "compareFrm";
            this.Text = "compareFrm";
            this.loanEstimateDisplayPanel.ResumeLayout(false);
            this.loanEstimateDisplayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label intrestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox loanAmmountTB;
        private System.Windows.Forms.TextBox intrestRateTB;
        private System.Windows.Forms.CheckBox useLowestCB;
        private System.Windows.Forms.RadioButton thirtyRadioBtn;
        private System.Windows.Forms.RadioButton fifteenRadioBtn;
        private System.Windows.Forms.Panel loanEstimateDisplayPanel;
        private System.Windows.Forms.Label displayTitle;
        private System.Windows.Forms.Label loanDataLabel;
        private System.Windows.Forms.Button estimateBtn;
    }
}