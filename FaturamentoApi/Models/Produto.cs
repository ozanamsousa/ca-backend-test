using System.ComponentModel.DataAnnotations;
namespace FaturamentoApi.Models
{
    public partial class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeProduto { get; set; }
    }
}