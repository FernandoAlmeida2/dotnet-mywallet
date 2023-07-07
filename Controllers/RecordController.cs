using dotnet_mywallet.Dtos.Record;
using dotnet_mywallet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mywallet.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/record")]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _recordService;

        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<int>>> PostRecord(SaveRecordReqDto record)
        {
            return Created("Save a record", await _recordService.SaveRecord(record));
        }
    }
}