using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControl1Register : UserControl
    {
        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;Convert Zero Datetime=True;";
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
            pictureBoxErrorPho.Visible = false;
            pictureBoxErrorCINC.Visible = false;
            pictureBoxErrorEmail.Visible = false;
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
            textBoxPassword.Clear();
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
        private bool TryParseDate(string input, out DateTime value)
        {
            return DateTime.TryParseExact(
                input,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out value);
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
            {
                pictureBoxErrorPho.Visible = false;
            }
        }

        private void maskedTextBoxPho_Leave(object sender, EventArgs e)
        {
            // Only reset to default if mask is incomplete or it's the default value
            if (!maskedTextBoxPho.MaskCompleted || maskedTextBoxPho.Text == "+000 00 00 000")
            {
                maskedTextBoxPho.Text = "000 00 00 000";
                maskedTextBoxPho.ForeColor = Color.DarkGray;
                pictureBoxErrorPho.Visible = true;
            }
            else
            {
                // Keep the entered value if mask is complete
                maskedTextBoxPho.ForeColor = Color.Black;
                pictureBoxErrorPho.Visible = false;
            }
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
            if (!TryParseDate(maskedTextBoxDOB.Text, out DateTime dob) ||
                dob > DateTime.Now)
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
                Mask(maskedTextBoxPho1);
            }
            else
            {
                pictureBoxErrorPho1.Visible = false;
            }
        }

        private void maskedTextBoxPho1_Leave(object sender, EventArgs e)
        {
            // Only reset to default if mask is incomplete or it's the default value
            if (!maskedTextBoxPho1.MaskCompleted || maskedTextBoxPho1.Text == "+000 00 00 000")
            {
                maskedTextBoxPho1.Text = "000 00 00 000";
                maskedTextBoxPho1.ForeColor = Color.DarkGray;
                pictureBoxErrorPho1.Visible = true;
            }
            else
            {
                // Keep the entered value if mask is complete
                maskedTextBoxPho1.ForeColor = Color.Black;
                pictureBoxErrorPho1.Visible = false;
            }
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
            if (!TryParseDate(maskedTextBoxDOB1.Text, out DateTime dob1) ||
                dob1 > DateTime.Now)
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



        // This is the complete function for handling the user search logic.
        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxUser.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                // When search term is empty, reload all users/students (you should implement this)
                // For now, we just return.
                // DisplayAllUsers(); 
                return;
            }

            string searchColumn = "";
            string searchOperator = "LIKE"; // Default for text-based search (Name)
            bool useWildcards = true;       // Default for LIKE

            // Determine the search column based on the ComboBox selection
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                searchColumn = "user_name"; // Based on your DB image
            }
            else if (comboBoxSearchBy.SelectedIndex == 1)
            {
                searchColumn = "user_pho"; // Based on your DB image
            }
            else if (comboBoxSearchBy.SelectedIndex == 2)
            {
                // 🛑 FIX 1: Use the EXACT column name 'user_CNIC' (lowercase for MySQL compatibility)
                searchColumn = "user_CNIC";

                // 💡 FIX 2: Use '=' operator for exact CNIC matching
                searchOperator = "=";
                useWildcards = false;
            }
            else
            {
                MessageBox.Show("Please select a search category first.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // The SQL query using the dynamic column and operator
            string query = $"SELECT * FROM user_table WHERE {searchColumn} {searchOperator} @SearchTerm";

            try
            {
                // ... (connection string setup remains the same) ...
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add the parameter for the search term, adjusting for LIKE vs. '='
                        string finalSearchTerm = useWildcards ? $"%{searchTerm}%" : searchTerm;
                        command.Parameters.AddWithValue("@SearchTerm", finalSearchTerm);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the result to the DataGridView
                            dataGridViewStudent.DataSource = dataTable;
                        }
                    }
                }

                string query1 = "SELECT COUNT(*) FROM user_table";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query1, connection))
                        {
                            // ExecuteScalar is used to retrieve a single value (the count)
                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                // Convert the result (which is typically a long) to a string and assign it to the label.
                                labelTotalUser.Text = result.ToString();
                            }
                            else
                            {
                                // If result is null (shouldn't happen with COUNT(*)), set to 0.
                                labelTotalUser.Text = "0";
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle database errors
                    MessageBox.Show("Database Error while loading total users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelTotalUser.Text = "Error"; // Indicate error on the label
                }
                catch (Exception ex)
                {
                    // Handle unexpected errors
                    MessageBox.Show("An unexpected error occurred while loading total users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelTotalUser.Text = "Error";
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


        private void LoadTotalUsers()
        {
            // SQL query to count all rows in the user_table
            
        }





        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            // 1. Clear previous search state
            textBoxUser.Clear(); // Clear the search box
            comboBoxSearchBy.SelectedIndex = -1; // Deselect any previous search category

            // 2. Define the Query to fetch ALL users
            // NOTE: If you only want to display certain columns, list them instead of using *.
            string query = "SELECT user_ID, user_name, user_Pass, user_Email, user_Pho, user_CNIC, " +
                   "DATE_FORMAT(user_DOB, '%Y-%m-%d') AS user_DOB, " +
                   "user_Gender, user_Role, user_Add FROM User_Table"; 

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
                labelTotalUser.Text = dataGridViewStudent.Rows.Count.ToString();
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
            string CI = maskedTextBoxCNIC.Text.Trim();
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

         
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                validationPassed = false;
            }
            else if (string.IsNullOrWhiteSpace(password) || password.Length < 5)
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
            if (validationPassed && (!IsValidEmail(email)))
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
                if (!TryParseDate(dobText, out DateTime parsedDob) || parsedDob > DateTime.Now)
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
                            command.Parameters.AddWithValue("@Password", password); 
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@CNIC", CI);
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
                ID = row.Cells["Column1"].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBoxPass1.Text = row.Cells["Column3"].Value.ToString();
                textBoxEmail1.Text = row.Cells["Column7"].Value.ToString();
                textBoxEmail1.ForeColor = Color.Black;
                maskedTextBoxPho1.Text = row.Cells["Column4"].Value.ToString();
                maskedTextBoxPho1.ForeColor = Color.Black;
                maskedTextBoxCNIC1.Text = row.Cells["Column5"].Value.ToString();
                maskedTextBoxCNIC1.ForeColor = Color.Black;
                maskedTextBoxDOB1.Text = row.Cells["Column6"].Value.ToString();
                maskedTextBoxDOB1.ForeColor = Color.Black;
                gender = row.Cells["user_gender"].Value.ToString();
                if (gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;
                Role = row.Cells["Column9"].Value.ToString();
                if (Role == "Admin")
                    checkBoxRole1.Checked = true;
                textBoxAdd1.Text = row.Cells["Column8"].Value.ToString();

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a user from the Search tab before attempting to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 2. Validation and Data Collection ---
            HideEroorPic1(); // Assuming this hides all error picture boxes for the 'Update' tab
            bool validationPassed = true;

            // Collect data from the 'Update and Delete User' controls (using suffix '1')
            string name = textBox4.Text.Trim();
            string email = textBoxEmail1.Text.Trim();
            string phone = maskedTextBoxPho1.Text.Replace(" ", "").Trim(); // Remove spaces
            string cnic = maskedTextBoxCNIC1.Text.Trim();
            string dobText = maskedTextBoxDOB1.Text.Trim();
            string address = textBoxAdd1.Text.Trim(); // Assuming an address textbox exists

            // Determine Role
            string role = checkBoxRole1.Checked ? "Admin" : "User";

            // Determine Gender
            string gender = "";
            if (radioButtonMale1.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale1.Checked)
            {
                gender = "Female";
            }

            // NOTE: You should ideally NOT allow CNIC/Email updates without strong validation
            // to prevent accidental duplicates, but for simplicity, we focus on required fields.

            // A. Check required fields
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
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
                pictureBoxErrorEmail1.Visible = true;
                MessageBox.Show("Invalid Email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail1.Focus();
                validationPassed = false;
            }

            // C. Check CNIC completion
            if (validationPassed && !maskedTextBoxCNIC1.MaskCompleted)
            {
                pictureBoxErrorCNIC1.Visible = true;
                MessageBox.Show("CNIC field is incomplete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxCNIC1.Focus();
                validationPassed = false;
            }

            // D. Check DOB validity
            if (validationPassed)
            {
                if (!TryParseDate(dobText, out DateTime parsedDob) || parsedDob > DateTime.Now)
                {
                    pictureBoxErrorDOB1.Visible = true;
                    MessageBox.Show("Invalid Date of Birth format or date is in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedTextBoxDOB1.Focus();
                    validationPassed = false;
                }
            }

            // --- 3. Database Update ---
            if (validationPassed)
            {
                // UPDATE query uses the primary key (ID) for identification
                string query = "UPDATE User_Table SET " +
                               "User_Name = @Name, " +
                               "User_Email = @Email, " +
                               "User_Pho = @Phone, " +
                               "User_CNIC = @CNIC, " +
                               "User_DOB = @DOB, " +
                               "User_Gender = @Gender, " +
                               "User_Role = @Role, " +
                               "User_Add = @Address " +
                               "WHERE User_ID = @ID"; // Assuming your primary key is User_ID

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.Parameters.AddWithValue("@CNIC", cnic);
                            command.Parameters.AddWithValue("@DOB", dobText);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Role", role);
                            command.Parameters.AddWithValue("@Address", address);
                            command.Parameters.AddWithValue("@ID", ID); // CRITICAL: Identify the row to update

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBox1(); // Clear the update form after success
                                                 // You should also navigate back to the Search tab or refresh the DataGridView here
                            }
                            else
                            {
                                MessageBox.Show("Update failed. User ID may not exist or data was unchanged.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 1. Check if a user ID is loaded for deletion
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please select a user from the Search tab before attempting to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmation Prompt (CRITICAL step for irreversible action)
            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete the user with ID **{ID}**?",
                                                   "Confirm Deletion",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return; // User cancelled the operation
            }

            // --- 3. Database Deletion ---

            // Delete query uses the primary key (ID) for identification
            string query = "DELETE FROM User_Table WHERE user_ID = @ID"; // Assuming your primary key is User_ID

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // CRITICAL: Identify the row to delete using the ID parameter
                        command.Parameters.AddWithValue("@ID", ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User was successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBox1(); // Clear the update/delete form after success
                            ID = ""; // Reset the ID to prevent accidental re-deletion
                                     // You should also refresh the DataGridView on the Search tab here
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. User ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle Foreign Key Constraint Violation (Error code 1451 in MySQL)
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete user: Dependent records (e.g., attendance data) exist. Remove those first.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database Error during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

