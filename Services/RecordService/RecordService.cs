using dotnet_mywallet.Dtos.Record;
using dotnet_mywallet.Models;

namespace dotnet_mywallet.Services.RecordService
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepo;

        public RecordService(IRecordRepository recordRepo)
        {
            _recordRepo = recordRepo;
        }
        public async Task<ServiceResponse<int>> SaveRecord(SaveRecordReqDto newRecord)
        {
            var response = new ServiceResponse<int>();
            var record = new Record
            {
                Amount = newRecord.Amount,
                Type = newRecord.Type
            };

            response.Data = await _recordRepo.InsertOne(record);
            response.Message = "Record saved successfully!";

            return response;
        }
    }
}