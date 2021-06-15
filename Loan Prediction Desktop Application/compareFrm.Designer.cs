
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
            this.SuspendLayout();
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.principalLabel.Location = new System.Drawing.Point(39, 26);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(118, 21);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Loan Ammount";
            // 
            // intrestLabel
            // 
            this.intrestLabel.AutoSize = true;
            this.intrestLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intrestLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.intrestLabel.Location = new System.Drawing.Point(68, 60);
            this.intrestLabel.Name = "intrestLabel";
            this.intrestLabel.Size = new System.Drawing.Size(89, 21);
            this.intrestLabel.TabIndex = 0;
            this.intrestLabel.Text = "Intrest Rate";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.yearsLabel.Location = new System.Drawing.Point(113, 94);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(44, 21);
            this.yearsLabel.TabIndex = 0;
            this.yearsLabel.Text = "Term";
            this.yearsLabel.Click += new System.EventHandler(this.yearsLabel_Click);
            // 
            // loanAmmountTB
            // 
            this.loanAmmountTB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loanAmmountTB.Location = new System.Drawing.Point(173, 29);
            this.loanAmmountTB.Name = "loanAmmountTB";
            this.loanAmmountTB.Size = new System.Drawing.Size(110, 20);
            this.loanAmmountTB.TabIndex = 1;
            // 
            // compareFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(731, 523);
            this.Controls.Add(this.loanAmmountTB);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.intrestLabel);
            this.Controls.Add(this.principalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compareFrm";
            this.Text = "compareFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label intrestLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.TextBox loanAmmountTB;
    }
}