using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPlpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Accrued Payment Acc Code")]
        [StringLength(50)]
        public string? AccruedPaymentAccCode { get; set; }
        [Column("Accrued Vat Ex Diff Flag")]
        [StringLength(1)]
        public string? AccruedVatExDiffFlag { get; set; }
        [Column("Accrued Voucher Type")]
        [StringLength(50)]
        public string? AccruedVoucherType { get; set; }
        [Column("Adjust Prefix")]
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        [Column("Advance Acc Code")]
        [StringLength(15)]
        public string? AdvanceAccCode { get; set; }
        [Column("App Generate Voucher No Flag")]
        [StringLength(1)]
        public string? AppGenerateVoucherNoFlag { get; set; }
        [Column("Auto Balance Flag")]
        [StringLength(50)]
        public string? AutoBalanceFlag { get; set; }
        [Column("Auto Post Flag")]
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [Column("Auto Vat Base Amt Flag")]
        [StringLength(1)]
        public string? AutoVatBaseAmtFlag { get; set; }
        [Column("Avg Vat Refund Rate", TypeName = "decimal(13, 2)")]
        public decimal? AvgVatRefundRate { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Account Mandatory Flag")]
        [StringLength(1)]
        public string? BankAccountMandatoryFlag { get; set; }
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
        [Column("Cash Advance Acc Code 01")]
        [StringLength(15)]
        public string? CashAdvanceAccCode01 { get; set; }
        [Column("Cash Advance Acc Code 02")]
        [StringLength(15)]
        public string? CashAdvanceAccCode02 { get; set; }
        [Column("Cash Advance Acc Code 03")]
        [StringLength(15)]
        public string? CashAdvanceAccCode03 { get; set; }
        [Column("Cash Advance Acc Code 04")]
        [StringLength(15)]
        public string? CashAdvanceAccCode04 { get; set; }
        [Column("Cash Advance Acc Code 05")]
        [StringLength(15)]
        public string? CashAdvanceAccCode05 { get; set; }
        [Column("Cash Advance Acc Code 06")]
        [StringLength(15)]
        public string? CashAdvanceAccCode06 { get; set; }
        [Column("Cash Advance Acc Code 07")]
        [StringLength(15)]
        public string? CashAdvanceAccCode07 { get; set; }
        [Column("Cash Advance Acc Code 08")]
        [StringLength(15)]
        public string? CashAdvanceAccCode08 { get; set; }
        [Column("Cash Advance Acc Code 09")]
        [StringLength(15)]
        public string? CashAdvanceAccCode09 { get; set; }
        [Column("Cash Advance Acc Code 10")]
        [StringLength(15)]
        public string? CashAdvanceAccCode10 { get; set; }
        [Column("Cash Advance Item Code")]
        [StringLength(30)]
        public string? CashAdvanceItemCode { get; set; }
        [Column("Cash Advance Item Code 01")]
        [StringLength(30)]
        public string? CashAdvanceItemCode01 { get; set; }
        [Column("Cash Advance Item Code 02")]
        [StringLength(30)]
        public string? CashAdvanceItemCode02 { get; set; }
        [Column("Cash Advance Item Code 03")]
        [StringLength(30)]
        public string? CashAdvanceItemCode03 { get; set; }
        [Column("Cash Advance Item Code 04")]
        [StringLength(30)]
        public string? CashAdvanceItemCode04 { get; set; }
        [Column("Cash Advance Item Code 05")]
        [StringLength(30)]
        public string? CashAdvanceItemCode05 { get; set; }
        [Column("Cash Advance Item Code 06")]
        [StringLength(30)]
        public string? CashAdvanceItemCode06 { get; set; }
        [Column("Cash Advance Item Code 07")]
        [StringLength(30)]
        public string? CashAdvanceItemCode07 { get; set; }
        [Column("Cash Advance Item Code 08")]
        [StringLength(30)]
        public string? CashAdvanceItemCode08 { get; set; }
        [Column("Cash Advance Item Code 09")]
        [StringLength(30)]
        public string? CashAdvanceItemCode09 { get; set; }
        [Column("Cash Advance Item Code 10")]
        [StringLength(30)]
        public string? CashAdvanceItemCode10 { get; set; }
        [Column("Cash Advance Type 01")]
        [StringLength(5)]
        public string? CashAdvanceType01 { get; set; }
        [Column("Cash Advance Type 02")]
        [StringLength(5)]
        public string? CashAdvanceType02 { get; set; }
        [Column("Cash Advance Type 03")]
        [StringLength(5)]
        public string? CashAdvanceType03 { get; set; }
        [Column("Cash Advance Type 04")]
        [StringLength(5)]
        public string? CashAdvanceType04 { get; set; }
        [Column("Cash Advance Type 05")]
        [StringLength(5)]
        public string? CashAdvanceType05 { get; set; }
        [Column("Cash Advance Type 06")]
        [StringLength(5)]
        public string? CashAdvanceType06 { get; set; }
        [Column("Cash Advance Type 07")]
        [StringLength(5)]
        public string? CashAdvanceType07 { get; set; }
        [Column("Cash Advance Type 08")]
        [StringLength(5)]
        public string? CashAdvanceType08 { get; set; }
        [Column("Cash Advance Type 09")]
        [StringLength(5)]
        public string? CashAdvanceType09 { get; set; }
        [Column("Cash Advance Type 10")]
        [StringLength(5)]
        public string? CashAdvanceType10 { get; set; }
        [Column("Cash Prefix")]
        [StringLength(5)]
        public string? CashPrefix { get; set; }
        [Column("Cash Vendor Code")]
        [StringLength(10)]
        public string? CashVendorCode { get; set; }
        [Column("Check Cheque Post Flag")]
        [StringLength(1)]
        public string? CheckChequePostFlag { get; set; }
        [Column("Check Duplicate Item Flag")]
        [StringLength(1)]
        public string? CheckDuplicateItemFlag { get; set; }
        [Column("Check Sales Flag")]
        [StringLength(1)]
        public string? CheckSalesFlag { get; set; }
        [Column("Combine Statement Flag")]
        [StringLength(1)]
        public string? CombineStatementFlag { get; set; }
        [Column("Complete Settlement Voucher Type")]
        [StringLength(2)]
        public string? CompleteSettlementVoucherType { get; set; }
        [Column("Cost Adjust Flag")]
        [StringLength(1)]
        public string? CostAdjustFlag { get; set; }
        [Column("Credit Prefix")]
        [StringLength(5)]
        public string? CreditPrefix { get; set; }
        [Column("Creditor Acc Code")]
        [StringLength(15)]
        public string? CreditorAccCode { get; set; }
        [Column("Curr Rate Flag")]
        [StringLength(1)]
        public string? CurrRateFlag { get; set; }
        [Column("Default Cheque Post Date")]
        [StringLength(1)]
        public string? DefaultChequePostDate { get; set; }
        [Column("Default Invoice Date Flag")]
        [StringLength(1)]
        public string? DefaultInvoiceDateFlag { get; set; }
        [Column("Default Search Name")]
        [StringLength(1)]
        public string? DefaultSearchName { get; set; }
        [Column("Duplicate Cheque No Flag")]
        [StringLength(1)]
        public string? DuplicateChequeNoFlag { get; set; }
        [Column("Duplicate Invoice No Flag")]
        [StringLength(1)]
        public string? DuplicateInvoiceNoFlag { get; set; }
        [Column("e Invoice Item Code")]
        [StringLength(30)]
        public string? EInvoiceItemCode { get; set; }
        [Column("Edit Costing Button")]
        [StringLength(10)]
        public string? EditCostingButton { get; set; }
        [Column("Edit Vat Base Amt Flag")]
        [StringLength(1)]
        public string? EditVatBaseAmtFlag { get; set; }
        [Column("Ex Gain Loss Acc Code")]
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        [Column("Hide Cost Flag")]
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        [Column("Hide Operation Unpost Flag")]
        [StringLength(1)]
        public string? HideOperationUnpostFlag { get; set; }
        [Column("Hide Payment Info Flag")]
        [StringLength(1)]
        public string? HidePaymentInfoFlag { get; set; }
        [Column("Hide Zer oProvision Flag")]
        [StringLength(1)]
        public string? HideZerOProvisionFlag { get; set; }
        [Column("Hire Purchase Item Code")]
        [StringLength(30)]
        public string? HirePurchaseItemCode { get; set; }
        [Column("Invoice Type Flag")]
        [StringLength(1)]
        public string? InvoiceTypeFlag { get; set; }
        [Column("Job No First Column Flag")]
        [StringLength(1)]
        public string? JobNoFirstColumnFlag { get; set; }
        [Column("Job Type 1")]
        [StringLength(10)]
        public string? JobType1 { get; set; }
        [Column("Job Type 2")]
        [StringLength(10)]
        public string? JobType2 { get; set; }
        [Column("Job Type 3")]
        [StringLength(10)]
        public string? JobType3 { get; set; }
        [Column("Job Type 4")]
        [StringLength(10)]
        public string? JobType4 { get; set; }
        [Column("Job Type 5")]
        [StringLength(10)]
        public string? JobType5 { get; set; }
        [Column("Job Type 6")]
        [StringLength(10)]
        public string? JobType6 { get; set; }
        [Column("Job Type 7")]
        [StringLength(10)]
        public string? JobType7 { get; set; }
        [Column("Job Type 8")]
        [StringLength(10)]
        public string? JobType8 { get; set; }
        [Column("Job Type 9")]
        [StringLength(10)]
        public string? JobType9 { get; set; }
        [Column("Job Type 10")]
        [StringLength(10)]
        public string? JobType10 { get; set; }
        [Column("Job Type 11")]
        [StringLength(10)]
        public string? JobType11 { get; set; }
        [Column("Job Type 12")]
        [StringLength(10)]
        public string? JobType12 { get; set; }
        [Column("Job Type 13")]
        [StringLength(10)]
        public string? JobType13 { get; set; }
        [Column("Job Type 14")]
        [StringLength(10)]
        public string? JobType14 { get; set; }
        [Column("Job Type 15")]
        [StringLength(10)]
        public string? JobType15 { get; set; }
        [Column("Job Type 16")]
        [StringLength(10)]
        public string? JobType16 { get; set; }
        [Column("Job Type 17")]
        [StringLength(10)]
        public string? JobType17 { get; set; }
        [Column("Job Type 18")]
        [StringLength(10)]
        public string? JobType18 { get; set; }
        [Column("Job Type 19")]
        [StringLength(10)]
        public string? JobType19 { get; set; }
        [Column("Job Type 20")]
        [StringLength(10)]
        public string? JobType20 { get; set; }
        [Column("Keep Op Payment Flag")]
        [StringLength(1)]
        public string? KeepOpPaymentFlag { get; set; }
        [Column("Link Op Flag")]
        [StringLength(1)]
        public string? LinkOpFlag { get; set; }
        [Column("Lock Approved Voucher Flag")]
        [StringLength(1)]
        public string? LockApprovedVoucherFlag { get; set; }
        [Column("Lock Close Job Flag")]
        [StringLength(1)]
        public string? LockCloseJobFlag { get; set; }
        [Column("Lock Description Flag")]
        [StringLength(1)]
        public string? LockDescriptionFlag { get; set; }
        [Column("Lock Item Screen Flag")]
        [StringLength(1)]
        public string? LockItemScreenFlag { get; set; }
        [Column("Lock PaidInvoice Flag")]
        [StringLength(1)]
        public string? LockPaidInvoiceFlag { get; set; }
        [Column("Lock Provision Date Flag")]
        [StringLength(1)]
        public string? LockProvisionDateFlag { get; set; }
        [Column("Lock Vendor Name Flag")]
        [StringLength(1)]
        public string? LockVendorNameFlag { get; set; }
        [Column("Mandatory Invoice No Flag")]
        [StringLength(1)]
        public string? MandatoryInvoiceNoFlag { get; set; }
        [Column("Multi Curr Flag")]
        [StringLength(1)]
        public string? MultiCurrFlag { get; set; }
        [Column("Next Batch No")]
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        [Column("Next Journal No")]
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        [Column("Next With Holding Tax No")]
        [StringLength(20)]
        public string? NextWithHoldingTaxNo { get; set; }
        [Column("Next With Holding Tax No 1")]
        [StringLength(20)]
        public string? NextWithHoldingTaxNo1 { get; set; }
        [Column("Original Curr Rate Flag")]
        [StringLength(1)]
        public string? OriginalCurrRateFlag { get; set; }
        [Column("Payment Adjust Flag")]
        [StringLength(1)]
        public string? PaymentAdjustFlag { get; set; }
        [Column("Post Accrual Flag")]
        [StringLength(1)]
        public string? PostAccrualFlag { get; set; }
        [Column("Post Detail Flag")]
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        [Column("Post Online Or Batch")]
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        [Column("Post Sum Of Cost Flag")]
        [StringLength(1)]
        public string? PostSumOfCostFlag { get; set; }
        [Column("Prompt Duplicate Doc Flag")]
        [StringLength(1)]
        public string? PromptDuplicateDocFlag { get; set; }
        [Column("Prompt Notify Flag")]
        [StringLength(1)]
        public string? PromptNotifyFlag { get; set; }
        [Column("Prompt Payment Approve Flag")]
        [StringLength(1)]
        public string? PromptPaymentApproveFlag { get; set; }
        [Column("Prompt Vendor Payment Request Flag")]
        [StringLength(1)]
        public string? PromptVendorPaymentRequestFlag { get; set; }
        [Column("Provision Cost Button Flag")]
        [StringLength(1)]
        public string? ProvisionCostButtonFlag { get; set; }
        [Column("Receipt Prefix")]
        [StringLength(5)]
        public string? ReceiptPrefix { get; set; }
        [Column("Reversal Flag")]
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        [Column("Reverse Post Online Or Batch")]
        [StringLength(50)]
        public string? ReversePostOnlineOrBatch { get; set; }
        [Column("Round Off Acc Code")]
        [StringLength(15)]
        public string? RoundOffAccCode { get; set; }
        [Column("Settlement Voucher Type")]
        [StringLength(2)]
        public string? SettlementVoucherType { get; set; }
        [Column("Show App Voucher Flag")]
        [StringLength(1)]
        public string? ShowAppVoucherFlag { get; set; }
        [Column("Show Operation Post Flag")]
        [StringLength(1)]
        public string? ShowOperationPostFlag { get; set; }
        [Column("Show Provision Post Flag")]
        [StringLength(1)]
        public string? ShowProvisionPostFlag { get; set; }
        [Column("Show PV Post Flag")]
        [StringLength(1)]
        public string? ShowPvPostFlag { get; set; }
        [Column("Show Vat Amt Flag")]
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        [Column("Show Vendor Balance Flag")]
        [StringLength(1)]
        public string? ShowVendorBalanceFlag { get; set; }
        [Column("Show Zero Balance Flag")]
        [StringLength(1)]
        public string? ShowZeroBalanceFlag { get; set; }
        [Column("Split Cost To Table")]
        [StringLength(1)]
        public string? SplitCostToTable { get; set; }
        [Column("Stop Payment Voucher Flag")]
        [StringLength(1)]
        public string? StopPaymentVoucherFlag { get; set; }
        [Column("Suspense Acc Code")]
        [StringLength(15)]
        public string? SuspenseAccCode { get; set; }
        [Column("Unrealise Acc Code")]
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        [Column("Update Vat Code Flag")]
        [StringLength(1)]
        public string? UpdateVatCodeFlag { get; set; }
        [Column("Update Vat Flag")]
        [StringLength(1)]
        public string? UpdateVatFlag { get; set; }
        [Column("User Define 1")]
        [StringLength(25)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(25)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(25)]
        public string? UserDefine3 { get; set; }
        [Column("Vat Refund Percentage", TypeName = "decimal(13, 2)")]
        public decimal? VatRefundPercentage { get; set; }
        [Column("Vendor Code Length")]
        public byte? VendorCodeLength { get; set; }
        [Column("Vendor Payment Cheque Date")]
        [StringLength(1)]
        public string? VendorPaymentChequeDate { get; set; }
        [Column("Vendor Provision Acc Code")]
        [StringLength(15)]
        public string? VendorProvisionAccCode { get; set; }
        [Column("Voucher Format")]
        [StringLength(255)]
        public string? VoucherFormat { get; set; }
        [Column("Voucher No 1")]
        [StringLength(20)]
        public string? VoucherNo1 { get; set; }
        [Column("Voucher No 2")]
        [StringLength(20)]
        public string? VoucherNo2 { get; set; }
        [Column("Voucher No 3")]
        [StringLength(20)]
        public string? VoucherNo3 { get; set; }
        [Column("Voucher No 4")]
        [StringLength(20)]
        public string? VoucherNo4 { get; set; }
        [Column("Voucher No 5")]
        [StringLength(20)]
        public string? VoucherNo5 { get; set; }
        [Column("Voucher No 6")]
        [StringLength(20)]
        public string? VoucherNo6 { get; set; }
        [Column("Voucher No 7")]
        [StringLength(20)]
        public string? VoucherNo7 { get; set; }
        [Column("Voucher No 8")]
        [StringLength(20)]
        public string? VoucherNo8 { get; set; }
        [Column("Voucher No 9")]
        [StringLength(20)]
        public string? VoucherNo9 { get; set; }
        [Column("Voucher No 10")]
        [StringLength(20)]
        public string? VoucherNo10 { get; set; }
        [Column("Voucher No 11")]
        [StringLength(20)]
        public string? VoucherNo11 { get; set; }
        [Column("Voucher No 12")]
        [StringLength(20)]
        public string? VoucherNo12 { get; set; }
        [Column("Voucher No 13")]
        [StringLength(20)]
        public string? VoucherNo13 { get; set; }
        [Column("Voucher No 14")]
        [StringLength(20)]
        public string? VoucherNo14 { get; set; }
        [Column("Voucher No 15")]
        [StringLength(20)]
        public string? VoucherNo15 { get; set; }
        [Column("Voucher No 16")]
        [StringLength(20)]
        public string? VoucherNo16 { get; set; }
        [Column("Voucher No 17")]
        [StringLength(20)]
        public string? VoucherNo17 { get; set; }
        [Column("Voucher No 18")]
        [StringLength(20)]
        public string? VoucherNo18 { get; set; }
        [Column("Voucher No 19")]
        [StringLength(20)]
        public string? VoucherNo19 { get; set; }
        [Column("Voucher No 20")]
        [StringLength(20)]
        public string? VoucherNo20 { get; set; }
        [Column("Voucher No Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherNoAutoManualFlag { get; set; }
        [Column("Voucher Type 1")]
        [StringLength(2)]
        public string? VoucherType1 { get; set; }
        [Column("Voucher Type 2")]
        [StringLength(2)]
        public string? VoucherType2 { get; set; }
        [Column("Voucher Type 3")]
        [StringLength(2)]
        public string? VoucherType3 { get; set; }
        [Column("Voucher Type 4")]
        [StringLength(2)]
        public string? VoucherType4 { get; set; }
        [Column("Voucher Type 5")]
        [StringLength(2)]
        public string? VoucherType5 { get; set; }
        [Column("Voucher Type 6")]
        [StringLength(2)]
        public string? VoucherType6 { get; set; }
        [Column("Voucher Type 7")]
        [StringLength(2)]
        public string? VoucherType7 { get; set; }
        [Column("Voucher Type 8")]
        [StringLength(2)]
        public string? VoucherType8 { get; set; }
        [Column("Voucher Type 9")]
        [StringLength(2)]
        public string? VoucherType9 { get; set; }
        [Column("Voucher Type 10")]
        [StringLength(2)]
        public string? VoucherType10 { get; set; }
        [Column("Voucher Type 11")]
        [StringLength(2)]
        public string? VoucherType11 { get; set; }
        [Column("Voucher Type 12")]
        [StringLength(2)]
        public string? VoucherType12 { get; set; }
        [Column("Voucher Type 13")]
        [StringLength(2)]
        public string? VoucherType13 { get; set; }
        [Column("Voucher Type 14")]
        [StringLength(2)]
        public string? VoucherType14 { get; set; }
        [Column("Voucher Type 15")]
        [StringLength(2)]
        public string? VoucherType15 { get; set; }
        [Column("Voucher Type 16")]
        [StringLength(2)]
        public string? VoucherType16 { get; set; }
        [Column("Voucher Type 17")]
        [StringLength(2)]
        public string? VoucherType17 { get; set; }
        [Column("Voucher Type 18")]
        [StringLength(2)]
        public string? VoucherType18 { get; set; }
        [Column("Voucher Type 19")]
        [StringLength(2)]
        public string? VoucherType19 { get; set; }
        [Column("Voucher Type 20")]
        [StringLength(2)]
        public string? VoucherType20 { get; set; }
        [Column("Voucher Type 1 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType1AutoManualFlag { get; set; }
        [Column("Voucher Type 2 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType2AutoManualFlag { get; set; }
        [Column("Voucher Type 3 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType3AutoManualFlag { get; set; }
        [Column("Voucher Type 4 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType4AutoManualFlag { get; set; }
        [Column("Voucher Type 5 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType5AutoManualFlag { get; set; }
        [Column("Voucher Type 6 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType6AutoManualFlag { get; set; }
        [Column("Voucher Type 7 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType7AutoManualFlag { get; set; }
        [Column("Voucher Type 8 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType8AutoManualFlag { get; set; }
        [Column("Voucher Type 9 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType9AutoManualFlag { get; set; }
        [Column("Voucher Type 10 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType10AutoManualFlag { get; set; }
        [Column("Voucher Type 11 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType11AutoManualFlag { get; set; }
        [Column("Voucher Type 12 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType12AutoManualFlag { get; set; }
        [Column("Voucher Type 13 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType13AutoManualFlag { get; set; }
        [Column("Voucher Type 14 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType14AutoManualFlag { get; set; }
        [Column("Voucher Type 15 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType15AutoManualFlag { get; set; }
        [Column("Voucher Type 16 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType16AutoManualFlag { get; set; }
        [Column("Voucher Type 17 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType17AutoManualFlag { get; set; }
        [Column("Voucher Type 18 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType18AutoManualFlag { get; set; }
        [Column("Voucher Type 19 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType19AutoManualFlag { get; set; }
        [Column("Voucher Type 20 Auto Manual Flag")]
        [StringLength(1)]
        public string? VoucherType20AutoManualFlag { get; set; }
        [Column("With Holding Tax Acc Code")]
        [StringLength(15)]
        public string? WithHoldingTaxAccCode { get; set; }
        [Column("WHold Tax Item Code")]
        [StringLength(15)]
        public string? WholdTaxItemCode { get; set; }
        [Column("With Holding Tax Vendor Type")]
        [StringLength(5)]
        public string? WithHoldingTaxVendorType { get; set; }
        [Column("With Holding Tax Vendor Type 1")]
        [StringLength(5)]
        public string? WithHoldingTaxVendorType1 { get; set; }
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
