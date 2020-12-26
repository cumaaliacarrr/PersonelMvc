using PersonelMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMvc.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Merhaba()
        {

            var departman = new Departman() { Id=1,Ad="bilgi islem"};
            return View(departman);
        }
        [HttpPost]
        public ActionResult Test()
        {

            return Content("post edildi");
        }
        public ActionResult Sil(int Id)
        {
            return Content("Gelen Id:" + Id);
        }
    }
}