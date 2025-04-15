using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Controllers
{
    public class ForgotPasswordModel
    {
        [Required(ErrorMessage = "Email-Id is required")]
        public string? Email { get;  set; }
    }
}