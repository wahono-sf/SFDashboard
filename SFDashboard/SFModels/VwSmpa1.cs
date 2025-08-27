using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Approve Attachment Flag")]
        [StringLength(1)]
        public string? ApproveAttachmentFlag { get; set; }
        [Column("Baf Item Code")]
        [StringLength(30)]
        public string? BafItemCode { get; set; }
        [Column("Ca fItem Code")]
        [StringLength(30)]
        public string? CaFItemCode { get; set; }
        [Column("Check Effective Date")]
        [StringLength(1)]
        public string? CheckEffectiveDate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Party Type")]
        [StringLength(20)]
        public string? CustomerPartyType { get; set; }
        [Column("Ddc Item Code")]
        [StringLength(30)]
        public string? DdcItemCode { get; set; }
        [Column("Define Uom Code 01")]
        [StringLength(50)]
        public string? DefineUomCode01 { get; set; }
        [Column("Define Uom Code 02")]
        [StringLength(50)]
        public string? DefineUomCode02 { get; set; }
        [Column("Define Uom Code 03")]
        [StringLength(50)]
        public string? DefineUomCode03 { get; set; }
        [Column("Define Uom Code 04")]
        [StringLength(50)]
        public string? DefineUomCode04 { get; set; }
        [Column("Define Uom Code 05")]
        [StringLength(50)]
        public string? DefineUomCode05 { get; set; }
        [Column("Define Uom Code 06")]
        [StringLength(50)]
        public string? DefineUomCode06 { get; set; }
        [Column("Define Uom Code 07")]
        [StringLength(50)]
        public string? DefineUomCode07 { get; set; }
        [Column("Define Uom Code 08")]
        [StringLength(50)]
        public string? DefineUomCode08 { get; set; }
        [Column("Define Uom Code 09")]
        [StringLength(50)]
        public string? DefineUomCode09 { get; set; }
        [Column("Define Uom Code 10")]
        [StringLength(50)]
        public string? DefineUomCode10 { get; set; }
        [Column("Define Uom Code 11")]
        [StringLength(50)]
        public string? DefineUomCode11 { get; set; }
        [Column("Define Uom Code 12")]
        [StringLength(50)]
        public string? DefineUomCode12 { get; set; }
        [Column("Define Uom Code 13")]
        [StringLength(50)]
        public string? DefineUomCode13 { get; set; }
        [Column("Define Uom Code 14")]
        [StringLength(50)]
        public string? DefineUomCode14 { get; set; }
        [Column("Define Uom Code 15")]
        [StringLength(50)]
        public string? DefineUomCode15 { get; set; }
        [Column("Dg 20 Item Code")]
        [StringLength(30)]
        public string? Dg20ItemCode { get; set; }
        [Column("Dg 40 Item Code")]
        [StringLength(30)]
        public string? Dg40ItemCode { get; set; }
        [Column("Dg 40 Hc Item Code")]
        [StringLength(30)]
        public string? Dg40HcItemCode { get; set; }
        [Column("Dg Lcl Item Code")]
        [StringLength(30)]
        public string? DgLclItemCode { get; set; }
        [Column("Format Type")]
        [StringLength(1)]
        public string? FormatType { get; set; }
        [Column("Insert Default Charge Flag")]
        [StringLength(1)]
        public string? InsertDefaultChargeFlag { get; set; }
        [Column("ft Lcl Item Code")]
        [StringLength(30)]
        public string? FtLclItemCode { get; set; }
        [Column("ft 20 Item Code")]
        [StringLength(30)]
        public string? Ft20ItemCode { get; set; }
        [Column("ft 40 Item Code")]
        [StringLength(30)]
        public string? Ft40ItemCode { get; set; }
        [Column("ft 40 Hc Item Code")]
        [StringLength(30)]
        public string? Ft40HcItemCode { get; set; }
        [Column("Next Quote No")]
        [StringLength(10)]
        public string? NextQuoteNo { get; set; }
        [Column("Quotation Shipment Date Flag")]
        [StringLength(1)]
        public string? QuotationShipmentDateFlag { get; set; }
        [Column("Rev Ton Check")]
        [StringLength(1)]
        public string? RevTonCheck { get; set; }
        [Column("Sc 20 Item Code")]
        [StringLength(30)]
        public string? Sc20ItemCode { get; set; }
        [Column("Sc 40 Item Code")]
        [StringLength(30)]
        public string? Sc40ItemCode { get; set; }
        [Column("Sc 40 Hc Item Code")]
        [StringLength(30)]
        public string? Sc40HcItemCode { get; set; }
        [Column("Sc Lcl Item Code")]
        [StringLength(30)]
        public string? ScLclItemCode { get; set; }
        [Column("Show Job Costing Remark Flag")]
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        [Column("Show Lock Flag")]
        [StringLength(1)]
        public string? ShowLockFlag { get; set; }
        [Column("Show Quotation Flag")]
        [StringLength(1)]
        public string? ShowQuotationFlag { get; set; }
        [Column("Space Term Condition Flag")]
        [StringLength(1)]
        public string? SpaceTermConditionFlag { get; set; }
        [Column("Teu M3 Flag")]
        [StringLength(5)]
        public string? TeuM3Flag { get; set; }
        [Column("Ton Kg Flag")]
        [StringLength(5)]
        public string? TonKgFlag { get; set; }
        [Column("Update Quote No Flag")]
        [StringLength(1)]
        public string? UpdateQuoteNoFlag { get; set; }
        [Column("Update Smct1 Audit Log Flag")]
        [StringLength(1)]
        public string? UpdateSmct1AuditLogFlag { get; set; }
        [Column("Upper Case Flag")]
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        [Column("Validity Days")]
        public short? ValidityDays { get; set; }
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
