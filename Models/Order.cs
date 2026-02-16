namespace BizSecureDemo22180085.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }          // собственик
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }

}
