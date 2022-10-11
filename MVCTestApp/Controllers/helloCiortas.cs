using Microsoft.AspNetCore.Mvc;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers
{
    public class helloCiortas : Controller
    {
        private List<CarViewModel> cars = new List<CarViewModel>();
        public IActionResult Index()
        {
            //CarViewModel car = new CarViewModel() { Make="BMW", Age=20};
            return View(cars);
        }

        public IActionResult Create()
        {
            var carVm = new CarViewModel();
            return View(carVm);
        }

        public IActionResult AddCar(CarViewModel carViewModel)
        {
            //return View("Index");
            cars.Add(carViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "hELLO FROM HELL!!";
        }
    }
}
