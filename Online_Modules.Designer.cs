namespace ProjectGui
{
    partial class Online_Modules
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
            this.lbAvailableModules = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.lbFilterTags = new System.Windows.Forms.Label();
            this.cbTagFilter = new System.Windows.Forms.ComboBox();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.Module_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAvailableModules
            // 
            this.lbAvailableModules.AutoSize = true;
            this.lbAvailableModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableModules.Location = new System.Drawing.Point(301, 9);
            this.lbAvailableModules.Name = "lbAvailableModules";
            this.lbAvailableModules.Size = new System.Drawing.Size(312, 39);
            this.lbAvailableModules.TabIndex = 0;
            this.lbAvailableModules.Text = "Available Modules";
            this.lbAvailableModules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Module_ID,
            this.Module_Name,
            this.Module_Description,
            this.Access_Type,
            this.Tag_Name});
            this.dgvModules.Location = new System.Drawing.Point(136, 94);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.RowHeadersWidth = 51;
            this.dgvModules.RowTemplate.Height = 24;
            this.dgvModules.Size = new System.Drawing.Size(785, 294);
            this.dgvModules.TabIndex = 1;
            // 
            // lbFilterTags
            // 
            this.lbFilterTags.AutoSize = true;
            this.lbFilterTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterTags.Location = new System.Drawing.Point(133, 60);
            this.lbFilterTags.Name = "lbFilterTags";
            this.lbFilterTags.Size = new System.Drawing.Size(110, 25);
            this.lbFilterTags.TabIndex = 2;
            this.lbFilterTags.Text = "Filter Tags:";
            // 
            // cbTagFilter
            // 
            this.cbTagFilter.FormattingEnabled = true;
            this.cbTagFilter.Location = new System.Drawing.Point(249, 64);
            this.cbTagFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTagFilter.Name = "cbTagFilter";
            this.cbTagFilter.Size = new System.Drawing.Size(95, 24);
            this.cbTagFilter.TabIndex = 3;
            this.cbTagFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(136, 407);
            this.btnEnroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(171, 36);
            this.btnEnroll.TabIndex = 5;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click_1);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(568, 418);
            this.btBack.Margin = new System.Windows.Forms.Padding(4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(353, 58);
            this.btBack.TabIndex = 21;
            this.btBack.Text = "Back to Dashboard";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Module_ID
            // 
            this.Module_ID.HeaderText = "Module ID";
            this.Module_ID.MinimumWidth = 6;
            this.Module_ID.Name = "Module_ID";
            this.Module_ID.Visible = false;
            this.Module_ID.Width = 125;
            // 
            // Module_Name
            // 
            this.Module_Name.HeaderText = "Module Name";
            this.Module_Name.MinimumWidth = 6;
            this.Module_Name.Name = "Module_Name";
            this.Module_Name.Width = 125;
            // 
            // Module_Description
            // 
            this.Module_Description.HeaderText = "Module Description";
            this.Module_Description.MinimumWidth = 6;
            this.Module_Description.Name = "Module_Description";
            this.Module_Description.Width = 125;
            // 
            // Access_Type
            // 
            this.Access_Type.HeaderText = "Access Type";
            this.Access_Type.MinimumWidth = 6;
            this.Access_Type.Name = "Access_Type";
            this.Access_Type.Visible = false;
            this.Access_Type.Width = 125;
            // 
            // Tag_Name
            // 
            this.Tag_Name.HeaderText = "Tag Name";
            this.Tag_Name.MinimumWidth = 6;
            this.Tag_Name.Name = "Tag_Name";
            this.Tag_Name.Visible = false;
            this.Tag_Name.Width = 125;
            // 
            // Online_Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 522);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.cbTagFilter);
            this.Controls.Add(this.lbFilterTags);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.lbAvailableModules);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Online_Modules";
            this.Text = "Online_Modules";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAvailableModules;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label lbFilterTags;
        private System.Windows.Forms.ComboBox cbTagFilter;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Access_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag_Name;
    }
}