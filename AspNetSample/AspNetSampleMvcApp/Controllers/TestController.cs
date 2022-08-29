using System.Text;
using AspNetSampleMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers;


public class TestController : Controller
{
    //[NonAction] //Don't needed in real app with clean code
    public IActionResult Index()
    {
        var cat = new 
        {
            Name = "Vasily",
            Age = 15,
        };
        return Ok(cat);
    }

    [ActionName("Do")]
    public string DoSpecificThing()
    {
        return "cat Vasiliy";
    }


    [HttpGet]
    public string Test(int number, string str)
    {
        return $"{str}: {number} * {number} = {number*number}";
    }

    [HttpGet]
    public string Test2(TestModel model)
    {
        return $"{model.Id}: {model.Name} - {model.Age}";
    }

    [HttpGet]
    public string Test3(string[] names)
    {
        var sb = new StringBuilder();
        foreach (var name in names)
        {
            sb.AppendLine(name);
        }

        return $"{sb}";
    }

    [HttpGet]
    public string Test4()
    {
        TestModel[] models;

        var sb = new StringBuilder();

        //foreach (var model in models)
        //{
        //    sb.AppendLine($"{model.Id}: {model.Name} - {model.Age}");
        //}

        return $"{sb}";
    }


    [HttpGet]
    public IActionResult FillTest()
    {
        return View();
    }

    [HttpPost]
    public IActionResult FillTest(TestModel model)
    {
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult TypesOfResponses()
    {
        // return Content(""); - return string
        //return new EmptyResult();- 200 - equivalent of void Action in controller
        //return NoContent(); - 204
        //return File() -> file result
        //return FileStreamResult();
        //return View(); -> a lot of option

        //return RedirectToAction(); ->Redirect family

        return StatusCode(513, "");
        return Unauthorized();
        return Ok();
        return NotFound();
        return BadRequest();
    }
}