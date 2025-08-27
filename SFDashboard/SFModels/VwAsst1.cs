using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAsst1
    {
        [Column("Airline ID")]
        [StringLength(2)]
        public string? AirlineId { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("DAwb Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? DawbChargeWeight { get; set; }
        [Column("DAwb Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? DawbFrtAmt { get; set; }
        [Column("DAwb Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? DawbFrtCostAmt { get; set; }
        [Column("DAwb Pcs")]
        public int? DawbPcs { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Frt Bill Amt", TypeName = "decimal(13, 2)")]
        public decimal? FrtBillAmt { get; set; }
        [Column("HAwb Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? HawbChargeWeight { get; set; }
        [Column("HAwb Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? HawbFrtAmt { get; set; }
        [Column("HAwb Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? HawbFrtCostAmt { get; set; }
        [Column("HAwb Pcs")]
        public int? HawbPcs { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string? JobMth { get; set; }
        [Column("Mawb Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? MawbChargeWeight { get; set; }
        [Column("MAwb Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? MawbFrtAmt { get; set; }
        [Column("MAwb Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? MawbFrtCostAmt { get; set; }
        [Column("MAwb Pcs")]
        public int? MawbPcs { get; set; }
        [Column("No Of DAwb Use")]
        public int? NoOfDawbUse { get; set; }
        [Column("No Of HAwb Use")]
        public int? NoOfHawbUse { get; set; }
        [Column("No Of MAwb Use")]
        public int? NoOfMawbUse { get; set; }
        [Column("No Of DAwb Shipment")]
        public int? NoOfDawbShipment { get; set; }
        [Column("No Of HAwb Shipment")]
        public int? NoOfHawbShipment { get; set; }
        [Column("No Of MAwb Shipment")]
        public int? NoOfMawbShipment { get; set; }
        [Column("No Of Other Shipment")]
        public int? NoOfOtherShipment { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Other Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? OtherChargeWeight { get; set; }
        [Column("Other Pcs")]
        public int? OtherPcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtAmt { get; set; }
        [Column("Total Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtCostAmt { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total No Of Shipment")]
        public int? TotalNoOfShipment { get; set; }
        [Column("Total Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalSalesAmt { get; set; }
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
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
