
using CliniSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CliniSoft.Controllers
{
    public class ChildrenController : Controller
    {
        Clinic _db = new Clinic();
        ChildrenViewModel Children = new ChildrenViewModel();
        Boolean isBd { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            var AllChildren = _db.Tbl_Childrens.ToList();
            Children.SelectedChildrens = AllChildren.FindAll(a => a.IsSelected == true).ToList<tbl_Children>();
            Children.UnSelectedChildrens = AllChildren.FindAll(a => a.IsSelected == false).ToList<tbl_Children>();
            return View(Children);
        }
        [HttpPost]
        public ActionResult SelectChild(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            var child = _db.Tbl_Childrens.SingleOrDefault(a => a.Id == id);
            isBd = child.BirthDate.Date.ToString("MM dd") == DateTime.Today.ToString("MM dd");
            if (isBd)
            {
                TempData["welcome"] = true;
                child.IsSelected = true;
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult UnSelectChild(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            _db.Tbl_Childrens.SingleOrDefault(a => a.Id == id).IsSelected = false;
            _db.SaveChanges();
            return RedirectToAction("index"); //--model
        }
    }
}