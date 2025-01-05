using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SE.ApplicationCore.Domain;
using SE.ApplicationCore.Interfaces;

namespace SE.WebApplication.Controllers
{
    public class PresataireController : Controller
    {
        IPrestataireService Ts;
        public PresataireController(IPrestataireService Ts)
        {
            this.Ts = Ts;
        }
        // GET: PresataireController
        public ActionResult Index()
        {
            return View(Ts.GetAll().OrderBy(s=>s.PrestataireNom));
        }

        // GET: PresataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PresataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PresataireController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestataire collection)
        {
            try
            {
                Ts.Add(collection);
                Ts.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PresataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PresataireController/Edit/5
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

        // GET: PresataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PresataireController/Delete/5
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
