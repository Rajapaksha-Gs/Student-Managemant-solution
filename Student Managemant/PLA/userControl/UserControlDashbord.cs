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

            try
            {
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
                }
            }
            catch (Exception ex)
            {
                // In a dashboard, you usually fail silently or log the error, 
                // but we'll show a message for debugging.
                MessageBox.Show("Error counting classes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelTotalClasses.Text = "ERR";
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
