using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARS
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Enter Username / Password");
            }
            else
            { 
                if (username.Text == "admin" && password.Text =="admin")
                {
                    adminpage adm = new adminpage();
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid  Username / Password");
                    username.Clear();
                    password.Clear();
                }
            }
            }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
