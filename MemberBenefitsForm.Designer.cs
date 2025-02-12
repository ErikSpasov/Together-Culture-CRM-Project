namespace MemberBenefitsDashboard
{
    partial class MemberBenefitsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBenefits = new System.Windows.Forms.DataGridView();
            this.progressBarUsage = new System.Windows.Forms.ProgressBar();
            this.btnToggleBenefitStatus = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenefits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(329, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Benefits Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewBenefits
            // 
            this.dataGridViewBenefits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBenefits.Location = new System.Drawing.Point(286, 84);
            this.dataGridViewBenefits.Name = "dataGridViewBenefits";
            this.dataGridViewBenefits.Size = new System.Drawing.Size(234, 126);
            this.dataGridViewBenefits.TabIndex = 1;
            // 
            // progressBarUsage
            // 
            this.progressBarUsage.Location = new System.Drawing.Point(312, 236);
            this.progressBarUsage.Name = "progressBarUsage";
            this.progressBarUsage.Size = new System.Drawing.Size(177, 23);
            this.progressBarUsage.TabIndex = 2;
            this.progressBarUsage.Value = 100;
            // 
            // btnToggleBenefitStatus
            // 
            this.btnToggleBenefitStatus.Location = new System.Drawing.Point(267, 279);
            this.btnToggleBenefitStatus.Name = "btnToggleBenefitStatus";
            this.btnToggleBenefitStatus.Size = new System.Drawing.Size(107, 23);
            this.btnToggleBenefitStatus.TabIndex = 3;
            this.btnToggleBenefitStatus.Text = "Update Status";
            this.btnToggleBenefitStatus.UseVisualStyleBackColor = true;
            this.btnToggleBenefitStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(413, 279);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(107, 23);
            this.btnViewDetails.TabIndex = 4;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(0, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(801, 55);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Together\r\nCulture";
            // 
            // MemberBenefitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnToggleBenefitStatus);
            this.Controls.Add(this.progressBarUsage);
            this.Controls.Add(this.dataGridViewBenefits);
            this.Controls.Add(this.label1);
            this.Name = "MemberBenefitsForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.MemberBenefitsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBenefits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBenefits;
        private System.Windows.Forms.ProgressBar progressBarUsage;
        private System.Windows.Forms.Button btnToggleBenefitStatus;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.TextBox textBox1;
    }
}