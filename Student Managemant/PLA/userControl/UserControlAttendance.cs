using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControlAttendance : UserControl
    {
        private const string ConnectionString = "server=localhost;port=3306;database=attendens_managment_system;uid=root;password=;";

        public UserControlAttendance()
        {
            InitializeComponent(); // <-- this must come first

            comboBoxClass.DisplayMember = "Class_Name";
            comboBoxClass.ValueMember = "Class_ID";

            ConfigureDataGridViewColumns();
        }


        private void ConfigureDataGridViewColumns()
        {

            dataGridViewMarkAttendance.Columns["Column1"].DataPropertyName = "Student_ID";
            dataGridViewMarkAttendance.Columns["Column1"].Visible = false;


            dataGridViewMarkAttendance.Columns["Column2"].DataPropertyName = "Student_Name";
            dataGridViewMarkAttendance.Columns["Column2"].HeaderText = "Student Name";


            dataGridViewMarkAttendance.Columns["Column3"].DataPropertyName = "Student_RegNo";
            dataGridViewMarkAttendance.Columns["Column3"].HeaderText = "Reg No.";


            dataGridViewMarkAttendance.Columns["Column4"].DataPropertyName = "Is_Present_Flag";
            dataGridViewMarkAttendance.Columns["Column4"].HeaderText = "Present";


            dataGridViewMarkAttendance.Columns["Column5"].DataPropertyName = "Attendance_Status";
            dataGridViewMarkAttendance.Columns["Column5"].Visible = false;
        }




        private void UserControlAttendance_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

            if (comboBoxClass.SelectedValue != null && comboBoxClass.SelectedValue != DBNull.Value)
            {

                if (int.TryParse(comboBoxClass.SelectedValue.ToString(), out int classId))
                {
                    LoadStudentsForClass(classId, dateTimePickerDate.Value.ToString("yyyy-MM-dd"));
                }
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxClass.SelectedValue != null && comboBoxClass.SelectedValue != DBNull.Value)
            {
                if (int.TryParse(comboBoxClass.SelectedValue.ToString(), out int classId))
                {
                    LoadStudentsForClass(classId, dateTimePickerDate.Value.ToString("yyyy-MM-dd"));
                }
            }
            else
            {

                dataGridViewMarkAttendance.DataSource = null;
            }
        }

        private void dataGridViewMarkAttendance_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (dataGridViewMarkAttendance.IsCurrentCellDirty)
            {
                dataGridViewMarkAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewMarkAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridViewMarkAttendance.Columns["Column4"] != null && e.ColumnIndex == dataGridViewMarkAttendance.Columns["Column4"].Index)
            {

                if (e.Value != null && e.Value is bool isPresent)
                {

                    if (isPresent)
                    {
                        dataGridViewMarkAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dataGridViewMarkAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }





        private void LoadClasses()
        {
            string query = "SELECT Class_ID, Class_Name FROM class_table ORDER BY Class_Name";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        comboBoxClass.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadStudentsForClass(int classId, string date)
        {


            string query = @"
                SELECT 
                    s.Student_ID,
                    s.Student_Name,
                    s.Student_RegNo,
                    a.Attendance_Status
                FROM 
                    student_table s
                LEFT JOIN 
                    attendance_table a ON s.Student_ID = a.Student_ID AND a.Attendance_Date = @date
                WHERE 
                    s.Class_ID = @classId
                ORDER BY s.Student_Name";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classId", classId);
                        command.Parameters.AddWithValue("@date", date);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }



                dt.Columns.Add("Is_Present_Flag", typeof(bool));


                foreach (DataRow row in dt.Rows)
                {
                    string status = row["Attendance_Status"] == DBNull.Value ? "Absent" : row["Attendance_Status"].ToString();
                    row["Attendance_Status"] = status;

                    row["Is_Present_Flag"] = status.Equals("Present", StringComparison.OrdinalIgnoreCase);
                }


                dataGridViewMarkAttendance.DataSource = dt;


                ConfigureDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewMarkAttendance.DataSource = null;
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedValue == null || comboBoxClass.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please select a class before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataTable attendanceTable = dataGridViewMarkAttendance.DataSource as DataTable;

            if (attendanceTable == null || attendanceTable.Rows.Count == 0)
            {
                MessageBox.Show("No students to save attendance for.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string date = dateTimePickerDate.Value.ToString("yyyy-MM-dd");
            int recordsSaved = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        foreach (DataRow row in attendanceTable.Rows)
                        {
                            int studentId = Convert.ToInt32(row["Student_ID"]);

                            // FIX 2: Safely convert object to bool from the DataRow
                            bool isPresent = Convert.ToBoolean(row["Is_Present_Flag"]);
                            string status = isPresent ? "Present" : "Absent";


                            string checkQuery = "SELECT COUNT(*) FROM attendance_table WHERE Student_ID = @studentId AND Attendance_Date = @date";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection, transaction);
                            checkCommand.Parameters.AddWithValue("@studentId", studentId);
                            checkCommand.Parameters.AddWithValue("@date", date);


                            // FIX 1: Safely convert object return value of ExecuteScalar to long
                            long count = Convert.ToInt64(checkCommand.ExecuteScalar());

                            string saveQuery;
                            if (count > 0)
                            {

                                saveQuery = "UPDATE attendance_table SET Attendance_Status = @status WHERE Student_ID = @studentId AND Attendance_Date = @date";
                            }
                            else
                            {

                                saveQuery = "INSERT INTO attendance_table (Attendance_Date, Attendance_Status, Student_ID) VALUES (@date, @status, @studentId)";
                            }

                            MySqlCommand saveCommand = new MySqlCommand(saveQuery, connection, transaction);
                            saveCommand.Parameters.AddWithValue("@date", date);
                            saveCommand.Parameters.AddWithValue("@status", status);
                            saveCommand.Parameters.AddWithValue("@studentId", studentId);

                            recordsSaved += saveCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"{recordsSaved} attendance records saved successfully for {date}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


                if (comboBoxClass.SelectedValue is int classId)
                {
                    LoadStudentsForClass(classId, date);
                }
            }
            catch (Exception ex)
            {



                MessageBox.Show("Error saving attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
