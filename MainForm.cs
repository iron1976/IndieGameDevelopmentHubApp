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
    public partial class MainForm : Form
    {
        public Action<object, KeyEventArgs> OnKeyDown = (x, y) => { };
        public Action<object, KeyEventArgs> OnKeyUp = (x, y) => { };
        public MainForm()
        {
            InitializeComponent();
            OpenLoginRegisterPanel();
        }
        private void OpenLoginRegisterPanel()
        {
            LoginRegisterScreen panel = new();

            this.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) => OnKeyDown(sender, e);
        private void MainForm_KeyUp(object sender, KeyEventArgs e) => OnKeyUp(sender, e);
    }
}
