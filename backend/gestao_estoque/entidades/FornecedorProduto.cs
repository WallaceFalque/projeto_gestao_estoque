using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("fornecedor_produto")]
    public class FornecedorProduto
    {
        //ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //INFO
        [Column("codigo_fornecedor")]
        [MaxLength(80)]
        public string? CodigoFornecedor { get; set; }

        [Column("preco", TypeName = "decimal(20,2)")]
        public decimal? Preco { get; set; }

        [Column("prazo_entrega_dias")]
        public int? PrazoEntregaDias { get; set; }

        [Column("ativo")]
        [Required]
        public bool Ativo { get; set; } = true;

        //Logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_edicao")]
        public DateTime? DataEdicao { get; set; }

        //FK`s
        [Column("fornecedor_id")]
        public int FornecedorId { get; set; }

        [Column("produto_id")]
        public int ProdutoId { get; set; }

        public Fornecedor? Fornecedor { get; set; }

        public Produto? Produto { get; set; }
    }
}
