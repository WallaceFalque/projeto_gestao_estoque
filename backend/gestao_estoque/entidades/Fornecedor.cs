using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestao_estoque.entidades
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        //Id
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        //Info
        [Column("razao_social")]
        [MaxLength(150)]
        [Required]
        public string RazaoSocial { get; set; } = string.Empty;

        [Column("nome_fantasia")]
        [MaxLength(150)]
        public string? NomeFantasia { get; set; }

        [Column("cnpj_cpf")]
        [MaxLength(20)]
        [Required]
        public string CnpjCpf { get; set; } = string.Empty;

        [Column("tipo")]
        [MaxLength(30)]
        [Required]
        public string Tipo { get; set; } = string.Empty;

        [Column("email")]
        [MaxLength(120)]
        public string? Email { get; set; }

        [Column("telefone")]
        [MaxLength(30)]
        public string? Telefone { get; set; }

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
        [Column("empresa_contratante_id")]
        public int EmpresaContratanteId {get; set;}

        public EmpresaContratante? EmpresaContratante {get; set;}

    }
}