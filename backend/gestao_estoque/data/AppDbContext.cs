using gestao_estoque.entidades;
using Microsoft.EntityFrameworkCore;

namespace gestao_estoque.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<EmpresaContratante> EmpresasContratantes { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<LogAuditoria> LogsAuditoria { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Holding> Holdings { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<EstoqueMovimentacao> EstoquesMovimentacao { get; set; }
        public DbSet<FornecedorProduto> FornecedoresProdutos { get; set; }
    }
}
