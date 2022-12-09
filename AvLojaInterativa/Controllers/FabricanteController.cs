using AvLojaInterativa.Data.Interfaces;
using AvLojaInterativa.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvLojaInterativa.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IFabricante _fabricante;
        public FabricanteController(IFabricante fabricante)
        {
            _fabricante = fabricante;
        }

        // GET: FabricanteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FabricanteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FabricanteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FabricanteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(FabricanteModel fabricante)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _fabricante.Create(fabricante);
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction(nameof(HomeController.Index));
        }

        // GET: FabricanteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FabricanteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FabricanteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FabricanteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
