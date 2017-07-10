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
    public partial class book : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
       
        public book()
        {
            InitializeComponent();
            date.MinDate = DateTime.Now.Date;
            date.MaxDate = DateTime.Now.AddDays(30).Date;
        }

        private void back_Click(object sender, EventArgs e)
        {
            user_home uh = new user_home();
            uh.Show();
            this.Hide();
        }

        private void book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet5.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter1.Fill(this.airlineDataSet5.airports);
            // TODO: This line of code loads data into the 'airlineDataSet4.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.airlineDataSet4.airports);

        }

        private void search_flight_Click(object sender, EventArgs e)
        {
            if (source.Text == "" || destination.Text == "" || date.Text == "" || no_of_seats.Text == "" || class1.Text =="")
            {
                MessageBox.Show("Please select source, destination, no of seats, class and date");
            }
            else
            {
                //search Flight Info
                da.SelectCommand = new SqlCommand("select a.flight_id,a.source,a.destination,a.airline,a.arrival,a.departure,a.duration,b.date,b.business_seat,a.business_fare,b.economy_seat,a.economy_fare,b.status from flights a inner join schedule b on a.flight_id = b.flight_id where source = '" + source.Text + "' and destination='" + destination.Text + "' and date ='" + date.Text + "'", cs);
                cs.Open();
                ds.Clear();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    flight_info.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Flight available");
                }
                cs.Close();
            }
        }

        private void book1_Click(object sender, EventArgs e)
        {
            if (flight_id1.Text != "")
            {
                booking bk = new booking(flight_id1.Text, date.Text, no_of_seats.Text, class1.Text);
                bk.Show();
            }
            else
            {
                MessageBox.Show("Please Select Flight First");
            }
        }

        private void flight_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
                {
                DataGridViewRow row = this.flight_info.Rows[e.RowIndex];
                flight_id1.Text = row.Cells["flight_id"].Value.ToString();
            }
        }
    }
}
