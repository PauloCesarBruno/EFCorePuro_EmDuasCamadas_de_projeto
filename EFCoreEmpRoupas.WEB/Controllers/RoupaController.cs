using EFCoreEmpRoupas.DATA;
using EFCoreEmpRoupas.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EFCoreEmpRoupas.WEB.Controllers
{
    public class RoupaController : Controller
    {
        private RoupaService oRoupaService = new RoupaService();

        public IActionResult Index()
        {
            List<Roupa> oListRoupa = oRoupaService.oRepositoryRoupa.SelecionarTodos();
            return View(oListRoupa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Roupa model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oRoupaService.oRepositoryRoupa.Incluir(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Roupa objRoupa = oRoupaService.oRepositoryRoupa.SelecionarPk(Id);
            return View(objRoupa);
        }

        public IActionResult Edit(int Id)
        {
            Roupa objRoupa = oRoupaService.oRepositoryRoupa.SelecionarPk(Id);
            return View(objRoupa);
        }

        [HttpPost]
        public IActionResult Edit(Roupa model)
        {
            Roupa objRoupa = oRoupaService.oRepositoryRoupa.Alterar(model);

            // Redirecionar para o Edit...
            int Id = objRoupa.Id;
            return RedirectToAction("Details", new { Id });
        }

        public IActionResult Delete(int Id)
        {
            try
            {
                /* Não vou usar partial View nem retornar nehuma view vou usar 
                 * o Botstrap Modal e retornar para Index Mesmo.*/
                oRoupaService.oRepositoryRoupa.Excluir(Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Tratamento");
            }
        }

    }
}
