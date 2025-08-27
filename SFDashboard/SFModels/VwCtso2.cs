using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwCtso2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Actual Detention Charge", TypeName = "decimal(13, 2)")]
        public decimal? ActualDetentionCharge { get; set; }
        [Column("Collection Remarks")]
        [StringLength(255)]
        public string? CollectionRemarks { get; set; }
        [Column("Computed Detention Charge", TypeName = "decimal(13, 2)")]
        public decimal? ComputedDetentionCharge { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Demurrage Amt", TypeName = "decimal(20, 2)")]
        public decimal? DemurrageAmt { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Detention Amt", TypeName = "decimal(20, 2)")]
        public decimal? DetentionAmt { get; set; }
        [Column("Edi Count")]
        public int? EdiCount { get; set; }
        [Column("Free Days")]
        public int? FreeDays { get; set; }
        [Column("Receive Batch No")]
        [StringLength(20)]
        public string? ReceiveBatchNo { get; set; }
        [Column("Receive Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiveDate { get; set; }
        [Column("Return Type")]
        [StringLength(2)]
        public string? ReturnType { get; set; }
        [Column("Rv Flag")]
        [StringLength(1)]
        public string? RvFlag { get; set; }
        [StringLength(3)]
        public string? State { get; set; }
        [Column("Survey Remarks")]
        [StringLength(255)]
        public string? SurveyRemarks { get; set; }
        [Column("Trucker Name")]
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [Column("Vehicle No")]
        [StringLength(20)]
        public string? VehicleNo { get; set; }
    }
}
