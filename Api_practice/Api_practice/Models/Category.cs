using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_practice.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category : ControllerBase
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = "";
        public string ProductName{ get; set; } = "";
        public int Quantity { get; set; }
    }
}
