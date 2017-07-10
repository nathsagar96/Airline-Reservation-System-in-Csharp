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
    public partial class cancel_ticket : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public cancel_ticket()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            user_home up = new user_home();
            up.Show();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cs.Open();
            da.UpdateCommand = new SqlCommand("update booking set status='Cancelled' where booking_id = '"+booking_id.Text+"'",cs);
            da.UpdateCommand.ExecuteNonQuery();
            if (class1.Text == "Business")
            {
                da.UpdateCommand = new SqlCommand("update schedule set business_seat = business_seat +" + no_of_seats.Text + " where flight_id = '" + flight_id.Text + "'and date = '" + date.Text + "'", cs);
                da.UpdateCommand.ExecuteNonQuery();
            }
            else
            {
                da.UpdateCommand = new SqlCommand("update schedule set economy_seat = economy_seat +" + no_of_seats.Text + " where flight_id = '" + flight_id.Text + "'and date = '" + date.Text + "'", cs);
                da.UpdateCommand.ExecuteNonQuery();
            }
            cs.Close();
            MessageBox.Show("Ticket Cancelled");
        }

        private void search1_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from booking where booking_id = '" + booking_id.Text + "'and status='Reserved'", cs);
            ds.Clear();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Wrong Details");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                flight_id.Text = row.Cells["flight_id"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                class1.Text = row.Cells["ticket_type"].Value.ToString();
                no_of_seats.Text = row.Cells["no_of_passengers"].Value.ToString();
            }
        }
    }
}
