using System.ComponentModel.DataAnnotations;

namespace LiteTe.Data
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string? ManufacturerName { get; set; }
        public virtual ICollection<Product>? Products { get; set; }

        public string? ManufacturerImage { get; set; }
    }
}
