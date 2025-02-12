using System.Drawing;
using System.Windows.Forms;

namespace ProjectGui
{
    partial class Community_Members
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvUserInterests = new System.Windows.Forms.DataGridView();
            this.intrestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrestDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new ProjectGui.ProjectDBDataSet();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.intrestsTableAdapter = new ProjectGui.ProjectDBDataSetTableAdapters.IntrestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInterests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(177, 27);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Community Member";
            // 
            // dgvUserInterests
            // 
            this.dgvUserInterests.AllowUserToAddRows = false;
            this.dgvUserInterests.AllowUserToDeleteRows = false;
            this.dgvUserInterests.AutoGenerateColumns = false;
            this.dgvUserInterests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInterests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserInterests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInterests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intrestIDDataGridViewTextBoxColumn,
            this.intrestNameDataGridViewTextBoxColumn,
            this.intrestDescriptionDataGridViewTextBoxColumn});
            this.dgvUserInterests.DataSource = this.intrestsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserInterests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserInterests.Location = new System.Drawing.Point(33, 101);
            this.dgvUserInterests.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUserInterests.Name = "dgvUserInterests";
            this.dgvUserInterests.ReadOnly = true;
            this.dgvUserInterests.RowHeadersWidth = 51;
            this.dgvUserInterests.RowTemplate.Height = 30;
            this.dgvUserInterests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInterests.Size = new System.Drawing.Size(529, 187);
            this.dgvUserInterests.TabIndex = 1;
            // 
            // intrestIDDataGridViewTextBoxColumn
            // 
            this.intrestIDDataGridViewTextBoxColumn.DataPropertyName = "Intrest_ID";
            this.intrestIDDataGridViewTextBoxColumn.HeaderText = "Intrest_ID";
            this.intrestIDDataGridViewTextBoxColumn.Name = "intrestIDDataGridViewTextBoxColumn";
            this.intrestIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intrestNameDataGridViewTextBoxColumn
            // 
            this.intrestNameDataGridViewTextBoxColumn.DataPropertyName = "Intrest_Name";
            this.intrestNameDataGridViewTextBoxColumn.HeaderText = "Intrest_Name";
            this.intrestNameDataGridViewTextBoxColumn.Name = "intrestNameDataGridViewTextBoxColumn";
            this.intrestNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intrestDescriptionDataGridViewTextBoxColumn
            // 
            this.intrestDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Intrest_Description";
            this.intrestDescriptionDataGridViewTextBoxColumn.HeaderText = "Intrest_Description";
            this.intrestDescriptionDataGridViewTextBoxColumn.Name = "intrestDescriptionDataGridViewTextBoxColumn";
            this.intrestDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intrestsBindingSource
            // 
            this.intrestsBindingSource.DataMember = "Intrests";
            this.intrestsBindingSource.DataSource = this.projectDBDataSet;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.Location = new System.Drawing.Point(490, 303);
            this.btnViewEvents.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(90, 32);
            this.btnViewEvents.TabIndex = 2;
            this.btnViewEvents.Text = "View Events";
            this.btnViewEvents.UseVisualStyleBackColor = true;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);  // Corrected event handler
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 79);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 73);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Together \r\nCulture\r\nCAMBRIDGE\r\n";
            // 
            // intrestsTableAdapter
            // 
            this.intrestsTableAdapter.ClearBeforeFill = true;
            // 
            // Community_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewEvents);
            this.Controls.Add(this.dgvUserInterests);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Community_Members";
            this.Text = "Community Members";
            this.Load += new System.EventHandler(this.Community_Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInterests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUserInterests;
        private System.Windows.Forms.Button btnViewEvents;
        private Panel panel1;
        private TextBox textBox1;
        private ProjectDBDataSet projectDBDataSet;
        private BindingSource intrestsBindingSource;
        private ProjectDBDataSetTableAdapters.IntrestsTableAdapter intrestsTableAdapter;
        private DataGridViewTextBoxColumn intrestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intrestNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn intrestDescriptionDataGridViewTextBoxColumn;
    }
}
