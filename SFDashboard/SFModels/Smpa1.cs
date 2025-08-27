using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smpa1")]
    public partial class Smpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [StringLength(1)]
        public string? ApproveAttachmentFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(30)]
        public string? BafItemCode { get; set; }
        /// <summary>
        /// Default Caf Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.The CAF must enter immediately after the Freight Charge.
        /// </summary>
        [StringLength(30)]
        public string? CafItemCode { get; set; }
        /// <summary>
        /// If set as N, then in the Job Costing, when click the button &apos;Charges&apos; or &apos;Cost&apos;, system should not filter EffectiveDate and Expiry Date
        /// </summary>
        [StringLength(1)]
        public string? CheckEffectiveDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(20)]
        public string? CustomerPartyType { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(30)]
        public string? DdcItemCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode01 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode02 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode03 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode04 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode05 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode06 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode07 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode08 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode09 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode10 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode11 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode12 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode13 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode14 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? DefineUomCode15 { get; set; }
        /// <summary>
        /// Default Dg 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Dg20ItemCode { get; set; }
        /// <summary>
        /// Default Dg 40 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Dg40ItemCode { get; set; }
        /// <summary>
        /// Default Dg 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Dg40HcItemCode { get; set; }
        /// <summary>
        /// Default Dg Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? DgLclItemCode { get; set; }
        /// <summary>
        /// Quotation No format
        /// - If set as 1, Quotation No format is Quotation Type(2 digits) + Salesman Code(2 digits) + YY + Next No
        /// - If leave blank, Quotation No format is Salesman Code + ‘-‘ + A + No(5 digits)
        /// </summary>
        [StringLength(1)]
        public string? FormatType { get; set; }
        /// <summary>
        /// Default Ft Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [Column("ftLclItemCode")]
        [StringLength(30)]
        public string? FtLclItemCode { get; set; }
        /// <summary>
        /// Default Ft 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [Column("ft20ItemCode")]
        [StringLength(30)]
        public string? Ft20ItemCode { get; set; }
        /// <summary>
        /// Default Ft 40 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [Column("ft40ItemCode")]
        [StringLength(30)]
        public string? Ft40ItemCode { get; set; }
        /// <summary>
        /// Default Ft 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [Column("ft40HcItemCode")]
        [StringLength(30)]
        public string? Ft40HcItemCode { get; set; }
        [StringLength(1)]
        public string? InsertDefaultChargeFlag { get; set; }
        /// <summary>
        /// Next Quote No
        /// </summary>
        [StringLength(10)]
        public string? NextQuoteNo { get; set; }
        [StringLength(1)]
        public string? QuotationShipmentDateFlag { get; set; }
        /// <summary>
        /// Just for Master Job, and ChargeUnite=REV TON RND UP in smct1
        /// 1. If set as N, then Qty = Master Job’ Charge Weight
        /// 2. If set as Y, then Qty = sum House Job’ Charge Weight or sum SubHouse’s Charge Weight
        /// </summary>
        [StringLength(1)]
        public string? RevTonCheck { get; set; }
        /// <summary>
        /// Default Sc 20 Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Sc20ItemCode { get; set; }
        /// <summary>
        /// Default Sc 40  Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Sc40ItemCode { get; set; }
        /// <summary>
        /// Default Sc 40 Hc Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? Sc40HcItemCode { get; set; }
        /// <summary>
        /// Default SC Lcl Item Code in the Freight Quotation.  It must be a valid code in Charge List in Account Reference.
        /// </summary>
        [StringLength(30)]
        public string? ScLclItemCode { get; set; }
        /// <summary>
        /// Set as Y, Show Job Costing Remark as a column instead of picture icon under Job Costing screen.
        /// </summary>
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos; then show the Lock Flag on the Charges tab under the smfq1
        /// </summary>
        [StringLength(1)]
        public string? ShowLockFlag { get; set; }
        /// <summary>
        /// If set as Y. then
        /// when there is no quotation in the screen base on the default selection. The quotation button will auto hide on the Job Costing and Billing Info screen under the sebk1
        /// </summary>
        [StringLength(1)]
        public string? ShowQuotationFlag { get; set; }
        /// <summary>
        /// If set as N, then when user enter the Term &amp; Condition in smfq1 and then click Standard Clauses it will not have the space between the clauses.
        /// </summary>
        [StringLength(1)]
        public string? SpaceTermConditionFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("TeuM3Flag")]
        [StringLength(5)]
        public string? TeuM3flag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? TonKgFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then when change the smct2 will update the smct1.UpdateBy and UpdateDateTime
        /// </summary>
        [StringLength(1)]
        public string? UpdateSmct1AuditLogFlag { get; set; }
        /// <summary>
        /// If set as ‘Y’, then the Note(include the ImportNote and ExportNote) will auto change to capital
        /// </summary>
        [StringLength(1)]
        public string? UpperCaseFlag { get; set; }
        /// <summary>
        /// Default Validity Days to Freight Quotation
        /// </summary>
        public short? ValidityDays { get; set; }
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
        public string? UpdateQuoteNoFlag { get; set; }

        [ForeignKey("BafItemCode")]
        [InverseProperty("Smpa1BafItemCodeNavigations")]
        public virtual Acit1? BafItemCodeNavigation { get; set; }
        [ForeignKey("DdcItemCode")]
        [InverseProperty("Smpa1DdcItemCodeNavigations")]
        public virtual Acit1? DdcItemCodeNavigation { get; set; }
        [ForeignKey("DefineUomCode01")]
        [InverseProperty("Smpa1DefineUomCode01Navigations")]
        public virtual Rcum1? DefineUomCode01Navigation { get; set; }
        [ForeignKey("DefineUomCode02")]
        [InverseProperty("Smpa1DefineUomCode02Navigations")]
        public virtual Rcum1? DefineUomCode02Navigation { get; set; }
        [ForeignKey("DefineUomCode03")]
        [InverseProperty("Smpa1DefineUomCode03Navigations")]
        public virtual Rcum1? DefineUomCode03Navigation { get; set; }
        [ForeignKey("DefineUomCode04")]
        [InverseProperty("Smpa1DefineUomCode04Navigations")]
        public virtual Rcum1? DefineUomCode04Navigation { get; set; }
        [ForeignKey("DefineUomCode05")]
        [InverseProperty("Smpa1DefineUomCode05Navigations")]
        public virtual Rcum1? DefineUomCode05Navigation { get; set; }
        [ForeignKey("DefineUomCode06")]
        [InverseProperty("Smpa1DefineUomCode06Navigations")]
        public virtual Rcum1? DefineUomCode06Navigation { get; set; }
        [ForeignKey("DefineUomCode07")]
        [InverseProperty("Smpa1DefineUomCode07Navigations")]
        public virtual Rcum1? DefineUomCode07Navigation { get; set; }
        [ForeignKey("DefineUomCode08")]
        [InverseProperty("Smpa1DefineUomCode08Navigations")]
        public virtual Rcum1? DefineUomCode08Navigation { get; set; }
        [ForeignKey("DefineUomCode09")]
        [InverseProperty("Smpa1DefineUomCode09Navigations")]
        public virtual Rcum1? DefineUomCode09Navigation { get; set; }
        [ForeignKey("DefineUomCode10")]
        [InverseProperty("Smpa1DefineUomCode10Navigations")]
        public virtual Rcum1? DefineUomCode10Navigation { get; set; }
        [ForeignKey("DefineUomCode11")]
        [InverseProperty("Smpa1DefineUomCode11Navigations")]
        public virtual Rcum1? DefineUomCode11Navigation { get; set; }
        [ForeignKey("DefineUomCode12")]
        [InverseProperty("Smpa1DefineUomCode12Navigations")]
        public virtual Rcum1? DefineUomCode12Navigation { get; set; }
        [ForeignKey("DefineUomCode13")]
        [InverseProperty("Smpa1DefineUomCode13Navigations")]
        public virtual Rcum1? DefineUomCode13Navigation { get; set; }
        [ForeignKey("DefineUomCode14")]
        [InverseProperty("Smpa1DefineUomCode14Navigations")]
        public virtual Rcum1? DefineUomCode14Navigation { get; set; }
        [ForeignKey("DefineUomCode15")]
        [InverseProperty("Smpa1DefineUomCode15Navigations")]
        public virtual Rcum1? DefineUomCode15Navigation { get; set; }
    }
}
