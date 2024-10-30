namespace Gulf_Logistics.Models
{
    public class Orders
    {
        public int Id { get; set; } 
        public string OrderId { get; set; } 
        public string ClientOrderNumner { get; set; } 
        public string ProductName { get; set; } 
        public string CustomerName { get; set; } 
        public int ClientId { get; set; } 
        public string ClientName { get; set; } 
        public string Address { get; set; } 
        public string ContatcNumber { get; set; } 
        public string Amount { get; set; } 
        public string WhatsupNumner { get; set; } 
        public string DeliveryStatus { get; set; }
        public string TrackingStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string isDeleted { get; set; }
    }
}
