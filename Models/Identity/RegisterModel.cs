namespace rina.Models
{
    public class RegisterModel
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
