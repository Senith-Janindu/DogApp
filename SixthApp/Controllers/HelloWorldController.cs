using Microsoft.AspNetCore.Mvc;
using SixthApp.Models;

namespace SixthApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            //DogViewModel model = new DogViewModel() 
            //{ Name = "Sasha" ,Age = 2};
            return View(dogs);
        }

        public IActionResult Create() 
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) 
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
            //return View("Index");
        }

        public string Hello() 
        {
            return "Who's there?";
        }
    }
}
