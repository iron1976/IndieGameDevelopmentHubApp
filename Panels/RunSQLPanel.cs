using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using main = IndieGameDevelopmentHubApp.Program;
using System.Windows.Forms.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IndieGameDevelopmentHubApp.Panels
{
    public partial class RunSQLPanel : UserControl
    {
        public RunSQLPanel()
        {
            InitializeComponent();
            LoadSqlDataToGrid();
            DataGridView.Location = new Point(47, 272);
        }
        private void LoadSqlDataToGrid()
        {
            string query = "SELECT * FROM GAMES";

            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(main.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(table);
            }

            DataGridView.DataSource = table;
        }
        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab.Text == "Data Grid")
            {
                SQLResultsText.Enabled = false;
                SQLResultsText.Visible = false;
                DataGridView.Enabled = true;
                DataGridView.Visible = true;

            }
            else if (TabControl.SelectedTab.Text == "Text")
            {
                SQLResultsText.Enabled = true;
                SQLResultsText.Visible = true;
                DataGridView.Enabled = false;
                DataGridView.Visible = false; 
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            DataGridView.Columns.Clear();
            DataGridView.AutoGenerateColumns = true;
            DataGridView.Refresh();
            string sqlQuery = RunSQLInput.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(main.connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    DataGridView.DataSource = resultTable;

                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Prepare to hold all rows in memory to calculate column widths
                    List<string[]> rows = new List<string[]>();
                    int columnCount = reader.FieldCount;
                    int[] columnWidths = new int[columnCount];

                    // Store headers and initialize column widths
                    string[] headers = new string[columnCount];
                    for (int i = 0; i < columnCount; i++)
                    {
                        headers[i] = reader.GetName(i);
                        columnWidths[i] = headers[i].Length;
                    }

                    // Read data and calculate max widths
                    while (reader.Read())
                    {
                        string[] row = new string[columnCount];
                        for (int i = 0; i < columnCount; i++)
                        {
                            string value = reader[i]?.ToString() ?? "";
                            row[i] = value;
                            if (value.Length > columnWidths[i])
                                columnWidths[i] = value.Length;
                        }
                        rows.Add(row);
                    }

                    // Build output string
                    StringBuilder result = new StringBuilder();

                    // Add headers
                    for (int i = 0; i < columnCount; i++)
                    {
                        result.Append(headers[i].PadRight(columnWidths[i] + 2));
                    }
                    result.AppendLine();

                    // Add separator line
                    for (int i = 0; i < columnCount; i++)
                    {
                        result.Append(new string('-', columnWidths[i]) + "  ");
                    }
                    result.AppendLine();

                    // Add data rows
                    foreach (var row in rows)
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            result.Append(row[i].PadRight(columnWidths[i] + 2));
                        }
                        result.AppendLine();
                    }

                    SQLResultsText.Text = result.ToString();
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
