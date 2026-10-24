using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [MaxLength(250)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("valor", TypeName = "decimal(10,2)")]
        public decimal? Valor { get; set; }

        [Column("descricao")]
        [MaxLength(256)]
        public string? Descricao { get; set; }

        [Column("codigo")]
        [MaxLength(80)]
        [Required]
        public string Codigo { get; set; } = string.Empty;

        [Column("ativo")]
        [Required]
        public bool Ativo { get; set; } = true;

        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_edicao")]
        public DateTime? DataEdicao { get; set; }
    }
}
