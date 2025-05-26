using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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

        public SqlDataAdapter Adapter;
        public DataTable DataTable;  
        string[] SQLCommandText;
        public DataControlPanel(string[] sqlCommandText)
        {
            InitializeComponent();
            this.SQLCommandText = sqlCommandText;
            
            for(int j = TabControl.TabPages.Count-1; j >= 0; j--)  
                if(j < sqlCommandText.Length)
                {
                    TabControl.TabPages[j].Text = sqlCommandText[j].Substring(sqlCommandText[j].LastIndexOf(' ')+1).Replace('_', ' ');    
                }
                else
                    TabControl.TabPages.RemoveAt(j); 
                
                
            SelectSQLData(0);

        }

        public void SelectSQLData(int index)
        {
            DataGridView.Columns.Clear();
            DataGridView.AutoGenerateColumns = true;
            DataGridView.Refresh();
            SqlConnection conn = new SqlConnection(main.connectionString);
            conn.Open();
            Adapter = new SqlDataAdapter(SQLCommandText[index], conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);

            DataTable = new DataTable();
            Adapter.Fill(DataTable);
            DataGridView.DataSource = DataTable;

        }
        private bool IsLoaded = false;
        public void DataControlPanel_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
        }
        private void SaveChangesButtonClicked(object sender, EventArgs e)
        {
            this.Adapter.Update(this.DataTable);
        } 
        private void DataGridViewSelected(object sender, EventArgs e)
        {
            if (!IsLoaded || !this.ParentForm.Enabled)
                return;
           if (DataGridView.CurrentCell != null)
           {
               int row = DataGridView.CurrentCell.RowIndex;
               int col = DataGridView.CurrentCell.ColumnIndex;
               var value = DataGridView.CurrentCell.Value;
           
               main.print($"New selection: " + DataGridView.CurrentCell.OwningColumn.Name);
           
               if (DataGridView.CurrentCell.OwningColumn.Name.Contains("ID"))
               {
                   this.ParentForm.Enabled = false;
                   DataPickerForm dataPickerForm = new DataPickerForm("SELECT * FROM DEVELOPERS");
                   dataPickerForm.FormClosed += (x,y) => {

                       int rowIndex = DataGridView.CurrentCell.RowIndex;
                       DataGridView.CurrentCell.Selected = false;
                       DataGridView.Rows[rowIndex].Cells[0].Selected = true;

                       this.ParentForm.Enabled = true; 
                   
                   };
                   dataPickerForm.Show();
               }
           
           }

        }
         

        private void DeleteTuppleButtonClicked(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            (DataGridView.CurrentRow.DataBoundItem as DataRowView).Row.Delete();
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        { 
            SelectSQLData((byte)TabControl.SelectedIndex); 
        }
    }
}
