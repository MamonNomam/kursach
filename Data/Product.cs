namespace LiteTe.Data
{
    public class Product
    {
        public int ProductId { get; set; }

        public virtual ICollection<Stock>? Stock { get; set; }
        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public int? ManufacturerId { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public int? SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }

        public float? Price { get; set; }

        public string? ProductImage { get; set; }


    }
}
