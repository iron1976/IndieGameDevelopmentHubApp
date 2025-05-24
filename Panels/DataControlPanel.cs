using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using main = IndieGameDevelopmentHubApp.Program;


namespace IndieGameDevelopmentHubApp.Panels
{
    public partial class DataControlPanel : UserControl
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;

        public DataControlPanel(string sqlCommandText)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(main.connectionString);
            conn.Open();

            adapter = new SqlDataAdapter(sqlCommandText, conn);
             
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataGridView.DataSource = dataTable;
            DataGridView.Columns.Clear();
            DataGridView.AutoGenerateColumns = true;
            DataGridView.Refresh();
        }

        private void DataControlPanel_Load(object sender, EventArgs e)
        {
        }

        private void SaveChangesButtonClicked(object sender, EventArgs e)
        {
            adapter.Update(dataTable);

        }

        private void DataGridViewClicked(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewSelected(object sender, EventArgs e)
        {
            if (DataGridView.CurrentCell != null)
            {
                int row = DataGridView.CurrentCell.RowIndex;
                int col = DataGridView.CurrentCell.ColumnIndex;
                var value = DataGridView.CurrentCell.Value;

                main.print($"New selection: " + DataGridView.CurrentCell.OwningColumn.Name);
            }

        }
    }
}
