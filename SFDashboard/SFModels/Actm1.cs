using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("actm1")]
    public partial class Actm1
    {
        [Key]
        [StringLength(3)]
        public string TermCode { get; set; } = null!;
        [StringLength(50)]
        public string? TermDescription { get; set; }
        [StringLength(1)]
        public string? DiscountDateFlag { get; set; }
        public short? DiscountDay { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? DiscountPercent { get; set; }
        [StringLength(1)]
        public string? NetDateFlag { get; set; }
        public short? NetDay { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ServiceChargeMinAmt { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? ServiceChargePercent { get; set; }
        [StringLength(1)]
        public string? ShipmentDateFlag { get; set; }
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
