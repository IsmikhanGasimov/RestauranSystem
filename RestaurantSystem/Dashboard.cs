using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menus menu = new Menus();
            menu.Show();
            Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Orders order = new Orders();
            order.Show();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            reservation.Show();
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
