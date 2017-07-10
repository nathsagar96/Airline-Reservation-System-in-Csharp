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
    public partial class view_flight : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        public view_flight()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminpage admin_obj = new adminpage();
            admin_obj.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //check input
            if (search_flight_id.Text == "")
            {
                MessageBox.Show("Enter The Flight Id");
            }
            else
            {
                //search Flight Info
                da.SelectCommand = new SqlCommand("select * from flights where flight_id ='" + search_flight_id.Text + "'", cs);
                cs.Open();
                ds.Clear();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Flight Not Found In Database");
                }
                cs.Close();
            }
        }

        private void dgb()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[bs.Position].Selected = true;
        }

        private void first_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
            dgb();
        }

        private void view_flight_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from flights", cs);
            ds.Clear();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
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

        private void reset_Click(object sender, EventArgs e)
        {
            view_flight view_obj = new view_flight();
            view_obj.Show();
            this.Hide();
        }
    }
}