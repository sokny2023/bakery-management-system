using bakery_management_system.Models;
using bakery_management_system.Services;

namespace bakery_management_system.Controllers
{
    public class CartController
    {
        private readonly CartService _cartService;

        public CartController()
        {
            _cartService = new CartService();
        }

        public bool RemoveCartItem(int cartId)
        {
            return _cartService.RemoveCartItem(cartId);
        }


        public List<Cart> GetCartsByEmployeeId(int employeeId)
        {
            return _cartService.GetCartsByEmployeeId(employeeId);
        }

        public bool AddToCart(int employeeId, int productId, int quantity)
        {
            return _cartService.AddToCart(employeeId, productId, quantity);
        }
    }
}
