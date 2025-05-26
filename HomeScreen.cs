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
        public readonly Dictionary<string,string> DataReferences = new Dictionary<string, string>()
        { 
            { "PlayerID", "SELECT * FROM GAMES" },
            { "TesterID", "SELECT * FROM TESTERS" },
            { "DevID", "SELECT * FROM DEVELOPERS" },
            { "GameID", "SELECT * FROM GAMES" } 
        };
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
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM DEVELOPERS", null),

                    ("SELECT * FROM WORKS_ON", new[] { "DevID", "GameID" }
                        .ToDictionary(key => key, key => DataReferences[key])),

                    ("SELECT * FROM DEVELOPER_FINANCES", new[] { "DevID" }
                        .ToDictionary(key => key, key => DataReferences[key])),

                    ("SELECT * FROM DeveloperFinanceView", null),
                });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == TestersTab)
            { 
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM TESTERS", null),

                    ("SELECT * FROM TESTERS_ACCESS", new[] { "GameID", "TesterID" }
                        .ToDictionary(key => key, key => DataReferences[key])),
                });
                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == PlayersTab)
            { 
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM PLAYERS", null), 
                });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == GamesTab)
            { 
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM GAMES", null),
                    ("SELECT * FROM GAME_GENRES", new[] { "GameID" }
                        .ToDictionary(key => key, key => DataReferences[key])),
                });
                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == AssetsTab)
            { 
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                { 
                    ("SELECT * FROM ASSETS",  new[] { "GameID", "DevID" }
                        .ToDictionary(key => key, key => DataReferences[key])),
                });
                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == ReviewsTab)
            {

                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                { 
                    ("SELECT * FROM REVIEWS",  new[] { "PlayerID", "GameID" }
                        .ToDictionary(key => key, key => DataReferences[key])),
                });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == BugReportsTab)
            {
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM BUG_REPORTS",  new[] { "GameID", "TesterID" }
                        .ToDictionary(key => key, key => DataReferences[key])),
                });

                OpenPanel(dataControl);
            }
            else if (TabControl.SelectedTab == EventsTab)
            {
                var dataControl = new DataControlPanel(new (string, Dictionary<string, string>)[]
                {
                    ("SELECT * FROM EVENTS",  null)
                });

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
