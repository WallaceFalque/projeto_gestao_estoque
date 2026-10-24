using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestao_estoque.entidades
{   
    [Table("empresa_contratante")]
    public class EmpresaContratante
    {
        // Id
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [Column("id")]
       public int Id { get; set; }

        // Info
        [Column("razao_social")]
        [MaxLength(150)]
        [Required]
        public string RazaoSocial { get; set; } = string.Empty;

        [Column("cnpj_cpf")]
        [MaxLength(20)]
        [Required]
        public string CnpjCpf { get; set; } = string.Empty;

        //logs
        [Column("data_criacao")]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Column("data_atualizacao")]
        public DateTime? DataAtualizacao { get; set; }
    }
}