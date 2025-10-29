using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControlAddClass : UserControl
    {
        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";
        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSerach_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSerach, "Search Class");
        }
    }
}
