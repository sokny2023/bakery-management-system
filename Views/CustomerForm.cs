using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;

namespace bakery_management_system.Views
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerController _customerController;

        public CustomerForm()
        {
            InitializeComponent();

            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

            _customerController = new CustomerController();

            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Fetch all customers
            var customers = _customerController.GetAllCustomers();

            // Clear existing controls in the FlowLayoutPanel
            flowLayoutPanelCustomers.Controls.Clear();

            // Add customers to the FlowLayoutPanel
            foreach (var customer in customers)
            {
                var customerControl = new CartCustomerControl();
                customerControl.SetCustomer(customer);
                flowLayoutPanelCustomers.Controls.Add(customerControl);
            }
        }

        private void cartCustomerControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonComponent11_Click(object sender, EventArgs e)
        {

        }
    }
}
