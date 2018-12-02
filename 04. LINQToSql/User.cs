using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace _04.LINQToSql
{
    [Table(Name = "users")]
    public class User
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "firstname")]
        public string Firstname { get; set; }
        [Column(Name = "lastname")]
        [StringLength(50)]
        public string Lastname { get; set; }
    }
}