using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmct1")]
    public partial class Jmct1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(13)]
        public string? ContainerStatus { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepotInDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepotOutDate { get; set; }
        public int? DetentionFreeDays { get; set; }
        [Column("ETA", TypeName = "datetime")]
        public DateTime? Eta { get; set; }
        [Column("ETD", TypeName = "datetime")]
        public DateTime? Etd { get; set; }
        public int? FreeDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GateInDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? GateOutDate { get; set; }
        [StringLength(100)]
        public string? InboundCommodity { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InboundDemurrageAmt { get; set; }
        public int? InboundDemurrageFreeDays { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InboundDetentionAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InboundLastDateBeforeDemurrage { get; set; }
        [StringLength(30)]
        public string? InboundOblNo { get; set; }
        [StringLength(5)]
        public string? InboundPortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? InboundPortOfLoadingCode { get; set; }
        [StringLength(20)]
        public string? InboundTerminal { get; set; }
        [StringLength(50)]
        public string? InboundVessel { get; set; }
        [StringLength(50)]
        public string? InboundVoyage { get; set; }
        [StringLength(3)]
        public string? InboundWarehouse { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastDateBeforeDetention { get; set; }
        [StringLength(10)]
        public string? LesserCode { get; set; }
        [StringLength(100)]
        public string? OutboundCommodity { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OutboundDemurrageAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OutboundDetentionAmt { get; set; }
        public int? OutboundDemurrageFreeDays { get; set; }
        public int? OutboundDetentionFreeDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutboundLadenDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutboundLastDateBeforeDemurrage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutboundLastDateBeforeDetention { get; set; }
        [StringLength(30)]
        public string? OutboundOblNo { get; set; }
        [StringLength(5)]
        public string? OutboundPortOfDischargeCode { get; set; }
        [StringLength(5)]
        public string? OutboundPortOfLoadingCode { get; set; }
        [StringLength(20)]
        public string? OutboundTerminal { get; set; }
        [StringLength(50)]
        public string? OutboundVessel { get; set; }
        [StringLength(50)]
        public string? OutboundVoyage { get; set; }
        [StringLength(3)]
        public string? OutboundWarehouse { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
