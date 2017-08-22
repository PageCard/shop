using FineUIMvc.EmptyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FineUIMvc.EmptyProject.Controllers
{
    public class indexController : Controller
    {
        //
        // GET: /index/
        public ActionResult Index()
        {
            Entities bb = new Entities();
            IQueryable<A_HG_HG> dddd = from obj in bb.A_HG_HG
                                       select obj;


            IList<A_HG_HG> ggg = dddd.ToList();
            Response.Write(ggg[0].Headurl.ToString());
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnHello_Click()
        {
            Alert.Show("你好 FineUI！", MessageBoxIcon.Warning);

            return UIHelper.Result();
        }

        //
        // GET: /index/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /index/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /index/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /index/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /index/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /index/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /index/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
