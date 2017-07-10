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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
        }

        private void adm_login_Click(object sender, EventArgs e)
        {
            admin_login adm = new admin_login();
            adm.Show();
        }
    }
}
