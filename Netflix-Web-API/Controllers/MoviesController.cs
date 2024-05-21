using BusinessLogic.DTOs;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netflix_Web_API.Helpers;

namespace Netflix_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesService moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await moviesService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await moviesService.Get(id));
        }

        [HttpGet("genres-{id:int}")]
        public async Task<IActionResult> GetByGenre([FromRoute] int id)
        {
            return Ok(await moviesService.GetByGenre(id));
        }

        [HttpGet("selection-{id:int}")]
        public async Task<IActionResult> GetBySelection([FromRoute] int id)
        {
            return Ok(await moviesService.GetBySelection(id));
        }

        [HttpPost]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = Policies.PREMIUM_CLIENT)]
        public IActionResult Create([FromForm] CreateMovieModel model)
        {
            moviesService.Create(model);
            return Ok();
        }


        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Edit([FromBody] MovieDto model)
        {
            moviesService.Edit(model);
            return Ok();
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = Roles.ADMIN)]
        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            moviesService.Delete(id);
            return Ok();
        }
    }
}
