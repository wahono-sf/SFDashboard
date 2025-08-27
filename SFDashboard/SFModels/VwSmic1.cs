using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmic1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Baf Rate", TypeName = "decimal(13, 3)")]
        public decimal? BafRate { get; set; }
        [Column("Baf Uom Code")]
        [StringLength(3)]
        public string? BafUomCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Ddc Rate", TypeName = "decimal(13, 3)")]
        public decimal? DdcRate { get; set; }
        [Column("Ddc Uom Code")]
        [StringLength(3)]
        public string? DdcUomCode { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column("Origin Code")]
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
        [Column("Oversea Agent No")]
        [StringLength(10)]
        public string OverseaAgentNo { get; set; } = null!;
        [Column("Shipping Line Code")]
        [StringLength(12)]
        public string? ShippingLineCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? Via { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
