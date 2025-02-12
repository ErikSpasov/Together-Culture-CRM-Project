namespace ProjectGui
{
    partial class Guest_Page
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
            this.btnEvents = new System.Windows.Forms.Button();
            this.TxtNameGuest = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOnlineModule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEvents.Location = new System.Drawing.Point(38, 234);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(88, 56);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // TxtNameGuest
            // 
            this.TxtNameGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNameGuest.AutoSize = true;
            this.TxtNameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameGuest.Location = new System.Drawing.Point(196, 92);
            this.TxtNameGuest.Name = "TxtNameGuest";
            this.TxtNameGuest.Size = new System.Drawing.Size(167, 29);
            this.TxtNameGuest.TabIndex = 3;
            this.TxtNameGuest.Text = "GUEST PAGE";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Location = new System.Drawing.Point(414, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOnlineModule
            // 
            this.btnOnlineModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOnlineModule.Location = new System.Drawing.Point(209, 234);
            this.btnOnlineModule.Name = "btnOnlineModule";
            this.btnOnlineModule.Size = new System.Drawing.Size(88, 56);
            this.btnOnlineModule.TabIndex = 6;
            this.btnOnlineModule.Text = "ONLINE MODULE";
            this.btnOnlineModule.UseVisualStyleBackColor = true;
            this.btnOnlineModule.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guest_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 426);
            this.Controls.Add(this.btnOnlineModule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.TxtNameGuest);
            this.Controls.Add(this.btnEvents);
            this.Name = "Guest_Page";
            this.Text = "Guest_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Label TxtNameGuest;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOnlineModule;
    }
}