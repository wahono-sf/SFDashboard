using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImsn1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Issue Line Item No")]
        public int? IssueLineItemNo { get; set; }
        [Column("Issue Note No")]
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        [Column("Receipt Line Item No")]
        public int? ReceiptLineItemNo { get; set; }
        [Column("Receipt Note No")]
        [StringLength(20)]
        public string? ReceiptNoteNo { get; set; }
        [Column("Serial No")]
        [StringLength(50)]
        public string? SerialNo { get; set; }
    }
}
