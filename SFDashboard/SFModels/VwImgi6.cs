using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImgi6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        public int? Qty { get; set; }
        [Column("Receipt Note Line Item No")]
        public int? ReceiptNoteLineItemNo { get; set; }
        [Column("Receipt Note No")]
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        [Column("Receipt Qty")]
        public int? ReceiptQty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
