using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Netflix_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectionsController : ControllerBase
    {
        private readonly ISelectionsService selectionsService;

        public SelectionsController(ISelectionsService selectionsService)
        {
            this.selectionsService = selectionsService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await selectionsService.GetAll());
        }
    }
}
