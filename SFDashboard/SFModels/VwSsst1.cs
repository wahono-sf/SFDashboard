using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSsst1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string ConsigneeCode { get; set; } = null!;
        [Column("Customer Code")]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("D Bl Pcs")]
        public int? DBlPcs { get; set; }
        [Column("D Bl Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? DBlChargeWeight { get; set; }
        [Column("D Bl Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? DBlFrtAmt { get; set; }
        [Column("D Bl Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? DBlFrtCostAmt { get; set; }
        [Column("Frt Bill Amt", TypeName = "decimal(13, 2)")]
        public decimal? FrtBillAmt { get; set; }
        [Column("H Bl Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? HBlChargeWeight { get; set; }
        [Column("H Bl Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? HBlFrtAmt { get; set; }
        [Column("H Bl Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? HBlFrtCostAmt { get; set; }
        [Column("H Bl Pcs")]
        public int? HBlPcs { get; set; }
        [Column("Job Mth")]
        [StringLength(6)]
        public string JobMth { get; set; } = null!;
        [Column("M Bl Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? MBlChargeWeight { get; set; }
        [Column("Mbl Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? MblFrtAmt { get; set; }
        [Column("M Bl Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? MBlFrtCostAmt { get; set; }
        [Column("M Bl Pcs")]
        public int? MBlPcs { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [Column("No Of D Bl Shipment")]
        public int? NoOfDBlShipment { get; set; }
        [Column("No Of D Bl Use")]
        public int? NoOfDBlUse { get; set; }
        [Column("No Of H Bl Shipment")]
        public int? NoOfHBlShipment { get; set; }
        [Column("No Of H Bl Use")]
        public int? NoOfHBlUse { get; set; }
        [Column("No Of M Bl Shipment")]
        public int? NoOfMBlShipment { get; set; }
        [Column("No Of M Bl Use")]
        public int? NoOfMBlUse { get; set; }
        [Column("No Of Other Shipment")]
        public int? NoOfOtherShipment { get; set; }
        [Column("Other Charge Weight", TypeName = "decimal(13, 2)")]
        public decimal? OtherChargeWeight { get; set; }
        [Column("Other Pcs")]
        public int? OtherPcs { get; set; }
        [Column("Port Of Discharge Code")]
        [StringLength(3)]
        public string PortOfDischargeCode { get; set; } = null!;
        [Column("Port Of Loading Code")]
        [StringLength(3)]
        public string PortOfLoadingCode { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Shipping Line Code")]
        [StringLength(12)]
        public string ShippingLineCode { get; set; } = null!;
        [Column("Total Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column("Total Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column("Total Frt Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtAmt { get; set; }
        [Column("Total Frt Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtCostAmt { get; set; }
        [Column("Total No Of Shipment")]
        public int? TotalNoOfShipment { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
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
