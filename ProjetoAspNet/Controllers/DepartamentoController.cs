using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAspNet.Models;

namespace ProjetoAspNet.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Nome = "Eletronics" });
            list.Add(new Departamento { Id = 2, Nome = "Fashion" });

            return View(list);
        }
    }
}
