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

        public async Task<ServiceResponse<List<RecordResDto>>> GetAll()
        {
            var response = new ServiceResponse<List<RecordResDto>>();

            var dbRecords = await _recordRepo.FindAll();
            response.Data = dbRecords.Select(r => new RecordResDto {
                Id = r.Id,
                Amount = r.Amount,
                Type = r.Type,
                CreatedAt = r.CreatedAt
            }).ToList();

            return response;
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

        public async Task<ServiceResponse<string>> PatchAmount(int id, int amount)
        {
            var response = new ServiceResponse<string>();
            try
            {
                var recordExists = await _recordRepo.UpdateAmount(id, amount);
                if (!recordExists) throw new Exception("Record not found");

                response.Data = "Ok";
                response.Message = "Amount updated successfully!";
            }
            catch (Exception ex) { response.HandleError(ex.Message); }

            return response;
        }
    }
}