namespace ProjectGui
{
    partial class Creative_Workspace_Dashboard
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
            this.CWD_title_lable = new System.Windows.Forms.Label();
            this.CWD_View_Benifits_Button = new System.Windows.Forms.Button();
            this.CWD_View_Benefits_Button = new System.Windows.Forms.Button();
            this.CWD_Manage_Membership_Button = new System.Windows.Forms.Button();
            this.btnOnlineModules = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CWD_title_lable
            // 
            this.CWD_title_lable.AutoSize = true;
            this.CWD_title_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWD_title_lable.Location = new System.Drawing.Point(12, 9);
            this.CWD_title_lable.Name = "CWD_title_lable";
            this.CWD_title_lable.Size = new System.Drawing.Size(498, 120);
            this.CWD_title_lable.TabIndex = 1;
            this.CWD_title_lable.Text = "Welcome";
            // 
            // CWD_View_Benifits_Button
            // 
            this.CWD_View_Benifits_Button.Location = new System.Drawing.Point(12, 132);
            this.CWD_View_Benifits_Button.Name = "CWD_View_Benifits_Button";
            this.CWD_View_Benifits_Button.Size = new System.Drawing.Size(150, 50);
            this.CWD_View_Benifits_Button.TabIndex = 2;
            this.CWD_View_Benifits_Button.Text = "View Benefits";
            this.CWD_View_Benifits_Button.UseVisualStyleBackColor = true;
            this.CWD_View_Benifits_Button.Click += new System.EventHandler(this.CWD_View_Benifits_Button_Click);
            // 
            // CWD_View_Benefits_Button
            // 
            this.CWD_View_Benefits_Button.Location = new System.Drawing.Point(168, 132);
            this.CWD_View_Benefits_Button.Name = "CWD_View_Benefits_Button";
            this.CWD_View_Benefits_Button.Size = new System.Drawing.Size(150, 50);
            this.CWD_View_Benefits_Button.TabIndex = 3;
            this.CWD_View_Benefits_Button.Text = "Events Manager";
            this.CWD_View_Benefits_Button.UseVisualStyleBackColor = true;
            this.CWD_View_Benefits_Button.Click += new System.EventHandler(this.CWD_View_Benefits_Button_Click);
            // 
            // CWD_Manage_Membership_Button
            // 
            this.CWD_Manage_Membership_Button.Location = new System.Drawing.Point(324, 132);
            this.CWD_Manage_Membership_Button.Name = "CWD_Manage_Membership_Button";
            this.CWD_Manage_Membership_Button.Size = new System.Drawing.Size(150, 50);
            this.CWD_Manage_Membership_Button.TabIndex = 4;
            this.CWD_Manage_Membership_Button.Text = "Manage Membership";
            this.CWD_Manage_Membership_Button.UseVisualStyleBackColor = true;
            this.CWD_Manage_Membership_Button.Click += new System.EventHandler(this.CWD_Manage_Membership_Button_Click);
            // 
            // btnOnlineModules
            // 
            this.btnOnlineModules.Location = new System.Drawing.Point(11, 187);
            this.btnOnlineModules.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnlineModules.Name = "btnOnlineModules";
            this.btnOnlineModules.Size = new System.Drawing.Size(150, 50);
            this.btnOnlineModules.TabIndex = 6;
            this.btnOnlineModules.Text = "Online Modules";
            this.btnOnlineModules.UseVisualStyleBackColor = true;
            this.btnOnlineModules.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(168, 184);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(306, 53);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "EXIT";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Creative_Workspace_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 242);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btnOnlineModules);
            this.Controls.Add(this.CWD_Manage_Membership_Button);
            this.Controls.Add(this.CWD_View_Benefits_Button);
            this.Controls.Add(this.CWD_View_Benifits_Button);
            this.Controls.Add(this.CWD_title_lable);
            this.Name = "Creative_Workspace_Dashboard";
            this.Text = "Creative_Workspace_Dashboard";
            this.Load += new System.EventHandler(this.Creative_Workspace_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CWD_title_lable;
        private System.Windows.Forms.Button CWD_View_Benifits_Button;
        private System.Windows.Forms.Button CWD_View_Benefits_Button;
        private System.Windows.Forms.Button CWD_Manage_Membership_Button;
        private System.Windows.Forms.Button btnOnlineModules;
        private System.Windows.Forms.Button btExit;
    }
}