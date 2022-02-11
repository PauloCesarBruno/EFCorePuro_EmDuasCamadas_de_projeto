using EFCoreEmpRoupas.DATA;
using EFCoreEmpRoupas.DATA.Models;
using EFCoreEmpRoupas.DATA.Services;
using EFCoreEmpRoupas.WEB.Models;
using EFCoreEmpRoupas.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreEmpRoupas.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        private RoupaEmprestimoClienteService _service = new RoupaEmprestimoClienteService();

        public IActionResult Index()
        {
            List<VW_RoupaEmprestimo> oListVw_RoupaEmprestimo = _service.oReposytoriVW_RoupaEmprestimo.SelecionarTodos();
            return View(oListVw_RoupaEmprestimo);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();
            List<Roupa> oListRoupa = _service.oRepositoryRoupa.SelecionarTodos();
            List<Cliente> oListCliente = _service.oRepositoryCliente.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = oListCliente;
            oEmprestimoViewModel.oListLivro = oListRoupa;

            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7); // 7 Dias p/ entrega.


            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(EmprestimoViewModel oEmprestimoViewModel)
        {
            RoupaEmprestimo oRoupaEmprestimo = new RoupaEmprestimo();
            oRoupaEmprestimo.DataEmprestimo = oEmprestimoViewModel.dataEmprestimo;
            oRoupaEmprestimo.DataEntrga = oEmprestimoViewModel.dataEntrega;
            oRoupaEmprestimo.Entegue = false;
            oRoupaEmprestimo.IdCliente = oEmprestimoViewModel.idCliente;
            oRoupaEmprestimo.IdRoupa = oEmprestimoViewModel.idRoupa;

            if (!ModelState.IsValid)
            {
                return View();
            }

            _service.oRepositoryRoupaEmprestimo.Incluir(oRoupaEmprestimo);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            VW_RoupaEmprestimo oListVw_RoupaEmprestimo = _service.oReposytoriVW_RoupaEmprestimo.SelecionarPk(Id);
            return View(oListVw_RoupaEmprestimo);
        }

        public IActionResult Edit(int Id)
        {
            VW_RoupaEmprestimo oListVw_RoupaEmprestimo = _service.oReposytoriVW_RoupaEmprestimo.SelecionarPk(Id);
            return View(oListVw_RoupaEmprestimo);
        }

        [HttpPost]
        public IActionResult Edit(RoupaEmprestimo model)
        {
            RoupaEmprestimo oRoupaEmprestimo = _service.oRepositoryRoupaEmprestimo.Alterar(model);

            // Redirecionamento...
            int Id = oRoupaEmprestimo.Id;
            return RedirectToAction("Index", "Emprestimos", new { Id });
        }

        public IActionResult Delete(int Id)
        {
            /* Não vou usar partial View nem retornar nehuma view vou usar 
             * o Botstrap Modal e retornar para Index Mesmo.*/
            _service.oRepositoryRoupaEmprestimo.Excluir(Id);
            return RedirectToAction("Index");
        }
    }
}
