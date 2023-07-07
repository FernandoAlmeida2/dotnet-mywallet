using dotnet_mywallet.Models;

namespace dotnet_mywallet.Dtos.Record
{
    public class SaveRecordReqDto
    {
        public int Amount { get; set; }
        public RecordType Type { get; set; }
    }
}