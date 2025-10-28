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
    public partial class UserControlDashbord : UserControl
    {
        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";
        public UserControlDashbord()
        {
            InitializeComponent();
        }

        public void Count()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashbord_Load(object sender, EventArgs e)
        {
            Count();    
        }
    }
}
