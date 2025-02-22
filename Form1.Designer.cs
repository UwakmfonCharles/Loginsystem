namespace Loginsystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            button_exit = new Button();
            button_login = new Button();
            button_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(179, 31);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome\r\n";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(125, 159);
            label.Name = "label";
            label.Size = new Size(75, 20);
            label.TabIndex = 1;
            label.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 210);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(227, 210);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(151, 27);
            txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(227, 159);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(151, 27);
            txt_username.TabIndex = 4;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(56, 347);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(100, 50);
            button_exit.TabIndex = 5;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_login
            // 
            button_login.Location = new Point(257, 267);
            button_login.Name = "button_login";
            button_login.Size = new Size(121, 47);
            button_login.TabIndex = 6;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(148, 267);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(103, 47);
            button_clear.TabIndex = 7;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            ClientSize = new Size(501, 454);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(button_exit);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(label);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label;
        private Label label2;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button button_exit;
        private Button button_login;
        private Button button_clear;
    }
}