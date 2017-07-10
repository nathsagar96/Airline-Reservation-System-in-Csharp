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
using System.Net;
using System.Net.Mail;
using System.Web;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SmsClient;

namespace ARS
{
    public partial class booking : Form
    {
        SqlConnection cs = new SqlConnection("server = A555LA\\SQLEXPRESS;initial catalog = airline; integrated security = true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        BindingSource bs = new BindingSource();
        BindingSource bs1 = new BindingSource();
        string fid, nos, dte,cls;
        public booking(string fid,string dte,string nos,string cls)
        {
            InitializeComponent();
            this.fid = fid;
            this.nos = nos;
            this.dte = dte;
            this.cls = cls;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cal_fare_Click(object sender, EventArgs e)
        {
            total_fare.Text = (int.Parse(no_of_seats.Text) * int.Parse(fare.Text)).ToString();
        }

        private void print_Click(object sender, EventArgs e)
        {
            //passenger details
            da.SelectCommand = new SqlCommand("select passenger_name,gender from passenger where booking_id = '" + booking_id.Text + "'", cs);
            ds2.Clear();
            da.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

            //generate pdf
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Ticket.pdf", FileMode.Create));
            doc.Open();
            Paragraph pr = new Paragraph("Booking Details\nBooking ID: " + booking_id.Text +
                "\nFlight ID:" + flight_id.Text +
                "\nDate: " + date.Text +
                "\nAirline:" + airline.Text +
                "\nSource: " + source.Text +
                "\nDestination:" + destination.Text +
                "\nArrival:" + arrival.Text +
                "\nDeparture:" + departure.Text +
                "\nDuration: " + duration.Text +
                "\nMobile No: " + mobile_no.Text +
                "\nEmail: " + email.Text +
                "\nClass: " + class1.Text +
                "\nNo of Seats: " + no_of_seats.Text +
                "\nTotal Fare: " + total_fare.Text + ""
                );
            doc.Add(pr);
            Paragraph s = new Paragraph("\nPassenger Details\n");
            doc.Add(s);
            PdfPTable pd = new PdfPTable(dataGridView1.Columns.Count);
            pd.AddCell("Passenger Name");
            pd.AddCell("Gender");
            pd.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value != null)
                    {
                        pd.AddCell(dataGridView1[k, i].Value.ToString());
                    }
                }
            }
            doc.Add(pd);
            doc.Close();
          
          //show Pdf
          System.Diagnostics.Process.Start("Ticket.pdf");
        }

        private void passenger_detail_Click(object sender, EventArgs e)
        {
            for(int i=1;i<=int.Parse(nos);i++)
            {
                detail d = new detail(booking_id.Text);
                d.Show();
            }
            passenger_detail.Enabled = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {

            //disable back button
            this.back.Visible = false;

            if (mobile_no.Text == "" && email.Text == "")
            {
                MessageBox.Show("Enter Email And Mobile Number");
            }
            else
            {
                //insert booking detail in db
                cs.Open();
                da.InsertCommand = new SqlCommand("insert into booking values(@flight_id,@source,@destination,@date,@ticket_type,@phone,@email,@no_of_passengers,@tfare,@status)", cs);
                da.InsertCommand.Parameters.Add("flight_id", SqlDbType.VarChar).Value = flight_id.Text;
                da.InsertCommand.Parameters.Add("source", SqlDbType.VarChar).Value = source.Text;
                da.InsertCommand.Parameters.Add("destination", SqlDbType.VarChar).Value = destination.Text;
                da.InsertCommand.Parameters.Add("date", SqlDbType.VarChar).Value = date.Text;
                da.InsertCommand.Parameters.Add("phone", SqlDbType.VarChar).Value = mobile_no.Text;
                da.InsertCommand.Parameters.Add("email", SqlDbType.VarChar).Value = email.Text;
                da.InsertCommand.Parameters.Add("no_of_passengers", SqlDbType.VarChar).Value = no_of_seats.Text;
                da.InsertCommand.Parameters.Add("tfare", SqlDbType.VarChar).Value = total_fare.Text;
                da.InsertCommand.Parameters.Add("status", SqlDbType.VarChar).Value = "Reserved";
                da.InsertCommand.Parameters.Add("ticket_type", SqlDbType.VarChar).Value = class1.Text;
                da.UpdateCommand = new SqlCommand("", cs);
                da.InsertCommand.ExecuteNonQuery();
                cs.Close();

                //update no. of seats available in db
                if (class1.Text == "Business")
                {
                    cs.Open();
                    da.UpdateCommand = new SqlCommand("update schedule set business_seat = business_seat -" + no_of_seats.Text + " where flight_id = '" + flight_id.Text + "'and date = '" + date.Text + "'", cs);
                    da.UpdateCommand.ExecuteNonQuery();
                    cs.Close();
                }
                else
                {
                    cs.Open();
                    da.UpdateCommand = new SqlCommand("update schedule set economy_seat = economy_seat -" + no_of_seats.Text + " where flight_id = '" + flight_id.Text + "'and date = '" + date.Text + "'", cs);
                    da.UpdateCommand.ExecuteNonQuery();
                    cs.Close();
                }
                
                //Send Mail
                string from = "//your email address";
                string subject = "Ticket";
                string body = "Your Booking Details\nBooking ID: " + booking_id.Text + "\tFlight Id: " + flight_id.Text + "\nAirlines: " + airline.Text + "\tDate Of Journey: " + date.Text + "\nSource: " + source.Text + "\tDestination: " + destination.Text + "\nArrival: " + arrival.Text + "\tDeparture: " + departure.Text + "\nDuration: " + duration.Text + "\tClass: " + class1.Text + "\nNo of Seats: " + no_of_seats.Text + "\nTotal Fare: " + total_fare.Text + "";
                string smtp = "smtp.gmail.com";
                string user = "//your gmail userid";
                string pass = "//your gmail password";
                MailMessage mail = new MailMessage(from, email.Text, subject, body);
                SmtpClient client = new SmtpClient(smtp);
                client.Port = 587;
                client.Credentials = new NetworkCredential(user, pass);
                client.EnableSsl = true;
                client.Send(mail);

                //Send Message
                //create a account on vianett to send messages
                WebClient sms = new WebClient();
                try
                {
                    Double v = Convert.ToDouble(mobile_no.Text);
                    string frm = "//vianett emailid";
                    string passw = "vianett password";
                    string message = "Your Booking Details\nBooking ID: " + booking_id.Text + "\tFlight Id: " + flight_id.Text + "\nAirlines: " + airline.Text +"\nArrival: " + arrival.Text + "\tDeparture: " + departure.Text + "\tClass: " + class1.Text+"";
                    string url = "//vianett generated url" + v + "&msg=" + message + "&username=" + frm + "&password=" + passw + "";
                    string result = sms.DownloadString(url);
                    if (result.Contains("OK"))
                    {
                        MessageBox.Show("Ticket Confirmed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Message not sent!!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kuch fayda nahi hai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.confirm.Enabled = false;
        }
        private void booking_Load(object sender, EventArgs e)
        {
            //get booking id from db
            da.SelectCommand = new SqlCommand("SELECT * FROM booking WHERE booking_id = (SELECT MAX(booking_id)  FROM booking)", cs);
            da.Fill(ds1);
            bs1.DataSource = ds1.Tables[0];
            booking_id.DataBindings.Add(new Binding("text", bs1, "booking_id"));
            booking_id.Text = (int.Parse(booking_id.Text) + 1).ToString();

            //fill the details
            flight_id.Text = fid;
            no_of_seats.Text = nos;
            date.Text = dte;
            class1.Text = cls;
            cs.Open();
            da.SelectCommand = new SqlCommand("select * from flights where flight_id = '" + flight_id.Text + "'", cs);
            da.Fill(ds);
            bs.DataSource = ds.Tables[0];
            source.DataBindings.Add(new Binding("text", bs, "source"));
            destination.DataBindings.Add(new Binding("text", bs, "destination"));
            airline.DataBindings.Add(new Binding("text", bs, "airline"));
            departure.DataBindings.Add(new Binding("text", bs, "departure"));
            arrival.DataBindings.Add(new Binding("text", bs, "arrival"));
            duration.DataBindings.Add(new Binding("text", bs, "duration"));

            //show fare
            if (cls == "Business")
            {
                fare.DataBindings.Add(new Binding("text", bs, "business_fare"));
            }
            else
            {
                fare.DataBindings.Add(new Binding("text", bs, "economy_fare"));
            }
            cs.Close();           
           }
    }
}
