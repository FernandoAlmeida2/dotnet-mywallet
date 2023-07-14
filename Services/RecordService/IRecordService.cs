using dotnet_mywallet.Dtos.Record;
using dotnet_mywallet.Models;

namespace dotnet_mywallet.Services.RecordService
{
    public interface IRecordService
    {
        Task<ServiceResponse<int>> SaveRecord(SaveRecordReqDto newRecord);
        Task<ServiceResponse<List<RecordResDto>>> GetAll();
        Task<ServiceResponse<string>> PatchRecord(int id, int amount, string description);
        Task<ServiceResponse<string>> DeleteRecord(int id);
    }
}