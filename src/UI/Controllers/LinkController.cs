using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class LinkController : Controller
    {
        // GET: LinkController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LinkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LinkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LinkController/Create
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

        // GET: LinkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LinkController/Edit/5
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

        // GET: LinkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LinkController/Delete/5
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
