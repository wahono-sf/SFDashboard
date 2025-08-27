using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImsd1
    {
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Issue Note No")]
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        [Column("Issue Line No")]
        public short? IssueLineNo { get; set; }
        [Column("Issue Qty")]
        public int? IssueQty { get; set; }
        [Column("Rcv Trx No")]
        public int? RcvTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("SO Trx No")]
        public int SoTrxNo { get; set; }
        [Column("SO Line Item No")]
        public short SoLineItemNo { get; set; }
    }
}
