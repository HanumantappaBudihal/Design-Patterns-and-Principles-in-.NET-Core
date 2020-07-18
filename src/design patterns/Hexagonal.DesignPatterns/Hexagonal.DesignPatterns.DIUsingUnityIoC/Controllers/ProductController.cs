using Hexagonal.DesignPatterns.DIUsingUnityIoC.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hexagonal.DesignPatterns.DIUsingUnityIoC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        //inject dependency - Constructor inject
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
    }
}