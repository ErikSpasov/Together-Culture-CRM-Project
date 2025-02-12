namespace ProjectGui
{
    partial class Payment_Page
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
            this.InpNamebox = new System.Windows.Forms.TextBox();
            this.InpCardNumbox = new System.Windows.Forms.TextBox();
            this.InpCvBox = new System.Windows.Forms.TextBox();
            this.InpAdrbox = new System.Windows.Forms.TextBox();
            this.InpPcBox = new System.Windows.Forms.TextBox();
            this.InpCountryBox = new System.Windows.Forms.TextBox();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.Label();
            this.TxtCardNum = new System.Windows.Forms.Label();
            this.TxtCVV = new System.Windows.Forms.Label();
            this.TxtExpDate = new System.Windows.Forms.Label();
            this.InpExpBox = new System.Windows.Forms.TextBox();
            this.TxtBilAdr = new System.Windows.Forms.Label();
            this.TxtPostcode = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InpNamebox
            // 
            this.InpNamebox.Location = new System.Drawing.Point(9, 35);
            this.InpNamebox.Margin = new System.Windows.Forms.Padding(2);
            this.InpNamebox.Name = "InpNamebox";
            this.InpNamebox.Size = new System.Drawing.Size(132, 20);
            this.InpNamebox.TabIndex = 0;
            // 
            // InpCardNumbox
            // 
            this.InpCardNumbox.Location = new System.Drawing.Point(9, 72);
            this.InpCardNumbox.Margin = new System.Windows.Forms.Padding(2);
            this.InpCardNumbox.Name = "InpCardNumbox";
            this.InpCardNumbox.Size = new System.Drawing.Size(132, 20);
            this.InpCardNumbox.TabIndex = 1;
            // 
            // InpCvBox
            // 
            this.InpCvBox.Location = new System.Drawing.Point(154, 72);
            this.InpCvBox.Margin = new System.Windows.Forms.Padding(2);
            this.InpCvBox.Name = "InpCvBox";
            this.InpCvBox.Size = new System.Drawing.Size(39, 20);
            this.InpCvBox.TabIndex = 2;
            // 
            // InpAdrbox
            // 
            this.InpAdrbox.Location = new System.Drawing.Point(9, 106);
            this.InpAdrbox.Margin = new System.Windows.Forms.Padding(2);
            this.InpAdrbox.Name = "InpAdrbox";
            this.InpAdrbox.Size = new System.Drawing.Size(132, 20);
            this.InpAdrbox.TabIndex = 3;
            // 
            // InpPcBox
            // 
            this.InpPcBox.Location = new System.Drawing.Point(9, 141);
            this.InpPcBox.Margin = new System.Windows.Forms.Padding(2);
            this.InpPcBox.Name = "InpPcBox";
            this.InpPcBox.Size = new System.Drawing.Size(66, 20);
            this.InpPcBox.TabIndex = 4;
            // 
            // InpCountryBox
            // 
            this.InpCountryBox.Location = new System.Drawing.Point(9, 181);
            this.InpCountryBox.Margin = new System.Windows.Forms.Padding(2);
            this.InpCountryBox.Name = "InpCountryBox";
            this.InpCountryBox.Size = new System.Drawing.Size(132, 20);
            this.InpCountryBox.TabIndex = 5;
            // 
            // BtnPayment
            // 
            this.BtnPayment.Location = new System.Drawing.Point(9, 204);
            this.BtnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(98, 38);
            this.BtnPayment.TabIndex = 7;
            this.BtnPayment.Text = "Continue with payment";
            this.BtnPayment.UseVisualStyleBackColor = true;
            // 
            // TxtName
            // 
            this.TxtName.AutoSize = true;
            this.TxtName.Location = new System.Drawing.Point(9, 20);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(75, 13);
            this.TxtName.TabIndex = 8;
            this.TxtName.Text = "Name on Card";
            this.TxtName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCardNum
            // 
            this.TxtCardNum.AutoSize = true;
            this.TxtCardNum.Location = new System.Drawing.Point(9, 57);
            this.TxtCardNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCardNum.Name = "TxtCardNum";
            this.TxtCardNum.Size = new System.Drawing.Size(69, 13);
            this.TxtCardNum.TabIndex = 9;
            this.TxtCardNum.Text = "Card Number";
            // 
            // TxtCVV
            // 
            this.TxtCVV.AutoSize = true;
            this.TxtCVV.Location = new System.Drawing.Point(160, 57);
            this.TxtCVV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCVV.Name = "TxtCVV";
            this.TxtCVV.Size = new System.Drawing.Size(28, 13);
            this.TxtCVV.TabIndex = 10;
            this.TxtCVV.Text = "CVV";
            // 
            // TxtExpDate
            // 
            this.TxtExpDate.AutoSize = true;
            this.TxtExpDate.Location = new System.Drawing.Point(202, 57);
            this.TxtExpDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtExpDate.Name = "TxtExpDate";
            this.TxtExpDate.Size = new System.Drawing.Size(61, 13);
            this.TxtExpDate.TabIndex = 12;
            this.TxtExpDate.Text = "Expiry Date";
            // 
            // InpExpBox
            // 
            this.InpExpBox.Location = new System.Drawing.Point(205, 72);
            this.InpExpBox.Margin = new System.Windows.Forms.Padding(2);
            this.InpExpBox.Name = "InpExpBox";
            this.InpExpBox.Size = new System.Drawing.Size(56, 20);
            this.InpExpBox.TabIndex = 11;
            // 
            // TxtBilAdr
            // 
            this.TxtBilAdr.AutoSize = true;
            this.TxtBilAdr.Location = new System.Drawing.Point(9, 93);
            this.TxtBilAdr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtBilAdr.Name = "TxtBilAdr";
            this.TxtBilAdr.Size = new System.Drawing.Size(75, 13);
            this.TxtBilAdr.TabIndex = 13;
            this.TxtBilAdr.Text = "Billing Address";
            // 
            // TxtPostcode
            // 
            this.TxtPostcode.AutoSize = true;
            this.TxtPostcode.Location = new System.Drawing.Point(9, 126);
            this.TxtPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtPostcode.Name = "TxtPostcode";
            this.TxtPostcode.Size = new System.Drawing.Size(52, 13);
            this.TxtPostcode.TabIndex = 14;
            this.TxtPostcode.Text = "Postcode";
            this.TxtPostcode.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TxtCountry
            // 
            this.TxtCountry.AutoSize = true;
            this.TxtCountry.Location = new System.Drawing.Point(9, 166);
            this.TxtCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(43, 13);
            this.TxtCountry.TabIndex = 15;
            this.TxtCountry.Text = "Country";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(9, 248);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(98, 38);
            this.btBack.TabIndex = 16;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Payment_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 366);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.TxtPostcode);
            this.Controls.Add(this.TxtBilAdr);
            this.Controls.Add(this.TxtExpDate);
            this.Controls.Add(this.InpExpBox);
            this.Controls.Add(this.TxtCVV);
            this.Controls.Add(this.TxtCardNum);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnPayment);
            this.Controls.Add(this.InpCountryBox);
            this.Controls.Add(this.InpPcBox);
            this.Controls.Add(this.InpAdrbox);
            this.Controls.Add(this.InpCvBox);
            this.Controls.Add(this.InpCardNumbox);
            this.Controls.Add(this.InpNamebox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment_Page";
            this.Text = "Payment_Page";
            this.Load += new System.EventHandler(this.Payment_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InpNamebox;
        private System.Windows.Forms.TextBox InpCardNumbox;
        private System.Windows.Forms.TextBox InpCvBox;
        private System.Windows.Forms.TextBox InpAdrbox;
        private System.Windows.Forms.TextBox InpPcBox;
        private System.Windows.Forms.TextBox InpCountryBox;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Label TxtName;
        private System.Windows.Forms.Label TxtCardNum;
        private System.Windows.Forms.Label TxtCVV;
        private System.Windows.Forms.Label TxtExpDate;
        private System.Windows.Forms.TextBox InpExpBox;
        private System.Windows.Forms.Label TxtBilAdr;
        private System.Windows.Forms.Label TxtPostcode;
        private System.Windows.Forms.Label TxtCountry;
        private System.Windows.Forms.Button btBack;
    }
}