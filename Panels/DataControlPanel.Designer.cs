
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
            OperationsText = new Label();
            label1 = new Label();
            DeleteTuppleButton = new Button();
            TabControl = new TabControl();
            TabPage1 = new TabPage();
            TabPage2 = new TabPage();
            TabPage3 = new TabPage();
            TabPage4 = new TabPage();
            TabPage5 = new TabPage();
            TabPage6 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).BeginInit();
            TabControl.SuspendLayout();
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
            DataGridView.Location = new Point(299, 41);
            DataGridView.Name = "DataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 5.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView.Size = new Size(645, 428);
            DataGridView.TabIndex = 1;
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
            // OperationsText
            // 
            OperationsText.AutoSize = true;
            OperationsText.Font = new Font("Segoe UI", 13F);
            OperationsText.Location = new Point(14, 17);
            OperationsText.Name = "OperationsText";
            OperationsText.Size = new Size(104, 25);
            OperationsText.TabIndex = 3;
            OperationsText.Text = "Operations:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "DataView:";
            // 
            // DeleteTuppleButton
            // 
            DeleteTuppleButton.Location = new Point(88, 177);
            DeleteTuppleButton.Name = "DeleteTuppleButton";
            DeleteTuppleButton.Size = new Size(117, 23);
            DeleteTuppleButton.TabIndex = 5;
            DeleteTuppleButton.Text = "Delete Tuple";
            DeleteTuppleButton.UseVisualStyleBackColor = true;
            DeleteTuppleButton.Click += DeleteTuppleButtonClicked;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabPage1);
            TabControl.Controls.Add(TabPage2);
            TabControl.Controls.Add(TabPage3);
            TabControl.Controls.Add(TabPage4);
            TabControl.Controls.Add(TabPage5);
            TabControl.Controls.Add(TabPage6);
            TabControl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.Location = new Point(299, 14);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(645, 27);
            TabControl.TabIndex = 6;
            TabControl.SelectedIndexChanged += TabControlSelectedIndexChanged;
            // 
            // TabPage1
            // 
            TabPage1.Location = new Point(4, 29);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(637, 0);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "tabPage1";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Location = new Point(4, 29);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(452, 0);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "tabPage2";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Location = new Point(4, 29);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(452, 0);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "tabPage3";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            TabPage4.Location = new Point(4, 29);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(452, 0);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "tabPage4";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // TabPage5
            // 
            TabPage5.Location = new Point(4, 29);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(452, 0);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "tabPage5";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // TabPage6
            // 
            TabPage6.Location = new Point(4, 29);
            TabPage6.Name = "TabPage6";
            TabPage6.Padding = new Padding(3);
            TabPage6.Size = new Size(452, 0);
            TabPage6.TabIndex = 5;
            TabPage6.Text = "tabPage6";
            TabPage6.UseVisualStyleBackColor = true;
            // 
            // DataControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabControl);
            Controls.Add(DeleteTuppleButton);
            Controls.Add(label1);
            Controls.Add(OperationsText);
            Controls.Add(SaveChangesButton);
            Controls.Add(DataGridView);
            Name = "DataControlPanel";
            Size = new Size(961, 518);
            Load += DataControlPanel_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)testerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)assetBindingSource).EndInit();
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label OperationsText;
        private Label label1;
        private Button DeleteTuppleButton;
        private TabControl TabControl;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private TabPage TabPage3;
        private TabPage TabPage4;
        private TabPage TabPage5;
        private TabPage TabPage6;
         
    }
}
