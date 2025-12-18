using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DinkToPdf;
using System.Diagnostics;

namespace Student_Managemant.PLA.userControl
{
    public partial class UserControlReport : UserControl
    {
        private const string ConnectionString = "server=localhost;port=3306;database=attendens_managment_system;uid=root;password=;";
        public UserControlReport()
        {
            InitializeComponent();
        }

        public void FirstTab()
        {
            tabControlReport.SelectedTab = tabPageClassReport;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Print Data");
        }

        private void pictureBoxPrint1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint1, "Print Data");
        }

        private void comboBoxClass1_Click(object sender, EventArgs e)
        {
            comboBoxClass1.Items.Clear();

            string quary = "SELECT DISTINCT(Class_Name) FROM class_table";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(quary, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxClass1.Items.Add(reader["Class_Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();

            string quary = "SELECT DISTINCT(Class_Name) FROM class_table";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(quary, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxClass.Items.Add(reader["Class_Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxClass_Enter(object sender, EventArgs e)
        {


        }

        private void comboBoxRegNo_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                comboBoxRegNo.Items.Clear(); // පැරණි දත්ත ඉවත් කරන්න

                // පන්තියේ නම අනුව Reg No ලබා ගැනීමේ නිවැරදි Query එක
                string query = "SELECT DISTINCT(Student_RegNo) FROM student_table " +
                               "INNER JOIN class_table ON student_table.Class_ID = class_table.Class_ID " +
                               "WHERE class_table.Class_Name = @className";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@className", comboBoxClass.SelectedItem.ToString());
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comboBoxRegNo.Items.Add(reader["Student_RegNo"].ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Reg Nos: " + ex.Message);
                }
            }
        }

        private void comboBoxRegNo_DropDown(object sender, EventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadClassReport();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            LoadClassReport();
        }

        private void LoadClassReport()
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                string query = @"SELECT s.Student_Name, s.Student_RegNo, c.Class_Name, 
                                 a.Attendance_Date, a.Attendance_Status 
                                 FROM student_table s
                                 INNER JOIN attendance_table a ON s.Student_ID = a.Student_ID 
                                 INNER JOIN class_table c ON c.Class_ID = s.Class_ID 
                                 WHERE c.Class_Name = @className 
                                 AND a.Attendance_Date LIKE @date";

                try
                {
                    DataTable dt = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@className", comboBoxClass.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@date", dateTimePickerDate.Value.ToString("yyyy-MM-dd") + "%");

                            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                            adapter.Fill(dt);
                        }
                    }
                    dataGridViewClassReport.AutoGenerateColumns = false;
                    dataGridViewClassReport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grid Error: " + ex.Message);
                }
            }
        }

        private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1)
            {
                comboBoxRegNo.Items.Clear();
                comboBoxRegNo.SelectedIndex = -1;

                string query = @"SELECT DISTINCT s.Student_RegNo 
                                 FROM student_table s
                                 INNER JOIN class_table c ON s.Class_ID = c.Class_ID 
                                 WHERE c.Class_Name = @className";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@className", comboBoxClass1.SelectedItem.ToString());
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    comboBoxRegNo.Items.Add(reader["Student_RegNo"].ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Reg Nos: " + ex.Message);
                }
            }
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudentReport();
        }

        private void dateTimePickerDate1_ValueChanged(object sender, EventArgs e)
        {
            LoadStudentReport();
        }

        private void LoadStudentReport()
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                string query = @"SELECT s.Student_Name, s.Student_RegNo, c.Class_Name, 
                                 a.Attendance_Date, a.Attendance_Status 
                                 FROM student_table s
                                 INNER JOIN attendance_table a ON s.Student_ID = a.Student_ID 
                                 INNER JOIN class_table c ON c.Class_ID = s.Class_ID 
                                 WHERE c.Class_Name = @className 
                                 AND s.Student_RegNo = @regNo
                                 AND a.Attendance_Date LIKE @yearMonth";

                try
                {
                    DataTable dt = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@className", comboBoxClass1.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@regNo", comboBoxRegNo.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@yearMonth", dateTimePickerDate1.Value.ToString("yyyy-MM") + "%");

                            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                            adapter.Fill(dt);
                        }
                    }
                    dataGridViewStudentReport.AutoGenerateColumns = false;
                    dataGridViewStudentReport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Student Report Error: " + ex.Message);
                }
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                await PrintStudentReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in pictureBox1_Click: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void pictureBoxPrint1_Click(object sender, EventArgs e)
        {
            try
            {
                await PrintClassReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in pictureBoxPrint1_Click: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task PrintClassReport()
        {
            if (dataGridViewClassReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to print. Please select a class and date first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string className = comboBoxClass.SelectedItem?.ToString() ?? "";
            string reportDate = dateTimePickerDate.Value.ToString("yyyy-MM-dd");

            string html = GenerateReportHtml(
                "Class Attendance Report",
                $"Class: {className} | Date: {reportDate}",
                dataGridViewClassReport
            );

            await GenerateAndOpenPdfAsync(html, "ClassReport");
        }

        private async Task PrintStudentReport()
        {
            if (dataGridViewStudentReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to print. Please select class, student and date first.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string className = comboBoxClass1.SelectedItem?.ToString() ?? "";
            string regNo = comboBoxRegNo.SelectedItem?.ToString() ?? "";
            string reportMonth = dateTimePickerDate1.Value.ToString("yyyy-MM");

            string html = GenerateReportHtml(
                "Student Attendance Report",
                $"Class: {className} | Reg No: {regNo} | Month: {reportMonth}",
                dataGridViewStudentReport
            );

            await GenerateAndOpenPdfAsync(html, "StudentReport");
        }

        


            private async Task GenerateAndOpenPdfAsync(string html, string reportName)
{
            await Task.Run(() =>
            {
                try
                {
                    string dllPath = Path.Combine(Application.StartupPath, "libwkhtmltox.dll");
                    if (!File.Exists(dllPath))
                    {
                        MessageBox.Show(
                            $"Missing required DLL file!\n\nPlease copy 'libwkhtmltox.dll' to:\n{dllPath}",
                            "DLL Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    using (var tools = new PdfTools())
                    {
                        var converter = new SynchronizedConverter(tools);

                        var doc = new HtmlToPdfDocument
                        {
                            GlobalSettings = {
                                ColorMode = ColorMode.Color,
                                Orientation = DinkToPdf.Orientation.Portrait,
                                PaperSize = PaperKind.A4,
                                Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
                            },
                            Objects = {
                                new ObjectSettings {
                                    HtmlContent = html,
                                    WebSettings = { DefaultEncoding = "utf-8" }
                                }
                            }
                        };

                        byte[] pdf = converter.Convert(doc);
                        if (pdf == null || pdf.Length == 0)
                        {
                            MessageBox.Show("PDF generation failed: Empty PDF generated.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string fileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                        string filePath = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                            fileName);

                        using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            fs.Write(pdf, 0, pdf.Length);
                        }

                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"PDF Generation Error:\n\n{ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            });
}
            // try
            // {
            //     // Check if DLL exists in output directory
            //     string dllPath = Path.Combine(Application.StartupPath, "libwkhtmltox.dll");
            //     if (!File.Exists(dllPath))
            //     {
            //         MessageBox.Show($"Missing required DLL file!\n\nPlease copy 'libwkhtmltox.dll' to:\n{dllPath}\n\nDownload from: https://github.com/AaronC81/DinkToPdf/releases", 
            //             "DLL Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         return;
            //     }

            //     SynchronizedConverter converter = new SynchronizedConverter(new PdfTools());

            //     var doc = new HtmlToPdfDocument()
            //     {
            //         GlobalSettings = {
            //             ColorMode = ColorMode.Color,
            //             Orientation = DinkToPdf.Orientation.Portrait,
            //             PaperSize = PaperKind.A4,
            //             Margins = new MarginSettings { Top = 10, Bottom = 10, Left = 10, Right = 10 }
            //         },
            //         Objects = {
            //             new ObjectSettings() {
            //                 HtmlContent = html,
            //                 WebSettings = { DefaultEncoding = "utf-8" }
            //             }
            //         }
            //     };

            //     byte[] pdf = converter.Convert(doc);

            //     if (pdf == null || pdf.Length == 0)
            //     {
            //         MessageBox.Show("PDF generation failed: Empty PDF generated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         return;
            //     }

            //     string fileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            //     string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            //     File.WriteAllBytes(filePath, pdf);

            //     if (File.Exists(filePath))
            //     {
            //         Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            //         MessageBox.Show($"Report saved successfully!\n\nFile: {fileName}\nLocation: Desktop", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //     }
            //     else
            //     {
            //         MessageBox.Show("Failed to save PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     }
            // }
            // catch (DllNotFoundException ex)
            // {
            //     MessageBox.Show($"Missing DLL library!\n\nError: {ex.Message}\n\nPlease copy 'libwkhtmltox.dll' to your application folder:\n{Application.StartupPath}\n\nDownload from: https://github.com/AaronC81/DinkToPdf/releases", 
            //         "DLL Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show($"PDF Generation Error:\n\n{ex.Message}\n\nType: {ex.GetType().Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
        

        private string GenerateReportHtml(string reportTitle, string filterInfo, DataGridView dgv)
        {
            string logoPath = @"D:\visual Studio\Student Managemant solution\photos\graduation.ico";
            string logoBase64 = "";

            try
            {
                if (File.Exists(logoPath))
                {
                    // Convert ICO to PNG for better PDF compatibility
                    using (Icon icon = new Icon(logoPath))
                    {
                        using (Bitmap bitmap = icon.ToBitmap())
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                byte[] imageBytes = ms.ToArray();
                                logoBase64 = Convert.ToBase64String(imageBytes);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If icon loading fails, logoBase64 will remain empty
                System.Diagnostics.Debug.WriteLine($"Icon load error: {ex.Message}");
            }

            StringBuilder tableRows = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    tableRows.Append("<tr>");
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellValue = cell.Value?.ToString() ?? "";
                        string statusClass = "";
                        if (cell.OwningColumn.DataPropertyName == "Attendance_Status")
                        {
                            statusClass = cellValue.ToLower() == "present" ? "status-present" : "status-absent";
                        }
                        tableRows.Append($"<td class='{statusClass}'>{cellValue}</td>");
                    }
                    tableRows.Append("</tr>");
                }
            }

            string html = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='UTF-8'>
    <style>
        * {{
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }}
        body {{
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            padding: 20px;
            background: #fff;
            color: #333;
        }}
        .header {{
            text-align: center;
            border-bottom: 3px solid #34b297;
            padding-bottom: 15px;
            margin-bottom: 20px;
        }}
        .header img {{
            width: 60px;
            height: 60px;
            margin-bottom: 10px;
        }}
        .school-name {{
            font-size: 24px;
            font-weight: bold;
            color: #34b297;
            margin-bottom: 5px;
        }}
        .school-address {{
            font-size: 12px;
            color: #666;
            margin-bottom: 3px;
        }}
        .report-title {{
            font-size: 18px;
            font-weight: bold;
            color: #333;
            margin: 15px 0 5px 0;
            text-transform: uppercase;
        }}
        .filter-info {{
            font-size: 12px;
            color: #555;
            margin-bottom: 15px;
            padding: 8px;
            background: #f5f5f5;
            border-radius: 4px;
        }}
        table {{
            width: 100%;
            border-collapse: collapse;
            margin-top: 10px;
            font-size: 11px;
        }}
        th {{
            background: #34b297;
            color: white;
            padding: 10px 8px;
            text-align: left;
            font-weight: 600;
            border: 1px solid #2a9d8f;
        }}
        td {{
            padding: 8px;
            border: 1px solid #ddd;
        }}
        tr:nth-child(even) {{
            background: #f9f9f9;
        }}
        .status-present {{
            color: #28a745;
            font-weight: bold;
        }}
        .status-absent {{
            color: #dc3545;
            font-weight: bold;
        }}
        .footer {{
            margin-top: 30px;
            text-align: center;
            font-size: 10px;
            color: #888;
            border-top: 1px solid #ddd;
            padding-top: 10px;
        }}
        .print-date {{
            text-align: right;
            font-size: 10px;
            color: #888;
            margin-bottom: 10px;
        }}
    </style>
</head>
<body>
    <div class='print-date'>Printed: {DateTime.Now:yyyy-MM-dd HH:mm}</div>
    
    <div class='header'>
        {(string.IsNullOrEmpty(logoBase64) ? "" : $"<img src='data:image/png;base64,{logoBase64}' alt='Logo'/>")}
        <div class='school-name'>Olukaradha Primary School</div>
        <div class='school-address'>Kandy Raod,Olukaradha,Kekirawa, Sri Lanka</div>
        <div class='school-address'>Tel: +94 76 2568 784 | Email: info@Olukaradhaprimary.lk</div>
        <div class='report-title'>{reportTitle}</div>
    </div>
    
    <div class='filter-info'>{filterInfo}</div>
    
    <table>
        <thead>
            <tr>
                <th>Student Name</th>
                <th>Reg No</th>
                <th>Class</th>
                <th>Date</th>
                <th>Status</th>
            </tr>
        </thead>
        <tbody>
            {tableRows}
        </tbody>
    </table>
    
    <div class='footer'>
        <p>This is a computer-generated report from Student Attendance Management System</p>
        <p>© {DateTime.Now.Year} Olukaradha Primary School - All Rights Reserved</p>
    </div>
</body>
</html>";

            return html;
        }
    }
}
    

