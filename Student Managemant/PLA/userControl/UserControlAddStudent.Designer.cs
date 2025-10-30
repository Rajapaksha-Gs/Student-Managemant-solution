namespace Student_Managemant.PLA.Froms
{
    partial class UserControlAddStudent
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
            tabControlAddStudent = new TabControl();
            tabPageAddStudent = new TabPage();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            comboBoxClass = new ComboBox();
            buttonAdd = new Button();
            textBoxRegNo = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            textBoxName = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchStudent = new TabPage();
            comboBoxSearchBy = new ComboBox();
            panel10 = new Panel();
            label13 = new Label();
            labelCountStudent = new Label();
            label15 = new Label();
            dataGridViewStudent = new DataGridView();
            pictureBoxSerach = new PictureBox();
            panel5 = new Panel();
            labelCountClass = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBoxSearch = new TextBox();
            tabPageUPStudent = new TabPage();
            radioButtonFemale1 = new RadioButton();
            radioButtonMale1 = new RadioButton();
            comboBoxClass1 = new ComboBox();
            textBoxRegNo1 = new TextBox();
            panel4 = new Panel();
            label9 = new Label();
            textBoxName1 = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label14 = new Label();
            toolTip = new ToolTip(components);
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tabControlAddStudent.SuspendLayout();
            tabPageAddStudent.SuspendLayout();
            tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSerach).BeginInit();
            tabPageUPStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Controls.Add(tabPageAddStudent);
            tabControlAddStudent.Controls.Add(tabPageSearchStudent);
            tabControlAddStudent.Controls.Add(tabPageUPStudent);
            tabControlAddStudent.Dock = DockStyle.Fill;
            tabControlAddStudent.Location = new Point(0, 0);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(942, 501);
            tabControlAddStudent.TabIndex = 0;
            // 
            // tabPageAddStudent
            // 
            tabPageAddStudent.BackColor = Color.Transparent;
            tabPageAddStudent.Controls.Add(radioButtonFemale);
            tabPageAddStudent.Controls.Add(radioButtonMale);
            tabPageAddStudent.Controls.Add(comboBoxClass);
            tabPageAddStudent.Controls.Add(buttonAdd);
            tabPageAddStudent.Controls.Add(textBoxRegNo);
            tabPageAddStudent.Controls.Add(panel1);
            tabPageAddStudent.Controls.Add(label3);
            tabPageAddStudent.Controls.Add(textBoxName);
            tabPageAddStudent.Controls.Add(panel3);
            tabPageAddStudent.Controls.Add(panel2);
            tabPageAddStudent.Controls.Add(label5);
            tabPageAddStudent.Controls.Add(label4);
            tabPageAddStudent.Controls.Add(label2);
            tabPageAddStudent.Controls.Add(label1);
            tabPageAddStudent.Font = new Font("Century Gothic", 9.75F);
            tabPageAddStudent.ForeColor = SystemColors.WindowText;
            tabPageAddStudent.Location = new Point(4, 4);
            tabPageAddStudent.Name = "tabPageAddStudent";
            tabPageAddStudent.Padding = new Padding(3);
            tabPageAddStudent.Size = new Size(934, 471);
            tabPageAddStudent.TabIndex = 0;
            tabPageAddStudent.Text = "Add Student";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonFemale.Location = new Point(656, 267);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 23);
            radioButtonFemale.TabIndex = 0;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonMale.Location = new Point(656, 229);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(62, 23);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(123, 242);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(267, 25);
            comboBoxClass.TabIndex = 0;
            comboBoxClass.Click += comboBoxClass_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(52, 178, 151);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(123, 314);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(114, 37);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxRegNo
            // 
            textBoxRegNo.BorderStyle = BorderStyle.None;
            textBoxRegNo.Location = new Point(561, 182);
            textBoxRegNo.Name = "textBoxRegNo";
            textBoxRegNo.Size = new Size(267, 16);
            textBoxRegNo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(561, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(564, 148);
            label3.Name = "label3";
            label3.Size = new Size(58, 16);
            label3.TabIndex = 0;
            label3.Text = "Reg No:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(120, 182);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(267, 16);
            textBoxName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(120, 266);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(120, 204);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(564, 252);
            label5.Name = "label5";
            label5.Size = new Size(56, 16);
            label5.TabIndex = 0;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(123, 216);
            label4.Name = "label4";
            label4.Size = new Size(46, 16);
            label4.TabIndex = 0;
            label4.Text = "Class:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(123, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 178, 151);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            // 
            // tabPageSearchStudent
            // 
            tabPageSearchStudent.Controls.Add(comboBoxSearchBy);
            tabPageSearchStudent.Controls.Add(panel10);
            tabPageSearchStudent.Controls.Add(label13);
            tabPageSearchStudent.Controls.Add(labelCountStudent);
            tabPageSearchStudent.Controls.Add(label15);
            tabPageSearchStudent.Controls.Add(dataGridViewStudent);
            tabPageSearchStudent.Controls.Add(pictureBoxSerach);
            tabPageSearchStudent.Controls.Add(panel5);
            tabPageSearchStudent.Controls.Add(labelCountClass);
            tabPageSearchStudent.Controls.Add(label8);
            tabPageSearchStudent.Controls.Add(label7);
            tabPageSearchStudent.Controls.Add(label6);
            tabPageSearchStudent.Controls.Add(textBoxSearch);
            tabPageSearchStudent.Location = new Point(4, 4);
            tabPageSearchStudent.Name = "tabPageSearchStudent";
            tabPageSearchStudent.Padding = new Padding(3);
            tabPageSearchStudent.Size = new Size(934, 471);
            tabPageSearchStudent.TabIndex = 1;
            tabPageSearchStudent.Text = "Search Student";
            tabPageSearchStudent.UseVisualStyleBackColor = true;
            tabPageSearchStudent.Click += tabPageSearchStudent_Click;
            tabPageSearchStudent.Enter += tabPageSearchStudent_Enter;
            tabPageSearchStudent.Leave += tabPageSearchStudent_Leave;
            tabPageSearchStudent.MouseMove += tabPageSearchStudent_MouseMove;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Name", "Reg No", "Class" });
            comboBoxSearchBy.Location = new Point(506, 79);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(186, 25);
            comboBoxSearchBy.TabIndex = 11;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Location = new Point(506, 108);
            panel10.Name = "panel10";
            panel10.Size = new Size(183, 3);
            panel10.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label13.Location = new Point(506, 53);
            label13.Name = "label13";
            label13.Size = new Size(76, 16);
            label13.TabIndex = 10;
            label13.Text = "Serach By:";
            // 
            // labelCountStudent
            // 
            labelCountStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCountStudent.AutoSize = true;
            labelCountStudent.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountStudent.Location = new Point(786, 448);
            labelCountStudent.Name = "labelCountStudent";
            labelCountStudent.Size = new Size(26, 19);
            labelCountStudent.TabIndex = 7;
            labelCountStudent.Text = "{?}";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label15.Location = new Point(684, 449);
            label15.Name = "label15";
            label15.Size = new Size(98, 16);
            label15.TabIndex = 8;
            label15.Text = "Total Student: ";
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AllowUserToResizeColumns = false;
            dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.BorderStyle = BorderStyle.None;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewStudent.Location = new Point(22, 128);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(906, 318);
            dataGridViewStudent.TabIndex = 0;
            dataGridViewStudent.CellClick += dataGridViewStudent_CellClick;
            // 
            // pictureBoxSerach
            // 
            pictureBoxSerach.Cursor = Cursors.Hand;
            pictureBoxSerach.Image = Properties.Resources.xmag_search_find_export_locate_5984;
            pictureBoxSerach.Location = new Point(405, 74);
            pictureBoxSerach.Name = "pictureBoxSerach";
            pictureBoxSerach.Size = new Size(19, 26);
            pictureBoxSerach.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSerach.TabIndex = 6;
            pictureBoxSerach.TabStop = false;
            pictureBoxSerach.MouseHover += pictureBoxSerach_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(154, 98);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 0;
            // 
            // labelCountClass
            // 
            labelCountClass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelCountClass.AutoSize = true;
            labelCountClass.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountClass.Location = new Point(1570, 454);
            labelCountClass.Name = "labelCountClass";
            labelCountClass.Size = new Size(0, 19);
            labelCountClass.TabIndex = 0;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label8.Location = new Point(1468, 455);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.Location = new Point(154, 53);
            label7.Name = "label7";
            label7.Size = new Size(56, 16);
            label7.TabIndex = 0;
            label7.Text = "Serach:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(52, 178, 151);
            label6.Location = new Point(9, 6);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
            label6.TabIndex = 0;
            label6.Text = "Serach Student";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Location = new Point(154, 79);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(270, 15);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // tabPageUPStudent
            // 
            tabPageUPStudent.Controls.Add(radioButtonFemale1);
            tabPageUPStudent.Controls.Add(radioButtonMale1);
            tabPageUPStudent.Controls.Add(comboBoxClass1);
            tabPageUPStudent.Controls.Add(textBoxRegNo1);
            tabPageUPStudent.Controls.Add(panel4);
            tabPageUPStudent.Controls.Add(label9);
            tabPageUPStudent.Controls.Add(textBoxName1);
            tabPageUPStudent.Controls.Add(panel6);
            tabPageUPStudent.Controls.Add(panel7);
            tabPageUPStudent.Controls.Add(label10);
            tabPageUPStudent.Controls.Add(label11);
            tabPageUPStudent.Controls.Add(label12);
            tabPageUPStudent.Controls.Add(buttonDelete);
            tabPageUPStudent.Controls.Add(buttonUpdate);
            tabPageUPStudent.Controls.Add(label14);
            tabPageUPStudent.Location = new Point(4, 4);
            tabPageUPStudent.Name = "tabPageUPStudent";
            tabPageUPStudent.Padding = new Padding(3);
            tabPageUPStudent.Size = new Size(934, 471);
            tabPageUPStudent.TabIndex = 2;
            tabPageUPStudent.Text = "Update and Delete Class";
            tabPageUPStudent.UseVisualStyleBackColor = true;
            tabPageUPStudent.Leave += tabPageUPStudent_Leave;
            // 
            // radioButtonFemale1
            // 
            radioButtonFemale1.AutoSize = true;
            radioButtonFemale1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonFemale1.Location = new Point(642, 246);
            radioButtonFemale1.Name = "radioButtonFemale1";
            radioButtonFemale1.Size = new Size(78, 23);
            radioButtonFemale1.TabIndex = 5;
            radioButtonFemale1.TabStop = true;
            radioButtonFemale1.Text = "Female";
            radioButtonFemale1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale1
            // 
            radioButtonMale1.AutoSize = true;
            radioButtonMale1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonMale1.Location = new Point(642, 208);
            radioButtonMale1.Name = "radioButtonMale1";
            radioButtonMale1.Size = new Size(62, 23);
            radioButtonMale1.TabIndex = 4;
            radioButtonMale1.TabStop = true;
            radioButtonMale1.Text = "Male";
            radioButtonMale1.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass1
            // 
            comboBoxClass1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass1.FlatStyle = FlatStyle.Flat;
            comboBoxClass1.FormattingEnabled = true;
            comboBoxClass1.Location = new Point(109, 221);
            comboBoxClass1.Name = "comboBoxClass1";
            comboBoxClass1.Size = new Size(267, 25);
            comboBoxClass1.TabIndex = 3;
            comboBoxClass1.Click += comboBoxClass1_Click;
            // 
            // textBoxRegNo1
            // 
            textBoxRegNo1.BorderStyle = BorderStyle.None;
            textBoxRegNo1.Location = new Point(547, 161);
            textBoxRegNo1.Name = "textBoxRegNo1";
            textBoxRegNo1.Size = new Size(267, 15);
            textBoxRegNo1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(547, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(550, 127);
            label9.Name = "label9";
            label9.Size = new Size(58, 16);
            label9.TabIndex = 0;
            label9.Text = "Reg No:";
            // 
            // textBoxName1
            // 
            textBoxName1.BorderStyle = BorderStyle.None;
            textBoxName1.Location = new Point(106, 161);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(267, 15);
            textBoxName1.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(106, 245);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(106, 183);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.Location = new Point(550, 231);
            label10.Name = "label10";
            label10.Size = new Size(56, 16);
            label10.TabIndex = 0;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label11.Location = new Point(109, 195);
            label11.Name = "label11";
            label11.Size = new Size(46, 16);
            label11.TabIndex = 0;
            label11.Text = "Class:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.Location = new Point(109, 127);
            label12.Name = "label12";
            label12.Size = new Size(50, 16);
            label12.TabIndex = 0;
            label12.Text = "Name:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(277, 290);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 49);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(52, 178, 151);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(109, 290);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(114, 49);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(52, 178, 151);
            label14.Location = new Point(6, 6);
            label14.Name = "label14";
            label14.Size = new Size(217, 19);
            label14.TabIndex = 0;
            label14.Text = "Update And Delete Student";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Student_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Student_Name";
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Student_Total";
            Column3.HeaderText = "Reg No.";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Student_Male";
            Column4.HeaderText = "Class";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Student_Gender";
            Column5.HeaderText = "Gender";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // UserControlAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlAddStudent";
            Size = new Size(942, 501);
            tabControlAddStudent.ResumeLayout(false);
            tabPageAddStudent.ResumeLayout(false);
            tabPageAddStudent.PerformLayout();
            tabPageSearchStudent.ResumeLayout(false);
            tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSerach).EndInit();
            tabPageUPStudent.ResumeLayout(false);
            tabPageUPStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddStudent;
        private TabPage tabPageAddStudent;
        private Button buttonAdd;
        private TextBox textBoxRegNo;
        private Panel panel1;
        private Label label3;
        private TextBox textBoxName;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TabPage tabPageSearchStudent;
        private DataGridView dataGridViewStudent;
        private PictureBox pictureBoxSerach;
        private Panel panel5;
        private Label labelCountClass;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxSearch;
        private TabPage tabPageUPStudent;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label14;
        private ComboBox comboBoxClass;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Label labelCountStudent;
        private Label label15;
        private RadioButton radioButtonFemale1;
        private RadioButton radioButtonMale1;
        private ComboBox comboBoxClass1;
        private TextBox textBoxRegNo1;
        private Panel panel4;
        private Label label9;
        private TextBox textBoxName1;
        private Panel panel6;
        private Panel panel7;
        private Label label10;
        private Label label11;
        private Label label12;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBoxSearchBy;
        private Panel panel10;
        private Label label13;
    }
}
