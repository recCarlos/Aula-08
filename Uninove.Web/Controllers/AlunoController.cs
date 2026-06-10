using System;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;   

namespace Uninove.Web.Controllers;      

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Carlos Eduardo";
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "1º Semestre";
        
        return View();
    }
}