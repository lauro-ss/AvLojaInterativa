using AvLojaInterativa.Data.Interfaces;
using AvLojaInterativa.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvLojaInterativa.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProduto _produto;
        private readonly IFabricante _fabricante;
        public ProdutoController(IProduto produto, IFabricante fabricante)
        {
            _produto = produto;
            _fabricante = fabricante;
        }
        // GET: ProdutoController
        public async Task<ActionResult> Index()
        {
            return View(await _produto.GetAll());
        }

        // GET: ProdutoController/Create
        public async Task<ActionResult> Create()
        {
            ProdutoModel produto = new ProdutoModel();

            IEnumerable<FabricanteModel> listaFabricantes = await _fabricante.GetAll();

            //produto.ListaFabricantes = new SelectList(listaFabricantes, "IdFabricante", "Nome", null);
            ViewBag.listaFabricantes = listaFabricantes;

            return View(produto);
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProdutoModel produto)
        {
            try
            {
                await _produto.Create(produto);
            }
            catch
            {
                return View(produto);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            return View(await _produto.Get(id));
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ProdutoModel produto)
        {
            if (id != produto.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    await _produto.Edit(produto, id);
                }
                catch
                {
                    return View(produto);
                }
            }
            return RedirectToAction(nameof(HomeController.Index));
        }

        // GET: ProdutoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await _produto.Get(id));
        }

        // POST: ProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            await _produto.Delete(id);

            return RedirectToAction(nameof(HomeController.Index));
        }

        // GET: ProdutoController/Delete/5
        public async Task<ActionResult> GetCategorias(int id)
        {
            return PartialView(await _fabricante.GetCategoriasById(id));
        }
    }
}
