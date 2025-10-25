namespace Student_Managemant.PLA.Froms
{
    partial class FormForgetPassword
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonVerify = new Button();
            pictureBoxError = new PictureBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxClose = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(pictureBoxError);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 506);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(140, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 8;
            // 
            // buttonVerify
            // 
            buttonVerify.BackColor = Color.FromArgb(95, 207, 202);
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            buttonVerify.FlatStyle = FlatStyle.Flat;
            buttonVerify.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            buttonVerify.ForeColor = Color.Black;
            buttonVerify.Image = Properties.Resources.verify_icon_227246__1_;
            buttonVerify.ImageAlign = ContentAlignment.MiddleRight;
            buttonVerify.Location = new Point(140, 344);
            buttonVerify.Margin = new Padding(2);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(265, 38);
            buttonVerify.TabIndex = 2;
            buttonVerify.Text = "Verify";
            buttonVerify.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVerify.UseVisualStyleBackColor = false;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = Properties.Resources.emblemimportant_103451;
            pictureBoxError.Location = new Point(413, 267);
            pictureBoxError.Margin = new Padding(2);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(19, 17);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 4;
            pictureBoxError.TabStop = false;
            pictureBoxError.MouseHover += pictureBoxError_MouseHover;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(140, 267);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 24);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.Text = "jone@gmail.com";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label1.Location = new Point(137, 238);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 5;
            label1.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.iconfinder_lock_4341303_120563;
            pictureBox1.Location = new Point(213, 31);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.stop_close_off_14465;
            pictureBoxClose.Location = new Point(548, 12);
            pictureBoxClose.Margin = new Padding(2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // FormForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 515);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgetPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += FormForgetPassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBox1;
        private Button buttonVerify;
        private PictureBox pictureBoxError;
        private TextBox textBoxEmail;
        private Label label1;
        private Panel panel2;
        private ToolTip toolTip1;
    }
}