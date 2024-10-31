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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RestaurantSystem
{
    public partial class Orders : Form
    {
        private readonly OrderRepository _orderRepository;
        private readonly CustomerRepository _customerRepository;
        public Orders()
        {
            InitializeComponent();

            _orderRepository = new OrderRepository();
            _customerRepository = new CustomerRepository();
        }

        private async void Order_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
            await FillComboBoxAsync();


        }

        private async Task FillDataGridAsync()
        {
            dataGridView1.DataSource = await _orderRepository.GetAllAsync();
        }


        private async Task FillComboBoxAsync()
        {
            cmbCustomer.Items.Clear();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DataSource = await _customerRepository.GetAllAsync();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.Text.IsNullOrEmpty() || txtOrderDate.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Order order = new()
            {

                OrderDate = DateTime.Parse(txtOrderDate.Text),

                CustomerId = (int)cmbCustomer.SelectedValue,

            };

            try
            {
                await _orderRepository.Add(order);
                await _orderRepository.SaveChangesAsync();

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
                    _orderRepository.Remove(selectedItem);
                    await _orderRepository.SaveChangesAsync();

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
                _orderRepository.Update(selectedRowItem);
                await _orderRepository.SaveChangesAsync();

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
