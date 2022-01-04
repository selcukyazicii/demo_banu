using demo_banu.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_banu.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category) //tüm inputlar
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var values = context.Categories.Find(id);
            return View("EditCategory",values); //güncellenen sayfa bilgileir yeni sayfaya taşındı
        }
        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            context.Update(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
