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
            comboBox1 = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            RegisterError = new Label();
            LoginError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F);
            label1.Location = new Point(441, 69);
            label1.Name = "label1";
            label1.Size = new Size(195, 62);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // RegisterMailInput
            // 
            RegisterMailInput.Location = new Point(452, 163);
            RegisterMailInput.Name = "RegisterMailInput";
            RegisterMailInput.Size = new Size(195, 23);
            RegisterMailInput.TabIndex = 1;
            RegisterMailInput.TextChanged += textBox1_TextChanged;
            // 
            // RegisterPasswordInput
            // 
            RegisterPasswordInput.Location = new Point(452, 214);
            RegisterPasswordInput.Name = "RegisterPasswordInput";
            RegisterPasswordInput.Size = new Size(195, 23);
            RegisterPasswordInput.TabIndex = 2;
            RegisterPasswordInput.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(579, 243);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 3;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegisterButtonClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F);
            label2.Location = new Point(83, 69);
            label2.Name = "label2";
            label2.Size = new Size(143, 62);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Click += LoginButtonClicked;
            // 
            // LoginMailInput
            // 
            LoginMailInput.Location = new Point(83, 163);
            LoginMailInput.Name = "LoginMailInput";
            LoginMailInput.Size = new Size(195, 23);
            LoginMailInput.TabIndex = 5;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.Location = new Point(83, 223);
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.Size = new Size(195, 23);
            LoginPasswordInput.TabIndex = 6;
            LoginPasswordInput.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Developer", "Tester", "Player" });
            comboBox1.Location = new Point(452, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(203, 252);
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
            label3.Location = new Point(81, 145);
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
            label4.Location = new Point(81, 207);
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
            label5.Location = new Point(450, 147);
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
            label6.Location = new Point(448, 198);
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
            RegisterError.Location = new Point(452, 280);
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
            LoginError.Location = new Point(83, 280);
            LoginError.Name = "LoginError";
            LoginError.Size = new Size(73, 15);
            LoginError.TabIndex = 14;
            LoginError.Text = "*Error: asdds";
            LoginError.Visible = false;
            // 
            // LoginRegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginError);
            Controls.Add(RegisterError);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginMailInput);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(RegisterPasswordInput);
            Controls.Add(RegisterMailInput);
            Controls.Add(label1);
            Name = "LoginRegisterScreen";
            Text = "LoginRegisterScreen";
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
        private ComboBox comboBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label RegisterError;
        private Label LoginError;
    }
}