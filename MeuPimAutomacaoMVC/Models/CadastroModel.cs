using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPimAutomacaoMVC.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Senha { get; set; }

        public int DataNasci { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public int Data_admissao { get; set; }

        public int Cargo { get; set; }

        public string Turno { get; set; }
    }
}
