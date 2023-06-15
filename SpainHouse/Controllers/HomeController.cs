using Microsoft.AspNetCore.Mvc;
using SpainHouse.Models;
using System.Diagnostics;

namespace SpainHouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(
                new List<HouseViewModel>
                {
                    new HouseViewModel
                    {
                        Id = "R3304693",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4195000,
                        Area = 300,
                        BedroomsCount = 5,
                        Terrace = 25,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png"
                        }
                    },
                    new HouseViewModel
                    {
                        Id = "R3304692",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4183000,
                        Area = 280,
                        BedroomsCount = 6,
                        Terrace = 23,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/006_PEDROJAEN_DJI_0815-1.png",
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png"
                        }
                    },
                    new HouseViewModel
                    {
                        Id = "R3304695",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4195000,
                        Area = 300,
                        BedroomsCount = 5,
                        Terrace = 25,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png",
                            "https://ltdfoto.ru/images/2023/06/15/006_PEDROJAEN_DJI_0815-1.png"
                        }
                    },
                    new HouseViewModel
                    {
                        Id = "R3304256",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4183000,
                        Area = 280,
                        BedroomsCount = 6,
                        Terrace = 23,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png",
                            "https://ltdfoto.ru/images/2023/06/15/006_PEDROJAEN_DJI_0815-1.png"
                        }
                    },
                    new HouseViewModel
                    {
                        Id = "R3304693",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4195000,
                        Area = 300,
                        BedroomsCount = 5,
                        Terrace = 25,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png"
                        }
                    },
                    new HouseViewModel
                    {
                        Id = "R3304693",
                        Town = "Fuengirola",
                        Name = "Элитная вилла в стиле модерн",
                        Price = 4195000,
                        Area = 300,
                        BedroomsCount = 5,
                        Terrace = 25,
                        ImageUrls = new List<string>
                        {
                            "https://ltdfoto.ru/images/2023/06/15/BBV-1.png"
                        }
                    },
                });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}