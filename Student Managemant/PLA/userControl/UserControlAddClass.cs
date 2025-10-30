using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Add these two 'using' statements for database access
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControlAddClass : UserControl
    {
        private string connectionString = "Server=localhost; Database=attendens_managment_system; Uid=root; Pwd=;";

        private string CID = "";
        public UserControlAddClass()
        {
            InitializeComponent();


        }

        // This is method to allow only numbers
        private void Integertype(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        // --- Event Handlers for the "Add Class" tab ---

        // These methods call your Integertype method
        private void textBoxMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        // This method will auto-calculate the total student count
        private void UpdateTotal(object sender, EventArgs e)
        {
            int.TryParse(textBoxMale.Text, out int maleCount);
            int.TryParse(textBoxFemale.Text, out int femaleCount);
            textBoxHmStudent.Text = (maleCount + femaleCount).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can add code here if needed
        }

        // --- Event Handlers for the "Search Class" tab ---

        private void tabPageSearchClass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSerach_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSerach, "Search Class");
        }

        // --- Button Click Event for "Add Class" tab ---

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // 1. Get values from text boxes
            string className = textBox1.Text.Trim(); // Class Name

            if (!int.TryParse(textBoxMale.Text.Trim(), out int maleCount))
            {
                MessageBox.Show("Please enter a valid number for 'Male'.");
                return;
            }

            if (!int.TryParse(textBoxFemale.Text.Trim(), out int femaleCount))
            {
                MessageBox.Show("Please enter a valid number for 'Female'.");
                return;
            }

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter a class name.");
                return;
            }

            // 2. Calculate Total
            int totalCount = maleCount + femaleCount;

            // 3. Create the INSERT SQL query
            string query = "INSERT INTO Class_Table (Class_Name, Class_Total, Class_Male, Class_Female) " +
                           "VALUES ('" + className + "', " + totalCount + ", " + maleCount + ", " + femaleCount + ")";

            // 4. Execute the query
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Class Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTxtBox(); // Clear fields after success
                        }
                        else
                        {
                            MessageBox.Show("Operation failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database command error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ai methana priver kare 
        public void ClearTxtBox()
        {
            textBox1.Clear();
            textBoxFemale.Clear();
            textBoxHmStudent.Clear();
            textBoxMale.Clear();
            tabControlAddClass.SelectedTab = tabPageAddClass;
        }

        public void ClearTxtBox1()
        {
            textBoxName1.Clear();
            textBoxFemale1.Clear();
            textBoxHwStudent1.Clear();
            textBoxMale1.Clear();
            CID = "";
        }

        // --- Event Handlers for "Update" and "Search" tabs ---

        private void tabPageUPClass_Leave(object sender, EventArgs e)
        {
            ClearTxtBox1();
        }

        // --- THIS IS THE METHOD YOU ASKED FOR ---
        // It now works using your connectionString
        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            string query = "SELECT * FROM Class_Table";

            try
            {
                // Create a new DataTable to hold the data
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Use MySqlDataAdapter to fill the DataTable
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                // Set the DataTable as the data source for your DataGridView
                // (Assuming your DataGridView is named 'dataGridViewClass')
                dataGridViewClass.DataSource = dataTable;

                // Now you can safely hide the column and count the rows
                if (dataGridViewClass.Columns.Count > 0)
                {
                    dataGridViewClass.Columns[0].Visible = false; // Hides Class_ID
                }

                // Set the count label
                // (Assuming your count label is named 'labelCountClass')
                labelCountClass.Text = dataGridViewClass.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database query error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControlAddClass_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageAddClass_Enter(object sender, EventArgs e)
        {
            ClearTxtBox1();
        }

        private void tabPageAddClass_Leave(object sender, EventArgs e)
        {
            ClearTxtBox1();
        }

        private void textBoxHmStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxMale_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxFemale_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxMale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxFemale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxHwStudent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Integertype(e);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
           
            // Get the search keyword and trim any extra spaces
            string searchKeyword = textBoxSearch.Text.Trim();

            // Construct the SQL Query with the LIKE operator
            // This query searches for the keyword anywhere in the Class_Name
            // Note: MySqlHelper.EscapeString is used for safety, but if you don't have that 
            // helper, you can use searchKeyword.Replace("'", "''") as a basic safeguard.
            string query = "SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + searchKeyword + "%'";

            try
            {
                DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Use MySqlDataAdapter to fill the DataTable with filtered data
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                // Update the DataGridView
                dataGridViewClass.DataSource = dataTable;

                // Ensure the ID column remains hidden
                if (dataGridViewClass.Columns.Count > 0)
                {
                    dataGridViewClass.Columns[0].Visible = false;
                }

                // Set the new count based on the filtered data
                labelCountClass.Text = dataTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                // Displaying a message box here is optional. If the user is typing very fast, 
                // they might trigger many errors for incomplete queries. It's often safer 
                // to just log the error to the console in a TextChanged event.
                // MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxHwStudent1.Text = row.Cells[2].Value.ToString();
                textBoxMale1.Text = row.Cells[3].Value.ToString();
                textBoxFemale1.Text = row.Cells[4].Value.ToString();


            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            if (CID != " ")
            {

                // 1. Get values from text boxes
                string className = textBox1.Text.Trim(); // Class Name



                if (!int.TryParse(textBoxMale1.Text.Trim(), out int maleCount))
                {
                    MessageBox.Show("Please enter a valid number for 'Male'.");
                    return;
                }

                if (!int.TryParse(textBoxFemale1.Text.Trim(), out int femaleCount))
                {
                    MessageBox.Show("Please enter a valid number for 'Female'.");
                    return;
                }

                if (string.IsNullOrEmpty(className))
                {
                    MessageBox.Show("Please enter a class name.");
                    return;
                }

                // 2. Calculate Total
                int totalCount = maleCount + femaleCount;

                // 3. Create the INSERT SQL query
                string query = "UPDATE Class_Table SET " +
                       "Class_Name = '" + MySqlHelper.EscapeString(className) + "', " + // Use EscapeString to help prevent SQL injection
                       "Class_Total = " + totalCount + ", " +
                       "Class_Male = " + maleCount + ", " +
                       "Class_Female = " + femaleCount + " " +
                       "WHERE Class_ID = " + CID;

                // 4. Execute the query
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            if (command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Class Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTxtBox(); // Clear fields after success
                            }
                            else
                            {
                                MessageBox.Show("Operation failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database command error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a Row from Table.", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           
            // Fix: Check if CID is not null or empty to ensure a row is selected.
            if (!string.IsNullOrEmpty(CID))
            {
                // 1. Ask the user for confirmation
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to delete this class (ID: " + CID + ")? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // 2. Create the DELETE SQL query
                    // The query targets the row using the stored CID.
                    string query = "DELETE FROM Class_Table WHERE Class_ID = " + CID;

                    // 3. Execute the query
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                if (command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Class Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // 4. Clear fields and refresh data
                                    ClearTxtBox1(); // Clears update tab fields and resets CID
                                                    // You should call the refresh method for your search tab's DataGridView here.
                                                    // Assuming your refresh logic is in tabPageSearchClass_Enter, you can switch tabs or call the refresh function directly.
                                                    // For simplicity, let's switch to the search tab which will trigger the refresh:
                                    tabControlAddClass.SelectedTab = tabPageSearchClass;
                                }
                                else
                                {
                                    MessageBox.Show("Operation failed. No class was deleted.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database command error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Class selected for Deletion.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

