using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sanm1")]
    [Index("UserGroup", Name = "IX_Sanm1_UserGroup_1")]
    public partial class Sanm1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? Cycle { get; set; }
        [StringLength(3)]
        public string? DateType { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(10)]
        public string? EndNo { get; set; }
        [StringLength(50)]
        public string? InvType { get; set; }
        [StringLength(500)]
        public string? JobType { get; set; }
        [StringLength(10)]
        public string? NextNo { get; set; }
        [StringLength(10)]
        public string? NumberType { get; set; }
        [StringLength(50)]
        public string? Prefix { get; set; }
        [StringLength(10)]
        public string? PromptNextNo { get; set; }
        [StringLength(5)]
        public string? ShipmentType { get; set; }
        [StringLength(50)]
        public string? Suffix { get; set; }
        [StringLength(50)]
        public string? TrxType { get; set; }
        [StringLength(10)]
        public string? UserGroup { get; set; }
        [StringLength(70)]
        public string? VatCode { get; set; }
        [StringLength(50)]
        public string? VoucherType { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
    }
}
