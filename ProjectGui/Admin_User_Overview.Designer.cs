namespace ProjectGui
{
    partial class Admin_User_Overview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btClose = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbCurrentUserRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChangeUserRoleSeletion = new System.Windows.Forms.ComboBox();
            this.btApplyUserRoleSelection = new System.Windows.Forms.Button();
            this.chartGlobalInterests = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbIsUserApproved = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalInterests)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(282, 387);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(98, 51);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(131, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Current Membership Type:";
            // 
            // tbCurrentUserRole
            // 
            this.tbCurrentUserRole.Location = new System.Drawing.Point(149, 12);
            this.tbCurrentUserRole.Name = "tbCurrentUserRole";
            this.tbCurrentUserRole.Size = new System.Drawing.Size(178, 20);
            this.tbCurrentUserRole.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Membership Type to:";
            // 
            // cbChangeUserRoleSeletion
            // 
            this.cbChangeUserRoleSeletion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeUserRoleSeletion.FormattingEnabled = true;
            this.cbChangeUserRoleSeletion.Location = new System.Drawing.Point(168, 38);
            this.cbChangeUserRoleSeletion.Name = "cbChangeUserRoleSeletion";
            this.cbChangeUserRoleSeletion.Size = new System.Drawing.Size(159, 21);
            this.cbChangeUserRoleSeletion.TabIndex = 4;
            // 
            // btApplyUserRoleSelection
            // 
            this.btApplyUserRoleSelection.Location = new System.Drawing.Point(333, 36);
            this.btApplyUserRoleSelection.Name = "btApplyUserRoleSelection";
            this.btApplyUserRoleSelection.Size = new System.Drawing.Size(58, 23);
            this.btApplyUserRoleSelection.TabIndex = 5;
            this.btApplyUserRoleSelection.Text = "Apply";
            this.btApplyUserRoleSelection.UseVisualStyleBackColor = true;
            this.btApplyUserRoleSelection.Click += new System.EventHandler(this.btApplyUserRoleSelection_Click);
            // 
            // chartGlobalInterests
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGlobalInterests.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGlobalInterests.Legends.Add(legend1);
            this.chartGlobalInterests.Location = new System.Drawing.Point(-15, 41);
            this.chartGlobalInterests.Name = "chartGlobalInterests";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "User Interests";
            this.chartGlobalInterests.Series.Add(series1);
            this.chartGlobalInterests.Size = new System.Drawing.Size(579, 283);
            this.chartGlobalInterests.TabIndex = 6;
            this.chartGlobalInterests.Text = "Global Interests";
            // 
            // tbIsUserApproved
            // 
            this.tbIsUserApproved.Location = new System.Drawing.Point(128, 328);
            this.tbIsUserApproved.Name = "tbIsUserApproved";
            this.tbIsUserApproved.Size = new System.Drawing.Size(148, 20);
            this.tbIsUserApproved.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Approval Status";
            // 
            // btApprove
            // 
            this.btApprove.Location = new System.Drawing.Point(282, 326);
            this.btApprove.Name = "btApprove";
            this.btApprove.Size = new System.Drawing.Size(98, 23);
            this.btApprove.TabIndex = 9;
            this.btApprove.Text = "Toggle Approve";
            this.btApprove.UseVisualStyleBackColor = true;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click);
            // 
            // Admin_User_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btApprove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIsUserApproved);
            this.Controls.Add(this.btApplyUserRoleSelection);
            this.Controls.Add(this.cbChangeUserRoleSeletion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentUserRole);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.chartGlobalInterests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Admin_User_Overview";
            this.Text = "Admin_User_Overview";
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalInterests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbCurrentUserRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChangeUserRoleSeletion;
        private System.Windows.Forms.Button btApplyUserRoleSelection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlobalInterests;
        private System.Windows.Forms.TextBox tbIsUserApproved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btApprove;
    }
}