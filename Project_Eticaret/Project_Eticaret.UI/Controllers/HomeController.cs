using Project_Eticaret.MODEL.Entities;
using Project_Eticaret.SERVICE.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Eticaret.UI.Controllers
{
    public class HomeController : Controller
    {
        CategoryService _categoryService;

        public HomeController()
        {
            _categoryService = new CategoryService();
        }
        public ActionResult Index()
        {
            return View();
        }
        // buradaki metot, PartialView ı yönlendirmekiçin kullanılır. bu attribute bu actionı sadece bu durumlarda çağırabileceğini belirtir. Bu attribute opsiyoneldir.
        [ChildActionOnly]
        public ActionResult CategoryList()
        {
            return PartialView("_CategoryList", _categoryService.GetActive());
        }
    }
}