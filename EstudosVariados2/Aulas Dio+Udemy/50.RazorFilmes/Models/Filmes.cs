using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorFilmes.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage ="Deve ter entre 3 a 6 Caracteres.")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Lancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Genero { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [RegularExpression(@"^[A-Z""']+[a-zA-Z0-9""'\s]*$")]
        [StringLength(5)]
        [Required]
        public string Classificacao { get; set; } = string.Empty;
    }
}
