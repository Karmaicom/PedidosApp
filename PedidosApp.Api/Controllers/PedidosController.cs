using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PedidosApp.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return StatusCode(501);
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return StatusCode(501);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return StatusCode(501);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return StatusCode(501);
        }

    }
}
