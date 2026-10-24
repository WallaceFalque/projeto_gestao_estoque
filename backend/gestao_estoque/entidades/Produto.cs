using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("produto")]
    public class Produto
    {
        //ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //INFO
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

        //Logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_edicao")]
        public DateTime? DataEdicao { get; set; }

        //FK`s
        [Column("categoria_id")]
        public int CategoriaId { get; set; }

        [Column("empresa_contratante_id")]
        public int EmpresaContratanteId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId  { get; set; }

        public Categoria? Categoria { get; set; }

        public EmpresaContratante? EmpresaContratante { get; set; }

        public Usuario? Usuario { get; set; }

    }
}
