namespace MVCApplicationForEvoke.Models
{
    public class Bill
    {
        public int BillNumber { get; set; }
        public string BillName { get; set;}
        public string BillDescription { get; set;} = string.Empty;
        public string BillType { get; set;} 
         public int BillId { get; set; } = 0;
        public string BillStatus { get; set; }
        public int NumberOfItems { get; set; }
        public int BillTotal { get; set; }  
    }
}
