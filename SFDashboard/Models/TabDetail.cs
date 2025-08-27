using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace SFDashboard.Models
{
    public class TabDetail 
    {
        [Key]
        public int TabCode { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string DashBoardName { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string Code { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string code2 { get; set; }
        [Key]
        [Column(TypeName = "nvarchar(30)")]
        public string CustomerCode { get; set; }

        [Key]
        public string UserId { get; set; }

        [NotMapped]
        public DashBoardDetails dbdashboard { get; set; }
        [NotMapped]
        public Tab tab { get; set; }


    }
}
