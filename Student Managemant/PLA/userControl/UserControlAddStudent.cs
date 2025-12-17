using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Managemant.PLA.Froms
{
    public partial class UserControlAddStudent : UserControl
    {
        // IMPORTANT: Assuming the following controls exist on the Update/Delete tab (tabPageUPStudent)
        // textBoxName1, textBoxRegNo1, comboBoxClass1, radioButtonMale1, radioButtonFemale1

        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";
        private string SID = "";

        // Variable to hold the Student ID of the selected row for Update/Delete operations
        private string studentIDToUpdateOrDelete = "";

        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearTxtBox()
        {
            textBoxName.Clear();
            textBoxRegNo.Clear();
            comboBoxClass.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            tabControlAddStudent.SelectedTab = tabPageAddStudent;
        }

        public void ClearTxtBox1()
        {
            // Assuming this clears the fields on the Update/Delete tab (tabPageUPStudent)
            textBoxName1.Clear();
            textBoxRegNo1.Clear();
            comboBoxClass1.SelectedIndex = -1;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            studentIDToUpdateOrDelete = ""; // Reset the tracking ID
        }

        private void pictureBoxSerach_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSerach, "Search Student");
        }

        private void tabPageSearchStudent_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            // Code to load all students when entering the search tab
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;

            string query = "SELECT " +
                           "Student_ID, Student_Name, Student_RegNo, Student_Gender, Class_Name " +
                           "FROM Student_Table " +
                           "INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID " +
                           "ORDER BY Student_Name ASC";

            ExecuteSearchAndDisplay(query);
        }

        private void tabPageSearchStudent_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void tabPageSearchStudent_Leave(object sender, EventArgs e)
        {
            ClearTxtBox1();
        }

        private void tabPageUPStudent_Leave(object sender, EventArgs e)
        {
            ClearTxtBox1();
        }

        private void comboBoxClass1_Click(object sender, EventArgs e)
        {
            // Fills the class ComboBox on the Update/Delete tab
            comboBoxClass1.Items.Clear();
            string query = "SELECT DISTINCT(Class_Name) FROM Class_Table ORDER BY Class_Name ASC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string? className = reader["Class_Name"]?.ToString();
                                if (!string.IsNullOrEmpty(className))
                                {
                                    comboBoxClass1.Items.Add(className);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes for update: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            // Fills the class ComboBox on the Add tab
            comboBoxClass.Items.Clear();
            string query = "SELECT DISTINCT(Class_Name) FROM Class_Table ORDER BY Class_Name ASC";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string? className = reader["Class_Name"]?.ToString();
                                if (!string.IsNullOrEmpty(className))
                                {
                                    comboBoxClass.Items.Add(className);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes for add: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButtonMale.Checked)
                gender = "Male";
            if (radioButtonFemale.Checked)
                gender = "Female";

            // 1. Data Validation Check
            if (textBoxName.Text.Trim() == string.Empty || textBoxRegNo.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the required fields (Name, Reg No, Class).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Please select the student's Gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input data
            string name = textBoxName.Text.Trim();
            string regNo = textBoxRegNo.Text.Trim();
            string className = comboBoxClass.SelectedItem.ToString();

            string classID = string.Empty;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // --- Step A: Retrieve the Class_ID ---
                    string queryGetClassID = "SELECT Class_ID FROM Class_Table WHERE Class_Name = @ClassName";
                    using (MySqlCommand command = new MySqlCommand(queryGetClassID, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", className);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            classID = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Selected class not found in the database. Cannot add student.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // --- Step B: Insert the Student Record ---
                    string queryInsertStudent = "INSERT INTO Student_Table (Student_Name, Student_RegNo, Class_ID, Student_Gender) " +
                                                "VALUES (@Name, @RegNo, @ClassID, @Gender)";

                    using (MySqlCommand command = new MySqlCommand(queryInsertStudent, connection))
                    {
                        // Use parameters for safe insertion
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@RegNo", regNo);
                        command.Parameters.AddWithValue("@ClassID", classID);
                        command.Parameters.AddWithValue("@Gender", gender);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student **" + name + "** added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxtBox();
                        }
                        else
                        {
                            MessageBox.Show("Student addition failed. No rows inserted.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate entry error code
                {
                    MessageBox.Show("Error: A student with Registration Number **" + regNo + "** already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- COMPLETED LOGIC FOR SEARCH FILTERING ---
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = textBoxSearch.Text.Trim();
            string searchByColumn = string.Empty;
            string searchQuery = string.Empty;

            // Base query structure (fetching all necessary student and class info)
            string baseQuery = "SELECT Student_ID, Student_Name, Student_RegNo, Student_Gender, Class_Name " +
                               "FROM Student_Table " +
                               "INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID ";

            // Check if a search term is present AND a category is selected
            if (searchKeyword.Length > 0 && comboBoxSearchBy.SelectedIndex != -1)
            {
                // Map the SelectedIndex to the database column name
                if (comboBoxSearchBy.SelectedIndex == 0) // Assuming Index 0 is "Name"
                {
                    searchByColumn = "Student_Name";
                }
                else if (comboBoxSearchBy.SelectedIndex == 1) // Assuming Index 1 is "Reg No"
                {
                    searchByColumn = "Student_RegNo";
                }
                else if (comboBoxSearchBy.SelectedIndex == 2) // Assuming Index 2 is "Class"
                {
                    // For Class, we search on the joined table's Class_Name column
                    searchByColumn = "Class_Name";
                }
                else
                {
                    // If selection is somehow invalid, just show all data
                    ExecuteSearchAndDisplay(baseQuery + "ORDER BY Student_Name ASC");
                    return;
                }

                // Construct the filtered query using LIKE
                searchQuery = baseQuery + "WHERE " + searchByColumn + " LIKE '%" + MySqlHelper.EscapeString(searchKeyword) + "%' " +
                              "ORDER BY Student_Name ASC";

                ExecuteSearchAndDisplay(searchQuery);
            }
            else if (searchKeyword.Length == 0)
            {
                // If the search box is empty, display all students
                ExecuteSearchAndDisplay(baseQuery + "ORDER BY Student_Name ASC");
            }
        }


        private void ExecuteSearchAndDisplay(string query)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                // 1. Update the DataGridView
                dataGridViewStudent.DataSource = dataTable;

                // 2. Configure the DataGridView
                if (dataGridViewStudent.Columns.Count > 0)
                {
                    // Hide the Student_ID column (index 0 in the SELECT statement)
                    dataGridViewStudent.Columns[0].Visible = false;
                }

                // 3. Update the count label
                labelCountStudent.Text = dataTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                // In TextChanged event, silently log the error
                Console.WriteLine("Search execution error: " + ex.Message);
            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];

                // --- 1. Load Data from DataGridView Row to Controls ---
                // Assuming column order: ID(0), Name(1), RegNo(2), Class_Name(3), Gender(4)

                comboBoxClass1.Items.Clear();

                string query = "SELECT Class_Name FROM Class_Table ORDER BY Class_Name ASC";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each class name found to the ComboBox
                                comboBoxClass1.Items.Add(reader.GetString(0));
                            }
                        }
                    }

                    // Set the selected item in the ComboBox to the student's current class name
                    comboBoxClass1.SelectedItem = studentClassName;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error while loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if class loading fails
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // --- 3. Handle Gender Radio Buttons ---
                string gender = row.Cells[4].Value.ToString(); // Student_Gender (Index 4)

                if (gender == "Male")
                {
                    radioButtonMale1.Checked = true;
                    radioButtonFemale1.Checked = false;
                }
                else if (gender == "Female")
                {
                    radioButtonFemale1.Checked = true;
                    radioButtonMale1.Checked = false;
                }
                else // Clear selection if gender is unrecognized
                {
                    radioButtonMale1.Checked = false;
                    radioButtonFemale1.Checked = false;
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string gender = "";
            if (radioButtonMale1.Checked)
                gender = "Male";
            if (radioButtonFemale1.Checked)
                gender = "Female";

            // 1. Data Validation Check
            if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || comboBoxClass1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the required fields (Name, Reg No, Class).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
            {
                MessageBox.Show("Please select the student's Gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input data
            string name = textBoxName1.Text.Trim();
            string regNo = textBoxRegNo1.Text.Trim();
            // Assuming you get the class name the same way as in your add method, using the selected item text
            string className = comboBoxClass1.SelectedItem.ToString();

            // Use integer for Class ID since it is typically an INT in the database
            int classID = -1;
            MySqlTransaction transaction = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction for atomicity (either both queries succeed or none do)
                    transaction = connection.BeginTransaction();

                    // --- Step A: Retrieve the Class_ID (Foreign Key) ---
                    string queryGetClassID = "SELECT Class_ID FROM Class_Table WHERE Class_Name = @ClassName";

                    using (MySqlCommand commandGetClassID = new MySqlCommand(queryGetClassID, connection, transaction))
                    {
                        commandGetClassID.Parameters.AddWithValue("@ClassName", className);

                        object result = commandGetClassID.ExecuteScalar();

                        if (result != null)
                        {
                            // Convert the result to the appropriate type (e.g., integer)
                            classID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show($"Selected class '{className}' not found in the database. Cannot update student.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                    // --- Step B: Update the Student Record ---
                    // This is the main difference from the INSERT query.
                    string queryUpdateStudent = "UPDATE Student_Table " +
                                                "SET Student_Name = @Name, " +
                                                "    Class_ID = @ClassID, " +
                                                "    Student_Gender = @Gender " +
                                                "WHERE Student_RegNo = @RegNo"; // Key update logic

                    using (MySqlCommand commandUpdate = new MySqlCommand(queryUpdateStudent, connection, transaction))
                    {
                        // Use parameters for safe update
                        commandUpdate.Parameters.AddWithValue("@Name", name);
                        commandUpdate.Parameters.AddWithValue("@ClassID", classID);
                        commandUpdate.Parameters.AddWithValue("@Gender", gender);
                        commandUpdate.Parameters.AddWithValue("@RegNo", regNo); // Parameter for WHERE clause

                        int rowsAffected = commandUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Both steps succeeded, commit the transaction
                            transaction.Commit();
                            MessageBox.Show("Student details for Reg No **" + regNo + "** updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxtBox();
                        }
                        else
                        {
                            // No rows affected means the Reg No was not found
                            transaction.Rollback();
                            MessageBox.Show($"Update failed. Student with Registration Number **{regNo}** was not found.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback(); // Rollback if transaction exists and an error occurred

                if (ex.Number == 1062) // Duplicate entry error code
                {
                    MessageBox.Show("Error: A duplicate value exists for a unique field (e.g., Reg No or Name/Class combination if unique).", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback(); // Rollback if transaction exists and a general error occurred
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // --- 1. Data Validation Check: Only Reg No is strictly required for deletion ---
            string regNo = textBoxRegNo1.Text.Trim();

            if (string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("Please enter the **Registration Number** of the student you want to delete.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxRegNo1.Focus();
                return;
            }

            // --- 2. Confirmation Prompt ---
            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete the student with Registration Number **{regNo}**?",
                                                   "Confirm Deletion",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return; // User cancelled the operation
            }

            MySqlTransaction transaction = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction (optional for a single DELETE, but good for consistency)
                    transaction = connection.BeginTransaction();

                    // --- SQL: Delete the Student Record based on Reg No ---
                    string queryDeleteStudent = "DELETE FROM Student_Table WHERE Student_RegNo = @RegNo";

                    using (MySqlCommand commandDelete = new MySqlCommand(queryDeleteStudent, connection, transaction))
                    {
                        // Use parameter for safe deletion (crucial WHERE clause)
                        commandDelete.Parameters.AddWithValue("@RegNo", regNo);

                        int rowsAffected = commandDelete.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Success! Commit the transaction
                            transaction.Commit();
                            MessageBox.Show("Student with Reg No **" + regNo + "** was successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxtBox();
                        }
                        else
                        {
                            // No rows affected means the Reg No was not found
                            transaction.Rollback();
                            MessageBox.Show($"Deletion failed. Student with Registration Number **{regNo}** was not found.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                transaction?.Rollback(); // Rollback if transaction exists and an error occurred

                // Note: Delete operations typically don't cause a 1062 error, but may hit foreign key constraints (1451)
                if (ex.Number == 1451) // Foreign Key Constraint Violation
                {
                    MessageBox.Show("Cannot delete student because they have dependent records (e.g., marks, attendance). Remove those first.", "Deletion Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                transaction?.Rollback(); // Rollback if transaction exists and a general error occurred
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
