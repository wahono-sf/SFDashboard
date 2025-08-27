using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imsd1")]
    public partial class Imsd1
    {
        [Key]
        [Column("SOTrxNo")]
        public int SotrxNo { get; set; }
        [Column("SOLineItemNo")]
        public short SolineItemNo { get; set; }
        [StringLength(20)]
        public string? IssueNoteNo { get; set; }
        public short? IssueLineNo { get; set; }
        public int? IssueQty { get; set; }
        public int? RcvTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
