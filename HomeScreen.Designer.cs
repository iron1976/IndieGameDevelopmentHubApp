namespace IndieGameDevelopmentHubApp
{
    partial class HomeScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            TabControl = new TabControl();
            HomeTab = new TabPage();
            ManageAccountTab = new TabPage();
            DevelopersTab = new TabPage();
            TestersTab = new TabPage();
            PlayersTab = new TabPage();
            GamesTab = new TabPage();
            AssetsTab = new TabPage();
            ReviewsTab = new TabPage();
            BugReportsTab = new TabPage();
            EventsTab = new TabPage();
            RunSqlTab = new TabPage();
            LogOutTab = new TabPage();
            Panel = new Panel();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 588);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // TabControl
            // 
            TabControl.Controls.Add(HomeTab);
            TabControl.Controls.Add(ManageAccountTab);
            TabControl.Controls.Add(DevelopersTab);
            TabControl.Controls.Add(TestersTab);
            TabControl.Controls.Add(PlayersTab);
            TabControl.Controls.Add(GamesTab);
            TabControl.Controls.Add(AssetsTab);
            TabControl.Controls.Add(ReviewsTab);
            TabControl.Controls.Add(BugReportsTab);
            TabControl.Controls.Add(EventsTab);
            TabControl.Controls.Add(RunSqlTab);
            TabControl.Controls.Add(LogOutTab);
            TabControl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(0, 10);
            TabControl.Margin = new Padding(0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(979, 30);
            TabControl.TabIndex = 5;
            TabControl.Selecting += TabControl1_SelectedIndexChanged;
            // 
            // HomeTab
            // 
            HomeTab.Location = new Point(4, 32);
            HomeTab.Name = "HomeTab";
            HomeTab.Padding = new Padding(3);
            HomeTab.Size = new Size(971, 0);
            HomeTab.TabIndex = 10;
            HomeTab.Text = "Home";
            HomeTab.UseVisualStyleBackColor = true;
            // 
            // ManageAccountTab
            // 
            ManageAccountTab.Location = new Point(4, 32);
            ManageAccountTab.Name = "ManageAccountTab";
            ManageAccountTab.Padding = new Padding(3);
            ManageAccountTab.Size = new Size(971, 0);
            ManageAccountTab.TabIndex = 1;
            ManageAccountTab.Text = "Manage Account";
            ManageAccountTab.UseVisualStyleBackColor = true;
            // 
            // Developers
            // 
            DevelopersTab.Location = new Point(4, 32);
            DevelopersTab.Name = "Developers";
            DevelopersTab.Padding = new Padding(3);
            DevelopersTab.Size = new Size(971, 0);
            DevelopersTab.TabIndex = 11;
            DevelopersTab.Text = "Developers";
            DevelopersTab.UseVisualStyleBackColor = true;
            // 
            // TestersTab
            // 
            TestersTab.Location = new Point(4, 32);
            TestersTab.Name = "TestersTab";
            TestersTab.Padding = new Padding(3);
            TestersTab.Size = new Size(971, 0);
            TestersTab.TabIndex = 2;
            TestersTab.Text = "Testers";
            TestersTab.UseVisualStyleBackColor = true;
            // 
            // PlayersTab
            // 
            PlayersTab.Location = new Point(4, 32);
            PlayersTab.Name = "PlayersTab";
            PlayersTab.Padding = new Padding(3);
            PlayersTab.Size = new Size(971, 0);
            PlayersTab.TabIndex = 12;
            PlayersTab.Text = "Players";
            PlayersTab.UseVisualStyleBackColor = true;
            // 
            // GamesTab
            // 
            GamesTab.Location = new Point(4, 32);
            GamesTab.Name = "GamesTab";
            GamesTab.Padding = new Padding(3);
            GamesTab.Size = new Size(971, 0);
            GamesTab.TabIndex = 4;
            GamesTab.Text = "Games";
            GamesTab.UseVisualStyleBackColor = true;
            // 
            // AssetsTab
            // 
            AssetsTab.Location = new Point(4, 32);
            AssetsTab.Name = "AssetsTab";
            AssetsTab.Padding = new Padding(3);
            AssetsTab.Size = new Size(971, 0);
            AssetsTab.TabIndex = 5;
            AssetsTab.Text = "Assets";
            AssetsTab.UseVisualStyleBackColor = true;
            // 
            // ReviewsTab
            // 
            ReviewsTab.Location = new Point(4, 32);
            ReviewsTab.Name = "ReviewsTab";
            ReviewsTab.Padding = new Padding(3);
            ReviewsTab.Size = new Size(971, 0);
            ReviewsTab.TabIndex = 6;
            ReviewsTab.Text = "Reviews";
            ReviewsTab.UseVisualStyleBackColor = true;
            // 
            // BugReportsTab
            // 
            BugReportsTab.Location = new Point(4, 32);
            BugReportsTab.Name = "BugReportsTab";
            BugReportsTab.Padding = new Padding(3);
            BugReportsTab.Size = new Size(971, 0);
            BugReportsTab.TabIndex = 8;
            BugReportsTab.Text = "Bug Reports";
            BugReportsTab.UseVisualStyleBackColor = true;
            // 
            // EventsTab
            // 
            EventsTab.Location = new Point(4, 32);
            EventsTab.Name = "EventsTab";
            EventsTab.Padding = new Padding(3);
            EventsTab.Size = new Size(971, 0);
            EventsTab.TabIndex = 3;
            EventsTab.Text = "Events";
            EventsTab.UseVisualStyleBackColor = true;
            // 
            // RunSqlTab
            // 
            RunSqlTab.Location = new Point(4, 32);
            RunSqlTab.Name = "RunSqlTab";
            RunSqlTab.Padding = new Padding(3);
            RunSqlTab.Size = new Size(971, 0);
            RunSqlTab.TabIndex = 7;
            RunSqlTab.Text = "RunSQL    ";
            RunSqlTab.UseVisualStyleBackColor = true;
            // 
            // LogOutTab
            // 
            LogOutTab.Location = new Point(4, 32);
            LogOutTab.Name = "LogOutTab";
            LogOutTab.Padding = new Padding(3);
            LogOutTab.Size = new Size(971, 0);
            LogOutTab.TabIndex = 9;
            LogOutTab.Text = "Log Out";
            LogOutTab.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveBorder;
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Location = new Point(11, 43);
            Panel.Name = "Panel";
            Panel.Size = new Size(961, 518);
            Panel.TabIndex = 7;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel);
            Controls.Add(TabControl);
            Controls.Add(label2);
            Name = "HomeScreen";
            Size = new Size(986, 574);
            Load += HomeScreen_Load;
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TabControl TabControl;
        private TabPage EventsTab;
        private TabPage GamesTab;
        private TabPage AssetsTab;
        private TabPage ReviewsTab;
        private TabPage RunSqlTab;
        private TabPage BugReportsTab;
        private TabPage LogOutTab;
        private TabPage ManageAccountTab;
        private TabPage TestersTab;
        public Panel Panel;
        private TabPage HomeTab;
        private TabPage DevelopersTab;
        private TabPage PlayersTab;
    }
}
