namespace Loginsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if ((txt_username.Text.Equals("grace")) && (txt_password.Text.Equals("grace123")))
            {
                Form F2 = new menuform();
                F2.Show();
                this.Hide();

                MessageBox.Show("Login Successful");
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password is not correct");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
                
            }
            else
            {
                this.Show();
            }
        }
    }
}