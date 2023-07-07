using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_mywallet.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "Anônimo";
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public List<Record>? Records { get; set; }
    }
}