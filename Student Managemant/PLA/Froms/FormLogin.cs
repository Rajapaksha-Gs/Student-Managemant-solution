using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Managemant.PLA.Froms
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text.Trim();
            string password = textBoxPassword.Text.Trim();
string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";
            


            if (username != String.Empty && password != String.Empty)
            {

                string query = "SELECT User_Role FROM User_Table WHERE User_name = @user AND user_Pass = @pass";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@user", username);
                            cmd.Parameters.AddWithValue("@pass", password);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                string userRole = result.ToString();

                                textBoxName.Clear();
                                textBoxPassword.Clear();
                                textBoxName.Focus();
                                pictureBoxError.Hide();
                                labelError.Hide();
                                this.Hide();


                                if (userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {

                                    FormMain formMain = new FormMain();
                                    formMain.Username = username;
                                    formMain.Role = userRole;
                                    formMain.ShowDialog();
                                    this.Close();
                                }
                                else if (userRole.Equals("Student", StringComparison.OrdinalIgnoreCase))
                                {
                                    FormMain formMain = new FormMain();
                                    formMain.Username = username;
                                    formMain.Role = userRole;
                                    formMain.ShowDialog();

                                    this.Close();
                                }
                            }
                            else
                            {

                                pictureBoxError.Show();

                                labelError.Show();
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Database Error: " + ex.Message);
                        labelError.Text = "Connection Failed. Check XAMPP.";
                        labelError.Show();
                    }
                }
            }
            else
            {
                pictureBoxError.Show();
                labelError.Text = "Please enter both Username and Password.";
                labelError.Show();
            }
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }



        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgetPassword forgetPasswordForm = new FormForgetPassword();
            forgetPasswordForm.ShowDialog();

        }
    }
}
