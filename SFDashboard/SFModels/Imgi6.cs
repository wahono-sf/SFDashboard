using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgi6")]
    public partial class Imgi6
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(255)]
        public string? ProductCode { get; set; }
        public int? ProductTrxNo { get; set; }
        public int? Qty { get; set; }
        public int? ReceiptNoteLineItemNo { get; set; }
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        public int? ReceiptQty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
