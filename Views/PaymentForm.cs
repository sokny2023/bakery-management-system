namespace bakery_management_system.Views
{
    public partial class PaymentForm : Form
    {
        public int CustomerId { get; private set; }
        public string PaymentMethod { get; private set; }

        public PaymentForm()
        {
            InitializeComponent();

            // Populate payment method combo box
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Credit Card");
            cmbPaymentMethod.Items.Add("Mobile Payment");
            cmbPaymentMethod.SelectedIndex = 0; // Default selection
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerId.Text) || !int.TryParse(txtCustomerId.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerId = customerId;
            PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }


    }
}
