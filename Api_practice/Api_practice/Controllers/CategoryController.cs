using Api_practice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> categories = new List<Category>
        {
            new() {Id=1,BrandName="Samsung",ProductName="A27",Quantity=5},
            new() {Id=2,BrandName="Samsung",ProductName="A27",Quantity=5},
            new() {Id=3,BrandName="Samsung",ProductName="A27",Quantity=5},
            new() {Id=4,BrandName="Samsung",ProductName="A27",Quantity=5},
            new() {Id=5,BrandName="Samsung",ProductName="A27",Quantity=5},
        };

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        [HttpPost]
        public void  Post(Category category)
        {
            categories.Add(category);
        }
    }
}
