using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAnac1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Code")]
        [StringLength(3)]
        public string AwbCode { get; set; } = null!;
        [Column("Awb Length")]
        public int? AwbLength { get; set; }
        [Column("Awb Name")]
        [StringLength(50)]
        public string? AwbName { get; set; }
        [Column("Awb Type")]
        [StringLength(1)]
        public string? AwbType { get; set; }
        [Column("Check Digit Flag")]
        [StringLength(1)]
        public string? CheckDigitFlag { get; set; }
        [Column("Last Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastReceiptDate { get; set; }
        [Column("Last Use Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastUseDate { get; set; }
        [Column("Last Yr Awb Use")]
        public int? LastYrAwbUse { get; set; }
        [Column("Mtd Awb Use")]
        public int? MtdAwbUse { get; set; }
        [Column("Neutral Awb Flag")]
        [StringLength(1)]
        public string? NeutralAwbFlag { get; set; }
        [Column("Qty On Hand")]
        public int? QtyOnHand { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Reorder Qty")]
        public int? ReorderQty { get; set; }
        [Column("Ytd Awb Use")]
        public int? YtdAwbUse { get; set; }
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
        public string? Status { get; set; }
    }
}
