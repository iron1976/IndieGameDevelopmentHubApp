using IndieGameDevelopmentHubApp.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndieGameDevelopmentHubApp
{
    public partial class DataPickerForm : Form
    {
        public DataPickerForm(string sqlCommandText, List<decimal> selectedIds, bool isMultiline)
        {
            InitializeComponent();
            OpenDataPickerPanel(sqlCommandText, selectedIds, isMultiline);
        }
        private void OpenDataPickerPanel(string sqlCommandText, List<decimal> selectedIds, bool isMultiline)
        {
            DataPickerPanel dataPickerPanel = new DataPickerPanel(sqlCommandText, selectedIds, isMultiline);
            dataPickerPanel.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(dataPickerPanel);
            dataPickerPanel.BringToFront();
        }
    }
}
