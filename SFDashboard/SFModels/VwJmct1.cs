using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmct1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Status")]
        [StringLength(13)]
        public string? ContainerStatus { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Depot In Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DepotInDate { get; set; }
        [Column("Depot Out Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DepotOutDate { get; set; }
        [Column("Detention Free Days")]
        public int? DetentionFreeDays { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("ETD")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Etd { get; set; }
        [Column("Free Days")]
        public int? FreeDays { get; set; }
        [Column("Gate In Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? GateInDate { get; set; }
        [Column("Gate Out Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? GateOutDate { get; set; }
        [Column("Inbound Commodity")]
        [StringLength(100)]
        public string? InboundCommodity { get; set; }
        [Column("Inbound Demurrage Amt", TypeName = "decimal(13, 2)")]
        public decimal? InboundDemurrageAmt { get; set; }
        [Column("Inbound Demurrage Free Days")]
        public int? InboundDemurrageFreeDays { get; set; }
        [Column("Inbound Detention Amt", TypeName = "decimal(13, 2)")]
        public decimal? InboundDetentionAmt { get; set; }
        [Column("Inbound Last Date Before Demurrage")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InboundLastDateBeforeDemurrage { get; set; }
        [Column("Inbound Obl No")]
        [StringLength(30)]
        public string? InboundOblNo { get; set; }
        [Column("Inbound Port Of Discharge Code")]
        [StringLength(5)]
        public string? InboundPortOfDischargeCode { get; set; }
        [Column("Inbound Port Of Loading Code")]
        [StringLength(5)]
        public string? InboundPortOfLoadingCode { get; set; }
        [Column("Inbound Terminal")]
        [StringLength(20)]
        public string? InboundTerminal { get; set; }
        [Column("Inbound Vessel")]
        [StringLength(50)]
        public string? InboundVessel { get; set; }
        [Column("Inbound Voyage")]
        [StringLength(50)]
        public string? InboundVoyage { get; set; }
        [Column("Last Date Before Detention")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastDateBeforeDetention { get; set; }
        [Column("Inbound Warehouse")]
        [StringLength(3)]
        public string? InboundWarehouse { get; set; }
        [Column("Lesser Code")]
        [StringLength(10)]
        public string? LesserCode { get; set; }
        [Column("Outbound Commodity")]
        [StringLength(100)]
        public string? OutboundCommodity { get; set; }
        [Column("Outbound Demurrage Amt", TypeName = "decimal(13, 2)")]
        public decimal? OutboundDemurrageAmt { get; set; }
        [Column("Outbound Demurrage Free Days")]
        public int? OutboundDemurrageFreeDays { get; set; }
        [Column("Outbound Detention Amt", TypeName = "decimal(13, 2)")]
        public decimal? OutboundDetentionAmt { get; set; }
        [Column("Outbound Detention Free Days")]
        public int? OutboundDetentionFreeDays { get; set; }
        [Column("Outbound Laden Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OutboundLadenDate { get; set; }
        [Column("Outbound Last Date Before Demurrage")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OutboundLastDateBeforeDemurrage { get; set; }
        [Column("Outbound Last Date Before Detention")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OutboundLastDateBeforeDetention { get; set; }
        [Column("Outbound Obl No")]
        [StringLength(30)]
        public string? OutboundOblNo { get; set; }
        [Column("Outbound Port Of Discharge Code")]
        [StringLength(5)]
        public string? OutboundPortOfDischargeCode { get; set; }
        [Column("Outbound Port Of Loading Code")]
        [StringLength(5)]
        public string? OutboundPortOfLoadingCode { get; set; }
        [Column("Outbound Terminal")]
        [StringLength(20)]
        public string? OutboundTerminal { get; set; }
        [Column("Outbound Vessel")]
        [StringLength(50)]
        public string? OutboundVessel { get; set; }
        [Column("Outbound Voyage")]
        [StringLength(50)]
        public string? OutboundVoyage { get; set; }
        [Column("Outbound Warehouse")]
        [StringLength(3)]
        public string? OutboundWarehouse { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(3)]
        public string Status { get; set; } = null!;
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
