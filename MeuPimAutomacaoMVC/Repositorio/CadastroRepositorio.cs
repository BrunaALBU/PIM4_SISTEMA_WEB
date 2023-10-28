using MeuPimAutomacaoMVC.Data;
using MeuPimAutomacaoMVC.Models;
using MeuPimAutomacaoMVC.Repositorio;

namespace MeuPimAutomacaoMVC.Repositório
{
    public class CadastroRepositorio : ICadastroRepositorio
    {

        private readonly BancoContext _bancoContext;

        public CadastroRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public CadastroModel Adicionar(CadastroModel cadastro)
        {
            // gravar no banco de dados 
            _bancoContext.Cadastro.Add(cadastro);
            return cadastro;
        }

    }
}
