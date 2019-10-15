using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpellingGame.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpellingGame.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            Random rand = new Random();
            int test = rand.Next(1,3);
            ViewBag.Image = "images/image" + "0" + test + ".png";
            ViewBag.Occurrence = test;
            ViewData["occor"] = test;
            System.Diagnostics.Debug.WriteLine(test);
            System.Diagnostics.Debug.WriteLine("Inicio");
            return View();
        }
        [HttpPost]
        public ViewResult CheckAnswer(Form1 form)
        {
            System.Diagnostics.Debug.WriteLine("CheckAnswer");
            int i = Convert.ToInt32(TempData["Data2"]) - 1;
            //int i = form.Occurrence;
            System.Diagnostics.Debug.WriteLine(ImageRepository.Answers.ElementAt(i));
            System.Diagnostics.Debug.WriteLine(form.Answer);
            System.Diagnostics.Debug.WriteLine(i);
            if (ImageRepository.Answers.ElementAt(i) == form.Answer)
            {
                ModelState.Clear();
                return View("Correct");
            }
            else
           {
                ModelState.Clear();
                return View("Wrong");
           }
        }
    }
}
