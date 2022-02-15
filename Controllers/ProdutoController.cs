using Microsoft.AspNetCore.Mvc;
using System;

namespace LojaWeb.Controllers
{
    public class ProdutoController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
