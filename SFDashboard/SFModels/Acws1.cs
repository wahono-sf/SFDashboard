using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acws1")]
    public partial class Acws1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("WHoldTaxCode")]
        [StringLength(3)]
        public string? WholdTaxCode { get; set; }
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
    }
}
