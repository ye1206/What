namespace WinFormsApp4Bank_Cheng3001_220504
{
    partial class FrmBankUI_Cheng3001
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.LblAccount = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtAccount
            // 
            this.TxtAccount.Location = new System.Drawing.Point(202, 58);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(151, 30);
            this.TxtAccount.TabIndex = 0;
            // 
            // LblAccount
            // 
            this.LblAccount.AutoSize = true;
            this.LblAccount.Location = new System.Drawing.Point(66, 61);
            this.LblAccount.Name = "LblAccount";
            this.LblAccount.Size = new System.Drawing.Size(80, 23);
            this.LblAccount.TabIndex = 1;
            this.LblAccount.Text = "Account";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(66, 122);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(103, 23);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(66, 180);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(101, 23);
            this.LblLastName.TabIndex = 3;
            this.LblLastName.Text = "Last Name";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Location = new System.Drawing.Point(66, 236);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(76, 23);
            this.LblBalance.TabIndex = 4;
            this.LblBalance.Text = "Balance";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(202, 177);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(151, 30);
            this.TxtLastName.TabIndex = 5;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(202, 119);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(151, 30);
            this.TxtFirstName.TabIndex = 6;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Location = new System.Drawing.Point(202, 233);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(151, 30);
            this.TxtBalance.TabIndex = 7;
            // 
            // FrmBankUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 332);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.LblAccount);
            this.Controls.Add(this.TxtAccount);
            this.Name = "FrmBankUI";
            this.Text = "FrmBankUI_Cheng3001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TxtAccount;
        public System.Windows.Forms.TextBox TxtLastName;
        public System.Windows.Forms.TextBox TxtFirstName;
        public System.Windows.Forms.TextBox TxtBalance;
        public System.Windows.Forms.Label LblAccount;
        public System.Windows.Forms.Label LblFirstName;
        public System.Windows.Forms.Label LblLastName;
        public System.Windows.Forms.Label LblBalance;
    }
}
