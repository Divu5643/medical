using System.ComponentModel.DataAnnotations;

namespace medicalApp.newModels
{
    public class Login
    {
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Login() { }
    }
}
