using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Domain.Models
{
    public class UserModel : BaseEntity
    {
        [Required(ErrorMessage = "É necessário informar o nome completo!")]
        [StringLength(50, ErrorMessage = "Precisa conter entre 3 e 50 caracteres!", MinimumLength = 3)]
        public string User { get; set; }
        [Required(ErrorMessage = "É necessário um UserName!")]
        [StringLength(50, ErrorMessage = "Precisa conter entre 3 e 50 caracteres!", MinimumLength = 3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "É necessário um UserName!")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
