using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_mywallet.Models
{
    [Table("records")]
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public User? User { get; set; }
        public int Amount { get; set; }
        public RecordType Type { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}