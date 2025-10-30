using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControl1Register : UserControl
    {
        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";
        public string UID = "";
        private string gender = "", Role, ID = "";
        public UserControl1Register()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageUPUser_Click(object sender, EventArgs e)
        {

        }
        private void HideEroorPic()
        {
            pictureBoxErrorCINC.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorCINC.Visible = false;
            pictureBoxErrorDOB.Visible = false;

        }
        private void HideEroorPic1()
        {
            pictureBoxErrorPho1.Visible = false;
            pictureBoxErrorEmail1.Visible = false;
            pictureBoxErrorCNIC1.Visible = false;
            pictureBoxErrorDOB1.Visible = false;

        }

        public void ClearTextBox()
        {
            textBoxName.Clear();


            textBoxEmail.Clear();
            maskedTextBoxPho.Text = "000 00 00 000";
            maskedTextBoxPho.ForeColor = Color.DarkGray;
            maskedTextBoxCNIC.Text = "0000-0000-0000";
            maskedTextBoxDOB.ForeColor = Color.DarkGray;
            maskedTextBoxDOB.Text = "00/00/0000";
            maskedTextBoxDOB.ForeColor = Color.DarkGray;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "Gayan@gmail.com";
            textBoxEmail.ForeColor = Color.DarkGray;
            checkBoxRole.Checked = false;
            textBoxAdd.Clear();
            tabControlRegister.SelectedTab = tabPageAddUser;


        }
        public void ClearTextBox1()
        {
            textBoxName.Clear();


            textBoxEmail1.Clear();
            maskedTextBoxPho1.Text = "000 00 00 000";
            maskedTextBoxPho1.ForeColor = Color.DarkGray;
            maskedTextBoxCNIC1.Text = "0000-0000-0000";
            maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            maskedTextBoxDOB1.Text = "00/00/0000";
            maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            textBoxEmail1.Text = "Gayan@gmail.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
            checkBoxRole1.Checked = false;
            textBoxAdd1.Clear();
            ID = "";


        }
        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox.Select(0, 0);

            });

        }
        private bool IsValidEmail(string email)
        {
            // NOTE: This implementation has errors (e.g., using undeclared 'textBox' and 'pictureBox').
            // I'm providing a corrected, standard implementation for reference.
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email; // Returns true if the address parsing succeeded
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidCNIC(string cnic)
        {
            // CNIC format: 0000-0000-0000 (13 digits with dashes)
            if (cnic.Length != 15) return false;
            for (int i = 0; i < cnic.Length; i++)
            {
                if (i == 4 || i == 9)
                {
                    if (cnic[i] != '-') return false;
                }
                else
                {
                    if (!char.IsDigit(cnic[i])) return false;
                }
            }
            return true;
        }
        private bool IsValidaDate(string date)
        {
            DateTime d;
            bool ChValidity;
            try
            {
                ChValidity = DateTime.TryParse(date, out d);
                return ChValidity;
            }
            catch
            {
                return false;
            }
        }

        private void pictureBoxSUser_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxUser, "Serach");

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Gayan@gmail.com")
            {
                if (textBoxEmail.Text == "")
                {

                    textBoxEmail.Text = "";
                    textBoxEmail.ForeColor = Color.Black;
                }
            }
            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "Gayan@gmail.com")
                pictureBoxErrorEmail.Visible = true;
            else
                pictureBoxErrorEmail.Visible = false;
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            textBoxEmail1.Text = "Gayan@gmail.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
        }

        private void maskedTextBoxPho_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "000 00 00 000")
            {
                maskedTextBoxPho.Text = "";
                maskedTextBoxPho.ForeColor = Color.Black;
            }
            if (!maskedTextBoxPho.MaskCompleted)
            {
                pictureBoxErrorPho.ForeColor = Color.Black;
                Mask(maskedTextBoxPho);
            }


            else
                pictureBoxErrorPho1.Visible = false;
        }

        private void maskedTextBoxPho_Leave(object sender, EventArgs e)
        {



            maskedTextBoxPho.Text = "000 00 00 000";
            maskedTextBoxPho.ForeColor = Color.DarkGray;
            if (!maskedTextBoxPho.MaskCompleted)
                maskedTextBoxPho.ForeColor = Color.DarkGray;

            if (!maskedTextBoxPho.MaskCompleted || maskedTextBoxPho.Text == "+000 00 00 000")
                pictureBoxErrorPho.Visible = true;
            else
                pictureBoxErrorPho.Visible = false;
        }

        private void maskedTextBoxCNIC_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC.Text == "0000-0000-0000")
                maskedTextBoxCNIC.Text = "";

            if (!maskedTextBoxCNIC.MaskCompleted)
            {
                maskedTextBoxCNIC.ForeColor = Color.Black;
                Mask(maskedTextBoxCNIC);
            }
        }

        private void maskedTextBoxCNIC_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBoxCNIC.MaskCompleted)
            {

                maskedTextBoxCNIC.Text = "0000-0000-0000";
                maskedTextBoxCNIC.ForeColor = Color.DarkGray;
                pictureBoxErrorCINC.Visible = true;
                return; // Exit the method early
            }


            if (maskedTextBoxCNIC.Text == "0000-0000-0000")
            {

                maskedTextBoxCNIC.ForeColor = Color.DarkGray;
                pictureBoxErrorCINC.Visible = true;
            }
            else
            {

                maskedTextBoxCNIC.ForeColor = Color.Black;
                pictureBoxErrorCINC.Visible = false;
            }

        }

        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "00/00/0000")
                maskedTextBoxDOB.Text = "";
            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB);
            }

        }

        private void maskedTextBoxDOB_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text.Trim() == "/   /")
            {
                maskedTextBoxDOB.Text = "00/00/0000";
                maskedTextBoxDOB.ForeColor = Color.DarkGray;

            }
            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.DarkGray;

            }
            if (!IsValidaDate(maskedTextBoxDOB.Text) || maskedTextBoxDOB.Text == "00/00/000" || DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now)
                pictureBoxErrorDOB.Visible = true;
            else
                pictureBoxErrorDOB.Visible = false;
        }

        private void maskedTextBoxDOB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBoxDOB, "DD/MM/YYYY");
        }

        private void pictureBoxErrorEmail_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail, "Invalid Email Format");
        }

        private void pictureBoxErrorDOB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorDOB, "Invalid Date Format");
        }

        private void pictureBoxErrorPho_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho, "Invalid Phone Number");
        }

        private void pictureBoxErrorCINC_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorCINC, "Invalid CNIC Format");
        }

        private void maskedTextBoxPho1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho1.Text == "000 00 00 000")
            {
                maskedTextBoxPho1.Text = "";
                maskedTextBoxPho1.ForeColor = Color.Black;
            }
            if (!maskedTextBoxPho1.MaskCompleted)
            {
                pictureBoxErrorPho1.ForeColor = Color.Black;
                Mask(maskedTextBoxPho);
            }


            else
                pictureBoxErrorPho.Visible = false;
        }

        private void maskedTextBoxPho1_Leave(object sender, EventArgs e)
        {



            maskedTextBoxPho1.Text = "000 00 00 000";
            maskedTextBoxPho1.ForeColor = Color.DarkGray;
            if (!maskedTextBoxPho1.MaskCompleted)
                maskedTextBoxPho1.ForeColor = Color.DarkGray;

            if (!maskedTextBoxPho1.MaskCompleted || maskedTextBoxPho1.Text == "+000 00 00 000")
                pictureBoxErrorPho1.Visible = true;
            else
                pictureBoxErrorPho1.Visible = false;
        }

        private void pictureBoxErrorPho1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho1, "Invalid Phone Number");
        }

        private void maskedTextBoxCNIC1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC1.Text == "0000-0000-0000")
                maskedTextBoxCNIC1.Text = "";

            if (!maskedTextBoxCNIC1.MaskCompleted)
            {
                maskedTextBoxCNIC1.ForeColor = Color.Black;
                Mask(maskedTextBoxCNIC1);
            }
        }

        private void maskedTextBoxCNIC1_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBoxCNIC1.MaskCompleted)
            {

                maskedTextBoxCNIC1.Text = "0000-0000-0000";
                maskedTextBoxCNIC1.ForeColor = Color.DarkGray;


            }


            if (maskedTextBoxCNIC1.Text == "0000-0000-0000")
            {

                maskedTextBoxCNIC1.ForeColor = Color.DarkGray;
                pictureBoxErrorCNIC1.Visible = true;
            }
            else
            {
                pictureBoxErrorCNIC1.ForeColor = Color.Black;
                pictureBoxErrorCNIC1.Visible = false;
            }
        }

        private void pictureBoxErrorCNIC1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorCNIC1, "Invalid CNIC Format");
        }

        private void maskedTextBoxDOB1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text == "00/00/0000")
                maskedTextBoxDOB1.Text = "";
            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB1);
            }

        }

        private void maskedTextBoxDOB1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text.Trim() == "/   /")
            {
                maskedTextBoxDOB1.Text = "00/00/0000";
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;

            }
            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;

            }
            if (!IsValidaDate(maskedTextBoxDOB1.Text) || maskedTextBoxDOB1.Text == "00/00/000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now)
                pictureBoxErrorDOB1.Visible = true;
            else
                pictureBoxErrorDOB1.Visible = false;
        }

        private void pictureBoxErrorDOB1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorDOB1, "Invalid Date Format");
        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "Gayan@gmail.com")
            {
                if (textBoxEmail1.Text == "")
                {

                    textBoxEmail1.Text = "";
                    textBoxEmail1.ForeColor = Color.Black;
                }
            }
            if (!IsValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "Gayan@gmail.com")
                pictureBoxErrorEmail1.Visible = true;
            else
                pictureBoxErrorEmail1.Visible = false;
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {

            textBoxEmail1.Text = "Gayan@gmail.com";
            textBoxEmail1.ForeColor = Color.DarkGray;
        }

        private void pictureBoxErrorEmail1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail1, "Invalid Email Format");
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            // Get the search term and ensure it's not empty
            string searchTerm = textBoxUser.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                // Optionally clear the grid if the search box is empty
                // dataGridViewUser.DataSource = null;
                // Or re-load all data if needed, but for now, we just stop.
                return;
            }

            // Determine the search column based on the ComboBox selection
            string searchColumn = "";
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                searchColumn = "User_Name";
            }
            else if (comboBoxSearchBy.SelectedIndex == 1)
            {
                searchColumn = "User_Pho"; // Assuming 'User_Pho' for Phone
            }
            else if (comboBoxSearchBy.SelectedIndex == 2)
            {
                searchColumn = "User_CNIC"; // Assuming 'User_CNIC' for CNIC
            }
            else
            {
                // Handle case where no selection is made (optional)
                MessageBox.Show("Please select a search category first.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // The SQL query using the dynamic column and LIKE operator
            string query = $"SELECT * FROM User_Table WHERE {searchColumn} LIKE @SearchTerm";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add the parameter for the search term. 
                        // Using '%' wildcards allows searching for partial matches.
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the result to the DataGridView
                        dataGridViewStudent.DataSource = dataTable;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            // 1. Clear previous search state
            textBoxUser.Clear(); // Clear the search box
            comboBoxSearchBy.SelectedIndex = -1; // Deselect any previous search category

            // 2. Define the Query to fetch ALL users
            // NOTE: If you only want to display certain columns, list them instead of using *.
            string query = "SELECT * FROM User_Table";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // 3. Bind the data to the DataGridView
                        dataGridViewStudent.DataSource = dataTable;
                    }
                }

                // 4. (Optional) Hide the first column (assuming it's an internal ID column)
                // Check if the DataGridView has any columns before trying to hide one.
                if (dataGridViewStudent.Columns.Count > 0)
                {
                    dataGridViewStudent.Columns[0].Visible = false;
                }

                // 5. Update the user count label
                // Using Rows.Count from the DataGridView is slightly less accurate than the DataTable count
                // but it reflects what is displayed.
                dataGridViewStudent.Text = dataGridViewStudent.Rows.Count.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: Failed to load user list. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            HideEroorPic();
            HideEroorPic1();
            ClearTextBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // --- 1. Reset Error Icons and Initialize Variables ---
            HideEroorPic(); // Assuming this hides all error picture boxes for the 'Add User' tab
            bool validationPassed = true;

            // Get input values (assuming Password is named textBoxPassword)
            string name = textBoxName.Text.Trim();
            string password = textBoxPassword.Text;
            string address = textBoxAdd.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = maskedTextBoxPho.Text.Replace(" ", "").Trim(); // Remove spaces from phone
            string cnic = maskedTextBoxCNIC.Text.Trim();
            string dobText = maskedTextBoxDOB.Text.Trim();

            // Determine Role
            string role = checkBoxRole.Checked ? "Admin" : "User";

            // Determine Gender (from radio buttons)
            string gender = "";
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            // --- 2. Validation Checks ---

            // A. Check required fields
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                validationPassed = false;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Password is required and must be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                validationPassed = false;
            }
            else if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Gender selection is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validationPassed = false;
            }

            // B. Check Email
            if (validationPassed && (!IsValidEmail(email) || email == "Gayan@gmail.com"))
            {
                pictureBoxErrorEmail.Visible = true;
                MessageBox.Show("Invalid Email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                validationPassed = false;
            }

            // C. Check CNIC completion
            if (validationPassed && !maskedTextBoxCNIC.MaskCompleted)
            {
                pictureBoxErrorCINC.Visible = true;
                MessageBox.Show("CNIC field is incomplete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxCNIC.Focus();
                validationPassed = false;
            }
            // D. Check Phone completion
            if (validationPassed && !maskedTextBoxPho.MaskCompleted)
            {
                pictureBoxErrorPho.Visible = true;
                MessageBox.Show("Phone field is incomplete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxPho.Focus();
                validationPassed = false;
            }

            // E. Check DOB validity and future date
            if (validationPassed)
            {
                DateTime dob;
                if (!IsValidaDate(dobText) || !DateTime.TryParse(dobText, out dob) || dob > DateTime.Now)
                {
                    pictureBoxErrorDOB.Visible = true;
                    MessageBox.Show("Invalid Date of Birth format or date is in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBoxDOB.Focus();
                    validationPassed = false;
                }
            }


            // --- 3. Database Insertion ---

            if (validationPassed)
            {
                // SQL Injection is prevented by using parameterized queries!
                string query = "INSERT INTO User_Table (User_Name, User_Pass, User_Email, User_Pho, User_CNIC, User_DOB, User_Gender, User_Role, User_Add) " +
                               "VALUES (@Name, @Password, @Email, @Phone, @CNIC, @DOB, @Gender, @Role, @Address)";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Password", password); // NOTE: In a real app, hash this password!
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@CNIC", cnic);
                            command.Parameters.AddWithValue("@DOB", dobText); // Assuming DB column accepts string/date format '00/00/0000'
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Role", role);
                            command.Parameters.AddWithValue("@Address", address);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBox(); // Clear the form after successful registration
                            }
                            else
                            {
                                MessageBox.Show("User registration failed. No rows were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle common errors like duplicate CNIC/Email if columns have UNIQUE constraints
                    if (ex.Number == 1062) // MySQL error code for Duplicate Entry
                    {
                        MessageBox.Show("Registration failed: CNIC or Email already exists.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPageAddUser_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageUPUser_Leave(object sender, EventArgs e)
        {
            HideEroorPic1();
            ClearTextBox1();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                ID = row.Cells["User_ID"].Value.ToString();
                textBox4.Text = row.Cells["User_Name"].Value.ToString();
                textBoxPass1.Text = row.Cells["User_Pass"].Value.ToString();
                textBoxEmail1.Text = row.Cells["User_Email"].Value.ToString();
                textBoxEmail1.ForeColor = Color.Black;
                maskedTextBoxPho1.Text = row.Cells["User_Pho"].Value.ToString();
                maskedTextBoxPho1.ForeColor = Color.Black;
                maskedTextBoxCNIC1.Text = row.Cells["User_CNIC"].Value.ToString();
                maskedTextBoxCNIC1.ForeColor = Color.Black;
                maskedTextBoxDOB1.Text = row.Cells["User_DOB"].Value.ToString();
                maskedTextBoxDOB1.ForeColor = Color.Black;
                gender = row.Cells["gender"].Value.ToString();
                if (gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;
                Role = row.Cells["User_Role"].Value.ToString();
                if (Role == "Admin")
                    checkBoxRole1.Checked = true;
                textBoxAdd1.Text = row.Cells["User_Add"].Value.ToString();

            }
        }
    }
}

