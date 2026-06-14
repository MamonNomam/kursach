namespace LiteTe.Data
{
    public class Stock
    {
        public int StockId { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; } 
        public int? Count { get; set; }
    }
}
