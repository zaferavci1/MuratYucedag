using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccesslayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_project.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var valuew = productManager.TGetList();
            return View(valuew);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult results = validationRules.Validate(product);
            if (results.IsValid) { 
            productManager.TInsert(product);
            return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = productManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                productManager.TUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
