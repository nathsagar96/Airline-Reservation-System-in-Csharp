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
    public partial class delete_flight : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public delete_flight()
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

        private void delete_flight_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from flights", cs);
            ds.Clear();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                flight_id.Text = row.Cells["flight_id"].Value.ToString();
                source.Text = row.Cells["source"].Value.ToString();
                destination.Text = row.Cells["destination"].Value.ToString();
                airline.Text = row.Cells["airline"].Value.ToString();
                departure.Text = row.Cells["departure"].Value.ToString();
                arrival.Text = row.Cells["arrival"].Value.ToString();
                duration.Text = row.Cells["duration"].Value.ToString();
                business_seat.Text = row.Cells["business_seat"].Value.ToString();
                business_fare.Text = row.Cells["business_fare"].Value.ToString();
                economy_seat.Text = row.Cells["economy_seat"].Value.ToString();
                economy_fare.Text = row.Cells["economy_fare"].Value.ToString();
            }
        }

        private void delet_Click(object sender, EventArgs e)
        {
            cs.Open();
            da.DeleteCommand = new SqlCommand("delete from flights where flight_id = '" + flight_id.Text + "'", cs);
            da.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show("Flight Information Deleted");
            cs.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            delete_flight reset = new delete_flight();
            reset.Show();
            this.Hide();
        }
    }
}
