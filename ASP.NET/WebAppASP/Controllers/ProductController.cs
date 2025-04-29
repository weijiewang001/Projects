using Microsoft.AspNetCore.Mvc;
using WebAppASP.Models;
using System.Collections.Generic;

public class ProductController : Controller
{
  public IActionResult Index()
  {
    var products = new List<Product>
    {
      new Product { Id = 1, Name = "Laptop", Price = 1000},
      new Product { Id = 2, Name = "Phone", Price = 500}
    };
    return View(products);
  }
}