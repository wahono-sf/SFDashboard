using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slbs1")]
    public partial class Slbs1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? BankSlipNo { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BankSlipDate { get; set; }
        [StringLength(10)]
        public string? BankSlipType { get; set; }
        [StringLength(5)]
        public string? PayMode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
