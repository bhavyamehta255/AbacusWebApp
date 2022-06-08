using Microsoft.AspNetCore.Mvc;
using AbacusWebApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AbacusWebApp.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var model = new ExamViewModel();
            
            List<ExamsLevel> list = new List<ExamsLevel>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(new ExamsLevel { Id = i, Level = "Level" + i });
            }

            model.ExamList = list;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExamViewModel qnAViewModel)
        {
            if (ModelState.IsValid)
            {
                //API Call
                return RedirectToAction(nameof(Index));
            }
            return View(qnAViewModel);

        }
    }
}
