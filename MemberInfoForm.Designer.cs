namespace MemberInformation
{
    partial class MemberInfoForm
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
            this.lblInterests = new System.Windows.Forms.Label();
            this.lblIntentions = new System.Windows.Forms.Label();
            this.txtInterests = new System.Windows.Forms.TextBox();
            this.txtIntentions = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInterests
            // 
            this.lblInterests.AutoSize = true;
            this.lblInterests.Location = new System.Drawing.Point(59, 76);
            this.lblInterests.Name = "lblInterests";
            this.lblInterests.Size = new System.Drawing.Size(47, 13);
            this.lblInterests.TabIndex = 0;
            this.lblInterests.Text = "Interests";
            // 
            // lblIntentions
            // 
            this.lblIntentions.AutoSize = true;
            this.lblIntentions.Location = new System.Drawing.Point(59, 166);
            this.lblIntentions.Name = "lblIntentions";
            this.lblIntentions.Size = new System.Drawing.Size(53, 13);
            this.lblIntentions.TabIndex = 1;
            this.lblIntentions.Text = "Intentions";
            // 
            // txtInterests
            // 
            this.txtInterests.Location = new System.Drawing.Point(62, 92);
            this.txtInterests.Name = "txtInterests";
            this.txtInterests.Size = new System.Drawing.Size(100, 20);
            this.txtInterests.TabIndex = 2;
            // 
            // txtIntentions
            // 
            this.txtIntentions.Location = new System.Drawing.Point(62, 182);
            this.txtIntentions.Name = "txtIntentions";
            this.txtIntentions.Size = new System.Drawing.Size(100, 20);
            this.txtIntentions.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(360, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(62, 329);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(-3, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(542, 48);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Together \r\nCulture";
            // 
            // MemberInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIntentions);
            this.Controls.Add(this.txtInterests);
            this.Controls.Add(this.lblIntentions);
            this.Controls.Add(this.lblInterests);
            this.Name = "MemberInfoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MemberInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterests;
        private System.Windows.Forms.Label lblIntentions;
        private System.Windows.Forms.TextBox txtInterests;
        private System.Windows.Forms.TextBox txtIntentions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox textBox1;
    }
}

