using Microsoft.AspNetCore.Mvc;
using PetCareConnect.App.ViewModels;
using PetCareConnect.Business.Enums;
using PetCareConnect.Business.Models;
using PetCareConnect.Data.Contexts;
using System.Diagnostics;

namespace PetCareConnect.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appdbcontext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appdbcontext)
        {
            _logger = logger;
            this.appdbcontext = appdbcontext;
        }

        public IActionResult Index()
        {
            var endereco = new EnderecoPrestador() { Bairro = "Jd.Ana", Cep = "12365498", Cidade="Sao Paulo", Estado="SP", Id=Guid.NewGuid(), Logradouro="Rua elzinha" };
            var vendedor = new Vendedor(nome:"Joel", documento:"1234567", imagem:"ft.png", enderecoPrestador: endereco);
            var freelancer = new Freelancer(nome:"Jefrs", documento:"1234567", imagem:"ft.png", enderecoPrestador: endereco);
            var petshop = new PetShop(nome:"PetMaiau", documento:"1234567", imagem:"ft.png", enderecoPrestador: endereco);

            appdbcontext.Add(vendedor);
            appdbcontext.Add(freelancer);
            appdbcontext.Add(petshop);

            appdbcontext.SaveChanges();

            return View();
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
