using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("usuarios")]
    public class Usuario
    {
        //ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //INFO
        [Column("nome")]
        [MaxLength(80)]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Column("email")]
        [MaxLength(100)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Column("senha_hash")]
        [MaxLength(256)]
        [Required]
        public string SenhaHash { get; set; } = string.Empty;

        [Column("setor")]
        [MaxLength(80)]
        [Required]
        public string Setor { get; set; } = string.Empty;

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
        [Column("holding_id")]
        public int HoldingId { get; set; }

        public Holding? Holding { get; set; }
    }
}
