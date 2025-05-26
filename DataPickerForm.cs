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
        public DataPickerForm(string sqlCommandText)
        {
            InitializeComponent();
            OpenDataPickerPanel(sqlCommandText);
        }
        private void OpenDataPickerPanel(string sqlCommandText)
        {
            DataPickerPanel dataPickerPanel = new DataPickerPanel(sqlCommandText);
            dataPickerPanel.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(dataPickerPanel);
            dataPickerPanel.BringToFront();
        }
    }
}
