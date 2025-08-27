using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slcu1")]
    [Index("AccCode", Name = "INDEX_Slcu1_AccCode")]
    [Index("CityCode", Name = "INDEX_Slcu1_CityCode")]
    [Index("ContraVendorCode", Name = "INDEX_Slcu1_ContraVendorCode")]
    [Index("CountryCode", Name = "INDEX_Slcu1_CountryCode")]
    [Index("CurrCode", Name = "INDEX_Slcu1_CurrCode")]
    [Index("CustomerName", Name = "INDEX_Slcu1_CustomerName")]
    [Index("CustomerType", Name = "INDEX_Slcu1_CustomerType")]
    [Index("Email", Name = "INDEX_Slcu1_Email")]
    [Index("Fax", Name = "INDEX_Slcu1_Fax")]
    [Index("StatusCode", Name = "INDEX_Slcu1_StatusCode")]
    [Index("Telephone", Name = "INDEX_Slcu1_Telephone")]
    [Index("TermCode", Name = "INDEX_Slcu1_TermCode")]
    [Index("UpdateDateTime", Name = "INDEX_Slcu1_UpdateDateTime")]
    [Index("CustomerCode", Name = "IX_slcu1_CustomerCode")]
    public partial class Slcu1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
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
        [StringLength(1)]
        public string? AllInCustomerFlag { get; set; }
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [StringLength(50)]
        public string? BankAccountNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? BudgetAmt { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(15)]
        public string? CompanyGroup { get; set; }
        [StringLength(1)]
        public string? ConsolInvFlag { get; set; }
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [StringLength(10)]
        public string? ContraVendorCode { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreditDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CreditLimit { get; set; }
        public int? CreditLimitByDay { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CreditLimitOutlay { get; set; }
        [StringLength(5)]
        public string? CreditStatusCode { get; set; }
        [StringLength(30)]
        public string? CrNo { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(1)]
        public string? CustomerHoldFlag { get; set; }
        [StringLength(10)]
        public string? CustomerShortCode { get; set; }
        [StringLength(5)]
        public string? CustomerType { get; set; }
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
        [StringLength(1)]
        public string? ExcludeNotificationFlag { get; set; }
        [StringLength(3)]
        public string? ExportTermCode { get; set; }
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
        [StringLength(3)]
        public string? ImportTermCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrAverageMargin { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LastYrTotalSalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MinAmtByDay { get; set; }
        [StringLength(1)]
        public string? MiscCustomerFlag { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [StringLength(80)]
        public string? NoCheckReason { get; set; }
        [StringLength(1)]
        public string? NoCreditLimitCheck { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [StringLength(1)]
        public string? OpenItemFlag { get; set; }
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
        [StringLength(1)]
        public string? PostArFlag { get; set; }
        [StringLength(1)]
        public string? PrintStatementFlag { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(50)]
        public string? SalesmanRemark { get; set; }
        [StringLength(1)]
        public string? SalesType { get; set; }
        [StringLength(1)]
        public string? ServiceChargeFlag { get; set; }
        [StringLength(100)]
        public string? StatementCcEmail { get; set; }
        [StringLength(80)]
        public string? StatementContactName { get; set; }
        [StringLength(100)]
        public string? StatementEmail { get; set; }
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [StringLength(50)]
        public string? SwiftCode { get; set; }
        [StringLength(3)]
        public string? TaxCode { get; set; }
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
        public decimal? ThisYrMtdAverageMargin { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdSalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12CostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12Receipt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12SalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdSalesAmt { get; set; }
        [StringLength(20)]
        public string? Title1 { get; set; }
        [StringLength(20)]
        public string? Title2 { get; set; }
        [StringLength(20)]
        public string? Title3 { get; set; }
        [StringLength(1)]
        public string? UpdateFlag { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
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

        [ForeignKey("AreaCode")]
        [InverseProperty("Slcu1s")]
        public virtual Acar1? AreaCodeNavigation { get; set; }
        [ForeignKey("CustomerType")]
        [InverseProperty("Slcu1s")]
        public virtual Slct1? CustomerTypeNavigation { get; set; }
        [ForeignKey("DivisionCode")]
        [InverseProperty("Slcu1s")]
        public virtual Acdv1? DivisionCodeNavigation { get; set; }
    }
}
