using gestao_estoque.entidades;
using Microsoft.EntityFrameworkCore;

namespace gestao_estoque.data
{
    public class GestaoEstoqueContext : DbContext
    {
        public GestaoEstoqueContext(
            DbContextOptions<GestaoEstoqueContext> options)
            : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedores => Set<Fornecedor>();
        public DbSet<EmpresaContratante> EmpresasContratantes => Set<EmpresaContratante>();
        public DbSet<Deposito> Depositos => Set<Deposito>();
        public DbSet<Estoque> Estoques => Set<Estoque>();
        public DbSet<Categoria> Categorias => Set<Categoria>();
        public DbSet<LogAuditoria> LogsAuditoria => Set<LogAuditoria>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Holding> Holdings => Set<Holding>();
        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<EstoqueMovimentacao> EstoquesMovimentacao => Set<EstoqueMovimentacao>();
        public DbSet<FornecedorProduto> FornecedoresProdutos => Set<FornecedorProduto>();
    }
}
