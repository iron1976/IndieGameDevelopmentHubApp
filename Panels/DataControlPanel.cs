using IndieGameDevelopmentHubApp.Models;
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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

using main = IndieGameDevelopmentHubApp.Program;


namespace IndieGameDevelopmentHubApp.Panels
{
    public partial class DataControlPanel : UserControl
    {

        public SqlDataAdapter Adapter;
        public DataTable DataTable;
        (string, Dictionary<string, string>)[] SQLCommandText;
        bool IsUserInteracted = false;
        string[] PrimaryKeys;
        public DataControlPanel((string, Dictionary<string, string>)[] sqlCommandText)
        {
            InitializeComponent();
            this.SQLCommandText = sqlCommandText;

            for (int j = TabControl.TabPages.Count - 1; j >= 0; j--)
                if (j < sqlCommandText.Length)
                    TabControl.TabPages[j].Text = sqlCommandText[j].Item1.Substring(sqlCommandText[j].Item1.LastIndexOf(' ') + 1).Replace('_', ' ');
                else
                    TabControl.TabPages.RemoveAt(j);

            SelectSQLData(0);

        }

        public void SelectSQLData(int index)
        {
            IsUserInteracted = false;
            DataGridView.Columns.Clear();
            DataGridView.AutoGenerateColumns = true;
            DataGridView.Refresh();
            SqlConnection conn = new SqlConnection(main.connectionString);
            conn.Open();
            Adapter = new SqlDataAdapter(SQLCommandText[index].Item1, conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(Adapter);

            DataTable = new DataTable();
            Adapter.Fill(DataTable);
            DataGridView.DataSource = DataTable;
            GetPrimaryKeys();
            DataGridView.CurrentCell = null;
            FormatDateTimeColumns(DataGridView, main.DateFormat);
        }
        private void GetPrimaryKeys()
        {

            using (var context = new IndieGameDevelopmentHubContext()) 
            {
                var entityTypes = context.Model.GetEntityTypes();

                foreach (var entityType in entityTypes)
                {
                    string str1 = entityType.ClrType.Name;
                    string str2 = TabControl.SelectedTab.Text.Replace(" ", "");
                    string str3 = str2.Substring(0, str2.Length - 1);
                    main.print("DATAA " + str1 + " " + str2 + "  " + str3);
                    if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase) || str1.Equals(str3, StringComparison.OrdinalIgnoreCase))
                    {
                        main.print($"Entity: {entityType.ClrType.Name}" + " " + TabControl.SelectedTab.Text.Replace(" ", ""));

                        var primaryKey = entityType.FindPrimaryKey();
                        if (primaryKey != null)
                        {
                            PrimaryKeys = new string[primaryKey.Properties.Count];
                            for (int j = 0; j < PrimaryKeys.Length; j++)
                            {
                                PrimaryKeys[j] = primaryKey.Properties.ElementAt(j).Name;
                                main.print($" - Primary Key: {PrimaryKeys[j]}");
                            }
                        }
                        else
                        {
                            main.print("No primary keys");
                        }
                    }


                }
            }
            if (PrimaryKeys.Length == 1)
                PrimaryKeysTitle.Text = "Primary Key:";
            else
                PrimaryKeysTitle.Text = "Composite Key:";
            PrimaryKeyRichText.Text = "";
            foreach (var item in PrimaryKeys)
            {
                PrimaryKeyRichText.Text += item + "\n";
            }
        }
        private bool IsLoaded = false;
        public void DataControlPanel_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
        }
        private void SaveChangesButtonClicked(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to save all changes?",
                "Save Changes?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
                try
                {
                    this.Adapter.Update(this.DataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the database:\n\n{ex.Message}",
                                    "Update Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
        }

        private void RevertChangesButtonClicked(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to revert all unsaved changes?",
                "Confirm Revert",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                this.DataTable.RejectChanges();
            }
        }
        private void DataGridViewSelected(object sender, EventArgs e)
        {
            if (!IsLoaded || !this.ParentForm.Enabled || !IsUserInteracted)
                return;


            if (DataGridView.CurrentCell != null)
            {
                int row = DataGridView.CurrentCell.RowIndex;
                int col = DataGridView.CurrentCell.ColumnIndex;
                var value = DataGridView.CurrentCell.Value;

                main.print($"New selection: " + DataGridView.CurrentCell.OwningColumn.Name);


                if (DataGridView.CurrentCell.OwningColumn.Name.Contains("ID"))
                {
                    if (SQLCommandText[TabControl.SelectedIndex].Item2 == null)
                        return;

                    if (SQLCommandText[TabControl.SelectedIndex].Item2.TryGetValue(DataGridView.CurrentCell.OwningColumn.Name, out string val))
                    {



                        //this.ParentForm.Enabled = false;
                        List<decimal> selectedIds = new List<decimal>();
                        DataPickerForm dataPickerForm = new DataPickerForm(val, selectedIds, PrimaryKeys.Length == 1 ? false : true);
                        dataPickerForm.FormClosed += (x, y) =>
                        {

                            IsUserInteracted = false;
                            this.ParentForm.Enabled = true;
                            if (selectedIds != null && selectedIds.Count > 0)
                            {
                                DataGridView.CurrentCell.Value = selectedIds[0];
                                main.print("DATA: " + selectedIds[0]);
                                if (selectedIds.Count > 1)
                                    for (uint j = 0; j < selectedIds.Count; j++)
                                    {

                                        DataRowView boundItem = DataGridView.CurrentRow.DataBoundItem as DataRowView;
                                        DataRow sourceRow = boundItem.Row;

                                        DataRow clonedRow = DataTable.NewRow();

                                        clonedRow.ItemArray = sourceRow.ItemArray.Clone() as object[]; // Clone the row  
                                        clonedRow[DataGridView.CurrentCell.OwningColumn.Name] = selectedIds[(int)j];

                                        // Add to the same DataGridView
                                        DataTable.Rows.Add(clonedRow);

                                    }
                            }
                            DataGridView.CurrentCell = null;

                        };
                        dataPickerForm.Show();
                    }
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

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsUserInteracted = true;
        }

        private void FormatDateTimeColumns(DataGridView dgv, string format = "yyyy-MM-dd HH:mm:ss")
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.ValueType == typeof(DateTime))
                {
                    col.DefaultCellStyle.Format = format;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddTupleButtonClicked(object sender, EventArgs e)
        { 
            DataRow clonedRow = DataTable.NewRow();

            if (DataTable.Rows.Count > 0)
            {
                DataRow sourceRow = DataTable.Rows[DataTable.Rows.Count - 1];
                clonedRow.ItemArray = sourceRow.ItemArray.Clone() as object[]; // Clone the row  
                clonedRow[PrimaryKeys[0]] = (decimal)sourceRow[PrimaryKeys[0]] + 1;
            }
             
            DataTable.Rows.Add(clonedRow);
        }
    }
}
