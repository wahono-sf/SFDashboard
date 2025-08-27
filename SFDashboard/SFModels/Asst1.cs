using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    [Table("asst1")]
    public partial class Asst1
    {
        [Column("AirlineID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("DAwbChargeWeight", TypeName = "decimal(13, 4)")]
        public decimal? DawbChargeWeight { get; set; }
        [Column("DAwbFrtAmt", TypeName = "decimal(13, 2)")]
        public decimal? DawbFrtAmt { get; set; }
        [Column("DAwbFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? DawbFrtCostAmt { get; set; }
        [Column("DAwbPcs")]
        public int? DawbPcs { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtBillAmt { get; set; }
        [Column("HAwbChargeWeight", TypeName = "decimal(13, 2)")]
        public decimal? HawbChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? HawbFrtAmt { get; set; }
        [Column("HAwbFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? HawbFrtCostAmt { get; set; }
        [Column("HAwbPcs")]
        public int? HawbPcs { get; set; }
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("MAwbChargeWeight", TypeName = "decimal(13, 4)")]
        public decimal? MawbChargeWeight { get; set; }
        [Column("MAwbFrtAmt", TypeName = "decimal(13, 2)")]
        public decimal? MawbFrtAmt { get; set; }
        [Column("MAwbFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? MawbFrtCostAmt { get; set; }
        [Column("MAwbPcs")]
        public int? MawbPcs { get; set; }
        [Column("NoOfDAwbUse")]
        public int? NoOfDawbUse { get; set; }
        [Column("NoOfHAwbUse")]
        public int? NoOfHawbUse { get; set; }
        [Column("NoOfMAwbUse")]
        public int? NoOfMawbUse { get; set; }
        [Column("NoOfDAwbShipment")]
        public int? NoOfDawbShipment { get; set; }
        public int? NoOfHawbShipment { get; set; }
        [Column("NoOfMAwbShipment")]
        public int? NoOfMawbShipment { get; set; }
        public int? NoOfOtherShipment { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherChargeWeight { get; set; }
        public int? OtherPcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtCostAmt { get; set; }
        public int? TotalPcs { get; set; }
        public int? TotalNoOfShipment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalSalesAmt { get; set; }
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
