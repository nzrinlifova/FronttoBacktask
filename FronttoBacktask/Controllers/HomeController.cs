using FronttoBacktask.Models;
using FrontToBackTask.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            FeaturedCars c1 = new FeaturedCars()
            {
                Id = 1,
                Brand = "BMW 6 - series gran coupe",
                Model = "2017 3100 mi 240HP automatic",
                Price = 89395,
                ImgUrl = "~/assets/images/featured-cars/fc1.png"

            };
            FeaturedCars c2 = new FeaturedCars()
            {
                Id = 2,
                Brand = "chevrolet camaro wmv20",
                Model = "2017 3100 mi 240HP automatic",
                Price = 66575,
                ImgUrl = "~/assets/images/featured-cars/fc2.png"

            };
            FeaturedCars c3 = new FeaturedCars()
            {
                Id = 3,
                Brand = "lamborghini v520",
                Model = "2017 3100 mi 240HP automatic",
                Price = 125250,
                ImgUrl = "~/assets/images/featured-cars/fc3.png"

            };
            FeaturedCars c4 = new FeaturedCars()
            {
                Id = 4,
                Brand = "audi a3 sedan",
                Model = "2017 3100 mi 240HP automatic",
                Price = 95500,
                ImgUrl = "~/assets/images/featured-cars/fc4.png"

            };
            FeaturedCars c5 = new FeaturedCars()
            {
                Id = 5,
                Brand = "infiniti z5",
                Model = "2017 3100 mi 240HP automatic",
                Price = 36850,
                ImgUrl = "~/assets/images/featured-cars/fc5.png"

            };
            FeaturedCars c6 = new FeaturedCars()
            {
                Id = 6,
                Brand = "porsche 718 cayman",
                Model = "2017 3100 mi 240HP automatic",
                Price = 95500,
                ImgUrl = "~/assets/images/featured-cars/fc6.png"

            };
            FeaturedCars c7 = new FeaturedCars()
            {
                Id = 7,
                Brand = "bmw 8-series coupe",
                Model = "2017 3100 mi 240HP automatic",
                Price = 56000,
                ImgUrl = "~/assets/images/featured-cars/fc7.png"

            };
            FeaturedCars c8 = new FeaturedCars()
            {
                Id = 8,
                Brand = "BMW xseries-6",
                Model = "2017 3100 mi 240HP automatic",
                Price = 75800,
                ImgUrl = "~/assets/images/featured-cars/fc8.png"

            };
            ViewData["FeaturedCars"] = new List<FeaturedCars>() { c1, c2, c3, c4, c5, c6, c7, c8 };


            return View();
        }
    }
}
