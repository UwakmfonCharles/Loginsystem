namespace Loginsystem
{
    partial class formlessons
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
            button1 = new Button();
            button2_exit = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 37);
            button1.Name = "button1";
            button1.Size = new Size(1005, 87);
            button1.TabIndex = 0;
            button1.Text = "Lessons Timetable";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2_exit
            // 
            button2_exit.Location = new Point(68, 626);
            button2_exit.Name = "button2_exit";
            button2_exit.Size = new Size(107, 38);
            button2_exit.TabIndex = 1;
            button2_exit.Text = "Exit";
            button2_exit.UseVisualStyleBackColor = true;
            button2_exit.Click += button2_exit_Click;
            // 
            // formlessons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FitnessScheduleTemplate;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1121, 691);
            Controls.Add(button2_exit);
            Controls.Add(button1);
            Name = "formlessons";
            Text = "Lessons";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2_exit;
    }
}