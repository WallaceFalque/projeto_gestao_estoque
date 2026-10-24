using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("holding")]
    public class Holding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [MaxLength(120)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("cnpj")]
        [MaxLength(20)]
        [Required]
        public string Cnpj { get; set; } = string.Empty;

        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_edicao")]
        public DateTime? DataEdicao { get; set; }
    }
}
