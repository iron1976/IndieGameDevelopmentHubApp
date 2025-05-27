namespace IndieGameDevelopmentHubApp
{
    partial class StatisticsPanel
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
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BugReportsBarChart = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 42);
            label1.Name = "label1";
            label1.Size = new Size(177, 60);
            label1.TabIndex = 0;
            label1.Text = "Top Rated Game: \r\nGame 1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(71, 101);
            progressBar1.Maximum = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(113, 23);
            progressBar1.Step = 50;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 102);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "3.64/5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 149);
            label3.Name = "label3";
            label3.Size = new Size(218, 30);
            label3.TabIndex = 3;
            label3.Text = "Most Reviewed Game:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 179);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 4;
            label4.Text = "Total of 24 reviews!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 32);
            label5.TabIndex = 5;
            label5.Text = "Game Statistics";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 225);
            label6.Name = "label6";
            label6.Size = new Size(226, 30);
            label6.TabIndex = 6;
            label6.Text = "Liked Genres Pie Chart:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(270, 83);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 348);
            label8.Name = "label8";
            label8.Size = new Size(222, 30);
            label8.TabIndex = 8;
            label8.Text = "Bug Reports Bar Chart:";
            // 
            // BugReportsBarChart
            // 
            BugReportsBarChart.Location = new Point(388, 179);
            BugReportsBarChart.Name = "BugReportsBarChart";
            BugReportsBarChart.Size = new Size(475, 296);
            BugReportsBarChart.TabIndex = 9;
            // 
            // StatisticsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BugReportsBarChart);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Name = "StatisticsPanel";
            Size = new Size(961, 518);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel BugReportsBarChart;
    }
}
