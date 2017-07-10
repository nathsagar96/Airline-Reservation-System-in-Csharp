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
    public partial class detail : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        string book_id;
        public detail(string book_id)
        {
            InitializeComponent();
            this.book_id = book_id;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("insert into passenger values(@booking_id,@passenger_name,@gender)",cs);
            da.InsertCommand.Parameters.Add("booking_id",SqlDbType.VarChar).Value = book_id;
            da.InsertCommand.Parameters.Add("passenger_name", SqlDbType.VarChar).Value = name.Text;
            da.InsertCommand.Parameters.Add("gender", SqlDbType.VarChar).Value = gender.Text;
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
            this.Hide();
        }
    }
}
