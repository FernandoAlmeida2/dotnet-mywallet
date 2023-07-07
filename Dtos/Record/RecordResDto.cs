using dotnet_mywallet.Models;

namespace dotnet_mywallet.Dtos.Record
{
    public class RecordResDto
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public RecordType Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}