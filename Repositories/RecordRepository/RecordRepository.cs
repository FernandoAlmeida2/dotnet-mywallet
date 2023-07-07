using dotnet_mywallet.Contexts;
using dotnet_mywallet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mywallet.Repositories.RecordRepository
{
    public class RecordRepository : IRecordRepository
    {
        private readonly DataContext _dbContext;
        private readonly IUserContext _userContext;

        public RecordRepository(DataContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
        }

        public async Task<List<Record>> FindAll()
        {
            return await _dbContext.Records
                .Where(r => r.User!.Id == _userContext.GetUserId()).ToListAsync();
        }

        public async Task<int> InsertOne(Record newRecord)
        {
            newRecord.User = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Id == _userContext.GetUserId());
                
            _dbContext.Records.Add(newRecord);
            await _dbContext.SaveChangesAsync();

            return newRecord.Id;
        }

        public async Task<bool> UpdateAmount(int id, int newAmount)
        {
            var record = await _dbContext.Records
                .FirstOrDefaultAsync(r => r.Id == id && r.User!.Id == _userContext.GetUserId());

            if(record is null) return false;

            record.Amount = newAmount;
            await _dbContext.SaveChangesAsync();

            return true;

        }
    }
}