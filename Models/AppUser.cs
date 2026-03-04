namespace BizSecureDemo22180075.Models
{
    public class AppUser
    {
        // Brute-force protection
        public int? FailedLogins { get; set; }
        public DateTime? LockoutUntilUtc { get; set; }
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
    }

}
