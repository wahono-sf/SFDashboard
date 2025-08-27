using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivpa1")]
    public partial class Ivpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Default Invoice Type for Air Export Invoice Type when Job Type is AE
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? AirExportInvoiceType { get; set; }
        /// <summary>
        /// To print on Air Export Invoice
        /// </summary>
        [StringLength(5)]
        public string? AirExportPrefix { get; set; }
        /// <summary>
        /// Default Invoice Type for Air Import Invoice Type when Job Type is AI
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? AirImportInvoiceType { get; set; }
        /// <summary>
        /// To print on Air Import Invoice
        /// </summary>
        [StringLength(5)]
        public string? AirImportPrefix { get; set; }
        /// <summary>
        /// Set as Y, if the record is not posted and not deleted, it will auto post as long as the record exit the form.
        /// </summary>
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [Column("BBFeeItemCode")]
        [StringLength(30)]
        public string? BbfeeItemCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? BlockInvTemplateFlag { get; set; }
        /// <summary>
        /// If set as F, Cash Note running No is created by Next Cash Invoice No 1
        /// If set as T, Cash Note running No is created by Next Invoice No base on Invoice Type
        /// </summary>
        [StringLength(1)]
        public string? CashNoteFlag { get; set; }
        /// <summary>
        /// If set as F, Cash Receipt running No is created by Next Cash Receipt No 1
        /// If set as T, Cash Receipt running No is created by Next Invoice No base on Invoice Type
        /// </summary>
        [StringLength(1)]
        public string? CashReceiptFlag { get; set; }
        /// <summary>
        /// Define the Term Code in ivcr1 which TrxType=4. If it has value, enter any customer in ivcr1 which TrxType=4, the Term Code will not pull from slcu1 but ivpa1.CashTermCode
        /// </summary>
        [StringLength(3)]
        public string? CashTermCode { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos; then
        ///    a). hide the Address3, Address 4, Postal Code and the button &apos;Other Billing Address&apos; . Display a textbox to show the below:
        ///          if the ModuleCode of ivcr1.JobNo =&apos;SE&apos; 
        ///          POD: sebl1.PortOfDischargeName
        ///          Stuffing Date: sebl1.StuffDate(show datetime)
        ///          Cargo Status: sebl2.CargoStatusCode(top1)
        ///          if the ModuleCode of ivcr1.JobNo=&apos;SI&apos;
        ///          POL: sebl1.PortOfLoadingName
        ///          Unstuffing Date: sibl1.UnstuffDate(show datetime)
        ///          Cargo Status: sibl2.CargoStatusCode(top1)
        /// </summary>
        [StringLength(1)]
        public string? CfsReceiptFlag { get; set; }
        /// <summary>
        /// If set as ‘Y’, then when change TrxType (enter the TrxType on the Change TrxType screen then click ‘OK’), it should prompt the message ‘Do you want to generate new Invoice No for this shipment?’, if yes, it will delete the current ivcr1 and copy a new record and generate a new Invoice No
        /// </summary>
        [StringLength(1)]
        public string? ChangeTypeNewNoFlag { get; set; }
        [StringLength(10)]
        public string? ConsolInvoiceNumberType { get; set; }
        [StringLength(1)]
        public string? ConsolInvUpdateFlag { get; set; }
        [StringLength(1)]
        public string? ControlInvoiceDateFlag { get; set; }
        /// <summary>
        /// Set as Y when click on the receipt button will prompt user to convert the invoice to cash receipt
        /// </summary>
        [StringLength(1)]
        public string? ConvertInvToRcpFlag { get; set; }
        [StringLength(1)]
        public string? CopyCloseJobFlag { get; set; }
        /// <summary>
        /// Verify the customer credit limit in Ivcr1 form. Enter Customer code in Acct ivcr1 form and Billing Party Code in operation ivcr1.if set ivpa1. CreditCheckErrorFlag as Y/A/S/U/N and slcu1.CustomerOnHoldFlag=’Y’,it will prompt the same message as the operation form,it will not allow user to continue.
        /// 
        /// </summary>
        [StringLength(1)]
        public string? CreditCheckErrorFlag { get; set; }
        [StringLength(15)]
        public string? CreditNoteAccCode { get; set; }
        /// <summary>
        /// If set as F, Credit Note running No is created by Next Credit Note No 1
        /// If set as T, Credit Note running No is created by Next Invoice No base on Invoice Type
        /// </summary>
        [StringLength(1)]
        public string? CreditNoteFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? CurrRateFlag { get; set; }
        /// <summary>
        /// If set as F, Debit Note running No is created by Next Debit Note No 1
        /// If set as T, Debit Note running No is created by Next Invoice No base on Invoice Type
        /// </summary>
        [StringLength(1)]
        public string? DebitNoteFlag { get; set; }
        /// <summary>
        /// Default Invoice Date by C - Current Date  or J - Job Date
        /// </summary>
        [StringLength(1)]
        public string? DefaultInvoiceDateFlag { get; set; }
        /// <summary>
        /// Default Invoice Type (08,09 &amp; 10) when enter a new Invoice
        /// </summary>
        [StringLength(1)]
        public string? DefaultInvoiceType { get; set; }
        /// <summary>
        /// Default the Name of the Invoice Type.
        /// </summary>
        [StringLength(20)]
        public string? DefaultName { get; set; }
        /// <summary>
        /// Access Right to Delete the Invoice
        /// </summary>
        [StringLength(1)]
        public string? DeleteInvRight { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Description { get; set; }
        /// <summary>
        /// Print to Footer 1 of the Invoice related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to Footer 2 of the Invoice related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, when create Cash Receipt (TrxType=’5’ and ModuleCode=SI), the system should prompt a screen to allow user enter the DeliveryOrderNo to pull the JobNo. It should also check the “Remark” in the Sibl1, if the remark is entered. It should prompt a message box and display the “Remark”.
        /// </summary>
        [StringLength(1)]
        public string? DoNoFlag { get; set; }
        [StringLength(1)]
        public string? DummyInvoiceCostFlag { get; set; }
        [StringLength(10)]
        public string? EditCostingButton { get; set; }
        /// <summary>
        /// If set as ‘N’, then if the ivcr2 is blank, should not generate InvoiceNo. If set as ‘Y’ or blank use old logic
        /// </summary>
        [StringLength(1)]
        public string? EmptyInvoiceNoFlag { get; set; }
        /// <summary>
        /// For sea import it fix the Cash Invoice
        /// </summary>
        [StringLength(1)]
        public string? FixCashTrxType { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it should pull the CommodityDescription from jmjm1 to ivcr1.GoodsDesecription1
        /// </summary>
        [StringLength(1)]
        public string? GoodsDescriptionFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? GroupFlag { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice node
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType01 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType02 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType03 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType04 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType05 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType06 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType07 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType08 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType09 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType10 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType11 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType12 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType13 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType14 { get; set; }
        /// <summary>
        /// Set Group Invoice Type for Group Invoice form
        /// </summary>
        [StringLength(1)]
        public string? GroupInvoiceType15 { get; set; }
        /// <summary>
        /// When set as Y, the system will hide &apos;Chg Trx&apos; button in ivcr1 form
        /// </summary>
        [StringLength(1)]
        public string? HideChgTrxFlag { get; set; }
        /// <summary>
        /// Hide the Unpost button in ivcr1 in operation.
        /// - if set as &apos;A&apos;, then hide the Unpost button for all user
        /// - if set as &apos;S&apos;, then hide the Unpost button for access right =&apos;S&apos; and &apos;U&apos;
        /// - if set as &apos;U&apos;, then hide the Unpost button for access right=&apos;U&apos;
        /// </summary>
        [StringLength(1)]
        public string? HideOperationUnpostFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, it will hide the sales/cost column in ivcr1 and the total as below abd auto move the invoice total to right
        /// </summary>
        [StringLength(1)]
        public string? HideSalesCostFlag { get; set; }
        [StringLength(1)]
        public string? HistoryOriginalCurrRateFlag { get; set; }
        /// <summary>
        /// If set as F, Invoice running No is created by Next Invoice No 1
        /// If set as T, Invoice running No is created by Next Invoice No base on Invoice Type
        /// </summary>
        [StringLength(1)]
        public string? InvoiceFlag { get; set; }
        /// <summary>
        /// Invoice No Format:[PF:Invoice Prefix],[SFX:Suffix],[S:Shipment Type],[MM:01-12],[M:1-9/A-C],[YY:01-99],[Y:0-9]
        /// </summary>
        [StringLength(255)]
        public string? InvoiceFormat { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? InvoiceFormatType { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? InvoiceNoAutoOrManual { get; set; }
        public int? InvoiceSeqLength { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 01
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType01 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 02
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType02 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 03
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType03 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 04
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType04 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 05
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType05 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 06
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType06 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 07
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType07 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 08
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType08 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 09
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType09 { get; set; }
        /// <summary>
        /// Default Next Invoice  / Credit Note / Debit Note / Cash Note / Cash Receipt No(base on Trx Type) for Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? InvoiceType10 { get; set; }
        /// <summary>
        /// Set as Y, the ivcr1 invoice no should generate base on top 1 sanm1 setting which numbertype=IVCR and TrxType=1. If create more than invoice for the same job, the second invoice no should be first invoiceno+A
        /// </summary>
        [StringLength(1)]
        public string? InvSeqNoByJobFlag { get; set; }
        /// <summary>
        /// Indicate the Invoice Type to control the currency
        /// </summary>
        [StringLength(1)]
        public string? IvTypeCurrControlFlag { get; set; }
        [StringLength(1)]
        public string? JobCostingMarkupFlag { get; set; }
        [StringLength(1)]
        public string? JobNoFirstColumnFlag { get; set; }
        /// <summary>
        /// Set Y to keep the operation invoice after Sales Transfer. N to delete the Invoice after Sales Transfer
        /// </summary>
        [StringLength(1)]
        public string? KeepOpInvoiceFlag { get; set; }
        [StringLength(1)]
        public string? KeepWhInvoiceFlag { get; set; }
        /// <summary>
        /// Set as Y, lock the Address1-4 in the invoice entry.
        /// </summary>
        [StringLength(1)]
        public string? LockAddressFlag { get; set; }
        [StringLength(1)]
        public string? LockAppInvoiceFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then totally lock the ivcr1 record in operation where job is closed. In account, it should not lock but still show the message the ‘This job is already closed.” closed NOT Closed. the back color change to yellow
        /// </summary>
        [StringLength(1)]
        public string? LockCloseJobFlag { get; set; }
        /// <summary>
        /// Lock Currency in the invoice entry
        /// </summary>
        [StringLength(1)]
        public string? LockCurrFlag { get; set; }
        /// <summary>
        /// Lock Currency Rate after invoice has invoice no.
        /// </summary>
        [StringLength(1)]
        public string? LockCurrRateFlag { get; set; }
        /// <summary>
        /// Lock Customer after invoice has invoice no.
        /// </summary>
        [StringLength(1)]
        public string? LockCustomerFlag { get; set; }
        /// <summary>
        /// Lock Customer Name in the invoice entry
        /// </summary>
        [StringLength(1)]
        public string? LockCustomerNameFlag { get; set; }
        /// <summary>
        /// Lock Item Description in the invoice entry
        /// </summary>
        [StringLength(1)]
        public string? LockDescriptionFlag { get; set; }
        /// <summary>
        /// Lock Invoice Date after invoice has invoice no and print count&gt;0.
        /// Set U for lock AccessRight=&apos;U&apos;
        /// Set S for lock AccessRight=&apos;U&apos; and &apos;S&apos;. 
        /// Set A for lock for user
        /// </summary>
        [StringLength(1)]
        public string? LockInvoiceDateFlag { get; set; }
        /// <summary>
        /// Define the days will lock the invoice in operation. Invoice Date &lt; Current Date - Lock Invoice Day will be locked.
        /// </summary>
        public int? LockInvoiceDay { get; set; }
        /// <summary>
        /// Lock Invoice after invoice has invoice no.
        /// </summary>
        [StringLength(1)]
        public string? LockInvoiceFlag { get; set; }
        /// <summary>
        /// Set as Y, it will lock ivcr2 grid under operation
        /// </summary>
        [StringLength(1)]
        public string? LockItemScreenFlag { get; set; }
        /// <summary>
        /// Lock Post Date after invoice has invoice no.
        /// </summary>
        [StringLength(1)]
        public string? LockPostDateFlag { get; set; }
        /// <summary>
        /// Lock ivcr1 form when invoice no have value and PrintCount&gt;0. Set as A - lock for all user. S - lock for user which access right = S/U. U - only lock user which access right = U. Y - only lock user which access right = U
        /// </summary>
        [StringLength(1)]
        public string? LockPrintInvoiceFlag { get; set; }
        [StringLength(1)]
        public string? LockShipmentInfoFlag { get; set; }
        /// <summary>
        /// Lock Term in the invoice entry
        /// </summary>
        [StringLength(1)]
        public string? LockTermFlag { get; set; }
        /// <summary>
        /// Lock Job No. after invoice has invoice no.
        /// </summary>
        [StringLength(1)]
        public string? LockJobNoFlag { get; set; }
        /// <summary>
        /// Define the UomCode in vicr2 when click Charge or Quotation in ivcr1 to pull charges, if the system pull the MinAmt.
        /// </summary>
        [StringLength(50)]
        public string? MinUomCode { get; set; }
        /// <summary>
        /// Default Invoice Type for Miscellaneous Invoice Type when Job Type is MS
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? MiscellaneousInvoiceType { get; set; }
        /// <summary>
        /// To print on Mis Job Invoice
        /// </summary>
        [StringLength(5)]
        public string? MiscellaneousPrefix { get; set; }
        /// <summary>
        /// Allow if the invoice to have negative amount
        /// </summary>
        [StringLength(1)]
        public string? NegativeInvoiceFlag { get; set; }
        /// <summary>
        /// When generate the EDI for AR, it will use the NextBatchNo and then update NextBatchNo+1
        /// </summary>
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        /// <summary>
        /// Default Next Cash invoice no
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo01 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Air Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo02 { get; set; }
        /// <summary>
        /// Default Next Cash invoice no for Sea Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo03 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Sea Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo04 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for warehouse Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo05 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Transport Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo06 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Miscellaneous Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo07 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo08 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo09 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextCashInvoiceNo10 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Air Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo01 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Air Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo02 { get; set; }
        /// <summary>
        /// Default Next Cash invoice no for Sea Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo03 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Sea Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo04 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for warehouse Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo05 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Transport Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo06 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo07 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix02
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo08 { get; set; }
        /// <summary>
        /// Default Next Cash Invoice no for Other Invoice Prefix03
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo09 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Other Invoice Prefix03
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo10 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Air Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo01 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Air Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo02 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Sea Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo03 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Sea Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo04 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for warehouse Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo05 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Transport Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo06 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt  no for Miscellaneous Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo07 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo08 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Other Invoice Prefix02
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo09 { get; set; }
        /// <summary>
        /// Default Next Cash Receipt no for Other Invoice Prefix03
        /// </summary>
        [StringLength(10)]
        public string? NextCreditNoteNo10 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Air Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo01 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Air Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo02 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Sea Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo03 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Sea Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo04 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for warehouse Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo05 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Transport Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo06 { get; set; }
        /// <summary>
        /// Default Next Credit Note  no for Miscellaneous Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo07 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo08 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Other Invoice Prefix02
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo09 { get; set; }
        /// <summary>
        /// Default Next Credit Note no for Other Invoice Prefix03
        /// </summary>
        [StringLength(10)]
        public string? NextDebitNoteNo10 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Air Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo01 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Air Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo02 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Sea Export Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo03 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Sea Import Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo04 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for warehouse Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo05 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Transport Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo06 { get; set; }
        /// <summary>
        /// Default Next Debit Note  no for Miscellaneous Prefix
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo07 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Other Invoice Prefix01
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo08 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Other Invoice Prefix02
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo09 { get; set; }
        /// <summary>
        /// Default Next Debit Note no for Other Invoice Prefix03
        /// </summary>
        [StringLength(10)]
        public string? NextInvoiceNo10 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? NgSignOnCreditNote { get; set; }
        /// <summary>
        /// No. of Days allow user to back date the invoice form current date
        /// </summary>
        public int? NoOfDaysBackDateInvoice { get; set; }
        /// <summary>
        /// Click Save to generate the Invoice No
        /// </summary>
        [StringLength(1)]
        public string? OnSaveGenerateInvNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? OperationFlag { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 01
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix01 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 02
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix02 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 03
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix03 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 04
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix04 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 05
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix05 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 06
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix06 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 07
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix07 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 08
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix08 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 09
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix09 { get; set; }
        /// <summary>
        /// To print on the Invoice that Invoice is Other Invoice Type 10
        /// </summary>
        [StringLength(5)]
        public string? OtherInvoicePrefix10 { get; set; }
        /// <summary>
        /// Define the Invoice Type 01 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType01 { get; set; }
        /// <summary>
        /// Define the Invoice Type 02 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType02 { get; set; }
        /// <summary>
        /// Define the Invoice Type 03 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType03 { get; set; }
        /// <summary>
        /// Define the Invoice Type 04 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType04 { get; set; }
        /// <summary>
        /// Define the Invoice Type 05 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType05 { get; set; }
        /// <summary>
        /// Define the Invoice Type 06 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType06 { get; set; }
        /// <summary>
        /// Define the Invoice Type 07 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType07 { get; set; }
        /// <summary>
        /// Define the Invoice Type 08 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType08 { get; set; }
        /// <summary>
        /// Define the Invoice Type 09 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType09 { get; set; }
        /// <summary>
        /// Define the Invoice Type 10 to Invoice
        /// </summary>
        [StringLength(20)]
        public string? OtherInvoiceType10 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 01 do not show on Seiv1 and Aeiv1 and Operation Ivcr1
        /// If set as SE, Control Other Invoice Type 01 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType01 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 02 do not show on Seiv1 and Aeiv1 and Operation Ivcr1
        /// If set as SE, Control Other Invoice Type 02 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType02 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1
        /// If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType03 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType04 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType05 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType06 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType07 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType08 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType09 { get; set; }
        /// <summary>
        /// If set as SI, Control Other Invoice Type 03 do not show on Seiv1 and Aeiv1 and Operation Ivcr1 If set as SE, Control Other Invoice Type 03 do not show on Siiv1
        /// </summary>
        [StringLength(10)]
        public string? OtherJobType10 { get; set; }
        /// <summary>
        /// Define the VAT (GST) outlay Item Code for reporting
        /// </summary>
        [StringLength(30)]
        public string? OutlayVatItemCode { get; set; }
        [StringLength(1)]
        public string? PostByAirlineFlag { get; set; }
        /// <summary>
        /// O - Post directly to General Ledger, B - Post by Batch to Sales Journal and then post to General Ledger when posting End of Month
        /// </summary>
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        [StringLength(1)]
        public string? PostSalesLedgerFlag { get; set; }
        [StringLength(1)]
        public string? PostSumOfSalesFlag { get; set; }
        /// <summary>
        /// To print the credit note with negative sign
        /// </summary>
        [StringLength(1)]
        public string? PrintCreditNoteSignFlag { get; set; }
        /// <summary>
        /// if the Invoice No is blank. When printing the invoice the Invoice Date will change to the Current Date
        /// </summary>
        [StringLength(1)]
        public string? PrintUpdInvDateFlag { get; set; }
        /// <summary>
        /// Verify the customer credit limit and Slcu1.CustomerHoldFlag when entering the invoice in operation. Y - Verify and stop the user to continue (access right =&apos;U&apos;), Verify but give user warning only (access right =&apos;A&apos; or &apos;S&apos;).
        /// </summary>
        [StringLength(1)]
        public string? PromptCreditCheckFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then under the Document List if record is already on the list(it mean already been invoiced),  click New button will prompt user &apos;This Job has already been invoiced......&apos; Just for TrxType=1
        /// </summary>
        [StringLength(1)]
        public string? PromptDuplicateDocFlag { get; set; }
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        /// <summary>
        /// When Reverse Posting of the invoice, O - delete the record in GL, B - insert the reversal entry in GL
        /// </summary>
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        /// <summary>
        /// Set as Y, The totalVatAmt will round up to 1 when decimal is &gt;=0.5 else 0.
        ///  e.g. 1.5 will be 2 and 1.4 will be 1
        /// </summary>
        [StringLength(1)]
        public string? RoundingVatAmtFlag { get; set; }
        /// <summary>
        /// Set Y to show a button to adjust the Invoice Local Amount
        /// </summary>
        [StringLength(1)]
        public string? SalesAdjustFlag { get; set; }
        [StringLength(1)]
        public string? SalesByCustomerTypeFlag { get; set; }
        /// <summary>
        /// Default Invoice Type for Sea Export Invoice Type when Job Type is SE
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? SeaExportInvoiceType { get; set; }
        /// <summary>
        /// To print on Sea Export Invoice
        /// </summary>
        [StringLength(5)]
        public string? SeaExportPrefix { get; set; }
        /// <summary>
        /// Default Invoice Type for Sea Import Invoice Type when Job Type is SI
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? SeaImportInvoiceType { get; set; }
        /// <summary>
        /// To print on Sea Import Invoice
        /// </summary>
        [StringLength(5)]
        public string? SeaImportPrefix { get; set; }
        /// <summary>
        /// ShowChargeType
        /// </summary>
        [StringLength(1)]
        public string? ShowChargeTypeFlag { get; set; }
        /// <summary>
        /// Set as Y, show MiscFlag on all account ivcr1 form
        /// </summary>
        [StringLength(1)]
        public string? ShowMiscFlag { get; set; }
        /// <summary>
        /// If set as &apos;U&apos;, then show the Post button in operation ivcr1 for all user.If set as &apos;S&apos;, then show the Post button in operation ivcr1 for access right =&apos;S&apos; or &apos;A&apos;If set as  &apos;A&apos;, then show the Post button in operation ivcr1 for access right=&apos;A&apos;.
        /// </summary>
        [StringLength(1)]
        public string? ShowOperationPostFlag { get; set; }
        [StringLength(1)]
        public string? ShowOriginalCurrRateFlag { get; set; }
        /// <summary>
        /// Set as Y, show Vat Amt column after Vat Code in ivcr1 grid. the TotalVatAmt sum from level2.VatAmt column.
        /// </summary>
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        [StringLength(30)]
        public string? SuspenseInvoiceChargeCode { get; set; }
        [StringLength(1)]
        public string? SuspenseInvoiceType { get; set; }
        [StringLength(1)]
        public string? TaxInvRecNoGroupFlag { get; set; }
        /// <summary>
        /// Default Invoice Type for Transport Invoice Type when Job Type is TP
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? TransportInvoiceType { get; set; }
        /// <summary>
        /// To print on Transport Invoice
        /// </summary>
        [StringLength(5)]
        public string? TransportPrefix { get; set; }
        /// <summary>
        /// Set as DUTA for one particular customer to print Bar Code
        /// </summary>
        [StringLength(255)]
        public string? UpdateBarCodeValue { get; set; }
        /// <summary>
        /// If set as N, then it will not update the ivcr1.totalExmAmt/TotalStdAmt/TotalZeroAmt when enter or edit the ivcr2.
        /// </summary>
        [StringLength(1)]
        public string? UpdateVatBaseAmtFlag { get; set; }
        [StringLength(1)]
        public string? UpdateVatCodeFlag { get; set; }
        /// <summary>
        /// Default Invoice Type for Warehouse Invoice Type when Job Type is WH
        /// 1-Invoice Type01, 2-Invoice Type 02………0-Invoice Type 10
        /// </summary>
        [StringLength(1)]
        public string? WarehouseInvoiceType { get; set; }
        /// <summary>
        /// To print on Warehouse Invoice
        /// </summary>
        [StringLength(5)]
        public string? WareHousePrefix { get; set; }
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
