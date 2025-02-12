namespace ProjectGui
{
    partial class Admin_User_Operations
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
            this.lvAUO = new System.Windows.Forms.ListView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btApplyFilter = new System.Windows.Forms.Button();
            this.btOpenUserDeatails = new System.Windows.Forms.Button();
            this.chartGlobalInterests = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalInterests)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAUO
            // 
            this.lvAUO.FullRowSelect = true;
            this.lvAUO.HideSelection = false;
            this.lvAUO.Location = new System.Drawing.Point(12, 12);
            this.lvAUO.Name = "lvAUO";
            this.lvAUO.Size = new System.Drawing.Size(776, 259);
            this.lvAUO.TabIndex = 0;
            this.lvAUO.UseCompatibleStateImageBehavior = false;
            this.lvAUO.View = System.Windows.Forms.View.Details;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(12, 277);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(197, 21);
            this.cbFilter.TabIndex = 1;
            // 
            // btApplyFilter
            // 
            this.btApplyFilter.Location = new System.Drawing.Point(215, 275);
            this.btApplyFilter.Name = "btApplyFilter";
            this.btApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btApplyFilter.TabIndex = 2;
            this.btApplyFilter.Text = "Apply Filter";
            this.btApplyFilter.UseVisualStyleBackColor = true;
            this.btApplyFilter.Click += new System.EventHandler(this.btApplyFilter_Click);
            // 
            // btOpenUserDeatails
            // 
            this.btOpenUserDeatails.Location = new System.Drawing.Point(12, 304);
            this.btOpenUserDeatails.Name = "btOpenUserDeatails";
            this.btOpenUserDeatails.Size = new System.Drawing.Size(278, 57);
            this.btOpenUserDeatails.TabIndex = 3;
            this.btOpenUserDeatails.Text = "Open Selected User Details";
            this.btOpenUserDeatails.UseVisualStyleBackColor = true;
            this.btOpenUserDeatails.Click += new System.EventHandler(this.btOpenUserDeatails_Click);
            // 
            // chartGlobalInterests
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGlobalInterests.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGlobalInterests.Legends.Add(legend1);
            this.chartGlobalInterests.Location = new System.Drawing.Point(314, 244);
            this.chartGlobalInterests.Name = "chartGlobalInterests";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Interest Distribution of selected filter";
            this.chartGlobalInterests.Series.Add(series1);
            this.chartGlobalInterests.Size = new System.Drawing.Size(670, 321);
            this.chartGlobalInterests.TabIndex = 4;
            this.chartGlobalInterests.Text = "Global Interests";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_User_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvAUO);
            this.Controls.Add(this.chartGlobalInterests);
            this.Controls.Add(this.btOpenUserDeatails);
            this.Controls.Add(this.btApplyFilter);
            this.Controls.Add(this.cbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Admin_User_Operations";
            this.Text = "Admin_User_Operations";
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobalInterests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAUO;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btApplyFilter;
        private System.Windows.Forms.Button btOpenUserDeatails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlobalInterests;
        private System.Windows.Forms.Button button1;
    }
}