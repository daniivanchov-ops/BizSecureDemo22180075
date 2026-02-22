namespace BizSecureDemo22180075.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }          // притежател
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }

}
