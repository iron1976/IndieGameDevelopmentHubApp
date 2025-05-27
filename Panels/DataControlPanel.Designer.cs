
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
            DeleteTupleButton = new Button();
            TabControl = new TabControl();
            TabPage1 = new TabPage();
            TabPage2 = new TabPage();
            TabPage3 = new TabPage();
            TabPage4 = new TabPage();
            TabPage5 = new TabPage();
            TabPage6 = new TabPage();
            panel1 = new Panel();
            AddTupleButton = new Button();
            RevertChangesButton = new Button();
            tabControl1 = new TabControl();
            OperationsTextTab = new TabPage();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).BeginInit();
            TabControl.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
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
            DataGridView.Location = new Point(173, 41);
            DataGridView.Name = "DataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 5.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.Size = new Size(771, 458);
            DataGridView.TabIndex = 1;
            DataGridView.CellMouseDown += DataGridView_CellMouseDown;
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
            SaveChangesButton.Location = new Point(5, 92);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(128, 23);
            SaveChangesButton.TabIndex = 2;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButtonClicked;
            // 
            // DeleteTupleButton
            // 
            DeleteTupleButton.Location = new Point(5, 34);
            DeleteTupleButton.Name = "DeleteTupleButton";
            DeleteTupleButton.Size = new Size(128, 23);
            DeleteTupleButton.TabIndex = 5;
            DeleteTupleButton.Text = "Delete Tuple";
            DeleteTupleButton.UseVisualStyleBackColor = true;
            DeleteTupleButton.Click += DeleteTuppleButtonClicked;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(TabPage2);
            TabControl.Controls.Add(TabPage3);
            TabControl.Controls.Add(TabPage4);
            TabControl.Controls.Add(TabPage5);
            TabControl.Controls.Add(TabPage6);
            TabControl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(173, 15);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(771, 27);
            TabControl.TabIndex = 6;
            TabControl.SelectedIndexChanged += TabControlSelectedIndexChanged;
            // 
            // TabPage1
            // 
            TabPage1.Location = new Point(4, 29);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(763, 0);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "tabPage1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Location = new Point(4, 29);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(763, 0);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "tabPage2";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Location = new Point(4, 29);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(763, 0);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "tabPage3";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            TabPage4.Location = new Point(4, 29);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(763, 0);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "tabPage4";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // TabPage5
            // 
            TabPage5.Location = new Point(4, 29);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(763, 0);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "tabPage5";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // TabPage6
            // 
            TabPage6.Location = new Point(4, 29);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(763, 0);
            TabPage6.TabIndex = 5;
            TabPage6.Text = "tabPage6";
            TabPage6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AddTupleButton);
            panel1.Controls.Add(RevertChangesButton);
            panel1.Controls.Add(DeleteTupleButton);
            panel1.Controls.Add(SaveChangesButton);
            panel1.Location = new Point(14, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 120);
            panel1.TabIndex = 7;
            // 
            // AddTupleButton
            // 
            AddTupleButton.Location = new Point(5, 5);
            AddTupleButton.Name = "AddTupleButton";
            AddTupleButton.Size = new Size(128, 23);
            AddTupleButton.TabIndex = 7;
            AddTupleButton.Text = "Add Tuple";
            AddTupleButton.UseVisualStyleBackColor = true;
            AddTupleButton.Click += AddTupleButtonClicked;
            // 
            // RevertChangesButton
            // 
            RevertChangesButton.Location = new Point(5, 63);
            RevertChangesButton.Name = "RevertChangesButton";
            RevertChangesButton.Size = new Size(128, 23);
            RevertChangesButton.TabIndex = 6;
            RevertChangesButton.Text = "Revert Changes";
            RevertChangesButton.UseVisualStyleBackColor = true;
            RevertChangesButton.Click += RevertChangesButtonClicked;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(OperationsTextTab);
            tabControl1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(13, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(146, 26);
            tabControl1.TabIndex = 8;
            // 
            // OperationsTextTab
            // 
            OperationsTextTab.BackColor = Color.Gray;
            OperationsTextTab.Location = new Point(4, 29);
            OperationsTextTab.Name = "OperationsTextTab";
            OperationsTextTab.Padding = new Padding(3);
            OperationsTextTab.Size = new Size(138, 0);
            OperationsTextTab.TabIndex = 1;
            OperationsTextTab.Text = "Operations:";
            // 
            // DataControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(TabControl);
            Controls.Add(DataGridView);
            Controls.Add(panel1);
            Name = "DataControlPanel";
            Size = new Size(961, 518);
            Load += DataControlPanel_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).EndInit();
            TabControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
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
        private Button DeleteTupleButton;
        private TabControl TabControl;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private TabPage TabPage3;
        private TabPage TabPage4;
        private TabPage TabPage5;
        private TabPage TabPage6;
        private Panel panel1;
        private Button RevertChangesButton;
        private TabControl tabControl1;
        private TabPage OperationsTextTab;
        private Button AddTupleButton;
    }
}
