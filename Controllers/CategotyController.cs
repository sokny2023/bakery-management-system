using bakery_management_system.Models;
using bakery_management_system.Services;

namespace bakery_management_system.Controllers
{
    public class CategoryController
    {
        private readonly CategoryService _categoryService;

        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        public List<Category> GetCategories()
        {
            return _categoryService.GetCategories();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _categoryService.GetProductsByCategory(categoryId);
        }
    }
}
