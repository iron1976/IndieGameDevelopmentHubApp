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


            int panelX = (this.ClientSize.Width - Panel.Width) / 2;
            Panel.Location = new Point(panelX, Panel.Location.Y);//Centering Tab Pages
            IndieGameDevelopmentHubApp.Program.print(TabControl.Location);



        }
        private void TabControl1_SelectedIndexChanged(object sender, TabControlCancelEventArgs e)
        {
            if (!this.ParentForm.Enabled)
            {
                e.Cancel = true;
                return;
            }
            main.print("parent is: " + this.ParentForm.Enabled);

            if (TabControl.SelectedTab == HomeTab)
            {
            }
            else if (TabControl.SelectedTab == ManageAccountTab)
            {
                OpenPanel(new ManageAccountPanel());
            }
            else if (TabControl.SelectedTab == DevelopersTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM DEVELOPERS", "SELECT * FROM DEVELOPER_FINANCES", "SELECT * FROM WORKS_ON"
                , "SELECT * FROM DeveloperFinanceView"});

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == TestersTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM TESTERS", "SELECT * FROM TESTERS_ACCESS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == PlayersTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM PLAYERS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == GamesTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM GAMES", "SELECT * FROM GAME_GENRES" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == AssetsTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM ASSETS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == ReviewsTab)
            {

                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM REVIEWS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == BugReportsTab)
            { 
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM BUG_REPORTS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == EventsTab)
            {
                var dataControl = new DataControlPanel(new string[] { "SELECT * FROM EVENTS" });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == RunSqlTab)
            {
                OpenPanel(new RunSQLPanel());
            }
            else if (TabControl.SelectedTab == LogOutTab)
            {
                
                DialogResult result = MessageBox.Show(
               "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    OpenLoginRegisterScreen();
                }
                else
                {
                    e.Cancel = true; 
                }
            }
        }
        private void OpenLoginRegisterScreen()
        {
            this.Controls.Clear();  
            this.Controls.Add(new LoginRegisterScreen());
        }
        void OpenPanel(Control controlPanel)
        {
            Panel.Controls.Clear();
            ManageAccountPanel uc = new();
            controlPanel.Dock = DockStyle.Fill;
            Panel.Controls.Add(controlPanel);
        }

    }
}
