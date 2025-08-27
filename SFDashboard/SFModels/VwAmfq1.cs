using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAmfq1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Quote No")]
        [StringLength(15)]
        public string? QuoteNo { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Check By")]
        [StringLength(50)]
        public string? CheckBy { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Copy Template Name")]
        [StringLength(50)]
        public string? CopyTemplateName { get; set; }
        [Column("Copy Template Remark")]
        [StringLength(255)]
        public string? CopyTemplateRemark { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Customer Address 1")]
        [StringLength(50)]
        public string? CustomerAddress1 { get; set; }
        [Column("Customer Address 2")]
        [StringLength(50)]
        public string? CustomerAddress2 { get; set; }
        [Column("Customer Address 3")]
        [StringLength(50)]
        public string? CustomerAddress3 { get; set; }
        [Column("Customer Address 4")]
        [StringLength(50)]
        public string? CustomerAddress4 { get; set; }
        [Column("Customer Contact Name")]
        [StringLength(50)]
        public string? CustomerContactName { get; set; }
        [Column("Customer Fax")]
        [StringLength(30)]
        public string? CustomerFax { get; set; }
        [Column("Customer Telephone")]
        [StringLength(30)]
        public string? CustomerTelephone { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Dest Name")]
        [StringLength(45)]
        public string? DestName { get; set; }
        [Column("Doc Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? DocChargeWeight { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("Event Template Name")]
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("Footer 1")]
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [Column("Footer 2")]
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [Column("Footer 3")]
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [Column("Footer 4")]
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [Column("Footer 5")]
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Header 1")]
        [StringLength(80)]
        public string? Header1 { get; set; }
        [Column("Header 2")]
        [StringLength(80)]
        public string? Header2 { get; set; }
        [Column("Header 3")]
        [StringLength(80)]
        public string? Header3 { get; set; }
        [Column("Header 4")]
        [StringLength(80)]
        public string? Header4 { get; set; }
        [Column("Header 5")]
        [StringLength(80)]
        public string? Header5 { get; set; }
        [Column("Job Costing Remark")]
        [StringLength(255)]
        public string? JobCostingRemark { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Last Quote Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastQuoteDate { get; set; }
        [Column("Last Quote No")]
        [StringLength(15)]
        public string? LastQuoteNo { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Origin Name")]
        [StringLength(45)]
        public string? OriginName { get; set; }
        public int? Pcs { get; set; }
        [Column("Quote Approve Code")]
        [StringLength(10)]
        public string? QuoteApproveCode { get; set; }
        [Column("Quote Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? QuoteDate { get; set; }
        [Column("Quote Table No")]
        [StringLength(5)]
        [Unicode(false)]
        public string? QuoteTableNo { get; set; }
        [Column("Quote Title")]
        [StringLength(100)]
        public string? QuoteTitle { get; set; }
        [Column("Quote Type")]
        [StringLength(5)]
        public string? QuoteType { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Request By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Revision Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RevisionDate { get; set; }
        [Column("Revision No")]
        public short? RevisionNo { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Special Instruction")]
        [StringLength(2000)]
        public string? SpecialInstruction { get; set; }
        [Column("Template Name")]
        [StringLength(50)]
        public string? TemplateName { get; set; }
        [Column("Term And Condition")]
        [StringLength(3000)]
        public string? TermAndCondition { get; set; }
        [Column("Term And Condition Flag")]
        [StringLength(1)]
        [Unicode(false)]
        public string TermAndConditionFlag { get; set; } = null!;
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("Validate Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ValidateDate { get; set; }
        [Column("Validity Day")]
        public int? ValidityDay { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
