namespace ProjectGui
{
    partial class Creative_Workspace_Membership
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
            this.components = new System.ComponentModel.Container();
            this.CWM_title_lable = new System.Windows.Forms.Label();
            this.CWM_Pay_Membership_Button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CWM_title_lable
            // 
            this.CWM_title_lable.AutoSize = true;
            this.CWM_title_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWM_title_lable.Location = new System.Drawing.Point(4, 9);
            this.CWM_title_lable.Name = "CWM_title_lable";
            this.CWM_title_lable.Size = new System.Drawing.Size(635, 73);
            this.CWM_title_lable.TabIndex = 4;
            this.CWM_title_lable.Text = "Manage Membership";
            // 
            // CWM_Pay_Membership_Button
            // 
            this.CWM_Pay_Membership_Button.Location = new System.Drawing.Point(17, 85);
            this.CWM_Pay_Membership_Button.Name = "CWM_Pay_Membership_Button";
            this.CWM_Pay_Membership_Button.Size = new System.Drawing.Size(601, 50);
            this.CWM_Pay_Membership_Button.TabIndex = 10;
            this.CWM_Pay_Membership_Button.Text = "Pay Membership";
            this.CWM_Pay_Membership_Button.UseVisualStyleBackColor = true;
            this.CWM_Pay_Membership_Button.Click += new System.EventHandler(this.CWM_Pay_Membership_Button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(17, 141);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(601, 47);
            this.btBack.TabIndex = 20;
            this.btBack.Text = "Back to Dashboard";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Creative_Workspace_Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 208);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.CWM_Pay_Membership_Button);
            this.Controls.Add(this.CWM_title_lable);
            this.Name = "Creative_Workspace_Membership";
            this.Text = "Creative_Workspace_Membership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CWM_title_lable;
        private System.Windows.Forms.Button CWM_Pay_Membership_Button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btBack;
    }
}