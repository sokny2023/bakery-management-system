using bakery_management_system.Models;

namespace bakery_management_system.components.userControl
{
    public partial class CartCustomerControl : UserControl
    {
        public CartCustomerControl()
        {
            InitializeComponent();
        }

        public void SetCustomer(Customer customer)
        {
            lblName.Text = customer.Name;
            lblPhone.Text = customer.Phone ?? "N/A";
            lblEmail.Text = customer.Email ?? "N/A";
            lblAddress.Text = customer.Address ?? "N/A";
        }
    }
}
