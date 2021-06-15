
namespace Loan_Prediction_Desktop_Application
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeMessage.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.welcomeMessage.Location = new System.Drawing.Point(0, 0);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(731, 109);
            this.welcomeMessage.TabIndex = 1;
            this.welcomeMessage.Text = "Welcome";
            this.welcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.descLabel.Location = new System.Drawing.Point(0, 109);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(731, 299);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = resources.GetString("descLabel.Text");
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteLabel
            // 
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.noteLabel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.noteLabel.Location = new System.Drawing.Point(0, 455);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(731, 68);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = resources.GetString("noteLabel.Text");
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(731, 523);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.welcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label noteLabel;
    }
}