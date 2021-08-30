using Micro.Web.Models;
using Micro.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Micro.Web.Controllers
{
    public class ProductController : Controller
    {
        private string _accessToken { get { return HttpContext.GetTokenAsync("access_token").Result; } }
        private string _userId { get { return User.Claims.Where(u => u.Type == "sub")?.FirstOrDefault()?.Value; } }


        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {            
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductDto> productList = new();
            var response = await _productService.GetAllProductsAsync<ResponseDto>(_accessToken);
            if(response != null && response.IsSuccess)
                productList = JsonConvert.DeserializeObject<List<ProductDto>>(response.Result.ToString());

            return View(productList);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProductAsync<ResponseDto>(model, _accessToken);
                if (response != null && response.IsSuccess)
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId, _accessToken);
            if (response != null && response.IsSuccess)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(response.Result.ToString());
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProductAsync<ResponseDto>(model, _accessToken);
                if (response != null && response.IsSuccess)
                    return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId, _accessToken);
            if (response != null && response.IsSuccess)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(response.Result.ToString());
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ProductDto model)
        {
            var response = await _productService.DeleteProductAsync<ResponseDto>(model.ProductId, _accessToken);
            if (response != null && response.IsSuccess)
                return RedirectToAction(nameof(Index));

            return View(model);
        }
    }
}
