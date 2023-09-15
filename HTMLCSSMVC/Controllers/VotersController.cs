using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotersClassLibrary.Repository;
using VotersClassLibrary.VotersModel;

namespace HTMLCSSMVC.Controllers
{
    public class VotersController : Controller
    {
        // GET: VotersController
        VotersMethod obj = new VotersMethod();
        CityMethod obj1 = new CityMethod();

        public VotersController()
        {
            obj = new VotersMethod();
            obj1 = new CityMethod();
        }
        public ActionResult List()
        {
            return View("List",obj.SelectSP());
        }

        // GET: VotersController/Details/5
        public ActionResult Details(int VoterID)
        {
            var result = obj.SelectSp1(VoterID);
            return View("Details",result);
        }

        // GET: VotersController/Create
        public ActionResult Create()
        {
            var model = new Voters();
            model.Cityname = obj1.SelectSP();
            return View("Create", model);
        }

        // POST: VotersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Voters data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.InsertSP(data);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    data.Cityname = obj1.SelectSP();
                    return View("Create", data);
                }
                //obj.InsertSP(collection);
                //return RedirectToAction(nameof(List));
            }
            catch(Exception ex)
            {
                return View("error");
            }
        }

        // GET: VotersController/Edit/5
        public ActionResult Edit(int VoterID)
        {
            var result = obj.SelectSp1(VoterID);
            return View("Edit",result);
        }

        // POST: VotersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int VoterID, Voters data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.updateSP(data);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Edit", new Voters());
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: VotersController/Delete/5
        public ActionResult Delete(int VoterID)
        {
            var res = obj.SelectSp1(VoterID);
            return View("Delete",res);
        }

        // POST: VotersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int VoterID, Voters data)
        {
            try
            {
                obj.deleteSP(VoterID);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
