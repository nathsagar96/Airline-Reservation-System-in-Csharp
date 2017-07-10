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
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add_flight add_obj = new add_flight();
            add_obj.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_flight delete_obj = new delete_flight();
            delete_obj.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            update_flight update_obj = new update_flight();
            update_obj.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            view_flight view_obj = new view_flight();
            view_obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            schedule_flight schedule = new schedule_flight();
            schedule.Show();
            this.Hide();
        }

        private void adminpage_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\naths\documents\visual studio 2015\Projects\ARS\ARS\Resources\login_icon.png");
            adminlogo.Image = img;
            adminlogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }
    }
}
