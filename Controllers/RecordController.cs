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

        [HttpGet("getAll")]
        public async Task<ActionResult<ServiceResponse<List<RecordResDto>>>> GetAll()
        {
            return Ok(await _recordService.GetAll());
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<ServiceResponse<string>>> PatchAmount(int id, UpdateRecordDto request)
        {
            var response = await _recordService.PatchRecord(id, request.Amount, request.Description);
            if (!response.Success)
            {
                if(response.Message == "Record not found.") return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<string>>> DeleteRecord(int id)
        {
            var response = await _recordService.DeleteRecord(id);
            if (!response.Success)
            {
                if(response.Message == "Record not found.") return NotFound(response);
            }
            return Ok(response);
        }
    }
}