namespace Loginsystem
{
    partial class formfeedback
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
            textBox_feedback = new TextBox();
            label2 = new Label();
            button_clear = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(646, 50);
            label1.TabIndex = 0;
            label1.Text = "Hello Member,\r\nCan you please leave feedback on this system below, It would help our leisure centre a lot!\r\n";
            label1.Click += label1_Click;
            // 
            // textBox_feedback
            // 
            textBox_feedback.Location = new Point(8, 122);
            textBox_feedback.Name = "textBox_feedback";
            textBox_feedback.Size = new Size(646, 23);
            textBox_feedback.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 99);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 2;
            label2.Text = "Please leave your feedback here:";
            label2.Click += label2_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(8, 151);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(97, 32);
            button_clear.TabIndex = 3;
            button_clear.Text = "Submit";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(8, 189);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(97, 36);
            button_exit.TabIndex = 4;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button1_Click;
            // 
            // formfeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 296);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(label2);
            Controls.Add(textBox_feedback);
            Controls.Add(label1);
            Name = "formfeedback";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_feedback;
        private Label label2;
        private Button button_clear;
        private Button button_exit;
    }
}