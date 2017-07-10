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
using System.Text.RegularExpressions;

namespace ARS
{
    public partial class registration : Form
    {
        
        public registration()
        {
            InitializeComponent();
        }
        public  bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            cs.Open();
            da.SelectCommand = new SqlCommand("select username,password from users where username = '"+username.Text+"'",cs);
            da.Fill(ds);

            //Check if user Already present
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Username Taken\nSelect Different Username");
            }
            else
            {
                //match passowrd
                if (password.Text == password1.Text)
                {
                    da.InsertCommand = new SqlCommand("insert into users values(@username,@password,@email,@phone)", cs);
                    da.InsertCommand.Parameters.Add("username", SqlDbType.VarChar).Value = username.Text;
                    da.InsertCommand.Parameters.Add("password", SqlDbType.VarChar).Value = password.Text;
                    da.InsertCommand.Parameters.Add("email", SqlDbType.VarChar).Value = email.Text;
                    da.InsertCommand.Parameters.Add("phone", SqlDbType.VarChar).Value = phone.Text;
                    da.InsertCommand.ExecuteNonQuery();

                    //Check user creation
                    ds.Clear();
                    da.SelectCommand = new SqlCommand("select * from users where username = '" + username.Text + "'", cs);
                    da.Fill(ds);
                    if(ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Successfully Registered");
                        login lgn = new login();
                        lgn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registration Failed");
                        cs.Close();
                    }
                }
                else {
                    MessageBox.Show("Password Doesnt Match.\nRetry");
                    password.Clear();
                    password1.Clear();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            ad.Show();
            this.Hide();
        }
    }
}
