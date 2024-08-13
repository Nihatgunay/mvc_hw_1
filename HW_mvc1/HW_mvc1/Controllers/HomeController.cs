using HW_mvc1.Models;
using HW_mvc1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HW_mvc1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>
            {
                new Slide
                {
                    Id = 1,
                    Title = "Home 1",
                    Subtitle = "Sub1",
                    Description = "Description1",
                    ImageUrl = "1-1.png",
                    Order = 3
                },
                new Slide
                {
                    Id = 2,
                    Title = "Home 2",
                    Subtitle = "Sub2",
                    Description = "Description2",
                    ImageUrl = "1-2.png",
                    Order = 1
                },
                new Slide
                {
                    Id = 1,
                    Title = "Home 3",
                    Subtitle = "Sub3",
                    Description = "Description3",
                    ImageUrl = "1-3.png",
                    Order = 2
                }
            };
            HomeVM homeVM = new HomeVM
            {
                Slides = slides.OrderBy(x=>x.Order).Take(2).ToList(),
            };


            return View(homeVM);
        }
    }
}
