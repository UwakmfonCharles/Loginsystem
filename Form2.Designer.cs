namespace Loginsystem
{
    partial class menuform
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
            button_lessons = new Button();
            button_booking = new Button();
            button_feedback = new Button();
            label1 = new Label();
            button_logout = new Button();
            SuspendLayout();
            // 
            // button_lessons
            // 
            button_lessons.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_lessons.Location = new Point(112, 80);
            button_lessons.Margin = new Padding(3, 2, 3, 2);
            button_lessons.Name = "button_lessons";
            button_lessons.Size = new Size(122, 74);
            button_lessons.TabIndex = 0;
            button_lessons.Text = "Lessons";
            button_lessons.UseVisualStyleBackColor = true;
            button_lessons.Click += button_lessons_Click;
            // 
            // button_booking
            // 
            button_booking.Location = new Point(112, 166);
            button_booking.Margin = new Padding(3, 2, 3, 2);
            button_booking.Name = "button_booking";
            button_booking.Size = new Size(122, 72);
            button_booking.TabIndex = 1;
            button_booking.Text = "Book Lesson";
            button_booking.UseVisualStyleBackColor = true;
            button_booking.Click += button_booking_Click;
            // 
            // button_feedback
            // 
            button_feedback.Location = new Point(112, 256);
            button_feedback.Margin = new Padding(3, 2, 3, 2);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(125, 85);
            button_feedback.TabIndex = 2;
            button_feedback.Text = "Leave Feedback";
            button_feedback.UseVisualStyleBackColor = true;
            button_feedback.Click += button_feedback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 3;
            label1.Text = "MENU";
            // 
            // button_logout
            // 
            button_logout.Location = new Point(276, 315);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(75, 23);
            button_logout.TabIndex = 4;
            button_logout.Text = "Log Out";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 350);
            Controls.Add(button_logout);
            Controls.Add(label1);
            Controls.Add(button_feedback);
            Controls.Add(button_booking);
            Controls.Add(button_lessons);
            Name = "menuform";
            Text = "Menu";
            Load += menuform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_lessons;
        private Button button_booking;
        private Button button_feedback;
        private Label label1;
        private Button button_logout;
    }
}