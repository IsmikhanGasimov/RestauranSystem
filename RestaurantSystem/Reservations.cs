using Microsoft.IdentityModel.Tokens;
using RestaurantSystem.EFCoreRepositories;
using RestaurantSystem.Entities;
using RestaurantSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RestaurantSystem
{
    public partial class Reservations : Form
    {
        private readonly ReservationRepository _reservationRepository;
        private readonly CustomerRepository _customerRepository;
        public Reservations()
        {
            InitializeComponent();
            _reservationRepository = new ReservationRepository();
            _customerRepository = new CustomerRepository();
        }

        private async void Reservation_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
            await FillComboBoxAsync();


        }

        private async Task FillComboBoxAsync()
        {
            cmbCustomer.Items.Clear();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DataSource = await _customerRepository.GetAllAsync();
        }

        private async Task FillDataGridAsync()
        {
            dataGridView1.DataSource = await _reservationRepository.GetAllAsync();
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




        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.Text.IsNullOrEmpty() || txtReservationDate.Text.IsNullOrEmpty() || txtNumGuests.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Reservation reservation = new()
            {
                ReservationDate = DateTime.Parse(txtReservationDate.Text),
                NumGuests = int.Parse(txtNumGuests.Text),
                CustomerId = (int)cmbCustomer.SelectedValue,
            };

            try
            {
                await _reservationRepository.Add(reservation);
                await _reservationRepository.SaveChangesAsync();

                MessageBox.Show("Added successfully");

                await FillDataGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Order selectedItem = (Order)dataGridView1.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _reservationRepository.Remove(selectedItem);
                    await _reservationRepository.SaveChangesAsync();

                    MessageBox.Show("Deleted successfully");

                    await FillDataGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            Order selectedRowItem = (Order)dataGridView1.SelectedRows[0].DataBoundItem;

            try
            {
                _reservationRepository.Update(selectedRowItem);
                await _reservationRepository.SaveChangesAsync();

                await FillDataGridAsync();

                MessageBox.Show("Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
