using MeuPimAutomacaoMVC.Models;
using MeuPimAutomacaoMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAutomacaoFolha.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ICadastroRepositorio _CadastroRepositorio;
        public CadastroController(ICadastroRepositorio CadastroRepositorio)
        {
            _CadastroRepositorio = CadastroRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(CadastroModel cadastro)
        {
            _CadastroRepositorio.Adicionar(cadastro);
            return RedirectToAction("Index");
        }

    }
}
