namespace IndieGameDevelopmentHubApp
{
    partial class LoginRegisterScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            RegisterMailInput = new TextBox();
            RegisterPasswordInput = new TextBox();
            button1 = new Button();
            label2 = new Label();
            LoginMailInput = new TextBox();
            LoginPasswordInput = new TextBox();
            UserTypeBox = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            RegisterError = new Label();
            LoginError = new Label();
            label7 = new Label();
            RegisterCompleteText = new TextBox();
            label8 = new Label();
            RegisterFirstNameInput = new TextBox();
            RegisterLastNameInput = new TextBox();
            label9 = new Label();
            IsLicensedCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(556, 81);
            label1.Name = "label1";
            label1.Size = new Size(195, 62);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // RegisterMailInput
            // 
            RegisterMailInput.Location = new Point(562, 258);
            RegisterMailInput.MaxLength = 14;
            RegisterMailInput.Name = "RegisterMailInput";
            RegisterMailInput.Size = new Size(195, 23);
            RegisterMailInput.TabIndex = 1;
            // 
            // RegisterPasswordInput
            // 
            RegisterPasswordInput.Location = new Point(562, 309);
            RegisterPasswordInput.Name = "RegisterPasswordInput";
            RegisterPasswordInput.Size = new Size(195, 23);
            RegisterPasswordInput.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(689, 342);
            button1.Name = "button1";
            button1.Size = new Size(68, 43);
            button1.TabIndex = 3;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegisterButtonClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F);
            label2.Location = new Point(169, 81);
            label2.Name = "label2";
            label2.Size = new Size(143, 62);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Click += LoginButtonClicked;
            // 
            // LoginMailInput
            // 
            LoginMailInput.Location = new Point(169, 172);
            LoginMailInput.Name = "LoginMailInput";
            LoginMailInput.Size = new Size(195, 23);
            LoginMailInput.TabIndex = 5;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.Location = new Point(169, 214);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(195, 23);
            LoginPasswordInput.TabIndex = 6;
            // 
            // UserTypeBox
            // 
            UserTypeBox.FormattingEnabled = true;
            UserTypeBox.Items.AddRange(new object[] { "Developer", "Player", "Tester" });
            UserTypeBox.Location = new Point(562, 361);
            UserTypeBox.Name = "UserTypeBox";
            UserTypeBox.Size = new Size(121, 23);
            UserTypeBox.TabIndex = 7;
            UserTypeBox.Text = "Developer";
            UserTypeBox.SelectedIndexChanged += UserTypeBoxChanged;
            // 
            // button2
            // 
            button2.Location = new Point(289, 243);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += LoginButtonClicked;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 155);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Mail:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 199);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(562, 241);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 11;
            label5.Text = "Mail:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(562, 292);
            label6.Margin = new Padding(0, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 12;
            label6.Text = "Password:";
            // 
            // RegisterError
            // 
            RegisterError.AutoSize = true;
            RegisterError.ForeColor = Color.FromArgb(128, 64, 64);
            RegisterError.Location = new Point(690, 394);
            RegisterError.Name = "RegisterError";
            RegisterError.Size = new Size(61, 15);
            RegisterError.TabIndex = 13;
            RegisterError.Text = "*Error: asd";
            RegisterError.Visible = false;
            // 
            // LoginError
            // 
            LoginError.AutoSize = true;
            LoginError.ForeColor = Color.FromArgb(128, 64, 64);
            LoginError.Location = new Point(169, 266);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(73, 15);
            LoginError.TabIndex = 14;
            LoginError.Text = "*Error: asdds";
            LoginError.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(562, 343);
            label7.Margin = new Padding(0, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 15;
            label7.Text = "User Type:";
            // 
            // RegisterCompleteText
            // 
            RegisterCompleteText.BorderStyle = BorderStyle.None;
            RegisterCompleteText.Font = new Font("Segoe UI", 15F);
            RegisterCompleteText.Location = new Point(556, 423);
            RegisterCompleteText.Multiline = true;
            RegisterCompleteText.Name = "RegisterCompleteText";
            RegisterCompleteText.ReadOnly = true;
            RegisterCompleteText.Size = new Size(286, 133);
            RegisterCompleteText.TabIndex = 17;
            RegisterCompleteText.TabStop = false;
            RegisterCompleteText.Text = "Your mail: \\n your password";
            RegisterCompleteText.Visible = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(562, 155);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 18;
            label8.Text = "First Name";
            // 
            // RegisterFirstNameInput
            // 
            RegisterFirstNameInput.Location = new Point(562, 172);
            RegisterFirstNameInput.Name = "RegisterFirstNameInput";
            RegisterFirstNameInput.Size = new Size(195, 23);
            RegisterFirstNameInput.TabIndex = 19;
            // 
            // RegisterLastNameInput
            // 
            RegisterLastNameInput.Location = new Point(562, 214);
            RegisterLastNameInput.Name = "RegisterLastNameInput";
            RegisterLastNameInput.Size = new Size(195, 23);
            RegisterLastNameInput.TabIndex = 20;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(562, 199);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 21;
            label9.Text = "Last Name";
            // 
            // IsLicensedCheckBox
            // 
            IsLicensedCheckBox.AutoSize = true;
            IsLicensedCheckBox.Location = new Point(562, 394);
            IsLicensedCheckBox.Name = "IsLicensedCheckBox";
            IsLicensedCheckBox.Size = new Size(80, 19);
            IsLicensedCheckBox.TabIndex = 22;
            IsLicensedCheckBox.Text = "IsLicensed";
            IsLicensedCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginRegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IsLicensedCheckBox);
            Controls.Add(label9);
            Controls.Add(RegisterLastNameInput);
            Controls.Add(RegisterFirstNameInput);
            Controls.Add(label8);
            Controls.Add(RegisterCompleteText);
            Controls.Add(label7);
            Controls.Add(LoginError);
            Controls.Add(RegisterError);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(UserTypeBox);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginMailInput);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(RegisterPasswordInput);
            Controls.Add(RegisterMailInput);
            Controls.Add(label1);
            Name = "LoginRegisterScreen";
            Size = new Size(986, 574);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RegisterMailInput;
        private TextBox RegisterPasswordInput;
        private Button button1;
        private Label label2;
        private TextBox LoginMailInput;
        private TextBox LoginPasswordInput;
        private ComboBox UserTypeBox;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label RegisterError;
        private Label LoginError;
        private Label label7;
        private TextBox RegisterCompleteText;
        private Label label8;
        private TextBox RegisterFirstNameInput;
        private TextBox RegisterLastNameInput;
        private Label label9;
        private CheckBox IsLicensedCheckBox;
    }
}