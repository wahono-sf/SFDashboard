using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Adjust Prefix")]
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        [Column("Ageing Type")]
        [StringLength(1)]
        public string? AgeingType { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Attn Name")]
        [StringLength(50)]
        public string? AttnName { get; set; }
        [Column("Auto Reverse Credit Note Flag")]
        [StringLength(1)]
        public string? AutoReverseCreditNoteFlag { get; set; }
        [Column("Auto Post Flag")]
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [Column("Auto Update Release Date Flag")]
        [StringLength(1)]
        public string? AutoUpdateReleaseDateFlag { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("Bank Code 1")]
        [StringLength(10)]
        public string? BankCode1 { get; set; }
        [Column("Bank Code 2")]
        [StringLength(10)]
        public string? BankCode2 { get; set; }
        [Column("Bank Code 3")]
        [StringLength(10)]
        public string? BankCode3 { get; set; }
        [Column("Bank Code 4")]
        [StringLength(10)]
        public string? BankCode4 { get; set; }
        [Column("Bank Code 5")]
        [StringLength(10)]
        public string? BankCode5 { get; set; }
        [Column("Bank Code 6")]
        [StringLength(10)]
        public string? BankCode6 { get; set; }
        [Column("Bank Code 7")]
        [StringLength(10)]
        public string? BankCode7 { get; set; }
        [Column("Bank Code 8")]
        [StringLength(10)]
        public string? BankCode8 { get; set; }
        [Column("Bank Code 9")]
        [StringLength(10)]
        public string? BankCode9 { get; set; }
        [Column("Bank Code 10")]
        [StringLength(10)]
        public string? BankCode10 { get; set; }
        [Column("Bank Code 11")]
        [StringLength(10)]
        public string? BankCode11 { get; set; }
        [Column("Bank Code 12")]
        [StringLength(10)]
        public string? BankCode12 { get; set; }
        [Column("Bank Code 13")]
        [StringLength(10)]
        public string? BankCode13 { get; set; }
        [Column("Bank Code 14")]
        [StringLength(10)]
        public string? BankCode14 { get; set; }
        [Column("Bank Code 15")]
        [StringLength(10)]
        public string? BankCode15 { get; set; }
        [Column("Bank Code 16")]
        [StringLength(10)]
        public string? BankCode16 { get; set; }
        [Column("Bank Code 17")]
        [StringLength(10)]
        public string? BankCode17 { get; set; }
        [Column("Bank Code 18")]
        [StringLength(10)]
        public string? BankCode18 { get; set; }
        [Column("Bank Code 19")]
        [StringLength(10)]
        public string? BankCode19 { get; set; }
        [Column("Bank Code 20")]
        [StringLength(10)]
        public string? BankCode20 { get; set; }
        [Column("Cash Customer Code")]
        [StringLength(10)]
        public string? CashCustomerCode { get; set; }
        [Column("Cash Prefix")]
        [StringLength(5)]
        public string? CashPrefix { get; set; }
        [Column("Combine Statement Flag")]
        [StringLength(1)]
        public string? CombineStatementFlag { get; set; }
        [Column("Container Deposit Acc Code")]
        [StringLength(15)]
        public string? ContainerDepositAccCode { get; set; }
        [Column("Credit Check Booking Error Flag")]
        [StringLength(1)]
        public string? CreditCheckBookingErrorFlag { get; set; }
        [Column("Credit Check Error Flag")]
        [StringLength(1)]
        public string? CreditCheckErrorFlag { get; set; }
        [Column("Credit Limit Email Address")]
        [StringLength(255)]
        public string? CreditLimitEmailAddress { get; set; }
        [Column("Credit Limit Email Reminder")]
        [StringLength(1)]
        public string? CreditLimitEmailReminder { get; set; }
        [Column("Credit Prefix")]
        [StringLength(5)]
        public string? CreditPrefix { get; set; }
        [Column("Customer Code Length")]
        public byte? CustomerCodeLength { get; set; }
        [Column("Debtor Acc Code")]
        [StringLength(15)]
        public string? DebtorAccCode { get; set; }
        [Column("Default Cheque Date Flag")]
        [StringLength(1)]
        public string? DefaultChequeDateFlag { get; set; }
        [StringLength(10)]
        public string? Designation { get; set; }
        [Column("Ex Gain Loss Acc Code")]
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        [Column("Invoice Flag")]
        [StringLength(1)]
        public string? InvoiceFlag { get; set; }
        [Column("Link Op Flag")]
        [StringLength(1)]
        public string? LinkOpFlag { get; set; }
        [Column("Lock Paid Invoice Flag")]
        [StringLength(1)]
        public string? LockPaidInvoiceFlag { get; set; }
        [Column("Lock Print Receipt Flag")]
        [StringLength(1)]
        public string? LockPrintReceiptFlag { get; set; }
        [Column("Multi Curr Flag")]
        [StringLength(1)]
        public string? MultiCurrFlag { get; set; }
        [Column("Next Cash Receipt No")]
        [StringLength(20)]
        public string? NextCashReceiptNo { get; set; }
        [Column("Next Journal No")]
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        [Column("Next Official Receipt No")]
        [StringLength(20)]
        public string? NextOfficialReceiptNo { get; set; }
        [Column("Next Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextPostDate { get; set; }
        [Column("Next With Holding Tax No")]
        [StringLength(20)]
        public string? NextWithHoldingTaxNo { get; set; }
        [Column("No Of Days Past")]
        public int? NoOfDaysPast { get; set; }
        [Column("Op Customer Code Flag")]
        [StringLength(1)]
        public string? OpCustomerCodeFlag { get; set; }
        [Column("Original Curr Rate Flag")]
        [StringLength(1)]
        public string? OriginalCurrRateFlag { get; set; }
        [Column("Post Detail Flag")]
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        [Column("Post Online Or Batch")]
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        [Column("Prompt Post Flag")]
        [StringLength(1)]
        public string? PromptPostFlag { get; set; }
        [Column("Receipt Adjust Flag")]
        [StringLength(1)]
        public string? ReceiptAdjustFlag { get; set; }
        [Column("Receipt No Audit Flag")]
        [StringLength(1)]
        public string? ReceiptNoAuditFlag { get; set; }
        [Column("Receipt Prefix")]
        [StringLength(5)]
        public string? ReceiptPrefix { get; set; }
        [Column("Receipt Type 1")]
        [StringLength(2)]
        public string? ReceiptType1 { get; set; }
        [Column("Receipt Type 2")]
        [StringLength(2)]
        public string? ReceiptType2 { get; set; }
        [Column("Receipt Type 3")]
        [StringLength(2)]
        public string? ReceiptType3 { get; set; }
        [Column("Receipt Type 4")]
        [StringLength(2)]
        public string? ReceiptType4 { get; set; }
        [Column("Receipt Type 5")]
        [StringLength(2)]
        public string? ReceiptType5 { get; set; }
        [Column("Receipt Type 6")]
        [StringLength(2)]
        public string? ReceiptType6 { get; set; }
        [Column("Receipt Type 7")]
        [StringLength(2)]
        public string? ReceiptType7 { get; set; }
        [Column("Receipt Type 8")]
        [StringLength(2)]
        public string? ReceiptType8 { get; set; }
        [Column("Receipt Type 9")]
        [StringLength(2)]
        public string? ReceiptType9 { get; set; }
        [Column("Receipt Type 10")]
        [StringLength(2)]
        public string? ReceiptType10 { get; set; }
        [Column("Receipt Type 11")]
        [StringLength(2)]
        public string? ReceiptType11 { get; set; }
        [Column("Receipt Type 12")]
        [StringLength(2)]
        public string? ReceiptType12 { get; set; }
        [Column("Receipt Type 13")]
        [StringLength(2)]
        public string? ReceiptType13 { get; set; }
        [Column("Receipt Type 14")]
        [StringLength(2)]
        public string? ReceiptType14 { get; set; }
        [Column("Receipt Type 15")]
        [StringLength(2)]
        public string? ReceiptType15 { get; set; }
        [Column("Receipt Type 16")]
        [StringLength(2)]
        public string? ReceiptType16 { get; set; }
        [Column("Receipt Type 17")]
        [StringLength(2)]
        public string? ReceiptType17 { get; set; }
        [Column("Receipt Type 18")]
        [StringLength(2)]
        public string? ReceiptType18 { get; set; }
        [Column("Receipt Type 19")]
        [StringLength(2)]
        public string? ReceiptType19 { get; set; }
        [Column("Receipt Type 20")]
        [StringLength(2)]
        public string? ReceiptType20 { get; set; }
        [Column("Reverse Post Online Or Batch")]
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        [Column("Round Off Acc Code")]
        [StringLength(15)]
        public string? RoundOffAccCode { get; set; }
        [Column("Salesman By Customer Flag")]
        [StringLength(1)]
        public string? SalesmanByCustomerFlag { get; set; }
        [Column("Show Customer Balance Flag")]
        [StringLength(1)]
        public string? ShowCustomerBalanceFlag { get; set; }
        [Column("Show Receipt Button Flag")]
        [StringLength(1)]
        public string? ShowReceiptButtonFlag { get; set; }
        [Column("Show Zero Balance Flag")]
        [StringLength(1)]
        public string? ShowZeroBalanceFlag { get; set; }
        [Column("Suspense Acc Code")]
        [StringLength(15)]
        public string? SuspenseAccCode { get; set; }
        [Column("Unrealise Acc Code")]
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        [Column("Update Vat Flag")]
        [StringLength(1)]
        public string? UpdateVatFlag { get; set; }
        [Column("Vat Registration No")]
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        [Column("Voucher No Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherNoAutoManualFlag { get; set; }
        [Column("With Hold Tax Acc Code")]
        [StringLength(15)]
        public string? WithHoldTaxAccCode { get; set; }
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
