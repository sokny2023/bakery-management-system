using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views
{
    public partial class CartForm : Form
    {
        private readonly CartController _cartController;
        private int _employeeId;

        // Constructor accepting employeeId as a parameter
        public CartForm(int employeeId)
        {
            InitializeComponent();
            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

            _cartController = new CartController();
            _employeeId = employeeId; // Assign the passed employeeId

            LoadCartItems();
            UserInfo();
        }

        private void LoadCartItems()
        {
            try
            {
                var carts = _cartController.GetCartsByEmployeeId(_employeeId);

                flpCarts.Controls.Clear();

                foreach (var cart in carts)
                {
                    var cartControl = new CartControl();
                    cartControl.SetCart(cart);
                    flpCarts.Controls.Add(cartControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserInfo()
        {
            // Section: User Information Display
            if (UserSession.CurrentUser != null)
            {
                lblWelcome.Text = $"Hello, {UserSession.CurrentUser.Name}";
                if (!string.IsNullOrEmpty(UserSession.CurrentUser.ImagePath) && File.Exists(UserSession.CurrentUser.ImagePath))
                {
                    pbProfile.Image = Image.FromFile(UserSession.CurrentUser.ImagePath);
                }
                else
                {
                    // defual avatar
                    pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
                }
            }
            else
            {
                lblWelcome.Text = "Welcome, Guest!";
                pbProfile.Image = Properties.Resources.photo_2023_08_01_20_25_42;
            }

        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(Object sender, EventArgs e)
        {
            // Confirm logout action
            var confirmLogout = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmLogout == DialogResult.Yes)
            {
                // Clear user session or any logged-in state
                UserSession.CurrentUser = null;

                // Navigate to the LoginForm
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close the current form
                this.Close();
            }
        }

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            MyPaymentForm myPaymentForm = new MyPaymentForm();
            myPaymentForm.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }
    }
}
