using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlvn1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
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
        [Column("Analysis Code")]
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [Column("Area Code")]
        [StringLength(5)]
        public string? AreaCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(50)]
        public string? BankAccCode { get; set; }
        [Column("Bank Account No")]
        [StringLength(50)]
        public string? BankAccountNo { get; set; }
        [Column("Bank Name")]
        [StringLength(50)]
        public string? BankName { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("City Name")]
        [StringLength(45)]
        public string? CityName { get; set; }
        [Column("Company Group")]
        [StringLength(15)]
        public string? CompanyGroup { get; set; }
        [Column("Contact Customer Code")]
        [StringLength(10)]
        public string? ContactCustomerCode { get; set; }
        [Column("Contact Name 1")]
        [StringLength(50)]
        public string? ContactName1 { get; set; }
        [Column("Contact Name 2")]
        [StringLength(50)]
        public string? ContactName2 { get; set; }
        [Column("Contact Name 3")]
        [StringLength(50)]
        public string? ContactName3 { get; set; }
        [Column("Contra Customer Code")]
        [StringLength(10)]
        public string? ContraCustomerCode { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [Column("Credit Limit", TypeName = "decimal(13, 2)")]
        public decimal? CreditLimit { get; set; }
        [Column("Cr No")]
        [StringLength(30)]
        public string? CrNo { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Current Balance", TypeName = "decimal(38, 2)")]
        public decimal? CurrentBalance { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(200)]
        public string? Email { get; set; }
        [Column("Email 1")]
        [StringLength(100)]
        public string? Email1 { get; set; }
        [Column("Email 2")]
        [StringLength(100)]
        public string? Email2 { get; set; }
        [Column("Email 3")]
        [StringLength(100)]
        public string? Email3 { get; set; }
        [Column("Export Pay Mode")]
        [StringLength(5)]
        public string? ExportPayMode { get; set; }
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
        [Column("Import Pay Mode")]
        [StringLength(5)]
        public string? ImportPayMode { get; set; }
        [Column("Last Yr Mth 01 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01Payment { get; set; }
        [Column("Last Yr Mth 01 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth01PurchaseAmt { get; set; }
        [Column("Last Yr Mth 02 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02Payment { get; set; }
        [Column("Last Yr Mth 02 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth02PurchaseAmt { get; set; }
        [Column("Last Yr Mth 03 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03Payment { get; set; }
        [Column("Last Yr Mth 03 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth03PurchaseAmt { get; set; }
        [Column("Last Yr Mth 04 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04Payment { get; set; }
        [Column("Last Yr Mth 04 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth04PurchaseAmt { get; set; }
        [Column("Last Yr Mth 05 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05Payment { get; set; }
        [Column("Last Yr Mth 05 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth05PurchaseAmt { get; set; }
        [Column("Last Yr Mth 06 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06Payment { get; set; }
        [Column("Last Yr Mth 06 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth06PurchaseAmt { get; set; }
        [Column("Last Yr Mth 07 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07Payment { get; set; }
        [Column("Last Yr Mth 07 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth07PurchaseAmt { get; set; }
        [Column("Last Yr Mth 08 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08Payment { get; set; }
        [Column("Last Yr Mth 08 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth08PurchaseAmt { get; set; }
        [Column("Last Yr Mth 09 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09Payment { get; set; }
        [Column("Last Yr Mth 09 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth09PurchaseAmt { get; set; }
        [Column("Last Yr Mth 10 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10Payment { get; set; }
        [Column("Last Yr Mth 10 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth10PurchaseAmt { get; set; }
        [Column("Last Yr Mth 11 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11Payment { get; set; }
        [Column("Last Yr Mth 11 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth11PurchaseAmt { get; set; }
        [Column("Last Yr Mth 12 Payment", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12Payment { get; set; }
        [Column("Last Yr Mth 12 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrMth12PurchaseAmt { get; set; }
        [Column("Last Yr Total Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? LastYrTotalPurchaseAmt { get; set; }
        [Column("Local Balance Amt", TypeName = "decimal(13, 2)")]
        public decimal? LocalBalanceAmt { get; set; }
        [Column("Local Name")]
        [StringLength(255)]
        public string? LocalName { get; set; }
        [Column("Misc Vendor Flag")]
        [StringLength(1)]
        public string? MiscVendorFlag { get; set; }
        [StringLength(50)]
        public string? Network { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
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
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("State Or Province")]
        [StringLength(50)]
        public string? StateOrProvince { get; set; }
        [Column("Statement Contact Name")]
        [StringLength(80)]
        public string? StatementContactName { get; set; }
        [Column("Statement Email")]
        [StringLength(100)]
        public string? StatementEmail { get; set; }
        [Column("Swift Code")]
        [StringLength(50)]
        public string? SwiftCode { get; set; }
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
        [Column("This Yr Mtd Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdPayment { get; set; }
        [Column("This Yr Mtd Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMtdPurchaseAmt { get; set; }
        [Column("This Yr Mth 01 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01Payment { get; set; }
        [Column("This Yr Mth 01 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth01PurchaseAmt { get; set; }
        [Column("This Yr Mth 02 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02Payment { get; set; }
        [Column("This Yr Mth 02 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth02PurchaseAmt { get; set; }
        [Column("This Yr Mth 03 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03Payment { get; set; }
        [Column("This Yr Mth 03 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth03PurchaseAmt { get; set; }
        [Column("This Yr Mth 04 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04Payment { get; set; }
        [Column("This Yr Mth 04 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth04PurchaseAmt { get; set; }
        [Column("This Yr Mth 05 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05Payment { get; set; }
        [Column("This Yr Mth 05 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth05PurchaseAmt { get; set; }
        [Column("This Yr Mth 06 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06Payment { get; set; }
        [Column("This Yr Mth 06 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth06PurchaseAmt { get; set; }
        [Column("This Yr Mth 07 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07Payment { get; set; }
        [Column("This Yr Mth 07 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth07PurchaseAmt { get; set; }
        [Column("This Yr Mth 08 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08Payment { get; set; }
        [Column("This Yr Mth 08 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth08PurchaseAmt { get; set; }
        [Column("This Yr Mth 09 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09Payment { get; set; }
        [Column("This Yr Mth 09 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth09PurchaseAmt { get; set; }
        [Column("This Yr Mth 10 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10Payment { get; set; }
        [Column("This Yr Mth 10 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth10PurchaseAmt { get; set; }
        [Column("This Yr Mth 11 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11Payment { get; set; }
        [Column("This Yr Mth 11 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth11PurchaseAmt { get; set; }
        [Column("This Yr Mth 12 Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12Payment { get; set; }
        [Column("This Yr Mth 12 Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrMth12PurchaseAmt { get; set; }
        [Column("This Yr Ytd Payment", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdPayment { get; set; }
        [Column("This Yr Ytd Purchase Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThisYrYtdPurchaseAmt { get; set; }
        [Column("Title 1")]
        [StringLength(20)]
        public string? Title1 { get; set; }
        [Column("Title 2")]
        [StringLength(20)]
        public string? Title2 { get; set; }
        [Column("Title 3")]
        [StringLength(20)]
        public string? Title3 { get; set; }
        [Column("Vat Code")]
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Vendor Short Code")]
        [StringLength(20)]
        public string? VendorShortCode { get; set; }
        [Column("Vendor Type")]
        [StringLength(5)]
        public string? VendorType { get; set; }
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
