namespace IndieGameDevelopmentHubApp
{
    partial class ManageAccountPanel
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
            UserIDText = new Label();
            label2 = new Label();
            NewFirstNameTextBox = new TextBox();
            NewLastNameTextBox = new TextBox();
            label3 = new Label();
            NewPasswordTextBox = new TextBox();
            label4 = new Label();
            Update = new Button();
            UserTypeText = new Label();
            IsLicensedCheckBox = new CheckBox();
            NewMailTextBox = new TextBox();
            label1 = new Label();
            MailText = new Label();
            FirstNameText = new Label();
            LastName = new Label();
            PasswordText = new Label();
            SuspendLayout();
            // 
            // UserIDText
            // 
            UserIDText.AccessibleRole = AccessibleRole.Text;
            UserIDText.AutoSize = true;
            UserIDText.BackColor = SystemColors.Control;
            UserIDText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            UserIDText.Location = new Point(19, 15);
            UserIDText.Name = "UserIDText";
            UserIDText.Size = new Size(156, 25);
            UserIDText.TabIndex = 4;
            UserIDText.Text = "Current User ID:";
            UserIDText.TextAlign = ContentAlignment.TopCenter;
            UserIDText.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 224);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "New First Name:";
            label2.Click += label2_Click_1;
            // 
            // NewFirstNameTextBox
            // 
            NewFirstNameTextBox.Location = new Point(19, 242);
            NewFirstNameTextBox.Name = "NewFirstNameTextBox";
            NewFirstNameTextBox.Size = new Size(151, 23);
            NewFirstNameTextBox.TabIndex = 7;
            // 
            // NewLastNameTextBox
            // 
            NewLastNameTextBox.Location = new Point(19, 286);
            NewLastNameTextBox.Name = "NewLastNameTextBox";
            NewLastNameTextBox.Size = new Size(151, 23);
            NewLastNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 268);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 8;
            label3.Text = "New Last Name:";
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.Location = new Point(19, 334);
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.Size = new Size(151, 23);
            NewPasswordTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 316);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 10;
            label4.Text = "New Password:";
            // 
            // Update
            // 
            Update.Location = new Point(103, 360);
            Update.Name = "Update";
            Update.Size = new Size(67, 23);
            Update.TabIndex = 12;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += UpdateButtonClicked;
            // 
            // UserTypeText
            // 
            UserTypeText.AccessibleRole = AccessibleRole.Text;
            UserTypeText.AutoSize = true;
            UserTypeText.BackColor = SystemColors.Control;
            UserTypeText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            UserTypeText.Location = new Point(19, 39);
            UserTypeText.Name = "UserTypeText";
            UserTypeText.Size = new Size(104, 25);
            UserTypeText.TabIndex = 13;
            UserTypeText.Text = "User Type:";
            UserTypeText.TextAlign = ContentAlignment.TopCenter;
            // 
            // IsLicensedCheckBox
            // 
            IsLicensedCheckBox.AutoSize = true;
            IsLicensedCheckBox.Location = new Point(19, 363);
            IsLicensedCheckBox.Name = "IsLicensedCheckBox";
            IsLicensedCheckBox.Size = new Size(80, 19);
            IsLicensedCheckBox.TabIndex = 14;
            IsLicensedCheckBox.Text = "IsLicensed";
            IsLicensedCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewMailTextBox
            // 
            NewMailTextBox.Location = new Point(19, 195);
            NewMailTextBox.Name = "NewMailTextBox";
            NewMailTextBox.Size = new Size(151, 23);
            NewMailTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 177);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 15;
            label1.Text = "New Email:";
            // 
            // MailText
            // 
            MailText.AccessibleRole = AccessibleRole.Text;
            MailText.AutoSize = true;
            MailText.BackColor = SystemColors.Control;
            MailText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            MailText.Location = new Point(19, 64);
            MailText.Name = "MailText";
            MailText.Size = new Size(64, 25);
            MailText.TabIndex = 17;
            MailText.Text = "Email:";
            MailText.TextAlign = ContentAlignment.TopCenter;
            // 
            // FirstNameText
            // 
            FirstNameText.AccessibleRole = AccessibleRole.Text;
            FirstNameText.AutoSize = true;
            FirstNameText.BackColor = SystemColors.Control;
            FirstNameText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            FirstNameText.Location = new Point(19, 89);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(112, 25);
            FirstNameText.TabIndex = 18;
            FirstNameText.Text = "First Name:";
            FirstNameText.TextAlign = ContentAlignment.TopCenter;
            // 
            // LastName
            // 
            LastName.AccessibleRole = AccessibleRole.Text;
            LastName.AutoSize = true;
            LastName.BackColor = SystemColors.Control;
            LastName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            LastName.Location = new Point(19, 114);
            LastName.Name = "LastName";
            LastName.Size = new Size(109, 25);
            LastName.TabIndex = 19;
            LastName.Text = "Last Name:";
            LastName.TextAlign = ContentAlignment.TopCenter;
            // 
            // PasswordText
            // 
            PasswordText.AccessibleRole = AccessibleRole.Text;
            PasswordText.AutoSize = true;
            PasswordText.BackColor = SystemColors.Control;
            PasswordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            PasswordText.Location = new Point(19, 139);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(102, 25);
            PasswordText.TabIndex = 20;
            PasswordText.Text = "Password:";
            PasswordText.TextAlign = ContentAlignment.TopCenter;
            // 
            // ManageAccountPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PasswordText);
            Controls.Add(LastName);
            Controls.Add(FirstNameText);
            Controls.Add(MailText);
            Controls.Add(NewMailTextBox);
            Controls.Add(label1);
            Controls.Add(IsLicensedCheckBox);
            Controls.Add(UserTypeText);
            Controls.Add(Update);
            Controls.Add(NewPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(NewLastNameTextBox);
            Controls.Add(label3);
            Controls.Add(NewFirstNameTextBox);
            Controls.Add(label2);
            Controls.Add(UserIDText);
            Name = "ManageAccountPanel";
            Size = new Size(961, 518);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label UserIDText;
        private Label label2;
        private TextBox NewFirstNameTextBox;
        private TextBox NewLastNameTextBox;
        private Label label3;
        private TextBox NewPasswordTextBox;
        private Label label4;
        private Button Update;
        private Label UserTypeText;
        private CheckBox IsLicensedCheckBox;
        private TextBox NewMailTextBox;
        private Label label1;
        private Label MailText;
        private Label FirstNameText;
        private Label LastName;
        private Label PasswordText;
    }
}
