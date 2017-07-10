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
    public partial class previous_booking : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public previous_booking()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //check input
            if (booking_id.Text == "")
            {
                MessageBox.Show("Enter The Booking Id");
            }
            else
            {
                //search Booking Info
                da.SelectCommand = new SqlCommand("select * from booking where booking_id ='" + booking_id.Text + "'", cs);
                cs.Open();
                ds.Clear();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Not Details In Database");
                }
                cs.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            user_home userpage = new user_home();
            userpage.Show();
            this.Hide();
        }

        private void first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgb();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dgb();
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dgb();
        }

        private void last_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dgb();
        }
        private void dgb()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[bs.Position].Selected = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            previous_booking pb = new previous_booking();
            pb.Show();
            this.Hide();
        }

        private void previous_booking_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from booking", cs);
            ds.Clear();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }
    }
}
