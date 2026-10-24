using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("estoque_movimentacao")]
    public class EstoqueMovimentacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("quantidade")]
        [Required]
        public int Quantidade { get; set; }

        [Column("motivo")]
        [MaxLength(256)]
        public string? Motivo { get; set; }

        [Column("tipo")]
        [MaxLength(30)]
        [Required]
        public string Tipo { get; set; } = string.Empty;

        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_movimentacao")]
        [Required]
        public DateTime DataMovimentacao { get; set; } = DateTime.UtcNow;
    }
}
