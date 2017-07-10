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
    public partial class schedule_flight : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        BindingSource bs = new BindingSource();
        BindingSource bs1 = new BindingSource();
        public schedule_flight()
        {
            InitializeComponent();
            date.MinDate = DateTime.Now.Date;
            date.MaxDate = DateTime.Now.AddDays(30).Date;
        }

        private void schedule_flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet2.flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.airlineDataSet2.flights);

            da.SelectCommand = new SqlCommand("select * from schedule", cs);
            ds.Clear();
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;

            da.SelectCommand = new SqlCommand("select * from flights where flight_id='" + flight_id.Text + "'", cs);
            da.Fill(ds1);
            bs1.DataSource = ds1.Tables[0];

            business_seat.DataBindings.Add("text", bs1, "business_seat");
            economy_seat.DataBindings.Add("text", bs1, "economy_seat");
            business_seat.Clear();
            economy_seat.Clear();
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminpage admin_obj = new adminpage();
            admin_obj.Show();
            this.Hide();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            schedule_flight refresh = new schedule_flight();
            refresh.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {

            da.InsertCommand = new SqlCommand("insert into schedule values('"+date.Text+"','"+flight_id.Text+"',"+business_seat.Text+","+economy_seat.Text+",'"+status.Text+"')",cs);
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            MessageBox.Show("Entry Done");
        }

        private void flight_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds1.Clear();
            da.SelectCommand = new SqlCommand("select * from flights where flight_id='" + flight_id.Text + "'", cs);
            da.Fill(ds1);
            bs1.DataSource = ds1.Tables[0];
        }
    }
}
