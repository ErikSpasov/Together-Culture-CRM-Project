namespace ProjectGui
{
    partial class Creative_Workspace_Events
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
            this.lb_test_CWE = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.tbEventDescription = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.dtpEventTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.Delete_1 = new System.Windows.Forms.Label();
            this.delete_2 = new System.Windows.Forms.Label();
            this.lbEventTag = new System.Windows.Forms.Label();
            this.lvCWE = new System.Windows.Forms.ListView();
            this.eventTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btLoadEventDescription = new System.Windows.Forms.Button();
            this.tbLoadEventDescription = new System.Windows.Forms.TextBox();
            this.cbEventTag = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_test_CWE
            // 
            this.lb_test_CWE.AutoSize = true;
            this.lb_test_CWE.Location = new System.Drawing.Point(164, 33);
            this.lb_test_CWE.Name = "lb_test_CWE";
            this.lb_test_CWE.Size = new System.Drawing.Size(0, 13);
            this.lb_test_CWE.TabIndex = 2;
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(614, 10);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(168, 20);
            this.tbEventName.TabIndex = 3;
            // 
            // tbEventDescription
            // 
            this.tbEventDescription.Location = new System.Drawing.Point(520, 59);
            this.tbEventDescription.Multiline = true;
            this.tbEventDescription.Name = "tbEventDescription";
            this.tbEventDescription.Size = new System.Drawing.Size(268, 163);
            this.tbEventDescription.TabIndex = 4;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(520, 300);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(268, 52);
            this.btInsert.TabIndex = 8;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // dtpEventTime
            // 
            this.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventTime.Location = new System.Drawing.Point(713, 238);
            this.dtpEventTime.Name = "dtpEventTime";
            this.dtpEventTime.ShowUpDown = true;
            this.dtpEventTime.Size = new System.Drawing.Size(69, 20);
            this.dtpEventTime.TabIndex = 9;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(594, 238);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(99, 20);
            this.dtpEventDate.TabIndex = 10;
            // 
            // Delete_1
            // 
            this.Delete_1.AutoSize = true;
            this.Delete_1.Location = new System.Drawing.Point(520, 13);
            this.Delete_1.Name = "Delete_1";
            this.Delete_1.Size = new System.Drawing.Size(64, 13);
            this.Delete_1.TabIndex = 11;
            this.Delete_1.Text = "Event name";
            // 
            // delete_2
            // 
            this.delete_2.AutoSize = true;
            this.delete_2.Location = new System.Drawing.Point(520, 43);
            this.delete_2.Name = "delete_2";
            this.delete_2.Size = new System.Drawing.Size(89, 13);
            this.delete_2.TabIndex = 12;
            this.delete_2.Text = "Event description";
            // 
            // lbEventTag
            // 
            this.lbEventTag.AutoSize = true;
            this.lbEventTag.Location = new System.Drawing.Point(520, 276);
            this.lbEventTag.Name = "lbEventTag";
            this.lbEventTag.Size = new System.Drawing.Size(53, 13);
            this.lbEventTag.TabIndex = 13;
            this.lbEventTag.Text = "Event tag";
            // 
            // lvCWE
            // 
            this.lvCWE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventTitle,
            this.eventDate,
            this.eventTime,
            this.ID});
            this.lvCWE.FullRowSelect = true;
            this.lvCWE.HideSelection = false;
            this.lvCWE.Location = new System.Drawing.Point(12, 12);
            this.lvCWE.Name = "lvCWE";
            this.lvCWE.Size = new System.Drawing.Size(488, 340);
            this.lvCWE.TabIndex = 14;
            this.lvCWE.UseCompatibleStateImageBehavior = false;
            this.lvCWE.View = System.Windows.Forms.View.Details;
            // 
            // eventTitle
            // 
            this.eventTitle.Text = "Event Title";
            this.eventTitle.Width = 150;
            // 
            // eventDate
            // 
            this.eventDate.Text = "Event Date";
            this.eventDate.Width = 70;
            // 
            // eventTime
            // 
            this.eventTime.Text = "Event Time";
            this.eventTime.Width = 70;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // btLoadEventDescription
            // 
            this.btLoadEventDescription.Location = new System.Drawing.Point(420, 358);
            this.btLoadEventDescription.Name = "btLoadEventDescription";
            this.btLoadEventDescription.Size = new System.Drawing.Size(80, 40);
            this.btLoadEventDescription.TabIndex = 15;
            this.btLoadEventDescription.Text = "Load Event Description";
            this.btLoadEventDescription.UseVisualStyleBackColor = true;
            this.btLoadEventDescription.Click += new System.EventHandler(this.btLoadEventDescription_Click);
            // 
            // tbLoadEventDescription
            // 
            this.tbLoadEventDescription.Location = new System.Drawing.Point(12, 360);
            this.tbLoadEventDescription.Multiline = true;
            this.tbLoadEventDescription.Name = "tbLoadEventDescription";
            this.tbLoadEventDescription.Size = new System.Drawing.Size(402, 78);
            this.tbLoadEventDescription.TabIndex = 16;
            // 
            // cbEventTag
            // 
            this.cbEventTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventTag.FormattingEnabled = true;
            this.cbEventTag.Location = new System.Drawing.Point(595, 273);
            this.cbEventTag.Name = "cbEventTag";
            this.cbEventTag.Size = new System.Drawing.Size(188, 21);
            this.cbEventTag.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Start Date/time";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(523, 391);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(265, 47);
            this.btBack.TabIndex = 19;
            this.btBack.Text = "Back to Dashboard";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(420, 398);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(80, 40);
            this.btBook.TabIndex = 20;
            this.btBook.Text = "BOOK";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // Creative_Workspace_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEventTag);
            this.Controls.Add(this.tbLoadEventDescription);
            this.Controls.Add(this.btLoadEventDescription);
            this.Controls.Add(this.lvCWE);
            this.Controls.Add(this.lbEventTag);
            this.Controls.Add(this.delete_2);
            this.Controls.Add(this.Delete_1);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.dtpEventTime);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbEventDescription);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lb_test_CWE);
            this.Name = "Creative_Workspace_Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Creative_Workspace_Events_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_test_CWE;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.TextBox tbEventDescription;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.DateTimePicker dtpEventTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label Delete_1;
        private System.Windows.Forms.Label delete_2;
        private System.Windows.Forms.Label lbEventTag;
        private System.Windows.Forms.ListView lvCWE;
        private System.Windows.Forms.ColumnHeader eventTitle;
        private System.Windows.Forms.ColumnHeader eventDate;
        private System.Windows.Forms.ColumnHeader eventTime;
        private System.Windows.Forms.Button btLoadEventDescription;
        private System.Windows.Forms.TextBox tbLoadEventDescription;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox cbEventTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btBook;
    }
}