using System.ComponentModel.DataAnnotations;

namespace ApiGeral.Models
{
    public class InformacoesEmail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public required string Email { get; set; }

        [Required]
        public required string Senha { get; set; }

    }
}
