using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public ShoppingCart(string username)
        {
            UserName = username;
        }

        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new();

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                foreach (var item in Items)
                {
                    totalprice += item.Price * item.Quantity;
                }
                return totalprice;
            }
        }
    }
}
