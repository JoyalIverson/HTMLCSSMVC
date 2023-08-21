using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLCSSMVC.Controllers
{
    public class FoodsController : Controller
    {
        // GET: FoodsController

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Quality()
        {
            return View();
        }
        // GET: FoodsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodsController/Create
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

        // GET: FoodsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodsController/Edit/5
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

        // GET: FoodsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodsController/Delete/5
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
