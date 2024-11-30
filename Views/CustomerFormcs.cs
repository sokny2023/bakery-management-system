using bakery_management_system.Controllers;

namespace bakery_management_system.Views
{
    public partial class CustomerFormcs : Form
    {
        private CustomerController customerController;
        public CustomerFormcs()
        {
            InitializeComponent();
            // Make the form full screen
            this.WindowState = FormWindowState.Maximized; // Maximized state
            customerController = new CustomerController();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            var customerData = customerController.GetAllCustomers();
            dataGridView1.DataSource = customerData;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }


    }
}
