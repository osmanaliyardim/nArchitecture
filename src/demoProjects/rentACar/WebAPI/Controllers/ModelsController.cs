using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListQuery;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseController
    {
        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] CreateModelCommand createModelCommand)
        //{
        //    CreatedModelDto result = await Mediator.Send(createModelCommand);

        //    return Created("", result);
        //}

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new() { PageRequest = pageRequest };
            ModelListModel result = await Mediator.Send(getListModelQuery);

            return Ok(result);
        }
    }
}
