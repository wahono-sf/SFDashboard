using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcu1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Address 1")]
        [StringLength(50)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(50)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(50)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("All In Customer Flag")]
        [StringLength(1)]
        public string? AllInCustomerFlag { get; set; }
        [Column("Analysis Code")]
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [Column("Area Code")]
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Account No")]
        [StringLength(50)]
        public string? BankAccountNo { get; set; }
        [Column("Budget Amt", TypeName = "decimal(13, 2)")]
        public decimal? BudgetAmt { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Company Group")]
        [StringLength(15)]
        public string? CompanyGroup { get; set; }
        [Column("Consol Inv Flag")]
        [StringLength(1)]
        public string? ConsolInvFlag { get; set; }
        [Column("Contact Name 1")]
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [Column("Contact Name 2")]
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [Column("Contact Name 3")]
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [Column("Contra Vendor Code")]
        [StringLength(10)]
        public string? ContraVendorCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Credit Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CreditDate { get; set; }
        [Column("Credit Limit", TypeName = "decimal(13, 2)")]
        public decimal? CreditLimit { get; set; }
        [Column("Credit Limit By Day")]
        public int? CreditLimitByDay { get; set; }
        [Column("Credit Limit Outlay", TypeName = "decimal(13, 2)")]
        public decimal? CreditLimitOutlay { get; set; }
        [Column("Credit Status Code")]
        [StringLength(5)]
        public string? CreditStatusCode { get; set; }
        [Column("Cr No")]
        [StringLength(30)]
        public string? CrNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Current Balance", TypeName = "decimal(38, 2)")]
        public decimal? CurrentBalance { get; set; }
        [Column("Customer Hold Flag")]
        [StringLength(1)]
        public string? CustomerHoldFlag { get; set; }
        [Column("Customer Short Code")]
        [StringLength(10)]
        public string? CustomerShortCode { get; set; }
        [Column("Customer Type")]
        [StringLength(5)]
        public string? CustomerType { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("Email 1")]
        [StringLength(50)]
        public string? Email1 { get; set; }
        [Column("Email 2")]
        [StringLength(50)]
        public string? Email2 { get; set; }
        [Column("Email 3")]
        [StringLength(50)]
        public string? Email3 { get; set; }
        [Column("Exclude Notification Flag")]
        [StringLength(1)]
        public string? ExcludeNotificationFlag { get; set; }
        [Column("Export Term Code")]
        [StringLength(3)]
        public string? ExportTermCode { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Fax 1")]
        [StringLength(30)]
        public string? Fax1 { get; set; }
        [Column("Fax 2")]
        [StringLength(30)]
        public string? Fax2 { get; set; }
        [Column("Fax 3")]
        [StringLength(30)]
        public string? Fax3 { get; set; }
        [Column("Foreign Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? ForeignBalanceAmt { get; set; }
        [Column("Handphone 1")]
        [StringLength(30)]
        public string? Handphone1 { get; set; }
        [Column("Handphone 2")]
        [StringLength(30)]
        public string? Handphone2 { get; set; }
        [Column("Handphone 3")]
        [StringLength(30)]
        public string? Handphone3 { get; set; }
        [Column("Import Term Code")]
        [StringLength(3)]
        public string? ImportTermCode { get; set; }
        [Column("Last Yr Average Margin", TypeName = "decimal(13, 2)")]
        public decimal? LastYrAverageMargin { get; set; }
        [Column("Last Yr Mth 01 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01CostAmt { get; set; }
        [Column("Last Yr Mth 01 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01Receipt { get; set; }
        [Column("Last Yr Mth 01 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01SalesAmt { get; set; }
        [Column("Last Yr Mth 02 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02CostAmt { get; set; }
        [Column("Last Yr Mth 02 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02Receipt { get; set; }
        [Column("Last Yr Mth 02 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02SalesAmt { get; set; }
        [Column("Last Yr Mth 03 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03CostAmt { get; set; }
        [Column("Last Yr Mth 03 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03Receipt { get; set; }
        [Column("Last Yr Mth 03 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03SalesAmt { get; set; }
        [Column("Last Yr Mth 04 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04CostAmt { get; set; }
        [Column("Last Yr Mth 04 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04Receipt { get; set; }
        [Column("Last Yr Mth 04 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04SalesAmt { get; set; }
        [Column("Last Yr Mth 05 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05CostAmt { get; set; }
        [Column("Last Yr Mth 05 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05Receipt { get; set; }
        [Column("Last Yr Mth 05 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05SalesAmt { get; set; }
        [Column("Last Yr Mth 06 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06CostAmt { get; set; }
        [Column("Last Yr Mth 06 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06Receipt { get; set; }
        [Column("Last Yr Mth 06 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06SalesAmt { get; set; }
        [Column("Last Yr Mth 07 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07CostAmt { get; set; }
        [Column("Last Yr Mth 07 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07Receipt { get; set; }
        [Column("Last Yr Mth 07 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07SalesAmt { get; set; }
        [Column("Last Yr Mth 08 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08CostAmt { get; set; }
        [Column("Last Yr Mth 08 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08Receipt { get; set; }
        [Column("Last Yr Mth 08 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08SalesAmt { get; set; }
        [Column("Last Yr Mth 09 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09CostAmt { get; set; }
        [Column("Last Yr Mth 09 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09Receipt { get; set; }
        [Column("Last Yr Mth 09 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09SalesAmt { get; set; }
        [Column("Last Yr Mth 10 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10CostAmt { get; set; }
        [Column("Last Yr Mth 10 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10Receipt { get; set; }
        [Column("Last Yr Mth 10 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10SalesAmt { get; set; }
        [Column("Last Yr Mth 11 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11CostAmt { get; set; }
        [Column("Last Yr Mth 11 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11Receipt { get; set; }
        [Column("Last Yr Mth 11 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11SalesAmt { get; set; }
        [Column("Last Yr Mth 12 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12CostAmt { get; set; }
        [Column("Last Yr Mth 12 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12Receipt { get; set; }
        [Column("Last Yr Mth 12 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12SalesAmt { get; set; }
        [Column("Last Yr Total Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrTotalSalesAmt { get; set; }
        [Column("Local Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column("Min Amt By Day", TypeName = "decimal(13, 2)")]
        public decimal? MinAmtByDay { get; set; }
        [Column("Misc Customer Flag")]
        [StringLength(1)]
        public string? MiscCustomerFlag { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [Column("No Check Reason")]
        [StringLength(80)]
        public string? NoCheckReason { get; set; }
        [Column("No Credit Limit Check")]
        [StringLength(1)]
        public string? NoCreditLimitCheck { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Open Item Flag")]
        [StringLength(1)]
        public string? OpenItemFlag { get; set; }
        [Column("Pager 1")]
        [StringLength(30)]
        public string? Pager1 { get; set; }
        [Column("Pager 2")]
        [StringLength(30)]
        public string? Pager2 { get; set; }
        [Column("Pager 3")]
        [StringLength(30)]
        public string? Pager3 { get; set; }
        [Column("Pay Code")]
        [StringLength(5)]
        public string? PayCode { get; set; }
        [Column("Payee Name")]
        [StringLength(80)]
        public string? PayeeName { get; set; }
        [StringLength(50)]
        public string? Place { get; set; }
        [Column("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("Post Ar Flag")]
        [StringLength(1)]
        public string? PostArFlag { get; set; }
        [Column("Print Statement Flag")]
        [StringLength(1)]
        public string? PrintStatementFlag { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Salesman Remark")]
        [StringLength(50)]
        public string? SalesmanRemark { get; set; }
        [Column("Sales Type")]
        [StringLength(1)]
        public string? SalesType { get; set; }
        [Column("Service Charge Flag")]
        [StringLength(1)]
        public string? ServiceChargeFlag { get; set; }
        [Column("Statement Cc Email")]
        [StringLength(100)]
        public string? StatementCcEmail { get; set; }
        [Column("Statement Contact Name")]
        [StringLength(80)]
        public string? StatementContactName { get; set; }
        [Column("Statement Email")]
        [StringLength(100)]
        public string? StatementEmail { get; set; }
        [Column("State Or Province")]
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [Column("Swift Code")]
        [StringLength(5)]
        public string? SwiftCode { get; set; }
        [Column("Tax Code")]
        [StringLength(3)]
        public string? TaxCode { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Telephone 1")]
        [StringLength(30)]
        public string? Telephone1 { get; set; }
        [Column("Telephone 2")]
        [StringLength(30)]
        public string? Telephone2 { get; set; }
        [Column("Telephone 3")]
        [StringLength(30)]
        public string? Telephone3 { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [Column("Term Code")]
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column("This Yr Mtd Average Margin", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdAverageMargin { get; set; }
        [Column("This Yr Mtd Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdSalesAmt { get; set; }
        [Column("This Yr Mth 01 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01CostAmt { get; set; }
        [Column("This Yr Mth 01 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01Receipt { get; set; }
        [Column("This Yr Mth 01 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01SalesAmt { get; set; }
        [Column("This Yr Mth 02 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02CostAmt { get; set; }
        [Column("This Yr Mth 02 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02Receipt { get; set; }
        [Column("This Yr Mth 02 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02SalesAmt { get; set; }
        [Column("This Yr Mth 03 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03CostAmt { get; set; }
        [Column("This Yr Mth 03 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03Receipt { get; set; }
        [Column("This Yr Mth 03 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03SalesAmt { get; set; }
        [Column("This Yr Mth 04 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04CostAmt { get; set; }
        [Column("This Yr Mth 04 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04Receipt { get; set; }
        [Column("This Yr Mth 04 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04SalesAmt { get; set; }
        [Column("This Yr Mth 05 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05CostAmt { get; set; }
        [Column("This Yr Mth 05 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05Receipt { get; set; }
        [Column("This Yr Mth 05 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05SalesAmt { get; set; }
        [Column("This Yr Mth 06 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06CostAmt { get; set; }
        [Column("This Yr Mth 06 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06Receipt { get; set; }
        [Column("This Yr Mth 06 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06SalesAmt { get; set; }
        [Column("This Yr Mth 07 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07CostAmt { get; set; }
        [Column("This Yr Mth 07 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07Receipt { get; set; }
        [Column("This Yr Mth 07 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07SalesAmt { get; set; }
        [Column("This Yr Mth 08 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08CostAmt { get; set; }
        [Column("This Yr Mth 08 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08Receipt { get; set; }
        [Column("This Yr Mth 08 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08SalesAmt { get; set; }
        [Column("This Yr Mth 09 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09CostAmt { get; set; }
        [Column("This Yr Mth 09 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09Receipt { get; set; }
        [Column("This Yr Mth 09 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09SalesAmt { get; set; }
        [Column("This Yr Mth 10 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10CostAmt { get; set; }
        [Column("This Yr Mth 10 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10Receipt { get; set; }
        [Column("This Yr Mth 10 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10SalesAmt { get; set; }
        [Column("This Yr Mth 11 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11CostAmt { get; set; }
        [Column("This Yr Mth 11 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11Receipt { get; set; }
        [Column("This Yr Mth 11 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11SalesAmt { get; set; }
        [Column("This Yr Mth 12 Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12CostAmt { get; set; }
        [Column("This Yr Mth 12 Receipt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12Receipt { get; set; }
        [Column("This Yr Mth 12 Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12SalesAmt { get; set; }
        [Column("This Yr Ytd Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdSalesAmt { get; set; }
        [Column("Title 1")]
        [StringLength(20)]
        public string? Title1 { get; set; }
        [Column("Title 2")]
        [StringLength(20)]
        public string? Title2 { get; set; }
        [Column("Title 3")]
        [StringLength(20)]
        public string? Title3 { get; set; }
        [Column("Update Flag")]
        [StringLength(1)]
        public string? UpdateFlag { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
