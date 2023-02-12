using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Cliente
    {
        [Key]
        public Guid IdCliente { get; set; }

        [Required(ErrorMessage = "One product needs a name")]
        [StringLength(60, MinimumLength = 3)]
        public string NomeDoCliente { get; set; }

        [Required]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Digite F ou M")]
        public char Sexo { get; set; }
    }
}
