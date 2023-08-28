namespace rina.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get => role; set => role = value; }

        private string role = "User";
    }
}
