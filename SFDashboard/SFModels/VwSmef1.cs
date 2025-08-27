using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmef1
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
        public string CurrCode { get; set; } = null!;
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
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
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string Via { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
