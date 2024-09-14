using Microsoft.AspNetCore.Mvc;
using OtoSatisServis.Entities;
using OtoSatisServis.Service.Abstract;
using OtoSatisServis.WebUI.Models;
using System.Diagnostics;

namespace OtoSatisServis.WebUI.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IService<Slider> _service;
        private readonly ICarService _serviceArac;

        public HomeController(IService<Slider> service, ICarService serviceArac)
        {
            _service = service;
            _serviceArac = serviceArac;
        }

        public  async Task<IActionResult> IndexAsync()
        {
            var model = new HomePageViewModel() 
            {
            Sliders = await _service.GetAllAsync(),
            Araclar = await _serviceArac.GetCustomCarList(a => a.Anasayfa)

            };


              

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AccessDenied")]
        public IActionResult AccessDenied()
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
