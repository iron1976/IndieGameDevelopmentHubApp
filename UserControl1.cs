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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            TESTY form2 = new TESTY();

            this.panel1.Controls.Clear();   // Clear previous control
            form2.Dock = DockStyle.Fill;     // Fill the panel
            this.panel1.Controls.Add(form2);   // Add new one 
        }
    }
}
