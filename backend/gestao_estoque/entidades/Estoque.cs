using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("estoque")]
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("quantidade_atual")]
        [Required]
        public int QuantidadeAtual { get; set; }

        //logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_atualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        //FK`s
        [Column("produto_id")]
        public int ProdutoId {get; set;}

        [Column("deposito_id")]
        public int DepositoId { get; set; }

        public Produto? Produto { get; set; }
        public Deposito? Deposito { get; set; }
    }
}