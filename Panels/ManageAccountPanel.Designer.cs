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
            label1 = new Label();
            _name = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Text;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 48);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 4;
            label1.Text = "You are Logged In As:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // _name
            // 
            _name.AccessibleDescription = "this is a label where the user name is diplayed";
            _name.AccessibleName = "User_Name";
            _name.AccessibleRole = AccessibleRole.Text;
            _name.AutoSize = true;
            _name.Location = new Point(160, 48);
            _name.Name = "_name";
            _name.Size = new Size(44, 15);
            _name.TabIndex = 5;
            _name.Text = "_Name";
            _name.TextAlign = ContentAlignment.TopCenter;
            _name.Click += Label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 120);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "new First Name:";
            label2.Click += label2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 186);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "new Last Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 264);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 10;
            label4.Text = "new Password:";
            // 
            // button5
            // 
            button5.Location = new Point(29, 354);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // ManageAccountPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(_name);
            Controls.Add(label1);
            Name = "ManageAccountPanel";
            Size = new Size(961, 518);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label _name;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button5;
    }
}
