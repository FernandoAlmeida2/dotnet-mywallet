using dotnet_mywallet.Models;

namespace dotnet_mywallet.Repositories.RecordRepository
{
    public interface IRecordRepository
    {
        Task<int> InsertOne(Record newRecord);
        Task<List<Record>> FindAll();
        Task<bool> UpdateAmount(int id, int newAmount);
    }
}