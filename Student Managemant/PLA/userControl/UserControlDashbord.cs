using MySql.Data.MySqlClient;
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
            string query = "SELECT COUNT(*) FROM Class_Table";
            string query1 = "SELECT COUNT(*) FROM Student_Table";
            string query3 = "SELECT COUNT(*) FROM User_Table";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // ExecuteScalar returns the value of the first column of the first row (the count)
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Convert the count to a string and assign it to the label
                        labelTotalClasses.Text = result.ToString();
                    }
                    else
                    {
                        labelTotalClasses.Text = "0";
                    }
                }
                using (MySqlCommand comandS = new MySqlCommand(query1, connection))
                {

                    object resultS = comandS.ExecuteScalar();
                    if (resultS != null)
                    {
                        label2.Text = resultS.ToString();
                    }
                    else
                    {
                        label2.Text = "0";
                    }
                }
                using(MySqlCommand comandU = new MySqlCommand(query3, connection))
                {
                    object resultU = comandU.ExecuteScalar();
                    if (resultU != null)
                    {
                        labelTotalRole.Text = resultU.ToString();
                    }
                    else
                    {
                        labelTotalRole.Text = "0";
                    }
                }


            }
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
