using System.Collections.Generic;
using System.Linq;

namespace shopapp.webui.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> CartItems { get; set; } = new List<CartItemModel>(); // Varsayılan olarak boş liste tanımlandı.

        // Toplam fiyatı hesaplayan metot
        public double TotalPrice()
        {
            return CartItems?.Sum(i => i.Price * i.Quantity) ?? 0; // Null kontrolü eklendi.
        }

        // Toplam ürün adedini hesaplayan metot
        public int TotalItems()
        {
            return CartItems?.Sum(i => i.Quantity) ?? 0; // Null kontrolü eklendi.
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }

        // Her ürünün toplam fiyatını hesaplayan özellik
        public double TotalPrice => Price * Quantity;
    }
}
