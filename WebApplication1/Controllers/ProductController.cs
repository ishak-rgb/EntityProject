﻿using Busines.Abstrac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

        public class ProductController : ControllerBase
        {
            IProductService _productService;
            public ProductController(IProductService productService)
            {
                _productService = productService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _productService.GetAll();
                if (result.Success)
                {
                    return Ok(result.Data);
                }

                return BadRequest(result.Message);
            }
        }

    }

