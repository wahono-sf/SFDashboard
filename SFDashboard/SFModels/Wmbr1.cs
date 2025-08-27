using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("wmbr1")]
    [Index("CustomerCode", Name = "INDEX_Wmbr1_CustomerCode")]
    [Index("EffectiveDate", Name = "INDEX_Wmbr1_EffectiveDate")]
    [Index("ExpiryDate", Name = "INDEX_Wmbr1_ExpiryDate")]
    [Index("TableNo", Name = "INDEX_Wmbr1_TableNo", IsUnique = true)]
    public partial class Wmbr1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string TableNo { get; set; } = null!;
        [StringLength(1)]
        public string? AutoGenerateInvFlag { get; set; }
        [StringLength(1)]
        public string? BillingDetailFlag { get; set; }
        public int? BillingStartDay { get; set; }
        [StringLength(12)]
        public string? ContractNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [StringLength(1)]
        public string? InvoiceByBatchFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinInvAmt { get; set; }
        public int? NoOfDefaultCycle { get; set; }
        public int? OnHoldPeriod { get; set; }
        [StringLength(10)]
        public string? ProductClass { get; set; }
        public int? ProductTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? RoundUpFlag { get; set; }
        [StringLength(1)]
        public string? StorageBillFlag { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
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
