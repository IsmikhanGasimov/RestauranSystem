using Microsoft.IdentityModel.Tokens;
using RestaurantSystem.EFCoreRepositories;
using RestaurantSystem.Entities;
using RestaurantSystem.Extensions;
using RestaurantSystem.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RestaurantSystem
{
    public partial class Menus : Form
    {
        private readonly MenuRepository _menuRepository;
        public Menus()
        {
            InitializeComponent();
            _menuRepository = new MenuRepository();
        }
        private async void Menu_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();

        }

        private async Task FillDataGridAsync()
        {
            dataGridView1.DataSource = await _menuRepository.GetAllAsync();
        }






        private void txtDescription_TextChanged(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Reservations reservation = new Reservations();
            reservation.Show();
            Close();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }



        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }



        private async void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text.IsNullOrEmpty() || txtDescription.Text.IsNullOrEmpty() || !txtPrice.IsGreaterThan(1))
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Menu menu = new()
            {

                Name = txtName.Text,
                Description = txtDescription.Text,
                Price = decimal.Parse(txtPrice.Text),
            };

            try
            {
                await _menuRepository.Add(menu);
                await _menuRepository.SaveChangesAsync();

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

            Menu selectedItem = (Menu)dataGridView1.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _menuRepository.Remove(selectedItem);
                    await _menuRepository.SaveChangesAsync();

                    MessageBox.Show("Deleted successfully");

                    await FillDataGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }




        private async Task btnEdit_ClickAsync(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            Menu selectedRowItem = (Menu)dataGridView1.SelectedRows[0].DataBoundItem;

            try
            {
                _menuRepository.Update(selectedRowItem);
                await _menuRepository.SaveChangesAsync();

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
