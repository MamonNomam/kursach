using System.ComponentModel.DataAnnotations;

namespace LiteTe.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

        public string? CategoryImage { get; set; }
    }
}
