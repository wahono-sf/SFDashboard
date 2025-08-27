using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slpa1")]
    public partial class Slpa1
    {
        /// <summary>
        /// test
        /// </summary>
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Define Ref No Prefix in slaj1/jmaj1
        /// </summary>
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? AgeingType { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? AgentCode { get; set; }
        /// <summary>
        /// Use in report e.g. Customer Reminder
        /// </summary>
        [StringLength(50)]
        public string? AttnName { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it will call the post store prcedure auotmatically as long as the record exit the form if the record is not posted and not deleted
        /// </summary>
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        /// <summary>
        /// Allow to reverse the Invoice by Credit note
        /// </summary>
        [StringLength(1)]
        public string? AutoReverseCreditNoteFlag { get; set; }
        [StringLength(1)]
        public string? AutoUpdateReleaseDateFlag { get; set; }
        /// <summary>
        /// Default the Bank Acc Code to the Customer Receipt if Bank Code is blank
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [StringLength(10)]
        public string? BankCode { get; set; }
        /// <summary>
        /// Default the Bank Code 1 to the Customer Receipt form when user select Receipt Type 1
        /// </summary>
        [StringLength(10)]
        public string? BankCode1 { get; set; }
        /// <summary>
        /// Default the Bank Code 2 to the Customer Receipt form when user select Receipt Type 2
        /// </summary>
        [StringLength(10)]
        public string? BankCode2 { get; set; }
        /// <summary>
        /// Default the Bank Code 3 to the Customer Receipt form when user select Receipt Type 3
        /// </summary>
        [StringLength(10)]
        public string? BankCode3 { get; set; }
        /// <summary>
        /// Default the Bank Code 4 to the Customer Receipt form when user select Receipt Type 4
        /// </summary>
        [StringLength(10)]
        public string? BankCode4 { get; set; }
        /// <summary>
        /// Default the Bank Code 5 to the Customer Receipt form when user select Receipt Type 5
        /// </summary>
        [StringLength(10)]
        public string? BankCode5 { get; set; }
        /// <summary>
        /// Default the Bank Code 6 to the Customer Receipt form when user select Receipt Type 6
        /// </summary>
        [StringLength(10)]
        public string? BankCode6 { get; set; }
        /// <summary>
        /// Default the Bank Code 7 to the Customer Receipt form when user select Receipt Type 7
        /// </summary>
        [StringLength(10)]
        public string? BankCode7 { get; set; }
        /// <summary>
        /// Default the Bank Code 8 to the Customer Receipt form when user select Receipt Type 8
        /// </summary>
        [StringLength(10)]
        public string? BankCode8 { get; set; }
        /// <summary>
        /// Default the Bank Code 9 to the Customer Receipt form when user select Receipt Type 9
        /// </summary>
        [StringLength(10)]
        public string? BankCode9 { get; set; }
        /// <summary>
        /// Default the Bank Code 10 to the Customer Receipt form when user select Receipt Type 10
        /// </summary>
        [StringLength(10)]
        public string? BankCode10 { get; set; }
        /// <summary>
        /// Default the Bank Code 11 to the Customer Receipt form when user select Receipt Type 11
        /// </summary>
        [StringLength(10)]
        public string? BankCode11 { get; set; }
        /// <summary>
        /// Default the Bank Code 12 to the Customer Receipt form when user select Receipt Type 12
        /// </summary>
        [StringLength(10)]
        public string? BankCode12 { get; set; }
        /// <summary>
        /// Default the Bank Code 13 to the Customer Receipt form when user select Receipt Type 13
        /// </summary>
        [StringLength(10)]
        public string? BankCode13 { get; set; }
        /// <summary>
        /// Default the Bank Code 14 to the Customer Receipt form when user select Receipt Type 14
        /// </summary>
        [StringLength(10)]
        public string? BankCode14 { get; set; }
        /// <summary>
        /// Default the Bank Code 15 to the Customer Receipt form when user select Receipt Type 15
        /// </summary>
        [StringLength(10)]
        public string? BankCode15 { get; set; }
        /// <summary>
        /// Default the Bank Code 16 to the Customer Receipt form when user select Receipt Type 16
        /// </summary>
        [StringLength(10)]
        public string? BankCode16 { get; set; }
        /// <summary>
        /// Default the Bank Code 17 to the Customer Receipt form when user select Receipt Type 17
        /// </summary>
        [StringLength(10)]
        public string? BankCode17 { get; set; }
        /// <summary>
        /// Default the Bank Code 18 to the Customer Receipt form when user select Receipt Type 18
        /// </summary>
        [StringLength(10)]
        public string? BankCode18 { get; set; }
        /// <summary>
        /// Default the Bank Code 19 to the Customer Receipt form when user select Receipt Type 19
        /// </summary>
        [StringLength(10)]
        public string? BankCode19 { get; set; }
        /// <summary>
        /// Default the Bank Code 20 to the Customer Receipt form when user select Receipt Type 20
        /// </summary>
        [StringLength(10)]
        public string? BankCode20 { get; set; }
        [StringLength(10)]
        public string? CashCustomerCode { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Cash Receipt
        /// </summary>
        [StringLength(5)]
        public string? CashPrefix { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? CombineStatementFlag { get; set; }
        [StringLength(15)]
        public string? ContainerDepositAccCode { get; set; }
        /// <summary>
        /// Verify the Customer credit limit when click Booking confirm or call the confirm booking sreen or click AWB Button in the booking.
        /// </summary>
        [StringLength(1)]
        public string? CreditCheckBookingErrorFlag { get; set; }
        /// <summary>
        /// Verify the customer credit limit when entering the job in operation. Y - Verify and stop the user to continue. N - Verify but give user warning only
        /// </summary>
        [StringLength(1)]
        public string? CreditCheckErrorFlag { get; set; }
        /// <summary>
        /// Define Email address. when enter the CustomerCode, the Credit Limit has exceeded it will auto send email
        /// </summary>
        [StringLength(255)]
        public string? CreditLimitEmailAddress { get; set; }
        [StringLength(1)]
        public string? CreditLimitEmailReminder { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Invoice
        /// </summary>
        [StringLength(5)]
        public string? CreditPrefix { get; set; }
        /// <summary>
        /// Define the length of the Customer Code when auto generate the customer code exclude the first letter of the name
        /// </summary>
        public byte? CustomerCodeLength { get; set; }
        [StringLength(15)]
        public string? DebtorAccCode { get; set; }
        [StringLength(1)]
        public string? DefaultChequeDateFlag { get; set; }
        /// <summary>
        /// Use in report e.g. Customer Reminder
        /// </summary>
        [StringLength(10)]
        public string? Designation { get; set; }
        /// <summary>
        /// Default the Account Code for Foreign Exchange Difference
        /// </summary>
        [StringLength(15)]
        public string? ExGainLossAccCode { get; set; }
        /// <summary>
        /// If set as’Y’, then show the button ‘Invoice’ instead the button ‘Trf’ and ‘Unpaid Invoice’ and hide the button &apos;Contra&apos;, &apos;Advance&apos; and ExDiff&apos; and also should not check if the balance is &apos;0&apos; or not in slcr1 in operation. Also show the slcr3 instead slcr2 and display only.
        /// </summary>
        [StringLength(1)]
        public string? InvoiceFlag { get; set; }
        /// <summary>
        /// Link to the Operation Invoice. If N, the Billing Party in the invoice will not link to Customer Code.If set Y, the Billing Party F4 search can not show the Business Party without Customer Code
        /// </summary>
        [StringLength(1)]
        public string? LinkOpFlag { get; set; }
        /// <summary>
        /// if set as Y, then the slcr2 amt will be locked when PaidInvoiceFlag=C,I or V
        /// </summary>
        [StringLength(1)]
        public string? LockPaidInvoiceFlag { get; set; }
        [StringLength(1)]
        public string? LockPrintReceiptFlag { get; set; }
        /// <summary>
        /// Allow Multiple Currencies of the Invoice or Customer Receipt if the Currency Code is entered to the Bank Code
        /// </summary>
        [StringLength(1)]
        public string? MultiCurrFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(20)]
        public string? NextCashReceiptNo { get; set; }
        /// <summary>
        /// Next Journal No to generate when posting
        /// </summary>
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        /// <summary>
        /// Next Official Receipt No.
        /// </summary>
        [StringLength(20)]
        public string? NextOfficialReceiptNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? NextPostDate { get; set; }
        /// <summary>
        /// Default the next running no. of the With Holding Tax in the Customer Receipt
        /// </summary>
        [StringLength(20)]
        public string? NextWithHoldingTaxNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public int? NoOfDaysPast { get; set; }
        /// <summary>
        /// If set as Y, Press F4 or auto search at the Customer Code in aebk1, aeaw1, aiaw1, sebk1, sebl1, sibl1 will filter the rcbp1 only with Customer Code
        /// </summary>
        [StringLength(1)]
        public string? OpCustomerCodeFlag { get; set; }
        /// <summary>
        /// Default the Original Currency Rate of the invoice when settlement of the invoice
        /// </summary>
        [StringLength(1)]
        public string? OriginalCurrRateFlag { get; set; }
        /// <summary>
        /// Specify if the posting should update the Sales Ledger to General Ledger with Detail. It works only when specify the posting by Batch
        /// </summary>
        [StringLength(1)]
        public string? PostDetailFlag { get; set; }
        /// <summary>
        /// O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month
        /// </summary>
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        /// <summary>
        /// When exit out the Customer Receipt will prompt user if it is not posted.
        /// </summary>
        [StringLength(1)]
        public string? PromptPostFlag { get; set; }
        /// <summary>
        /// Y to show an Adjustment button in the Customer Receipt to adjust the Local Receipt Amount
        /// </summary>
        [StringLength(1)]
        public string? ReceiptAdjustFlag { get; set; }
        [StringLength(1)]
        public string? ReceiptNoAuditFlag { get; set; }
        /// <summary>
        /// The Ref No. and Journal No. Prefix for the Customer Receipt
        /// </summary>
        [StringLength(5)]
        public string? ReceiptPrefix { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType1 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType2 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType3 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType4 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType5 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType6 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType7 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType8 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType9 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType10 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType11 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType12 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType13 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType14 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType15 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType16 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType17 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType18 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType19 { get; set; }
        /// <summary>
        /// Set the Receipt Type for Customer Receipt form
        /// </summary>
        [StringLength(2)]
        public string? ReceiptType20 { get; set; }
        /// <summary>
        /// When Reverse Posting of the cusotmer receipt, O - delete the record in GL, B - insert the reversal entry in GL
        /// </summary>
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        /// <summary>
        /// Default the Account Code for Rounding Difference
        /// </summary>
        [StringLength(15)]
        public string? RoundOffAccCode { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? SalesmanByCustomerFlag { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? ShowCustomerBalanceFlag { get; set; }
        /// <summary>
        /// When set as Y, it will show Receipt button in slcr1 form.
        /// </summary>
        [StringLength(1)]
        public string? ShowReceiptButtonFlag { get; set; }
        [StringLength(1)]
        public string? ShowZeroBalanceFlag { get; set; }
        [StringLength(15)]
        public string? SuspenseAccCode { get; set; }
        /// <summary>
        /// When generate gljv1 record from Currency Revaluation, one Acc Code pull this for AR
        /// </summary>
        [StringLength(15)]
        public string? UnrealiseAccCode { get; set; }
        /// <summary>
        /// NOT IN USE IN NET SYSFREIGHT
        /// </summary>
        [StringLength(1)]
        public string? UpdateVatFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(20)]
        public string? VatRegistrationNo { get; set; }
        /// <summary>
        /// A - Auto Receipt No, M - Manual Receipt No , B - Both
        /// </summary>
        [StringLength(1)]
        public string? VoucherNoAutoManualFlag { get; set; }
        /// <summary>
        /// Default the Account Code of the With Holding Tax
        /// </summary>
        [Column("WHoldTaxAccCode")]
        [StringLength(15)]
        public string? WholdTaxAccCode { get; set; }
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
