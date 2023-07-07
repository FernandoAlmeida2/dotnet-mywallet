using System.Text.Json.Serialization;

namespace dotnet_mywallet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordType
    {
        Income = 1,
        Expense = 2
    }
}