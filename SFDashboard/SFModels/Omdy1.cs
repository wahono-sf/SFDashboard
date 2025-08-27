using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omdy1")]
    public partial class Omdy1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal? BalanceQty { get; set; }
        [StringLength(12)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(30)]
        public string? MasterJobNo { get; set; }
        [StringLength(12)]
        public string? OnHandNo { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
