using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARS
{
    public partial class user_home : Form
    {
        public user_home()
        {
            InitializeComponent();
        }

        private void book_flight_Click(object sender, EventArgs e)
        {
            book bk = new book();
            bk.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            search sf = new search();
            sf.Show();
            this.Hide();
        }

        private void cancel_ticket_Click(object sender, EventArgs e)
        {
            cancel_ticket canc = new cancel_ticket();
            canc.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {
            previous_booking pb = new previous_booking();
            pb.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void user_home_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\naths\documents\visual studio 2015\Projects\ARS\ARS\Resources\User.png");
            userlogo.Image = img;
            userlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
