using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plvn1")]
    [Index("AccCode", Name = "INDEX_Plvn1_AccCode")]
    [Index("CityCode", Name = "INDEX_Plvn1_CityCode")]
    [Index("ContactCustomerCode", Name = "INDEX_Plvn1_ContactCustomerCode")]
    [Index("CountryCode", Name = "INDEX_Plvn1_CountryCode")]
    [Index("CurrCode", Name = "INDEX_Plvn1_CurrCode")]
    [Index("Email", Name = "INDEX_Plvn1_Email")]
    [Index("Fax", Name = "INDEX_Plvn1_Fax")]
    [Index("StatusCode", Name = "INDEX_Plvn1_StatusCode")]
    [Index("Telephone", Name = "INDEX_Plvn1_Telephone")]
    [Index("TermCode", Name = "INDEX_Plvn1_TermCode")]
    [Index("UpdateDateTime", Name = "INDEX_Plvn1_UpdateDateTime")]
    [Index("VendorName", Name = "INDEX_Plvn1_VendorName")]
    [Index("VendorType", Name = "INDEX_Plvn1_VendorType")]
    [Index("VendorCode", Name = "IX_plvn1_VendorCode")]
    public partial class Plvn1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [StringLength(50)]
        public string? BankAccCode { get; set; }
        [StringLength(50)]
        public string? BankAccountNo { get; set; }
        [StringLength(50)]
        public string? BankName { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(15)]
        public string? CompanyGroup { get; set; }
        [StringLength(10)]
        public string? ContactCustomerCode { get; set; }
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CreditLimit { get; set; }
        [StringLength(30)]
        public string? CrNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [StringLength(100)]
        public string? Email1 { get; set; }
        [StringLength(100)]
        public string? Email2 { get; set; }
        [StringLength(100)]
        public string? Email3 { get; set; }
        [StringLength(5)]
        public string? ExportPayMode { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ForeignBalanceAmt { get; set; }
        [StringLength(30)]
        public string? Handphone1 { get; set; }
        [StringLength(30)]
        public string? Handphone2 { get; set; }
        [StringLength(30)]
        public string? Handphone3 { get; set; }
        [StringLength(5)]
        public string? ImportPayMode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrTotalPurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [StringLength(255)]
        public string? LocalName { get; set; }
        [StringLength(1)]
        public string? MiscVendorFlag { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(30)]
        public string? Pager1 { get; set; }
        [StringLength(30)]
        public string? Pager2 { get; set; }
        [StringLength(30)]
        public string? Pager3 { get; set; }
        [StringLength(5)]
        public string? PayCode { get; set; }
        [StringLength(80)]
        public string? PayeeName { get; set; }
        [StringLength(50)]
        public string? Place { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [StringLength(80)]
        public string? StatementContactName { get; set; }
        [StringLength(100)]
        public string? StatementEmail { get; set; }
        [StringLength(50)]
        public string? SwiftCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [StringLength(30)]
        public string? Telephone3 { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdPayment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdPurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12Payment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12PurchaseAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdPayment { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdPurchaseAmt { get; set; }
        [StringLength(20)]
        public string? Title1 { get; set; }
        [StringLength(20)]
        public string? Title2 { get; set; }
        [StringLength(20)]
        public string? Title3 { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [StringLength(20)]
        public string? VendorShortCode { get; set; }
        [StringLength(5)]
        public string? VendorType { get; set; }
        [StringLength(50)]
        public string? WebSite { get; set; }
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
