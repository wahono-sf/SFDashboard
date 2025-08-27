using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imms1")]
    public partial class Imms1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? IssueFlag { get; set; }
        public short ReceiptLineItemNo { get; set; }
        public int? ReceiptTrxNo { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [StringLength(3)]
        public string Statuscode { get; set; } = null!;
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
