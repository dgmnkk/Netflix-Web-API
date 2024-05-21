using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Netflix_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService genresService;
        
        public GenresController(IGenresService genresService)
        {
            this.genresService = genresService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await genresService.GetAll());
        }
    }
}
