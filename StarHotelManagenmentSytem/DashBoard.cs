using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarHotelManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerRegistrationBtn_Click(object sender, EventArgs e)
        {
            CustomerRegistrationBtn.BackColor = Color.Wheat;
            AddRoomButton.BackColor = Color.FromArgb(62, 120, 138);
            CheckOutBtn.BackColor = Color.FromArgb(62, 120, 138);
            EmployeeBtn.BackColor = Color.FromArgb(62, 120, 138);
            CustomerDetailsBtn.BackColor = Color.FromArgb(62, 120, 138);
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomButton.BackColor = Color.Wheat;
            CustomerRegistrationBtn.BackColor = Color.FromArgb(62, 120, 138);
            CheckOutBtn.BackColor = Color.FromArgb(62, 120, 138);
            EmployeeBtn.BackColor = Color.FromArgb(62, 120, 138);
            CustomerDetailsBtn.BackColor = Color.FromArgb(62, 120, 138);
        }

        private void minimisebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            CheckOutBtn.BackColor = Color.Wheat;
            CustomerRegistrationBtn.BackColor = Color.FromArgb(62, 120, 138);
            AddRoomButton.BackColor = Color.FromArgb(62, 120, 138);
            EmployeeBtn.BackColor = Color.FromArgb(62, 120, 138);
            CustomerDetailsBtn.BackColor = Color.FromArgb(62, 120, 138);
        }

        private void CustomerDetailsBtn_Click(object sender, EventArgs e)
        {
            CustomerDetailsBtn.BackColor = Color.Wheat;
            CustomerRegistrationBtn.BackColor = Color.FromArgb(62, 120, 138);
            AddRoomButton.BackColor = Color.FromArgb(62, 120, 138);
            CheckOutBtn.BackColor = Color.FromArgb(62, 120, 138);
            EmployeeBtn.BackColor = Color.FromArgb(62, 120, 138);
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeBtn.BackColor = Color.Wheat;
            CustomerRegistrationBtn.BackColor = Color.FromArgb(62, 120, 138);
            AddRoomButton.BackColor = Color.FromArgb(62, 120, 138);
            CheckOutBtn.BackColor = Color.FromArgb(62, 120, 138);
            CustomerDetailsBtn.BackColor =  Color.FromArgb(62, 120, 138);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
