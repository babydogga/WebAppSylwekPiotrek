using Microsoft.AspNetCore.Mvc;
using WebAppSylwek.Models;

namespace WebAppSylwek.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Book()
            {

            };
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id " + id);
        }
    }
}
