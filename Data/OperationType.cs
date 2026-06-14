using Azure;

namespace LiteTe.Data
{
    public class OperationType
    {
        public int OperationTypeId { get; set; }

        public string? OperationTypeName { get; set; }
        public virtual ICollection<Operation>? Operations { get; set; }
    }
}
