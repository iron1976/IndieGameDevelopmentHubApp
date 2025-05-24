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
using main = IndieGameDevelopmentHubApp.Program;

namespace IndieGameDevelopmentHubApp
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen() => InitializeComponent();  
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - TabControl.Width) / 2;
            TabControl.Location = new Point(x, TabControl.Location.Y);//Centering Tab Pages
            IndieGameDevelopmentHubApp.Program.print(TabControl.Location);



        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            if (TabControl.SelectedTab == HomeTab)
            {
            }
            else if (TabControl.SelectedTab == ManageAccountTab)
            { 
                OpenPanel(new ManageAccountPanel());
            }
            else if (TabControl.SelectedTab == TestersTab)
            {

                var dataControl = new DataControlPanel("SELECT * FROM ASSETS");
                
                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == ReviewsTab)
            {
            }
            else if (TabControl.SelectedTab == GamesTab)
            {
            }
            else if (TabControl.SelectedTab == BugReportsTab)
            {
            }
            else if (TabControl.SelectedTab == EventsTab)
            {
            }
            else if (TabControl.SelectedTab == RunSqlTab)
            {
                OpenPanel(new RunSQLPanel());
            }
            else if (TabControl.SelectedTab == LogOutTab)
            {
                OpenPanel(new LogOutPanel());
            }
        } 
        void OpenPanel(Control controlPanel)
        { 
            ManageAccountPanel uc = new();
            controlPanel.Dock = DockStyle.Fill;
            Panel.Controls.Add(controlPanel);
        }

    }
}
