using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;
using bakery_management_system.Utils;

namespace bakery_management_system.Views
{
    public partial class MyPaymentForm : Form
    {
        private readonly InvoiceController _invoiceController;
        public MyPaymentForm()
        {
            InitializeComponent();
            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

            _invoiceController = new InvoiceController();
            int employeeId = UserSession.CurrentUser.EmployeeId; // Example
            LoadInvoices(employeeId);
        }

        private void LoadInvoices(int employeeId)
        {
            flpInvoices.Controls.Clear();
            var invoices = _invoiceController.GetInvoicesByEmployeeId(employeeId);

            foreach (var invoice in invoices)
            {
                var invoiceControl = new InvoiceControl();
                invoiceControl.SetInvoice(invoice);
                flpInvoices.Controls.Add(invoiceControl);
            }
        }

    }
}
