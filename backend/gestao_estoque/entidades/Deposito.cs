using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("deposito")]
    public class Deposito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [MaxLength(150)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("descricao")]
        [MaxLength(255)]
        public string? Descricao { get; set; }

        [Column("ativo")]
        [Required]
        public bool Ativo { get; set; } = true;

        //logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_atualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        //FK`s
        [Column("holding_id")]
        public int HoldingId { get; set; }

        public Holding? Holding {get; set;}
    }
}