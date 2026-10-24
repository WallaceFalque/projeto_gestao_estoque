using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace gestao_estoque.entidades
{
    [Table("categoria")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("descricao")]
        [MaxLength(255)]
        [Required]
        public string Descricao { get; set; } = string.Empty;

        //logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_atualizacao")]
        public DateTime? DataAtualizacao { get; set; }

        //FK`s
        [Column("empresa_contratante_id")]
        public int EmpresaContratanteId { get; set; }

        public EmpresaContratante? EmpresaContratante { get; set; }
    }
}