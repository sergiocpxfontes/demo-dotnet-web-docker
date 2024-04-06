
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppPipeline.Controllers
{
    public class IndividuoController : Controller
    {
        // GET: IndividuoController
        public ActionResult Index()
        {
            List<Individuo> lst = new List<Individuo>();

            lst.Add(new Individuo { Nome = "Sergio", Apelido = "Fontes", DataNasc = new DateTime(1998, 12, 23) });
            lst.Add(new Individuo { Nome = "Maria", Apelido = "Antunes", DataNasc = new DateTime(1998, 12, 23) });

            lst.Add(new Individuo { Nome = "Jose", Apelido = "Januario", DataNasc = new DateTime(1998, 12, 23) });

            return View(lst);
        }

        // GET: IndividuoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IndividuoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndividuoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: IndividuoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IndividuoController/Edit/5
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

        // GET: IndividuoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IndividuoController/Delete/5
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
