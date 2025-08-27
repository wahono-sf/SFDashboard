using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcsm1")]
    public partial class Rcsm1
    {
        [Key]
        [StringLength(10)]
        public string SalesmanCode { get; set; } = null!;
        [StringLength(50)]
        public string? SalesmanName { get; set; }
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(10)]
        public string? EmployeeCode { get; set; }
        [StringLength(30)]
        public string? Handphone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JoinDate { get; set; }
        [StringLength(8)]
        public string? Password { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ResignDate { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("AreaCode")]
        [InverseProperty("Rcsm1s")]
        public virtual Acar1? AreaCodeNavigation { get; set; }
        [ForeignKey("DivisionCode")]
        [InverseProperty("Rcsm1s")]
        public virtual Acdv1? DivisionCodeNavigation { get; set; }
    }
}
