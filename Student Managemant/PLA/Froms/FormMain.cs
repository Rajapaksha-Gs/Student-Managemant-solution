using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managemant.PLA.Froms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if (Role == "Student" || Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                userControlDashbord1.Visible = false;
                buttonRegister.Hide();
            }

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            panelExpand.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("hh:mm:ss tt");
        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {

            MoveSidePanel(buttonDashboard);
            userControlReport1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlDashbord1.Count();
            userControlDashbord1.Visible = true;
            userControlAddStudent1.Visible = false;
            userControl1Register1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlReport1.Visible = false;
            userControlAttendance1.Visible = true;
            userControlAddClass1.ClearTxtBox();
            userControlAddClass1.Visible = false;
            userControlDashbord1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControl1Register1.Visible = false;

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlReport1.Visible = false;
            userControlAddClass1.Visible = true;
            userControlDashbord1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControl1Register1.Visible = false;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlReport1.Visible = false;
            userControlAddClass1.Visible = false;
            userControlDashbord1.Visible = false;
            userControl1Register1.Visible = false;
            userControlAddStudent1.Visible = true;
            userControlAddStudent1.ClearTxtBox();
            userControlAttendance1.Visible = false;
        }
        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            
            userControlAddClass1.Visible = false;
            userControlDashbord1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControl1Register1.Visible = false;
            userControlAttendance1.Visible = false;
            userControlReport1.FirstTab();
            userControlReport1.Visible = true;
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlReport1.Visible = false;
           
            userControlAddClass1.Visible = false;
            userControlDashbord1.Visible = false;
            userControlAddStudent1.Visible = false;
            userControlAttendance1.Visible = false;
            userControl1Register1.Visible = true;
            userControlAddStudent1.ClearTxtBox();
        }
        // Fixes CS0501, CS1002, and SPELL: Rename to MoveSidePanel and provide a method body
        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 255);
        }

        private void pictureBoxExpand_Click(object sender, EventArgs e)
        {
            if (panelExpand.Visible)
                panelExpand.Visible = false;
            else
                panelExpand.Visible = true;
        }

        private void userControlAddClass1_Load(object sender, EventArgs e)
        {

        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void userControl1Register1_Load(object sender, EventArgs e)
        {

        }

        private void userControlDashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

