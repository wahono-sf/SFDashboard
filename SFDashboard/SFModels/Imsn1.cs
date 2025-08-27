using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imsn1")]
    [Index("IssueNoteNo", "IssueLineItemNo", Name = "IX_imsn1_IssueNote")]
    [Index("ReceiptNoteNo", "ReceiptLineItemNo", Name = "IX_imsn1_ReceiptNote")]
    public partial class Imsn1
    {
        [Key]
        public int TrxNo { get; set; }
        public int? IssueLineItemNo { get; set; }
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        public int? ReceiptLineItemNo { get; set; }
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        [StringLength(50)]
        public string? SerialNo { get; set; }
    }
}
