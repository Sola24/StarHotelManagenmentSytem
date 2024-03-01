using StarHotelManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarHotelManagenmentSytem
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "sola" && txtpassword.Text == "pass")
            {
                labelerr.Visible = false;
                DashBoard dashboard= new DashBoard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                labelerr.Visible = true;
                txtpassword.Clear();
                txtusername.Clear();
            }
        }
    }
}
