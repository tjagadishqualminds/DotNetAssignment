using System.ComponentModel.DataAnnotations;

namespace GroceriesAppDemo.Models
{
    public class ProductsModel
    {
        [Key]
        public int ProductsId { get; set; }

        public int ProductSupplierId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public int ProductQuantity { get; set; }

        public int ProductCategoryId { get; set; }
    }
}
