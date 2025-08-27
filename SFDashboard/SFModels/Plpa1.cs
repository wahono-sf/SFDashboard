using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("plpa1")]
    public partial class Plpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Default the Account Code to the Payment Voucher when transferred to Account for the specified Accrued Voucher Type
        /// </summary>
        [StringLength(50)]
        public string? AccruedPaymentAccCode { get; set; }
        [StringLength(1)]
        public string? AccruedVatExDiffFlag { get; set; }
        /// <summary>
        /// Specify the Voucher Type for the Payment need to change the account code during the Purchase Transfer
        /// </summary>
        [StringLength(50)]
        public string? AccruedVoucherType { get; set; }
        /// <summary>
        /// Define Ref No Prefix in plaj1
        /// </summary>
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        /// <summary>
        /// Set Acc Code for Plvi1 Settlement button.
        /// </summary>
        [StringLength(15)]
        public string? AdvanceAccCode { get; set; }
        /// <summary>
        /// Set as Y, plvi1 and Payment Voucher Approve screen not auto generate the voucher no when save. But when click Approve button;
        /// </summary>
        [StringLength(1)]
        public string? AppGenerateVoucherNoFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos;, then it will auto update plvi2 total amout to plvi1, if set as &apos;N&apos; or leave blank, then use the old logic
        /// </summary>
        [StringLength(50)]
        public string? AutoBalanceFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted
        /// </summary>
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [StringLength(1)]
        public string? AutoVatBaseAmtFlag { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? AvgVatRefundRate { get; set; }
        /// <summary>
        /// Default the Account Code in Cash Purchase and Vendor Payment when Bank Code is not specified
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        /// <summary>
        /// Control
        /// </summary>
        [StringLength(1)]
        public string? BankAccountMandatoryFlag { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 1
        /// </summary>
        [StringLength(10)]
        public string? BankCode1 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 2
        /// </summary>
        [StringLength(10)]
        public string? BankCode2 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 3
        /// </summary>
        [StringLength(10)]
        public string? BankCode3 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 4
        /// </summary>
        [StringLength(10)]
        public string? BankCode4 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 5
        /// </summary>
        [StringLength(10)]
        public string? BankCode5 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 6
        /// </summary>
        [StringLength(10)]
        public string? BankCode6 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 7
        /// </summary>
        [StringLength(10)]
        public string? BankCode7 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 8
        /// </summary>
        [StringLength(10)]
        public string? BankCode8 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 9
        /// </summary>
        [StringLength(10)]
        public string? BankCode9 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 10
        /// </summary>
        [StringLength(10)]
        public string? BankCode10 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 11
        /// </summary>
        [StringLength(10)]
        public string? BankCode11 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 12
        /// </summary>
        [StringLength(10)]
        public string? BankCode12 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 13
        /// </summary>
        [StringLength(10)]
        public string? BankCode13 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 14
        /// </summary>
        [StringLength(10)]
        public string? BankCode14 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 15
        /// </summary>
        [StringLength(10)]
        public string? BankCode15 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 16
        /// </summary>
        [StringLength(10)]
        public string? BankCode16 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 17
        /// </summary>
        [StringLength(10)]
        public string? BankCode17 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 18
        /// </summary>
        [StringLength(10)]
        public string? BankCode18 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 19
        /// </summary>
        [StringLength(10)]
        public string? BankCode19 { get; set; }
        /// <summary>
        /// Default the Bank Code for Voucher Type 20
        /// </summary>
        [StringLength(10)]
        public string? BankCode20 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode01 to plvi2.AccCode base on the CashAdvanceType01
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode01 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode02 to plvi2.AccCode base on the CashAdvanceType02
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode02 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode03 to plvi2.AccCode base on the CashAdvanceType03
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode03 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode04 to plvi2.AccCode base on the CashAdvanceType04
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode04 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode05 to plvi2.AccCode base on the CashAdvanceType05
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode05 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode06 to plvi2.AccCode base on the CashAdvanceType06
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode06 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode07 to plvi2.AccCode base on the CashAdvanceType07
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode07 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode08 to plvi2.AccCode base on the CashAdvanceType08
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode08 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode09 to plvi2.AccCode base on the CashAdvanceType09
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode09 { get; set; }
        /// <summary>
        /// Click Expense Settlement button, it will default CashAdvanceAccCode10 to plvi2.AccCode base on the CashAdvanceType10
        /// </summary>
        [StringLength(15)]
        public string? CashAdvanceAccCode10 { get; set; }
        [StringLength(30)]
        public string? CashAdvanceItemCode { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode01 to plvi2 base on the CashAdvanceType01
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode01 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode01 to plvi2 base on the CashAdvanceType01
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode02 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode03 to plvi2 base on the CashAdvanceType03
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode03 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode04 to plvi2 base on the CashAdvanceType04
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode04 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode05 to plvi2 base on the CashAdvanceType05
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode05 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode06 to plvi2 base on the CashAdvanceType06
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode06 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode07 to plvi2 base on the CashAdvanceType07
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode07 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode08 to plvi2 base on the CashAdvanceType08
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode08 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode09 to plvi2 base on the CashAdvanceType09
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode09 { get; set; }
        /// <summary>
        /// Click Complete Settlement button, it will default the CashAdvanceItemCode10 to plvi2 base on the CashAdvanceType10
        /// </summary>
        [StringLength(30)]
        public string? CashAdvanceItemCode10 { get; set; }
        /// <summary>
        /// Default Cash Advance Type
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType01 { get; set; }
        /// <summary>
        /// Set CashAdvanceType02 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType02 { get; set; }
        /// <summary>
        /// Set CashAdvanceType03 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType03 { get; set; }
        /// <summary>
        /// Set CashAdvanceType04 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType04 { get; set; }
        /// <summary>
        /// Set CashAdvanceType05 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType05 { get; set; }
        /// <summary>
        /// Set CashAdvanceType06 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType06 { get; set; }
        /// <summary>
        /// Set CashAdvanceType07 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType07 { get; set; }
        /// <summary>
        /// Set CashAdvanceType08 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType08 { get; set; }
        /// <summary>
        /// Set CashAdvanceType09 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType09 { get; set; }
        /// <summary>
        /// Set CashAdvanceType10 for plvi1 Cash Advance
        /// </summary>
        [StringLength(5)]
        public string? CashAdvanceType10 { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Cash Purchase
        /// </summary>
        [StringLength(5)]
        public string? CashPrefix { get; set; }
        /// <summary>
        /// Default the Vendor Code for the Cash Purchase without Vendor Code for Reporting
        /// </summary>
        [StringLength(10)]
        public string? CashVendorCode { get; set; }
        /// <summary>
        /// Set as Y,  check the Cheque No and Cheque Date is entered or not when post plvi1 record (TrxType=5,6)
        /// </summary>
        [StringLength(1)]
        public string? CheckChequePostFlag { get; set; }
        /// <summary>
        /// Set as Y, check the duplicate item code is entered for same job in plvi2.
        /// </summary>
        [StringLength(1)]
        public string? CheckDuplicateItemFlag { get; set; }
        /// <summary>
        /// When entering the Item Code in Vendor Invoice or Cash Purchase, it will prompt user if the Sales is less than the Cost entered
        /// </summary>
        [StringLength(1)]
        public string? CheckSalesFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? CombineStatementFlag { get; set; }
        /// <summary>
        /// Set Voucher Type for Complete Settlement screen.
        /// </summary>
        [StringLength(2)]
        public string? CompleteSettlementVoucherType { get; set; }
        /// <summary>
        /// Y to show an Adjustment button in the Vendor Invoice to adjust the Local Invoice Amount
        /// </summary>
        [StringLength(1)]
        public string? CostAdjustFlag { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Vendor Invoice
        /// </summary>
        [StringLength(5)]
        public string? CreditPrefix { get; set; }
        /// <summary>
        /// Default Trade Creditor Account Code in Customer File
        /// </summary>
        [StringLength(15)]
        public string? CreditorAccCode { get; set; }
        [StringLength(1)]
        public string? CurrRateFlag { get; set; }
        /// <summary>
        /// Set as Y, then the Voucher Date in Plcp1 and Payment Date in Plpm1 will default to ChequeDate
        /// </summary>
        [StringLength(1)]
        public string? DefaultChequePostDate { get; set; }
        /// <summary>
        /// Set as &apos;J&apos; to default the Invoice Date as Job Date, Set as &apos;B&apos; to default the Invoice Date as blank which TrxType=1,2,3
        /// </summary>
        [StringLength(1)]
        public string? DefaultInvoiceDateFlag { get; set; }
        /// <summary>
        /// If set as &apos;T&apos;, then default TrxNo. If set as &apos;J&apos;, then default Job No. If set as &apos;M&apos;, then default MAWB/Awb No in the combo box
        /// </summary>
        [StringLength(1)]
        public string? DefaultSearchName { get; set; }
        [StringLength(1)]
        public string? DuplicateChequeNoFlag { get; set; }
        [StringLength(1)]
        public string? DuplicateInvoiceNoFlag { get; set; }
        /// <summary>
        /// Control which button to show under Edit screen(plvi2 edit button).  Can enter M,O,K or blank. Blank means show all.
        /// </summary>
        [StringLength(10)]
        public string? EditCostingButton { get; set; }
        /// <summary>
        /// If set ‘N’, the system should disable ‘…’ button which nearby the Total Standard text box in plvi1
        /// </summary>
        [StringLength(1)]
        public string? EditVatBaseAmtFlag { get; set; }
        /// <summary>
        /// E Invoice EDI
        /// </summary>
        [Column("eInvoiceItemCode")]
        [StringLength(30)]
        public string? EInvoiceItemCode { get; set; }
        /// <summary>
        /// Default the Account Code for Foreign Exchange Difference
        /// </summary>
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        /// <summary>
        /// Set as Y, hide the Local Amt filed in plvi1/2
        /// </summary>
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        /// <summary>
        /// Hide the Unpost button in Plvi1 in operation.
        /// If set as &apos;A&apos;, then hide the Unpost button for all user
        /// If set as &apos;S&apos;, then hide the Unpost button for access right =&apos;S&apos; and &apos;U&apos;
        /// If set as &apos;U&apos;, then hide the Unpost button for access right=&apos;U&apos;
        /// </summary>
        [StringLength(1)]
        public string? HideOperationUnpostFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then hide the &apos;Invoice No&apos;, &apos;Hire Purchase Code&apos; and &apos; Purchase Order No&apos; in plvi1_5.
        /// </summary>
        [StringLength(1)]
        public string? HidePaymentInfoFlag { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? HideZeroProvisionFlag { get; set; }
        /// <summary>
        /// Define the HirePurchaseItemCode to plcp1
        /// </summary>
        [StringLength(30)]
        public string? HirePurchaseItemCode { get; set; }
        /// <summary>
        /// Set as Y, it will show the Invoice Type on plvi1 screen. The value search from savl1
        /// </summary>
        [StringLength(1)]
        public string? InvoiceTypeFlag { get; set; }
        [StringLength(1)]
        public string? JobNoFirstColumnFlag { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 1
        /// </summary>
        [StringLength(10)]
        public string? JobType1 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 2
        /// </summary>
        [StringLength(10)]
        public string? JobType2 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 3
        /// </summary>
        [StringLength(10)]
        public string? JobType3 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 4
        /// </summary>
        [StringLength(10)]
        public string? JobType4 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 5
        /// </summary>
        [StringLength(10)]
        public string? JobType5 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 6
        /// </summary>
        [StringLength(10)]
        public string? JobType6 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 7
        /// </summary>
        [StringLength(10)]
        public string? JobType7 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 8
        /// </summary>
        [StringLength(10)]
        public string? JobType8 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 9
        /// </summary>
        [StringLength(10)]
        public string? JobType9 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 10
        /// </summary>
        [StringLength(10)]
        public string? JobType10 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 11
        /// </summary>
        [StringLength(10)]
        public string? JobType11 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 12
        /// </summary>
        [StringLength(10)]
        public string? JobType12 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 13
        /// </summary>
        [StringLength(10)]
        public string? JobType13 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 14
        /// </summary>
        [StringLength(10)]
        public string? JobType14 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 15
        /// </summary>
        [StringLength(10)]
        public string? JobType15 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 16
        /// </summary>
        [StringLength(10)]
        public string? JobType16 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 17
        /// </summary>
        [StringLength(10)]
        public string? JobType17 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 18
        /// </summary>
        [StringLength(10)]
        public string? JobType18 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 19
        /// </summary>
        [StringLength(10)]
        public string? JobType19 { get; set; }
        /// <summary>
        /// Default the Job Type for Voucher Type 20
        /// </summary>
        [StringLength(10)]
        public string? JobType20 { get; set; }
        /// <summary>
        /// Set Y to keep the operation Payment Voucher after Purchase Transfer. N to delete the Payment Voucher after Purchase Transfer
        /// </summary>
        [StringLength(1)]
        public string? KeepOpPaymentFlag { get; set; }
        /// <summary>
        /// If set as Y, it will check if Charge Item Code have Acc Code in Sepv1 and Sipv1
        /// </summary>
        [StringLength(1)]
        public string? LinkOpFlag { get; set; }
        [StringLength(1)]
        public string? LockAppVoucherFlag { get; set; }
        /// <summary>
        /// Set as Y, lock the plvi1 form (operation) when plvi1 job no status code is CLS. The plvi1 form(Account) only show message in top right.
        /// </summary>
        [StringLength(1)]
        public string? LockCloseJobFlag { get; set; }
        /// <summary>
        /// Lock the Item Description when enter an item code
        /// </summary>
        [StringLength(1)]
        public string? LockDescriptionFlag { get; set; }
        /// <summary>
        /// Set as Y, lock plvi2 grid(operation) grid.
        /// </summary>
        [StringLength(1)]
        public string? LockItemScreenFlag { get; set; }
        /// <summary>
        /// if set as Y, then the plpm2 amt will be locked when PaidInvoiceFlag=C,I or V
        /// </summary>
        [StringLength(1)]
        public string? LockPaidInvoiceFlag { get; set; }
        /// <summary>
        /// if set as &apos;N&apos;,  then enter the Post Date in plvi1 for TrxType=0 will not need to check against the glpa1 currentPlperiod is the PostMth is closed
        /// </summary>
        [StringLength(1)]
        public string? LockProvisionDateFlag { get; set; }
        /// <summary>
        /// Lock the Vendor Name when enter the Vendor Code
        /// </summary>
        [StringLength(1)]
        public string? LockVendorNameFlag { get; set; }
        /// <summary>
        /// Set if the Invoice No. in Cash Purchase is mandatory
        /// </summary>
        [StringLength(1)]
        public string? MandatoryInvoiceNoFlag { get; set; }
        /// <summary>
        /// Allow Multiple Currencies of the Invoice, Cash Purchase or Vendor Payment if the Currency Code is entered to the Bank Code
        /// </summary>
        [StringLength(1)]
        public string? MultiCurrFlag { get; set; }
        /// <summary>
        /// When generate the EDI for AP, it will use the NextBatchNo and then update NextBatchNo+1
        /// </summary>
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        /// <summary>
        /// Next Journal No to generate when posting
        /// </summary>
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        /// <summary>
        /// Default the next running no. of the With Holding Tax in the Payment Voucher which Plvi4.VendorCode link Plvn1.VendorType=WHTVendorType
        /// </summary>
        [StringLength(20)]
        public string? NextWithHoldingTaxNo { get; set; }
        /// <summary>
        /// Default the next running no. of the With Holding Tax in the Payment Voucher which Plvi4.VendorCode link Plvn1.VendorType=WHTVendorType1
        /// </summary>
        [StringLength(20)]
        public string? NextWithHoldingTaxNo1 { get; set; }
        /// <summary>
        /// Default the original currency rate of the invoice when settlement of the invoice
        /// </summary>
        [StringLength(1)]
        public string? OriginalCurrRateFlag { get; set; }
        /// <summary>
        /// Y to show an Adjustment button in the Vendor Payment to adjust the Local Payment Amount
        /// </summary>
        [StringLength(1)]
        public string? PaymentAdjustFlag { get; set; }
        /// <summary>
        /// Set Y when posting the Vendor Invoice or Cash Purchase, it will post the Accural Account Code to reverse the accural from Job Costing
        /// </summary>
        [StringLength(1)]
        public string? PostAccrualFlag { get; set; }
        /// <summary>
        /// Specify if the posting should update the Purchase Ledger to General Ledger with Detail. It works only when specify the posting by Batch
        /// </summary>
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        /// <summary>
        /// O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month
        /// </summary>
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        /// <summary>
        /// Set as Y,  plvi1.InvoiceLocalAmt =Sum plvi2.LocalAmt + round up(plvi1.VatAmt x plvi1.CurrRate)
        /// </summary>
        [StringLength(1)]
        public string? PostSumOfCostFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then under the Document List if record is already on the list(it mean already been invoiced),  click New button will prompt user &apos;This Job has already been invoiced......&apos; Just for TrxType=5
        /// </summary>
        [StringLength(1)]
        public string? PromptDuplicateDocFlag { get; set; }
        /// <summary>
        /// Send the message to Account when operation has prepared a Payment Voucher
        /// </summary>
        [StringLength(1)]
        public string? PromptNotifyFlag { get; set; }
        [StringLength(1)]
        public string? PromptPaymentApproveFlag { get; set; }
        [StringLength(1)]
        public string? PromptVendorPaymentRequestFlag { get; set; }
        /// <summary>
        /// If set as ‘Y’, then click the ‘Cost’ button in plvi1(the TrxType&lt;&gt;’0’) change to pull from plvi2 where plvi1.TrxType=’0’(Provision Cost). It should filter the VendorCode and StatusCode&lt;&gt;’Del’.
        /// - when update the Provision Cost to Vendor Invoice (TrxType&lt;&gt;&apos;0&apos;), the Qty, UnitRate and CurrRate in Vendor Invoice should same as Provision Cost
        /// </summary>
        [StringLength(1)]
        public string? ProvisionCostButtonFlag { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Vendor Payment
        /// </summary>
        [StringLength(5)]
        public string? ReceiptPrefix { get; set; }
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        /// <summary>
        /// When Reverse Posting of the record in Purchase Ledger, O - delete the record in GL, B - insert the reversal entry in GL
        /// </summary>
        [StringLength(50)]
        public string? ReversePostOnlineOrBatch { get; set; }
        /// <summary>
        /// Default the Account Code for Rounding Difference
        /// </summary>
        [StringLength(15)]
        public string? RoundOffAccCode { get; set; }
        /// <summary>
        /// Set Voucher Type for Settlement screen.
        /// </summary>
        [StringLength(2)]
        public string? SettlementVoucherType { get; set; }
        /// <summary>
        /// Set as Y, click PV button under plpm1 screen, the system will show record which StatusCode=&apos;APP&apos;
        /// </summary>
        [StringLength(1)]
        public string? ShowAppVoucherFlag { get; set; }
        /// <summary>
        /// If set as &apos;U&apos;, then show the Post button in operation plvi1 for all user.If set as &apos;S&apos;, then show the Post button in operation plvi1 for access right =&apos;S&apos; or &apos;A&apos;If set as  &apos;A&apos;, then show the Post button in operation plvi1 for access right=&apos;A&apos;.
        /// </summary>
        [StringLength(1)]
        public string? ShowOperationPostFlag { get; set; }
        [StringLength(1)]
        public string? ShowProvPostFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will hide  the those records that are not posted in the Vendor Payment screen when user clicks on the “PV” button
        /// </summary>
        [StringLength(1)]
        public string? ShowPvPostFlag { get; set; }
        /// <summary>
        /// Set as Y, show Vat Amt column after Vat Code in plvi1,slcr1,plpm1 grid. the TotalVatAmt sum from level 2 VatAmt column.
        /// </summary>
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? ShowVendorBalanceFlag { get; set; }
        [StringLength(1)]
        public string? ShowZeroBalanceFlag { get; set; }
        /// <summary>
        /// Set as Y, click Split by in the Vendor Invoice, the system will call screen.
        /// </summary>
        [StringLength(1)]
        public string? SplitCostToTable { get; set; }
        /// <summary>
        /// The document list will check and stop user to enter any cost if the user has not entered any Sales Invoice for the Job
        /// </summary>
        [StringLength(1)]
        public string? StopPaymentVoucherFlag { get; set; }
        [StringLength(15)]
        public string? SuspenseAccCode { get; set; }
        /// <summary>
        /// Set Acc Code for Currency Revalucation form to generate gljv1 record for AP.
        /// </summary>
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        [StringLength(1)]
        public string? UpdateVatCodeFlag { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? UpdateVatFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(25)]
        public string? UserDefine1 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(25)]
        public string? UserDefine2 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(25)]
        public string? UserDefine3 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? VatRefundPercentage { get; set; }
        [StringLength(1)]
        public string? VendorPaymentChequeDate { get; set; }
        [StringLength(15)]
        public string? VendorProvAccCode { get; set; }
        /// <summary>
        /// Define the length of the Vendor Code when auto generate the vendor code exclude the first letter of the name
        /// </summary>
        public byte? VendorCodeLength { get; set; }
        /// <summary>
        /// PF - Prefix,S - Shipment Type,MM - Month,M - Single Month,YY - Year,Y - Single Year,SFX - Suffix
        /// </summary>
        [StringLength(255)]
        public string? VoucherFormat { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 1
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo1 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 2
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo2 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 3
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo3 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 4
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo4 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 5
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo5 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 6
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo6 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 7
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo7 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 8
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo8 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 9
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo9 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 10
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo10 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 11
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo11 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 12
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo12 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 13
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo13 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 14
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo14 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 15
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo15 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 16
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo16 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 17
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo17 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 18
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo18 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 19
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo19 { get; set; }
        /// <summary>
        /// Default the next voucher no. for voucher Type 20
        /// </summary>
        [StringLength(20)]
        public string? VoucherNo20 { get; set; }
        /// <summary>
        /// A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherNoAutoManualFlag { get; set; }
        /// <summary>
        /// Default Voucher Type 1
        /// </summary>
        [StringLength(2)]
        public string? VoucherType1 { get; set; }
        /// <summary>
        /// Default Voucher Type 2
        /// </summary>
        [StringLength(2)]
        public string? VoucherType2 { get; set; }
        /// <summary>
        /// Default Voucher Type 3
        /// </summary>
        [StringLength(2)]
        public string? VoucherType3 { get; set; }
        /// <summary>
        /// Default Voucher Type 4
        /// </summary>
        [StringLength(2)]
        public string? VoucherType4 { get; set; }
        /// <summary>
        /// Default Voucher Type 5
        /// </summary>
        [StringLength(2)]
        public string? VoucherType5 { get; set; }
        /// <summary>
        /// Default Voucher Type 6
        /// </summary>
        [StringLength(2)]
        public string? VoucherType6 { get; set; }
        /// <summary>
        /// Default Voucher Type 7
        /// </summary>
        [StringLength(2)]
        public string? VoucherType7 { get; set; }
        /// <summary>
        /// Default Voucher Type 8
        /// </summary>
        [StringLength(2)]
        public string? VoucherType8 { get; set; }
        /// <summary>
        /// Default Voucher Type 9
        /// </summary>
        [StringLength(2)]
        public string? VoucherType9 { get; set; }
        /// <summary>
        /// Default Voucher Type 10
        /// </summary>
        [StringLength(2)]
        public string? VoucherType10 { get; set; }
        /// <summary>
        /// Default Voucher Type 11
        /// </summary>
        [StringLength(2)]
        public string? VoucherType11 { get; set; }
        /// <summary>
        /// Default Voucher Type 12
        /// </summary>
        [StringLength(2)]
        public string? VoucherType12 { get; set; }
        /// <summary>
        /// Default Voucher Type 13
        /// </summary>
        [StringLength(2)]
        public string? VoucherType13 { get; set; }
        /// <summary>
        /// Default Voucher Type 14
        /// </summary>
        [StringLength(2)]
        public string? VoucherType14 { get; set; }
        /// <summary>
        /// Default Voucher Type 15
        /// </summary>
        [StringLength(2)]
        public string? VoucherType15 { get; set; }
        /// <summary>
        /// Default Voucher Type 16
        /// </summary>
        [StringLength(2)]
        public string? VoucherType16 { get; set; }
        /// <summary>
        /// Default Voucher Type 17
        /// </summary>
        [StringLength(2)]
        public string? VoucherType17 { get; set; }
        /// <summary>
        /// Default Voucher Type 18
        /// </summary>
        [StringLength(2)]
        public string? VoucherType18 { get; set; }
        /// <summary>
        /// Default Voucher Type 19
        /// </summary>
        [StringLength(2)]
        public string? VoucherType19 { get; set; }
        /// <summary>
        /// Default Voucher Type 20
        /// </summary>
        [StringLength(2)]
        public string? VoucherType20 { get; set; }
        /// <summary>
        /// Control Voucher No for Voucher Type 1
        /// </summary>
        [StringLength(1)]
        public string? VoucherType1AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 2. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType2AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 1. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType3AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 3. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType4AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 5. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType5AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 6. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType6AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 7. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType7AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 8. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType8AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 9. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType9AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 10. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType10AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 11. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType11AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 12. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType12AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 13. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType13AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 14. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType14AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 15. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType15AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 16. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType16AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 17. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType17AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 18. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType18AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 19. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType19AutoManualFlag { get; set; }
        /// <summary>
        /// Control generate Voucher No for Voucher Type 20. A - Auto Voucher No, M - Manual Voucher No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherType20AutoManualFlag { get; set; }
        /// <summary>
        /// Default the Account Code of the With Holding Tax
        /// </summary>
        [Column("WHoldTaxAccCode")]
        [StringLength(15)]
        public string? WholdTaxAccCode { get; set; }
        [Column("WHoldTaxItemCode")]
        [StringLength(15)]
        public string? WholdTaxItemCode { get; set; }
        /// <summary>
        /// Define the VendorType (match plvi4.VendorCode link Plvn1.VendorType) to generate the WithHoldingTaxNo for Next With Holding Tax No
        /// </summary>
        [Column("WHTVendorType")]
        [StringLength(5)]
        public string? WhtvendorType { get; set; }
        /// <summary>
        /// Define the VendorType (match plvi4.VendorCode link Plvn1.VendorType) to generate the WithHoldingTaxNo for Next With Holding Tax No 1
        /// </summary>
        [Column("WHTVendorType1")]
        [StringLength(5)]
        public string? WhtvendorType1 { get; set; }
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
    }
}
