namespace IndieGameDevelopmentHubApp.Panels
{
    partial class DataControlPanel
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
            testerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registerDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isLicensedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bugReportsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            testersAccessesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            testerBindingSource = new BindingSource(components);
            assetBindingSource = new BindingSource(components);
            SaveChangesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AutoGenerateColumns = false;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { testerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, registerDateDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, isLicensedDataGridViewTextBoxColumn, bugReportsDataGridViewTextBoxColumn, testersAccessesDataGridViewTextBoxColumn });
            DataGridView.DataSource = testerBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridView.Location = new Point(299, 57);
            DataGridView.Name = "DataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 5.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.Size = new Size(645, 412);
            DataGridView.TabIndex = 1;
            DataGridView.CellContentClick += DataGridViewClicked;
            DataGridView.SelectionChanged += DataGridViewSelected;
            // 
            // testerIdDataGridViewTextBoxColumn
            // 
            testerIdDataGridViewTextBoxColumn.DataPropertyName = "TesterId";
            testerIdDataGridViewTextBoxColumn.HeaderText = "TesterId";
            testerIdDataGridViewTextBoxColumn.Name = "testerIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // registerDateDataGridViewTextBoxColumn
            // 
            registerDateDataGridViewTextBoxColumn.DataPropertyName = "RegisterDate";
            registerDateDataGridViewTextBoxColumn.HeaderText = "RegisterDate";
            registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // isLicensedDataGridViewTextBoxColumn
            // 
            isLicensedDataGridViewTextBoxColumn.DataPropertyName = "IsLicensed";
            isLicensedDataGridViewTextBoxColumn.HeaderText = "IsLicensed";
            isLicensedDataGridViewTextBoxColumn.Name = "isLicensedDataGridViewTextBoxColumn";
            // 
            // bugReportsDataGridViewTextBoxColumn
            // 
            bugReportsDataGridViewTextBoxColumn.DataPropertyName = "BugReports";
            bugReportsDataGridViewTextBoxColumn.HeaderText = "BugReports";
            bugReportsDataGridViewTextBoxColumn.Name = "bugReportsDataGridViewTextBoxColumn";
            // 
            // testersAccessesDataGridViewTextBoxColumn
            // 
            testersAccessesDataGridViewTextBoxColumn.DataPropertyName = "TestersAccesses";
            testersAccessesDataGridViewTextBoxColumn.HeaderText = "TestersAccesses";
            testersAccessesDataGridViewTextBoxColumn.Name = "testersAccessesDataGridViewTextBoxColumn";
            // 
            // testerBindingSource
            // 
            testerBindingSource.DataSource = typeof(Models.Tester);
            // 
            // assetBindingSource
            // 
            assetBindingSource.DataSource = typeof(Models.Asset);
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(147, 422);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(128, 23);
            SaveChangesButton.TabIndex = 2;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButtonClicked;
            // 
            // DataControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveChangesButton);
            Controls.Add(DataGridView);
            Name = "DataControlPanel";
            Size = new Size(961, 518);
            Load += DataControlPanel_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private BindingSource assetBindingSource;
        private DataGridViewTextBoxColumn testerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isLicensedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bugReportsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn testersAccessesDataGridViewTextBoxColumn;
        private BindingSource testerBindingSource;
        private Button SaveChangesButton;
    }
}
