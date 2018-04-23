using System;
using System.Web;
using System.Web.Mvc;
using CS.Models;

namespace CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            if(Session["DataTableModel"] == null)
                Session["DataTableModel"] = InMemoryModel.OpenExcelFile();

            return View(Session["DataTableModel"]);
        }
        public ActionResult DataTableDataBindingPartial() {
            return PartialView(Session["DataTableModel"]);
        }
    }
}