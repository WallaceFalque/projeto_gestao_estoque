using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("holding")]
    public class Holding
    {
        //ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //INFO
        [Column("nome")]
        [MaxLength(120)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("cnpj")]
        [MaxLength(20)]
        [Required]
        public string Cnpj { get; set; } = string.Empty;

        //Logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_edicao")]
        public DateTime? DataEdicao { get; set; }

        //FK`s
        [Column("empresa_contratante_id")]
        public int EmpresaContratanteId {get; set;}

        public EmpresaContratante? EmpresaContratante { get; set; }
    }
}
