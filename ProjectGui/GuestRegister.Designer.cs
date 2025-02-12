namespace ProjectGui
{
    partial class GuestRegister
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btSubmitGuest = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbGuestEmail = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbGuestLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbGuestFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 28);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 18);
            this.progressBar1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(2, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "CAMBRIDGE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(2, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Together\r\nCulture";
            // 
            // btSubmitGuest
            // 
            this.btSubmitGuest.BackColor = System.Drawing.SystemColors.InfoText;
            this.btSubmitGuest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSubmitGuest.Location = new System.Drawing.Point(44, 207);
            this.btSubmitGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSubmitGuest.Name = "btSubmitGuest";
            this.btSubmitGuest.Size = new System.Drawing.Size(202, 40);
            this.btSubmitGuest.TabIndex = 14;
            this.btSubmitGuest.Text = "SUBMIT";
            this.btSubmitGuest.UseVisualStyleBackColor = false;
            this.btSubmitGuest.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbEmail.Location = new System.Drawing.Point(10, 130);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "E-Mail :";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(58, 16);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(282, 46);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Welcome to Together Culture \r\n            CAMBRIDGE";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Controls.Add(this.btSubmitGuest);
            this.panel6.Controls.Add(this.lbEmail);
            this.panel6.Controls.Add(this.tbGuestEmail);
            this.panel6.Controls.Add(this.lbLastName);
            this.panel6.Controls.Add(this.tbGuestLastName);
            this.panel6.Controls.Add(this.lbFirstName);
            this.panel6.Controls.Add(this.tbGuestFirstName);
            this.panel6.Location = new System.Drawing.Point(45, 89);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 262);
            this.panel6.TabIndex = 0;
            // 
            // tbGuestEmail
            // 
            this.tbGuestEmail.Location = new System.Drawing.Point(14, 152);
            this.tbGuestEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGuestEmail.Name = "tbGuestEmail";
            this.tbGuestEmail.Size = new System.Drawing.Size(270, 20);
            this.tbGuestEmail.TabIndex = 12;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbLastName.Location = new System.Drawing.Point(10, 70);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(64, 13);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Last Name :";
            // 
            // tbGuestLastName
            // 
            this.tbGuestLastName.Location = new System.Drawing.Point(14, 93);
            this.tbGuestLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGuestLastName.Name = "tbGuestLastName";
            this.tbGuestLastName.Size = new System.Drawing.Size(270, 20);
            this.tbGuestLastName.TabIndex = 4;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbFirstName.Location = new System.Drawing.Point(10, 15);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(63, 13);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name :";
            // 
            // tbGuestFirstName
            // 
            this.tbGuestFirstName.Location = new System.Drawing.Point(14, 41);
            this.tbGuestFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGuestFirstName.Name = "tbGuestFirstName";
            this.tbGuestFirstName.Size = new System.Drawing.Size(270, 20);
            this.tbGuestFirstName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.lbWelcome);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(4, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 392);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 66);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 457);
            this.panel1.TabIndex = 1;
            // 
            // GuestRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 452);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GuestRegister";
            this.Text = "GuestRegister";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSubmitGuest;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbGuestEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbGuestLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbGuestFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

