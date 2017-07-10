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
    public partial class search : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public search()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            user_home userpage = new user_home();
            userpage.Show();
            this.Hide();
        }

        private void search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDataSet3.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter1.Fill(this.airlineDataSet3.airports);
            // TODO: This line of code loads data into the 'airlineDataSet.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.airlineDataSet.airports);

        }

        private void search1_Click(object sender, EventArgs e)
        {
            //check input
            if (source.Text == "" || destination.Text =="" || date.Text =="")
            {
                MessageBox.Show("Please select source, destination and date");
            }
            else
            {
                //search Flight Info
                da.SelectCommand = new SqlCommand("select a.flight_id,a.source,a.destination,a.airline,b.date,b.status from flights a inner join schedule b on a.flight_id = b.flight_id where source = '"+source.Text+"' and destination='"+destination.Text+"' and date ='"+date.Text+"'", cs);
                cs.Open();
                ds.Clear();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No Flight available");
                }
                cs.Close();
            }
        }
    }
}
