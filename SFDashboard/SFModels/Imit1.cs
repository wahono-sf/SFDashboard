using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imit1")]
    [Index("CustomerCode", Name = "INDEX_Imit1_CustomerCode")]
    [Index("GoodsTransferNoteNo", Name = "INDEX_Imit1_GoodsTransferNoteNo")]
    [Index("RefNo", Name = "INDEX_Imit1_RefNo")]
    [Index("TransferDateTime", Name = "INDEX_Imit1_TransferDateTime")]
    public partial class Imit1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(11)]
        public string GoodsTransferNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? TransferBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDateTime { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
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
