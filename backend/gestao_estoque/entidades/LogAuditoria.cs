using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestao_estoque.entidades
{
    [Table("log_auditoria")]
    public class LogAuditoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("acao")]
        [MaxLength(30)]
        [Required]
        public string Acao { get; set; } = string.Empty;

        [Column("entidade")]
        [MaxLength(80)]
        [Required]
        public string Entidade { get; set; } = string.Empty;

        [Column("descricao")]
        [MaxLength(255)]
        public string Descricao { get; set; } = string.Empty;

        [Column("dados_anteriores", TypeName = "json")]
        public string? DadosAnteriores { get; set; }

        [Column("dados_novos", TypeName = "json")]
        public string? DadosNovos { get; set; }

        //Logs
        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }

        //FK`s
        [Column("registro_id")]
        public int RegistroId { get; set; }

        [Column("usuario_id")]
        public int UsuarioId { get; set; }

    }
}