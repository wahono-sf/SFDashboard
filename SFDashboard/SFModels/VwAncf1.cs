using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAncf1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Code")]
        [StringLength(1)]
        public string AwbCode { get; set; } = null!;
        [Column("Awb Name")]
        [StringLength(50)]
        public string? AwbName { get; set; }
        [Column("Check Digit")]
        [StringLength(1)]
        public string? CheckDigit { get; set; }
        [Column("Last Yr Awb Use")]
        public int? LastYrAwbUse { get; set; }
        [Column("Last Yr Receive Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYrReceiveDate { get; set; }
        [Column("Last Yr Use Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastYrUseDate { get; set; }
        [Column("Mtd Awb Use")]
        public int? MtdAwbUse { get; set; }
        [Column("Qty On Hand")]
        public int? QtyOnHand { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Re Order Qty")]
        public int? ReOrderQty { get; set; }
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
        public string Status { get; set; } = null!;
    }
}
