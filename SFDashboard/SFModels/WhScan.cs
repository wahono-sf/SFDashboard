using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("WhScan")]
    public partial class WhScan
    {
        [StringLength(20)]
        public string? AsnNo { get; set; }
        [StringLength(50)]
        public string? BarCode { get; set; }
        [StringLength(50)]
        public string? ConfirmBy { get; set; }
        [StringLength(1)]
        public string? ConfirmType { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(20)]
        public string? GoodsIssueNoteNo { get; set; }
        public int? IssueNoteLineItemNo { get; set; }
        [StringLength(20)]
        public string? OldStoreNo { get; set; }
        [StringLength(20)]
        public string? OldWarehouseCode { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [StringLength(20)]
        public string? Qty { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column(TypeName = "ntext")]
        public string? SerialNo { get; set; }
        [StringLength(20)]
        public string? WarehouseCode { get; set; }
    }
}
