using SE.ApplicationCore.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SE.ApplicationCore.Interfaces;

namespace SE.WebApplication.Controllers
{
    public class PrestationController : Controller
    {
        IPrestationService Ps;
        IPrestataireService Ts;
        IClientService Cs;
        public PrestationController(IPrestationService Ps, IPrestataireService Ts, IClientService Cs)
        {
            this.Ps = Ps;
            this.Ts = Ts;
            this.Cs = Cs;
        }
        // GET: PrestationController
        public ActionResult Index()
        {
            
            
            return View(Ps.GetAll().OrderBy(p=>p.HeureDebut));
        }

        // GET: PrestationController/Details/5
        public ActionResult Details(int id)
        {
            return View(Ts.GetById(id));
        }

        // GET: PrestationController/Create
        public ActionResult Create()
        {
            ViewBag.PrestataireFK = new SelectList(Ts.GetAll(), "PrestataireId", "PrestataireNom");
            ViewBag.ClientFK = new SelectList(Cs.GetAll(), "ClientId", "ClientId");
            return View();
        }

        // POST: PrestationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Prestation collection)
        {
            try
            {
                Ps.Add(collection);
                Ps.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrestationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestationController/Edit/5
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

        // GET: PrestationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestationController/Delete/5
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
