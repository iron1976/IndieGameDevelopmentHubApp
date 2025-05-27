namespace IndieGameDevelopmentHubApp.Panels
{
    partial class RunSQLPanel
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            RunSQLInput = new RichTextBox();
            DataGridView = new DataGridView();
            gameIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameRatingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            assetsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bugReportsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameGenresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reviewsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            testersAccessesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            worksOnsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gameBindingSource = new BindingSource(components);
            TabControl = new TabControl();
            DataGridTabPage1 = new TabPage();
            DataGridTabPage2 = new TabPage();
            ExecuteButton = new Button();
            SQLResultsText = new RichTextBox();
            tabControl1 = new TabControl();
            RunSQLTextTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).BeginInit();
            TabControl.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // RunSQLInput
            // 
            RunSQLInput.Location = new Point(47, 45);
            RunSQLInput.Name = "RunSQLInput";
            RunSQLInput.Size = new Size(817, 175);
            RunSQLInput.TabIndex = 0;
            RunSQLInput.Text = "SELECT * FROM EVENTS";
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AutoGenerateColumns = false;
            DataGridView.BackgroundColor = Color.Gray;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, gameRatingDataGridViewTextBoxColumn, assetsDataGridViewTextBoxColumn, bugReportsDataGridViewTextBoxColumn, gameGenresDataGridViewTextBoxColumn, reviewsDataGridViewTextBoxColumn, testersAccessesDataGridViewTextBoxColumn, worksOnsDataGridViewTextBoxColumn });
            DataGridView.DataSource = gameBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.Location = new Point(141, 45);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(817, 214);
            DataGridView.TabIndex = 1;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            gameIdDataGridViewTextBoxColumn.DataPropertyName = "GameId";
            gameIdDataGridViewTextBoxColumn.HeaderText = "GameId";
            gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // gameRatingDataGridViewTextBoxColumn
            // 
            gameRatingDataGridViewTextBoxColumn.DataPropertyName = "GameRating";
            gameRatingDataGridViewTextBoxColumn.HeaderText = "GameRating";
            gameRatingDataGridViewTextBoxColumn.Name = "gameRatingDataGridViewTextBoxColumn";
            // 
            // assetsDataGridViewTextBoxColumn
            // 
            assetsDataGridViewTextBoxColumn.DataPropertyName = "Assets";
            assetsDataGridViewTextBoxColumn.HeaderText = "Assets";
            assetsDataGridViewTextBoxColumn.Name = "assetsDataGridViewTextBoxColumn";
            // 
            // bugReportsDataGridViewTextBoxColumn
            // 
            bugReportsDataGridViewTextBoxColumn.DataPropertyName = "BugReports";
            bugReportsDataGridViewTextBoxColumn.HeaderText = "BugReports";
            bugReportsDataGridViewTextBoxColumn.Name = "bugReportsDataGridViewTextBoxColumn";
            // 
            // gameGenresDataGridViewTextBoxColumn
            // 
            gameGenresDataGridViewTextBoxColumn.DataPropertyName = "GameGenres";
            gameGenresDataGridViewTextBoxColumn.HeaderText = "GameGenres";
            gameGenresDataGridViewTextBoxColumn.Name = "gameGenresDataGridViewTextBoxColumn";
            // 
            // reviewsDataGridViewTextBoxColumn
            // 
            reviewsDataGridViewTextBoxColumn.DataPropertyName = "Reviews";
            reviewsDataGridViewTextBoxColumn.HeaderText = "Reviews";
            reviewsDataGridViewTextBoxColumn.Name = "reviewsDataGridViewTextBoxColumn";
            // 
            // testersAccessesDataGridViewTextBoxColumn
            // 
            testersAccessesDataGridViewTextBoxColumn.DataPropertyName = "TestersAccesses";
            testersAccessesDataGridViewTextBoxColumn.HeaderText = "TestersAccesses";
            testersAccessesDataGridViewTextBoxColumn.Name = "testersAccessesDataGridViewTextBoxColumn";
            // 
            // worksOnsDataGridViewTextBoxColumn
            // 
            worksOnsDataGridViewTextBoxColumn.DataPropertyName = "WorksOns";
            worksOnsDataGridViewTextBoxColumn.HeaderText = "WorksOns";
            worksOnsDataGridViewTextBoxColumn.Name = "worksOnsDataGridViewTextBoxColumn";
            // 
            // gameBindingSource
            // 
            gameBindingSource.DataSource = typeof(Models.Game);
            // 
            // TabControl
            // 
            TabControl.Controls.Add(DataGridTabPage1);
            TabControl.Controls.Add(DataGridTabPage2);
            TabControl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(47, 243);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(200, 29);
            TabControl.TabIndex = 2;
            TabControl.SelectedIndexChanged += TabControlSelectedIndexChanged;
            // 
            // DataGridTabPage1
            // 
            DataGridTabPage1.Location = new Point(4, 29);
            DataGridTabPage1.Name = "DataGridTabPage1";
            DataGridTabPage1.Padding = new Padding(3);
            DataGridTabPage1.Size = new Size(192, 0);
            DataGridTabPage1.TabIndex = 0;
            DataGridTabPage1.Text = "Data Grid";
            DataGridTabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridTabPage2
            // 
            DataGridTabPage2.Location = new Point(4, 29);
            DataGridTabPage2.Name = "DataGridTabPage2";
            DataGridTabPage2.Padding = new Padding(3);
            DataGridTabPage2.Size = new Size(192, 0);
            DataGridTabPage2.TabIndex = 1;
            DataGridTabPage2.Text = "Text";
            DataGridTabPage2.UseVisualStyleBackColor = true;
            // 
            // ExecuteButton
            // 
            ExecuteButton.Location = new Point(783, 226);
            ExecuteButton.Name = "ExecuteButton";
            ExecuteButton.Size = new Size(81, 23);
            ExecuteButton.TabIndex = 4;
            ExecuteButton.Text = "Execute(F5)";
            ExecuteButton.UseVisualStyleBackColor = true;
            ExecuteButton.Click += ExecuteButton_Click;
            // 
            // SQLResultsText
            // 
            SQLResultsText.BackColor = SystemColors.ActiveCaption;
            SQLResultsText.BorderStyle = BorderStyle.FixedSingle;
            SQLResultsText.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SQLResultsText.Location = new Point(47, 274);
            SQLResultsText.Name = "SQLResultsText";
            SQLResultsText.ReadOnly = true;
            SQLResultsText.Size = new Size(817, 214);
            SQLResultsText.TabIndex = 5;
            SQLResultsText.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RunSQLTextTab);
            tabControl1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(48, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 24);
            tabControl1.TabIndex = 6;
            // 
            // RunSQLTextTab
            // 
            RunSQLTextTab.Location = new Point(4, 29);
            RunSQLTextTab.Name = "RunSQLTextTab";
            RunSQLTextTab.Padding = new Padding(3);
            RunSQLTextTab.Size = new Size(192, 0);
            RunSQLTextTab.TabIndex = 1;
            RunSQLTextTab.Text = "RunSQL:";
            RunSQLTextTab.UseVisualStyleBackColor = true;
            // 
            // RunSQLPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(ExecuteButton);
            Controls.Add(TabControl);
            Controls.Add(DataGridView);
            Controls.Add(RunSQLInput);
            Controls.Add(SQLResultsText);
            Name = "RunSQLPanel";
            Size = new Size(961, 518);
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).EndInit();
            TabControl.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox RunSQLInput;
        private DataGridView DataGridView;
        private DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gameRatingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn assetsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bugReportsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gameGenresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reviewsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn testersAccessesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn worksOnsDataGridViewTextBoxColumn;
        private BindingSource gameBindingSource;
        private TabControl TabControl;
        private TabPage DataGridTabPage1;
        private TabPage DataGridTabPage2;
        private Button ExecuteButton;
        private RichTextBox SQLResultsText;
        private TabControl tabControl1;
        private TabPage RunSQLTextTab;
    }
}
