using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ctso2")]
    public partial class Ctso2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ActualDetentionCharge { get; set; }
        [StringLength(255)]
        public string? CollectionRemarks { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ComputedDetentionCharge { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? DemurrageAmt { get; set; }
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column(TypeName = "decimal(20, 2)")]
        public decimal? DetentionAmt { get; set; }
        public int? EdiCount { get; set; }
        public int? FreeDays { get; set; }
        [StringLength(20)]
        public string? ReceiveBatchNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiveDate { get; set; }
        [StringLength(2)]
        public string? ReturnType { get; set; }
        [StringLength(1)]
        public string? RvFlag { get; set; }
        [StringLength(3)]
        public string? State { get; set; }
        [StringLength(255)]
        public string? SurveyRemarks { get; set; }
        [StringLength(50)]
        public string? TruckerName { get; set; }
        [StringLength(20)]
        public string? VehicleNo { get; set; }
    }
}
