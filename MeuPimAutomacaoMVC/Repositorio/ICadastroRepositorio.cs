using MeuPimAutomacaoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPimAutomacaoMVC.Repositorio
{
    public interface ICadastroRepositorio
    {
        public CadastroModel Adicionar(CadastroModel cadastro);
    }
}
