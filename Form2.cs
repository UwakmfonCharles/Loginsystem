using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginsystem
{
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void menuform_Load(object sender, EventArgs e)
        {

        }

        private void button_booking_Click(object sender, EventArgs e)
        {
            Form F2 = new formbooking();
            F2.Show();
        }

        private void button_lessons_Click(object sender, EventArgs e)
        {
            Form F2 = new formlessons();
            F2.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to log out", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            Form F2 = new formfeedback();
            F2.Show();
            
        }
    }
}
