using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARS
{
    public partial class login : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public login()
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
                //Search User
                cs.Open();
                da.SelectCommand = new SqlCommand("select username,password from users where username = '" + username.Text + "' and password = '" + password.Text + "'", cs);
                da.Fill(ds);
                cs.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    user_home user = new user_home();
                    user.Show();
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
