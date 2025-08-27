using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;


namespace SFDashboard.Models
{
  
    public class UserAccessID
    {
        [Key]
        public string UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserFullName { get; set; }
      
        public string? UserEmail { get; set; }
       
        public string? UserGroup { get; set; }
      
        public string? AccessRight { get; set; }
        public string? CompanyName { get; set; }
        public string? CustomerCode { get; set; }
       
        public string? DBName { get; set; }
        public string? ServerName { get; set; }
        public string? LoginID { get; set; }
        public string? PassDB { get; set; }

        public string? BlockUserFlag { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public string? Memo { get; set; }

        public string? Password { get; set; }

        public string? Remark { get; set; }

        public int? ResetPasswordDay { get; set; }
        public DateTime? ResignDate { get; set; }
        public int? RoleId { get; set; }
        public string? Telephone { get; set; }
        public string? Title { get; set; }
        public string? StatusCode { get; set; }
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        public int? MediumViewDisplayNonGraph { get; set; }
        public int? LargeViewDisplayNonGraph { get; set; }
        public int? MediumViewDisplayGraph { get; set; }
        public int? LargeViewDisplayGraph { get; set; }
       
    }
}
