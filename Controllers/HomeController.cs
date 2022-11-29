using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_da_turma_23.Models;

namespace Projeto_da_turma_23.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
