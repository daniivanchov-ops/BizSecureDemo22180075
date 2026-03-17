namespace BizSecureDemo22180075.ViewModels
{
    public class ReplayDemo
    {
            public decimal Balance { get; set; }
            public string? Message { get; set; }
            public int UserId { get; set; }
            public decimal Amount { get; set; } = 100;
            public string Token { get; set; } = "SECRET123";

    }
}
