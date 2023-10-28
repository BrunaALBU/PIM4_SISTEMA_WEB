using MeuPimAutomacaoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuPimAutomacaoMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<CadastroModel> Cadastro { get; set; }
    }
}
