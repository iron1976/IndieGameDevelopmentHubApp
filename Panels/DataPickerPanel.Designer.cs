namespace IndieGameDevelopmentHubApp.Panels
{
    partial class DataPickerPanel
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            SelectIdsButton = new Button();
            SelectedIdText = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.AutoGenerateColumns = false;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { gameIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, gameRatingDataGridViewTextBoxColumn, assetsDataGridViewTextBoxColumn, bugReportsDataGridViewTextBoxColumn, gameGenresDataGridViewTextBoxColumn, reviewsDataGridViewTextBoxColumn, testersAccessesDataGridViewTextBoxColumn, worksOnsDataGridViewTextBoxColumn });
            DataGridView.DataSource = gameBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.Location = new Point(24, 50);
            DataGridView.Name = "DataGridView";
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Size = new Size(907, 400);
            DataGridView.TabIndex = 0;
            DataGridView.CellMouseDown += DataGridView_CellMouseDown;
            DataGridView.SelectionChanged += DataGridViewSelected;
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
            // SelectIdsButton
            // 
            SelectIdsButton.Location = new Point(856, 456);
            SelectIdsButton.Name = "SelectIdsButton";
            SelectIdsButton.Size = new Size(75, 23);
            SelectIdsButton.TabIndex = 1;
            SelectIdsButton.Text = "Select Ids";
            SelectIdsButton.UseVisualStyleBackColor = true;
            SelectIdsButton.Click += SelectIdsClicked;
            // 
            // SelectedIdText
            // 
            SelectedIdText.AutoSize = true;
            SelectedIdText.Location = new Point(24, 456);
            SelectedIdText.Name = "SelectedIdText";
            SelectedIdText.Size = new Size(72, 15);
            SelectedIdText.TabIndex = 2;
            SelectedIdText.Text = "Selected Ids:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 5);
            label1.Name = "label1";
            label1.Size = new Size(230, 37);
            label1.TabIndex = 3;
            label1.Text = "Reference Picker";
            // 
            // DataPickerPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(SelectedIdText);
            Controls.Add(SelectIdsButton);
            Controls.Add(DataGridView);
            Name = "DataPickerPanel";
            Size = new Size(961, 518);
            Load += DataPickerPanelLoaded;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button SelectIdsButton;
        private Label SelectedIdText;
        private Label label1;
    }
}
