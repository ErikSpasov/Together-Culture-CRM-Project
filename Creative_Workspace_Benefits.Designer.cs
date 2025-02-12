namespace ProjectGui
{
    partial class Creative_Workspace_Benefits
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
            this.CWB_title_lable = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.chartCMB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new ProjectGui.ProjectDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.chartCMB)).BeginInit();
            this.SuspendLayout();
            // 
            // CWB_title_lable
            // 
            this.CWB_title_lable.AutoSize = true;
            this.CWB_title_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWB_title_lable.Location = new System.Drawing.Point(15, 9);
            this.CWB_title_lable.Name = "CWB_title_lable";
            this.CWB_title_lable.Size = new System.Drawing.Size(773, 73);
            this.CWB_title_lable.TabIndex = 2;
            this.CWB_title_lable.Text = "Creative Member Benefits";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(509, 350);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(265, 47);
            this.btBack.TabIndex = 20;
            this.btBack.Text = "Back to Dashboard";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // chartCMB
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCMB.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCMB.Legends.Add(legend1);
            this.chartCMB.Location = new System.Drawing.Point(12, 85);
            this.chartCMB.Name = "chartCMB";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Your Interests";
            this.chartCMB.Series.Add(series1);
            this.chartCMB.Size = new System.Drawing.Size(476, 353);
            this.chartCMB.TabIndex = 21;
            this.chartCMB.Text = "chart1";
            this.chartCMB.Click += new System.EventHandler(this.chartCMB_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(509, 86);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(265, 248);
            this.tbInfo.TabIndex = 22;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.IntrestsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ProjectGui.ProjectDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Creative_Workspace_Benefits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.chartCMB);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.CWB_title_lable);
            this.Name = "Creative_Workspace_Benefits";
            this.Text = "Creative_Workspace_Benefits";
            ((System.ComponentModel.ISupportInitialize)(this.chartCMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CWB_title_lable;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCMB;
        private System.Windows.Forms.TextBox tbInfo;
        private ProjectDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}