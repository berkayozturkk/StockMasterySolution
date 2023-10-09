using Application.Features.Items.Queries.GetListStockExtract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : BaseController
    {
        [HttpGet("GetListStockExtract")]
        public async Task<IActionResult> GetListStockExtract([FromQuery] GetListStockExtractQuery getListStockExtractQuery)
        {
            GetListStockExtractResponse response = await Mediator.Send(getListStockExtractQuery);

            return Ok(response);
        }
    }
}
