namespace BizSecureDemo22180075.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
    }

}
