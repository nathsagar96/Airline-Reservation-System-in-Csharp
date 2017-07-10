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
    public partial class add_flight : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        
        public add_flight()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            cs.Open();
            da.SelectCommand = new SqlCommand("select flight_id from flights where flight_id = '" + flight_id.Text + "'", cs);
            DataSet cnt = new DataSet();
            da.Fill(cnt);

            //check if flight is already available
            if (cnt.Tables[0].Rows.Count > 0)
            {
                //error
                MessageBox.Show("Flight Information Already Present");
                cs.Close();
            }
            else
            {

                //check source and destination
                if (source.Text == destination.Text)
                {
                    MessageBox.Show("Source And Destination Cannot be Same");
                }
                else
                {
                    //insert data
                    da.InsertCommand = new SqlCommand("insert into flights values('" + flight_id.Text + "','" + source.Text + "','" + destination.Text + "','" + airline.Text + "','" + arrival.Text + "','" + departure.Text + "','" + duration.Text + "'," + business_seat.Text + "," + business_fare.Text + "," + economy_seat.Text + "," + economy_fare.Text + ")", cs);
                    da.InsertCommand.ExecuteNonQuery();
                    cnt.Clear();

                    //check success
                    da.SelectCommand = new SqlCommand("select flight_id from flights where flight_id = '" + flight_id.Text + "'", cs);
                    da.Fill(cnt);

                    if (cnt.Tables[0].Rows.Count == 0)
                    {
                        //error
                        MessageBox.Show("Couldn't Add Flight Information");
                    }
                    else
                    {
                        //success
                        MessageBox.Show("Flight Information Successfully Added\nGo Back and Check it out");
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            adminpage admin_obj = new adminpage();
            admin_obj.Show();
            this.Hide();
        }

        private void add_flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet1.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter1.Fill(this.airlineDataSet1.airports);
            // TODO: This line of code loads data into the 'airlineDataSet.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.airlineDataSet.airports);
        }
    }
}