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

namespace Student_Managemant.PLA.Froms
{
    public partial class FormForgetPassword : Form
    {
        public FormForgetPassword()
        {
            InitializeComponent();
        }
        private bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "johndoe@gamil.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
            if (!isValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "johndoe@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty)
            {
                textBoxEmail.Text = "johndoe@gmail.com";
                textBoxEmail.ForeColor = Color.Gray;
            }
            if (!isValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "johonedoe@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "Invalid Email");
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();

            // XAMPP Connection String (Database නම: attendens_managment_system)
            string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. SQL Query: ඊමේල් ලිපිනයට අදාළ Username සහ Password යන දෙකම තෝරා ගැනීම
            string query = "SELECT User_name, user_Pass FROM User_Table WHERE user_email = @email";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        // 2. දත්ත කියවනය (DataReader) භාවිතයෙන් ප්‍රතිඵල ලබා ගැනීම
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 3. Username සහ Password කියවීම
                                string username = reader["User_name"].ToString();
                                string password = reader["user_Pass"].ToString(); // ⚠️ ආරක්ෂක අවදානම!

                                // 4. Message Box එකක් හරහා දත්ත පෙන්වීම
                                MessageBox.Show(
                                    $"Verification Successful!\n\nYour Username is: {username}\nYour Password is: {password}",
                                    "Information Retrieved",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                // මෙහිදී Forget Password Form එක වසා දැමිය හැක.
                                this.Close();
                            }
                            else
                            {
                                // 5. සත්‍යාපනය අසාර්ථකයි
                                MessageBox.Show("Email address not found in the system.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormForgetPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
    }
}
