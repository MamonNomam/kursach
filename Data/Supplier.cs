namespace LiteTe.Data
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierContacts { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
