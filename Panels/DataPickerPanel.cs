using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

using main = IndieGameDevelopmentHubApp.Program;

namespace IndieGameDevelopmentHubApp.Panels
{
    public partial class DataPickerPanel : UserControl
    {
        public string SQLCommandText;
        private bool IsUserInteracted = false;
        public DataPickerPanel(string sqlCommandText)
        {
            InitializeComponent();
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.MultiSelect = true;
            this.SQLCommandText = sqlCommandText;
            InitializeSQLData();
            ClearSelection();
        }
        private void InitializeSQLData()
        {
            DataGridView.Columns.Clear();
            DataGridView.AutoGenerateColumns = true;
            DataGridView.Refresh();
            SqlConnection conn = new SqlConnection(main.connectionString);
            conn.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommandText, conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);

            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            DataGridView.DataSource = dataTable;
        }
        private void DataGridViewSelected(object sender, EventArgs e)
        {
            if (!IsUserInteracted)
                return;
            SelectedIdText.Text = "Selected Ids:";
            main.print("DATA: " + DataGridView.SelectedCells.Count + " " + DataGridView.ColumnCount); 

            for (int j = (DataGridView.SelectedCells.Count / DataGridView.ColumnCount) - 1; j >= 0; j--)
            {
                main.print("COUNTER: " + j);
                var val = DataGridView.Rows[DataGridView.SelectedCells[(int)j * DataGridView.ColumnCount].RowIndex].Cells[0].Value;
                if (val != null)
                    SelectedIdText.Text += DataGridView.Rows[DataGridView.SelectedCells[(int)j * DataGridView.ColumnCount].RowIndex].Cells[0].Value.ToString() + " ";
                

            }

            if (DataGridView.CurrentCell != null)
            {
                int row = DataGridView.CurrentCell.RowIndex;
                int col = DataGridView.CurrentCell.ColumnIndex;
                var value = DataGridView.CurrentCell.Value;

                //main.print($"New selectionTR: " + DataGridView.Rows[DataGridView.SelectedCells[0].ColumnIndex].Cells[0].Value.ToString()); 

                ///if(DataGridView.CurrentCell.OwningColumn.Name.Contains("ID"))
            }
        }

        private void DataPickerPanelLoaded(object sender, EventArgs e)
        {
            ClearSelection();
        }
        private void ClearSelection()
        {
            DataGridView.CurrentCell = null;
            DataGridView.ClearSelection();
        } 

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            IsUserInteracted = true;
        }

        private void SelectIdsClicked(object sender, EventArgs e)
        {
            this.ParentForm.Close(); 
        }
    }
}
