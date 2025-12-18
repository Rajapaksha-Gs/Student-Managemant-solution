namespace Student_Managemant.PLA.userControl
{
    partial class UserControlReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControlReport = new TabControl();
            tabPageClassReport = new TabPage();
            pictureBoxPrint1 = new PictureBox();
            dataGridViewClassReport = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            comboBoxClass = new ComboBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerDate = new DateTimePicker();
            tabPageStudentReport = new TabPage();
            pictureBox1 = new PictureBox();
            dataGridViewStudentReport = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel15 = new Panel();
            panel8 = new Panel();
            comboBoxRegNo = new ComboBox();
            comboBoxClass1 = new ComboBox();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            label7 = new Label();
            panel14 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePickerDate1 = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            tabControlReport.SuspendLayout();
            tabPageClassReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassReport).BeginInit();
            tabPageStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentReport).BeginInit();
            SuspendLayout();
            // 
            // tabControlReport
            // 
            tabControlReport.Alignment = TabAlignment.Bottom;
            tabControlReport.Anchor = AnchorStyles.None;
            tabControlReport.Controls.Add(tabPageClassReport);
            tabControlReport.Controls.Add(tabPageStudentReport);
            tabControlReport.Location = new Point(0, 0);
            tabControlReport.Name = "tabControlReport";
            tabControlReport.SelectedIndex = 0;
            tabControlReport.Size = new Size(942, 498);
            tabControlReport.TabIndex = 0;
            // 
            // tabPageClassReport
            // 
            tabPageClassReport.Controls.Add(pictureBoxPrint1);
            tabPageClassReport.Controls.Add(dataGridViewClassReport);
            tabPageClassReport.Controls.Add(panel7);
            tabPageClassReport.Controls.Add(comboBoxClass);
            tabPageClassReport.Controls.Add(panel6);
            tabPageClassReport.Controls.Add(panel5);
            tabPageClassReport.Controls.Add(panel4);
            tabPageClassReport.Controls.Add(panel3);
            tabPageClassReport.Controls.Add(panel1);
            tabPageClassReport.Controls.Add(panel2);
            tabPageClassReport.Controls.Add(label3);
            tabPageClassReport.Controls.Add(label2);
            tabPageClassReport.Controls.Add(label1);
            tabPageClassReport.Controls.Add(dateTimePickerDate);
            tabPageClassReport.Location = new Point(4, 4);
            tabPageClassReport.Name = "tabPageClassReport";
            tabPageClassReport.Padding = new Padding(3);
            tabPageClassReport.Size = new Size(934, 466);
            tabPageClassReport.TabIndex = 0;
            tabPageClassReport.Text = "Class Report";
            tabPageClassReport.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint1
            // 
            pictureBoxPrint1.Cursor = Cursors.Hand;
            pictureBoxPrint1.Image = Properties.Resources.icons8_printer_48;
            pictureBoxPrint1.Location = new Point(792, 4);
            pictureBoxPrint1.Name = "pictureBoxPrint1";
            pictureBoxPrint1.Size = new Size(40, 40);
            pictureBoxPrint1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPrint1.TabIndex = 3;
            pictureBoxPrint1.TabStop = false;
            pictureBoxPrint1.MouseHover += pictureBoxPrint1_MouseHover;
            pictureBoxPrint1.Click += pictureBoxPrint1_Click;
            // 
            // dataGridViewClassReport
            // 
            dataGridViewClassReport.AllowUserToAddRows = false;
            dataGridViewClassReport.AllowUserToDeleteRows = false;
            dataGridViewClassReport.AllowUserToResizeColumns = false;
            dataGridViewClassReport.AllowUserToResizeRows = false;
            dataGridViewClassReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewClassReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClassReport.BackgroundColor = Color.White;
            dataGridViewClassReport.BorderStyle = BorderStyle.None;
            dataGridViewClassReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClassReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClassReport.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewClassReport.Location = new Point(20, 148);
            dataGridViewClassReport.Name = "dataGridViewClassReport";
            dataGridViewClassReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewClassReport.ScrollBars = ScrollBars.Vertical;
            dataGridViewClassReport.ShowCellErrors = false;
            dataGridViewClassReport.ShowRowErrors = false;
            dataGridViewClassReport.Size = new Size(889, 297);
            dataGridViewClassReport.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Student_Name";
            Column1.HeaderText = "Student Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Student_RegNo";
            Column2.HeaderText = "Reg No";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Class_Name";
            Column3.HeaderText = "Class";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Attendance_Date";
            Column4.HeaderText = "Date";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Attendance_Status";
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(582, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 0;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(582, 77);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 27);
            comboBoxClass.TabIndex = 2;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            comboBoxClass.Click += comboBoxClass_Click;
            comboBoxClass.Enter += comboBoxClass_Enter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(33, 103);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(242, 78);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 22);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Location = new Point(302, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 22);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(24, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 23);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(33, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(33, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 10);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(565, 52);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 0;
            label3.Text = "Class:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(36, 52);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 0;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 178, 151);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 0;
            label1.Text = "Class Report";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(33, 77);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(270, 24);
            dateTimePickerDate.TabIndex = 0;
            dateTimePickerDate.ValueChanged += dateTimePickerDate_ValueChanged;
            // 
            // tabPageStudentReport
            // 
            tabPageStudentReport.Controls.Add(pictureBox1);
            tabPageStudentReport.Controls.Add(dataGridViewStudentReport);
            tabPageStudentReport.Controls.Add(panel15);
            tabPageStudentReport.Controls.Add(panel8);
            tabPageStudentReport.Controls.Add(comboBoxRegNo);
            tabPageStudentReport.Controls.Add(comboBoxClass1);
            tabPageStudentReport.Controls.Add(panel9);
            tabPageStudentReport.Controls.Add(panel10);
            tabPageStudentReport.Controls.Add(panel11);
            tabPageStudentReport.Controls.Add(panel12);
            tabPageStudentReport.Controls.Add(panel13);
            tabPageStudentReport.Controls.Add(label7);
            tabPageStudentReport.Controls.Add(panel14);
            tabPageStudentReport.Controls.Add(label4);
            tabPageStudentReport.Controls.Add(label5);
            tabPageStudentReport.Controls.Add(label6);
            tabPageStudentReport.Controls.Add(dateTimePickerDate1);
            tabPageStudentReport.Location = new Point(4, 4);
            tabPageStudentReport.Name = "tabPageStudentReport";
            tabPageStudentReport.Padding = new Padding(3);
            tabPageStudentReport.Size = new Size(934, 470);
            tabPageStudentReport.TabIndex = 1;
            tabPageStudentReport.Text = "Student Report";
            tabPageStudentReport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_printer_48;
            pictureBox1.Location = new Point(792, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridViewStudentReport
            // 
            dataGridViewStudentReport.AllowUserToAddRows = false;
            dataGridViewStudentReport.AllowUserToDeleteRows = false;
            dataGridViewStudentReport.AllowUserToResizeColumns = false;
            dataGridViewStudentReport.AllowUserToResizeRows = false;
            dataGridViewStudentReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewStudentReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudentReport.BackgroundColor = Color.White;
            dataGridViewStudentReport.BorderStyle = BorderStyle.None;
            dataGridViewStudentReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStudentReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudentReport.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewStudentReport.Location = new Point(28, 157);
            dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            dataGridViewStudentReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudentReport.ScrollBars = ScrollBars.Vertical;
            dataGridViewStudentReport.ShowCellErrors = false;
            dataGridViewStudentReport.ShowRowErrors = false;
            dataGridViewStudentReport.Size = new Size(889, 297);
            dataGridViewStudentReport.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Student_Name";
            dataGridViewTextBoxColumn1.HeaderText = "Student Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Student_RegNo";
            dataGridViewTextBoxColumn2.HeaderText = "Reg No";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Class_Name";
            dataGridViewTextBoxColumn3.HeaderText = "Class";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Attendance_Date";
            dataGridViewTextBoxColumn4.HeaderText = "Date";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Attendance_Status";
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel15
            // 
            panel15.BackColor = Color.LightGray;
            panel15.Location = new Point(647, 109);
            panel15.Name = "panel15";
            panel15.Size = new Size(270, 2);
            panel15.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(349, 108);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 0;
            // 
            // comboBoxRegNo
            // 
            comboBoxRegNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegNo.FlatStyle = FlatStyle.Flat;
            comboBoxRegNo.FormattingEnabled = true;
            comboBoxRegNo.Location = new Point(647, 83);
            comboBoxRegNo.Name = "comboBoxRegNo";
            comboBoxRegNo.Size = new Size(270, 27);
            comboBoxRegNo.TabIndex = 3;
            comboBoxRegNo.SelectedIndexChanged += comboBoxRegNo_SelectedIndexChanged;
            // 
            // comboBoxClass1
            // 
            comboBoxClass1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass1.FlatStyle = FlatStyle.Flat;
            comboBoxClass1.FormattingEnabled = true;
            comboBoxClass1.Location = new Point(349, 82);
            comboBoxClass1.Name = "comboBoxClass1";
            comboBoxClass1.Size = new Size(270, 27);
            comboBoxClass1.TabIndex = 2;
            comboBoxClass1.SelectedIndexChanged += comboBoxClass1_SelectedIndexChanged;
            comboBoxClass1.Click += comboBoxClass1_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(28, 108);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Location = new Point(237, 83);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 22);
            panel10.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Location = new Point(297, 83);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 22);
            panel11.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Location = new Point(19, 82);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 23);
            panel12.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Location = new Point(28, 104);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 10);
            panel13.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.Location = new Point(647, 57);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 0;
            label7.Text = "Reg No:";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Transparent;
            panel14.Location = new Point(28, 73);
            panel14.Name = "panel14";
            panel14.Size = new Size(270, 10);
            panel14.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(349, 57);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 0;
            label4.Text = "Class:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(31, 57);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 0;
            label5.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(52, 178, 151);
            label6.Location = new Point(17, 15);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 12;
            label6.Text = "Student Report";
            // 
            // dateTimePickerDate1
            // 
            dateTimePickerDate1.CustomFormat = "yyyy/MM";
            dateTimePickerDate1.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate1.Location = new Point(28, 82);
            dateTimePickerDate1.Name = "dateTimePickerDate1";
            dateTimePickerDate1.Size = new Size(270, 24);
            dateTimePickerDate1.TabIndex = 13;
            dateTimePickerDate1.ValueChanged += dateTimePickerDate1_ValueChanged;
            // 
            // UserControlReport
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlReport);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlReport";
            Size = new Size(942, 501);
            tabControlReport.ResumeLayout(false);
            tabPageClassReport.ResumeLayout(false);
            tabPageClassReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClassReport).EndInit();
            tabPageStudentReport.ResumeLayout(false);
            tabPageStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudentReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReport;
        private TabPage tabPageClassReport;
        private DataGridView dataGridViewClassReport;
        private Panel panel7;
        private ComboBox comboBoxClass;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TabPage tabPageStudentReport;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel panel8;
        private ComboBox comboBoxClass1;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePickerDate1;
        private Panel panel15;
        private ComboBox comboBoxRegNo;
        private Label label7;
        private PictureBox pictureBoxPrint1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewStudentReport;
    }
}
