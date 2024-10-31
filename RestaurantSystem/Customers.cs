using Microsoft.IdentityModel.Tokens;
using RestaurantSystem.EFCoreRepositories;
using RestaurantSystem.Entities;
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
    public partial class Customers : Form
    {
        private readonly CustomerRepository _customerRepository;
        public Customers()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private async void Customer_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();

        }

        private async Task FillDataGridAsync()
        {
            dataGridView1.DataSource = await _customerRepository.GetAllAsync();
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
            if (txtName.Text.IsNullOrEmpty() || txtPhone.Text.IsNullOrEmpty() || txtEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Customer customer = new()
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
            };

            try
            {
                await _customerRepository.Add(customer);
                await _customerRepository.SaveChangesAsync();

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

            Customer selectedItem = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _customerRepository.Remove(selectedItem);
                    await _customerRepository.SaveChangesAsync();

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

            Customer selectedRowItem = (Customer)dataGridView1.SelectedRows[0].DataBoundItem;

            try
            {
                _customerRepository.Update(selectedRowItem);
                await _customerRepository.SaveChangesAsync();

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
