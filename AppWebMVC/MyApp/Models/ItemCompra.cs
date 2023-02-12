using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class ItemCompra 
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "One product needs a name")]
        [StringLength(60, MinimumLength = 3)]
        public string NomeDoProduto { get; set; }

        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Invalid format")]
        public DateTime DataLancamento { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "Value must be between 1 and 1000")]
        public Decimal  Valor { get; set; }
    }
}
