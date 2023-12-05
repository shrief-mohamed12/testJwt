

using System.ComponentModel.DataAnnotations;

namespace JwtApi.Models
{
    public class RegisterModel
    {
        [Required ,StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string PassWord { get; set; }
    }
}
