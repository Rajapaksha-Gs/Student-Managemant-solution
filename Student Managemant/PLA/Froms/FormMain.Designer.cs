namespace Student_Managemant.PLA.Froms
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonRegister = new Button();
            buttonReport = new Button();
            buttonAddStudent = new Button();
            buttonAddClass = new Button();
            buttonAttendance = new Button();
            buttonDashboard = new Button();
            panel4 = new Panel();
            panelSlide = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelBack = new Panel();
            panelExpand = new Panel();
            buttonLogOut = new Button();
            panel3 = new Panel();
            buttonMinimize = new Button();
            pictureBoxExpand = new PictureBox();
            pictureBox2 = new PictureBox();
            panelTop = new Panel();
            labelRole = new Label();
            labelUsername = new Label();
            label6 = new Label();
            label4 = new Label();
            labelTime = new Label();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            userControlDashbord1 = new Student_Managemant.PLA.userControl.UserControlDashbord();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 178, 151);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonAddStudent);
            panel1.Controls.Add(buttonAddClass);
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 681);
            panel1.TabIndex = 0;
            // 
            // buttonRegister
            // 
            buttonRegister.Dock = DockStyle.Top;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Image = Properties.Resources.icons8_settings_30;
            buttonRegister.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegister.Location = new Point(8, 510);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 60);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "       Register";
            buttonRegister.TextAlign = ContentAlignment.MiddleLeft;
            buttonRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRegister.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            buttonReport.Dock = DockStyle.Top;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = Properties.Resources.icons8_report_file_30;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(8, 450);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(250, 60);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "       Report";
            buttonReport.TextAlign = ContentAlignment.MiddleLeft;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = true;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Dock = DockStyle.Top;
            buttonAddStudent.FlatAppearance.BorderSize = 0;
            buttonAddStudent.FlatStyle = FlatStyle.Flat;
            buttonAddStudent.ForeColor = Color.White;
            buttonAddStudent.Image = Properties.Resources.icons8_add_users_301;
            buttonAddStudent.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddStudent.Location = new Point(8, 390);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(250, 60);
            buttonAddStudent.TabIndex = 0;
            buttonAddStudent.Text = "       Add Student";
            buttonAddStudent.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonAddClass
            // 
            buttonAddClass.Dock = DockStyle.Top;
            buttonAddClass.FlatAppearance.BorderSize = 0;
            buttonAddClass.FlatStyle = FlatStyle.Flat;
            buttonAddClass.ForeColor = Color.White;
            buttonAddClass.Image = Properties.Resources.icons8_class_30;
            buttonAddClass.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddClass.Location = new Point(8, 330);
            buttonAddClass.Name = "buttonAddClass";
            buttonAddClass.Size = new Size(250, 60);
            buttonAddClass.TabIndex = 0;
            buttonAddClass.Text = "       Add Class";
            buttonAddClass.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddClass.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddClass.UseVisualStyleBackColor = true;
            buttonAddClass.Click += buttonAddClass_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = Properties.Resources.icons8_attendance_301;
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(8, 270);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(250, 60);
            buttonAttendance.TabIndex = 0;
            buttonAttendance.Text = "       Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = Properties.Resources.icons8_billboard_241;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(8, 210);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(250, 60);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "       Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelSlide);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(8, 471);
            panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(10, 60);
            panelSlide.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 210);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 156);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 0;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 127);
            label1.Name = "label1";
            label1.Size = new Size(217, 19);
            label1.TabIndex = 0;
            label1.Text = "Attendance Managemant ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fashion_school_cap_graduation_university_education_icon_2670731;
            pictureBox1.Location = new Point(69, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBoxExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(panelTop);
            panelBack.Controls.Add(labelTime);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(258, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(926, 184);
            panelBack.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(52, 178, 151);
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(buttonLogOut);
            panelExpand.Controls.Add(panel3);
            panelExpand.Location = new Point(702, 64);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(224, 120);
            panelExpand.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Cursor = Cursors.Hand;
            buttonLogOut.Dock = DockStyle.Top;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.ForeColor = Color.FromArgb(52, 178, 151);
            buttonLogOut.Image = Properties.Resources._4115235_exit_logout_sign_out_1140301;
            buttonLogOut.Location = new Point(0, 54);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(222, 73);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = " Log Out";
            buttonLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonMinimize);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 54);
            panel3.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMinimize.ForeColor = Color.FromArgb(52, 178, 151);
            buttonMinimize.Image = Properties.Resources.minimize_14775__1_;
            buttonMinimize.Location = new Point(0, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(222, 63);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = " Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.Cursor = Cursors.Hand;
            pictureBoxExpand.Image = Properties.Resources.angle_arrow_down_icon_icons_com_73683;
            pictureBoxExpand.Location = new Point(790, 34);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 31);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 2;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.graduation1;
            pictureBox2.Location = new Point(730, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(52, 178, 151);
            panelTop.Controls.Add(labelRole);
            panelTop.Controls.Add(labelUsername);
            panelTop.Controls.Add(label6);
            panelTop.Controls.Add(label4);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 64);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(926, 120);
            panelTop.TabIndex = 0;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.FromArgb(52, 178, 151);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(154, 63);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(28, 19);
            labelRole.TabIndex = 0;
            labelRole.Text = "{?}";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.FromArgb(52, 178, 151);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(154, 22);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(28, 19);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(52, 178, 151);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 63);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 0;
            label6.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(52, 178, 151);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 22);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 0;
            label4.Text = "Welcome:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.ForeColor = Color.FromArgb(52, 178, 151);
            labelTime.Location = new Point(24, 23);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(28, 19);
            labelTime.TabIndex = 0;
            labelTime.Text = "{?}";
            // 
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick;
            // 
            // userControlDashbord1
            // 
            userControlDashbord1.BackColor = Color.White;
            userControlDashbord1.Dock = DockStyle.Fill;
            userControlDashbord1.Font = new Font("Century Gothic", 9.75F);
            userControlDashbord1.Location = new Point(258, 184);
            userControlDashbord1.Margin = new Padding(4);
            userControlDashbord1.Name = "userControlDashbord1";
            userControlDashbord1.Size = new Size(926, 497);
            userControlDashbord1.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 681);
            Controls.Add(userControlDashbord1);
            Controls.Add(panelBack);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance Managemant System";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panelBack;
        private Panel panelTop;
        private Label labelTime;
        private Label label4;
        private Label labelUsername;
        private Label labelRole;
        private Label label6;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBox2;
        private Panel panelExpand;
        private Panel panel3;
        private Button buttonMinimize;
        private Button button;
        private Panel panel4;
        private Panel panelSlide;
        private Button buttonDashboard;
        private Button buttonAttendance;
        private Button buttonAddClass;
        private Button buttonAddStudent;
        private Button buttonRegister;
        private Button buttonReport;
        private Button buttonLogOut;
        private System.Windows.Forms.Timer timerDateAndTime;
        private userControl.UserControlDashbord userControlDashbord1;
    }
}