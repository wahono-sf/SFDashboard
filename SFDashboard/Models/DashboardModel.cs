using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SFDashboard.Models
{
    public class DashboardModel
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName="nvarchar(50)")]
        public string fieldname { get; set; }
        public int value { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string type { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string source { get; set; }
    }
}
