using dotnet_mywallet.Models;

namespace dotnet_mywallet.Repositories.RecordRepository
{
    public interface IRecordRepository
    {
        Task<int> InsertOne(Record newRecord);
        Task<List<Record>> FindAll();
        Task<Record?> FindRecordById(int id);
        Task<bool> UpdateAmount(int id, int newAmount);
        Task<bool> DeleteOne(int id);
    }
}