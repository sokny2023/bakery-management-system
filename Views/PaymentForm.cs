namespace bakery_management_system.Views
{
    public partial class PaymentForm : Form
    {
        public int CustomerId { get; private set; }
        public string PaymentMethod { get; private set; }

        private const string ErrorTitle = "Input Error";
        private const string CustomerIdError = "Please enter a valid Customer ID.";
        private const string PaymentMethodError = "Please select a valid payment method.";

        public PaymentForm()
        {
            InitializeComponent();
            InitializePaymentMethods();
        }

        private void InitializePaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Mobile Payment");
            cmbPaymentMethod.SelectedIndex = 0; // Default selection
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string customerIdInput = txtCustomerId.Text?.Trim();

            // Validate Customer ID
            if (string.IsNullOrEmpty(customerIdInput) || !int.TryParse(customerIdInput, out int customerId))
            {
                MessageBox.Show(CustomerIdError, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate Payment Method
            if (cmbPaymentMethod.SelectedItem == null || string.IsNullOrWhiteSpace(cmbPaymentMethod.SelectedItem.ToString()))
            {
                MessageBox.Show(PaymentMethodError, ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign values
            CustomerId = customerId;
            PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            // Confirm dialog result
            DialogResult = DialogResult.OK;
        }
    }
}
