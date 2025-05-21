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
    public partial class LoginRegisterScreen : Form
    {
        public LoginRegisterScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButtonClicked(object sender, EventArgs e)
        { 
            this.RegisterError.Visible = true;
        }

        private void LoginButtonClicked(object sender, EventArgs e)
        {
            
            this.LoginError.Visible = true;
            OpenHomeScreen();

        }
        private void OpenHomeScreen()
        {
            UserControl1 form2 = new UserControl1(); 

            this.Controls.Clear();   // Clear previous control
            form2.Dock = DockStyle.Fill;     // Fill the panel
            this.Controls.Add(form2);   // Add new one
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
