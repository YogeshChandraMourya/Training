namespace Emp.Models
{
    public class Billing
    {
        public int BillingId { get; set; }
        public string BillingName { get; set; } = string.Empty;
        public string BillingDescription { get; set;} = string.Empty;
        public int BillingStatus { get; set;} = 0;
        public string BillingAddress { get; set; }= string.Empty;
    }
}
