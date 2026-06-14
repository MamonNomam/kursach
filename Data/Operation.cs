namespace LiteTe.Data
{
    public class Operation
    {
        public int OperationId { get; set; }
        public int OperationTypeId { get; set; }
        public virtual OperationType? OperationType { get; set; }
        public int OperationAmount { get; set; }
        public DateTime? OperationDate { get; set; }

        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
