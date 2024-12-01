using bakery_management_system.components.userControl;
using bakery_management_system.Controllers;

namespace bakery_management_system.Views
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryController _categoryController;

        public CategoryForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _categoryController = new CategoryController();
            LoadCategory();
        }

        private void LoadCategory()
        {
            // Fetch categories from the database
            var categories = _categoryController.GetCategories();

            // Dynamically add rows for each category
            foreach (var category in categories)
            {
                var categoryControl = new CategoryControl();
                categoryControl.LoadCategory(category.CategoryId, category.CategoryName);
                flowLayoutPanelCategories.Controls.Add(categoryControl);
            }
        }


    }
}
