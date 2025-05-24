namespace IndieGameDevelopmentHubApp.Panels
{
    partial class LogOutPanel
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(373, 219);
            button1.Name = "button1";
            button1.Size = new Size(212, 23);
            button1.TabIndex = 0;
            button1.Text = "Log Out From This Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogOutPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "LogOutPanel";
            Size = new Size(961, 518);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
