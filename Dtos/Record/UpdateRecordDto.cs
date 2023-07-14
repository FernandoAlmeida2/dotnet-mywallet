namespace dotnet_mywallet.Dtos.Record
{
    public class UpdateRecordDto
    {
        public int Amount { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}