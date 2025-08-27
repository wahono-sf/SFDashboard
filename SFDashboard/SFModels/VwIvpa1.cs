using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Air Export Invoice Type")]
        [StringLength(1)]
        public string? AirExportInvoiceType { get; set; }
        [Column("Air Export Prefix")]
        [StringLength(5)]
        public string? AirExportPrefix { get; set; }
        [Column("Air Import Invoice Type")]
        [StringLength(1)]
        public string? AirImportInvoiceType { get; set; }
        [Column("Air Import Prefix")]
        [StringLength(5)]
        public string? AirImportPrefix { get; set; }
        [Column("Auto Post Flag")]
        [StringLength(1)]
        public string? AutoPostFlag { get; set; }
        [Column("BB Fee Item Code")]
        [StringLength(30)]
        public string? BbFeeItemCode { get; set; }
        [Column("Block Inv Template Flag")]
        [StringLength(1)]
        public string? BlockInvTemplateFlag { get; set; }
        [Column("Cash Note Flag")]
        [StringLength(1)]
        public string? CashNoteFlag { get; set; }
        [Column("Cash Receipt Flag")]
        [StringLength(1)]
        public string? CashReceiptFlag { get; set; }
        [Column("Cash Term Code")]
        [StringLength(3)]
        public string? CashTermCode { get; set; }
        [Column("CFS Receipt Flag")]
        [StringLength(1)]
        public string? CfsReceiptFlag { get; set; }
        [Column("Change Type New No Flag")]
        [StringLength(1)]
        public string? ChangeTypeNewNoFlag { get; set; }
        [Column("Consol Invoice Number Type")]
        [StringLength(10)]
        public string? ConsolInvoiceNumberType { get; set; }
        [Column("Consol Invoice Update Flag")]
        [StringLength(1)]
        public string? ConsolInvoiceUpdateFlag { get; set; }
        [Column("Control Invoice Date Flag")]
        [StringLength(1)]
        public string? ControlInvoiceDateFlag { get; set; }
        [Column("Convert Inv To Rcp Flag")]
        [StringLength(1)]
        public string? ConvertInvToRcpFlag { get; set; }
        [Column("Copy Close Job Flag")]
        [StringLength(1)]
        public string? CopyCloseJobFlag { get; set; }
        [Column("Credit Check Error Flag")]
        [StringLength(1)]
        public string? CreditCheckErrorFlag { get; set; }
        [Column("Credit Note Acc Code")]
        [StringLength(15)]
        public string? CreditNoteAccCode { get; set; }
        [Column("Credit Note Flag")]
        [StringLength(1)]
        public string? CreditNoteFlag { get; set; }
        [Column("Curr Rate Flag")]
        [StringLength(1)]
        public string? CurrRateFlag { get; set; }
        [Column("Debit Note Flag")]
        [StringLength(1)]
        public string? DebitNoteFlag { get; set; }
        [Column("Default Invoice Date Flag")]
        [StringLength(1)]
        public string? DefaultInvoiceDateFlag { get; set; }
        [Column("Default Invoice Type")]
        [StringLength(1)]
        public string? DefaultInvoiceType { get; set; }
        [Column("Default Name")]
        [StringLength(20)]
        public string? DefaultName { get; set; }
        [Column("Delete Inv Right")]
        [StringLength(1)]
        public string? DeleteInvRight { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("Do No Flag")]
        [StringLength(1)]
        public string? DoNoFlag { get; set; }
        [Column("Dummy Invoice Cost Flag")]
        [StringLength(1)]
        public string? DummyInvoiceCostFlag { get; set; }
        [Column("Edit Costing Button")]
        [StringLength(10)]
        public string? EditCostingButton { get; set; }
        [Column("Empty Invoice No Flag")]
        [StringLength(1)]
        public string? EmptyInvoiceNoFlag { get; set; }
        [Column("Fix Cash Trx Type")]
        [StringLength(1)]
        public string? FixCashTrxType { get; set; }
        [Column("Goods Description Flag")]
        [StringLength(1)]
        public string? GoodsDescriptionFlag { get; set; }
        [Column("Group Flag")]
        [StringLength(1)]
        public string? GroupFlag { get; set; }
        [Column("Group Invoice Type 01")]
        [StringLength(1)]
        public string? GroupInvoiceType01 { get; set; }
        [Column("Group Invoice Type 02")]
        [StringLength(1)]
        public string? GroupInvoiceType02 { get; set; }
        [Column("Group Invoice Type 03")]
        [StringLength(1)]
        public string? GroupInvoiceType03 { get; set; }
        [Column("Group Invoice Type 04")]
        [StringLength(1)]
        public string? GroupInvoiceType04 { get; set; }
        [Column("Group Invoice Type 05")]
        [StringLength(1)]
        public string? GroupInvoiceType05 { get; set; }
        [Column("Group Invoice Type 06")]
        [StringLength(1)]
        public string? GroupInvoiceType06 { get; set; }
        [Column("Group Invoice Type 07")]
        [StringLength(1)]
        public string? GroupInvoiceType07 { get; set; }
        [Column("Group Invoice Type 08")]
        [StringLength(1)]
        public string? GroupInvoiceType08 { get; set; }
        [Column("Group Invoice Type 09")]
        [StringLength(1)]
        public string? GroupInvoiceType09 { get; set; }
        [Column("Group Invoice Type 10")]
        [StringLength(1)]
        public string? GroupInvoiceType10 { get; set; }
        [Column("Group Invoice Type 11")]
        [StringLength(1)]
        public string? GroupInvoiceType11 { get; set; }
        [Column("Group Invoice Type 12")]
        [StringLength(1)]
        public string? GroupInvoiceType12 { get; set; }
        [Column("Group Invoice Type 13")]
        [StringLength(1)]
        public string? GroupInvoiceType13 { get; set; }
        [Column("Group Invoice Type 14")]
        [StringLength(1)]
        public string? GroupInvoiceType14 { get; set; }
        [Column("Group Invoice Type 15")]
        [StringLength(1)]
        public string? GroupInvoiceType15 { get; set; }
        [Column("Hide Chg Trx Flag")]
        [StringLength(1)]
        public string? HideChgTrxFlag { get; set; }
        [Column("Hide Operation Unpost Flag")]
        [StringLength(1)]
        public string? HideOperationUnpostFlag { get; set; }
        [Column("Hide Sales Cost Flag")]
        [StringLength(1)]
        public string? HideSalesCostFlag { get; set; }
        [Column("History Original Curr Rate Flag")]
        [StringLength(1)]
        public string? HistoryOriginalCurrRateFlag { get; set; }
        [Column("Invoice Flag")]
        [StringLength(1)]
        public string? InvoiceFlag { get; set; }
        [Column("Invoice Format")]
        [StringLength(255)]
        public string? InvoiceFormat { get; set; }
        [Column("Invoice Format Type")]
        [StringLength(1)]
        public string? InvoiceFormatType { get; set; }
        [Column("Invoice No Auto Or Manual")]
        [StringLength(1)]
        public string? InvoiceNoAutoOrManual { get; set; }
        [Column("Invoice Seq Length")]
        public int? InvoiceSeqLength { get; set; }
        [Column("Invoice Type 01")]
        [StringLength(1)]
        public string? InvoiceType01 { get; set; }
        [Column("Invoice Type 02")]
        [StringLength(1)]
        public string? InvoiceType02 { get; set; }
        [Column("Invoice Type 03")]
        [StringLength(1)]
        public string? InvoiceType03 { get; set; }
        [Column("Invoice Type 04")]
        [StringLength(1)]
        public string? InvoiceType04 { get; set; }
        [Column("Invoice Type 05")]
        [StringLength(1)]
        public string? InvoiceType05 { get; set; }
        [Column("Invoice Type 06")]
        [StringLength(1)]
        public string? InvoiceType06 { get; set; }
        [Column("Invoice Type 07")]
        [StringLength(1)]
        public string? InvoiceType07 { get; set; }
        [Column("Invoice Type 08")]
        [StringLength(1)]
        public string? InvoiceType08 { get; set; }
        [Column("Invoice Type 09")]
        [StringLength(1)]
        public string? InvoiceType09 { get; set; }
        [Column("Invoice Type 10")]
        [StringLength(1)]
        public string? InvoiceType10 { get; set; }
        [Column("Inv Seq No By Job Flag")]
        [StringLength(1)]
        public string? InvSeqNoByJobFlag { get; set; }
        [Column("Iv Type Curr Control Flag")]
        [StringLength(1)]
        public string? IvTypeCurrControlFlag { get; set; }
        [Column("Job Costing Markup Flag")]
        [StringLength(1)]
        public string? JobCostingMarkupFlag { get; set; }
        [Column("Job No First Column Flag")]
        [StringLength(1)]
        public string? JobNoFirstColumnFlag { get; set; }
        [Column("Keep Op Invoice Flag")]
        [StringLength(1)]
        public string? KeepOpInvoiceFlag { get; set; }
        [Column("Lock Address Flag")]
        [StringLength(1)]
        public string? LockAddressFlag { get; set; }
        [Column("Lock Approved Invoice Flag")]
        [StringLength(1)]
        public string? LockApprovedInvoiceFlag { get; set; }
        [Column("Lock Close Job Flag")]
        [StringLength(1)]
        public string? LockCloseJobFlag { get; set; }
        [Column("Lock Curr Flag")]
        [StringLength(1)]
        public string? LockCurrFlag { get; set; }
        [Column("Lock Curr Rate Flag")]
        [StringLength(1)]
        public string? LockCurrRateFlag { get; set; }
        [Column("Lock Customer Flag")]
        [StringLength(1)]
        public string? LockCustomerFlag { get; set; }
        [Column("Lock Customer Name Flag")]
        [StringLength(1)]
        public string? LockCustomerNameFlag { get; set; }
        [Column("Lock Description Flag")]
        [StringLength(1)]
        public string? LockDescriptionFlag { get; set; }
        [Column("Lock Invoice Date Flag")]
        [StringLength(1)]
        public string? LockInvoiceDateFlag { get; set; }
        [Column("Lock Invoice Day")]
        public int? LockInvoiceDay { get; set; }
        [Column("Lock Invoice Flag")]
        [StringLength(1)]
        public string? LockInvoiceFlag { get; set; }
        [Column("Lock Item Screen Flag")]
        [StringLength(1)]
        public string? LockItemScreenFlag { get; set; }
        [Column("Lock Post Date Flag")]
        [StringLength(1)]
        public string? LockPostDateFlag { get; set; }
        [Column("Lock Print Invoice Flag")]
        [StringLength(1)]
        public string? LockPrintInvoiceFlag { get; set; }
        [Column("Lock Shipment Info Flag")]
        [StringLength(1)]
        public string? LockShipmentInfoFlag { get; set; }
        [Column("Lock Term Flag")]
        [StringLength(1)]
        public string? LockTermFlag { get; set; }
        [Column("Lock Job No Flag")]
        [StringLength(1)]
        public string? LockJobNoFlag { get; set; }
        [Column("Min Uom Code")]
        [StringLength(50)]
        public string? MinUomCode { get; set; }
        [Column("Miscellaneous Invoice Type")]
        [StringLength(1)]
        public string? MiscellaneousInvoiceType { get; set; }
        [Column("Miscellaneous Prefix")]
        [StringLength(5)]
        public string? MiscellaneousPrefix { get; set; }
        [Column("Negative Invoice Flag")]
        [StringLength(1)]
        public string? NegativeInvoiceFlag { get; set; }
        [Column("Next Batch No")]
        [StringLength(10)]
        public string? NextBatchNo { get; set; }
        [Column("Next Cash Invoice No 01")]
        [StringLength(10)]
        public string? NextCashInvoiceNo01 { get; set; }
        [Column("Next Cash Invoice No 02")]
        [StringLength(10)]
        public string? NextCashInvoiceNo02 { get; set; }
        [Column("Next Cash Invoice No 03")]
        [StringLength(10)]
        public string? NextCashInvoiceNo03 { get; set; }
        [Column("Next Cash Invoice No 04")]
        [StringLength(10)]
        public string? NextCashInvoiceNo04 { get; set; }
        [Column("Next Cash Invoice No 05")]
        [StringLength(10)]
        public string? NextCashInvoiceNo05 { get; set; }
        [Column("Next Cash Invoice No 06")]
        [StringLength(10)]
        public string? NextCashInvoiceNo06 { get; set; }
        [Column("Next Cash Invoice No 07")]
        [StringLength(10)]
        public string? NextCashInvoiceNo07 { get; set; }
        [Column("Next Cash Invoice No 08")]
        [StringLength(10)]
        public string? NextCashInvoiceNo08 { get; set; }
        [Column("Next Cash Invoice No 09")]
        [StringLength(10)]
        public string? NextCashInvoiceNo09 { get; set; }
        [Column("Next Cash Invoice No 10")]
        [StringLength(10)]
        public string? NextCashInvoiceNo10 { get; set; }
        [Column("Next Cash Receipt No 01")]
        [StringLength(10)]
        public string? NextCashReceiptNo01 { get; set; }
        [Column("Next Cash Receipt No 02")]
        [StringLength(10)]
        public string? NextCashReceiptNo02 { get; set; }
        [Column("Next Cash Receipt No 03")]
        [StringLength(10)]
        public string? NextCashReceiptNo03 { get; set; }
        [Column("Next Cash Receipt No 04")]
        [StringLength(10)]
        public string? NextCashReceiptNo04 { get; set; }
        [Column("Next Cash Receipt No 05")]
        [StringLength(10)]
        public string? NextCashReceiptNo05 { get; set; }
        [Column("Next Cash Receipt No 06")]
        [StringLength(10)]
        public string? NextCashReceiptNo06 { get; set; }
        [Column("Next Cash Receipt No 07")]
        [StringLength(10)]
        public string? NextCashReceiptNo07 { get; set; }
        [Column("Next Cash Receipt No 08")]
        [StringLength(10)]
        public string? NextCashReceiptNo08 { get; set; }
        [Column("Next Cash Receipt No 09")]
        [StringLength(10)]
        public string? NextCashReceiptNo09 { get; set; }
        [Column("Next Cash Receipt No 10")]
        [StringLength(10)]
        public string? NextCashReceiptNo10 { get; set; }
        [Column("Next Credit Note No 01")]
        [StringLength(10)]
        public string? NextCreditNoteNo01 { get; set; }
        [Column("Next Credit Note No 02")]
        [StringLength(10)]
        public string? NextCreditNoteNo02 { get; set; }
        [Column("Next Credit Note No 03")]
        [StringLength(10)]
        public string? NextCreditNoteNo03 { get; set; }
        [Column("Next Credit Note No 04")]
        [StringLength(10)]
        public string? NextCreditNoteNo04 { get; set; }
        [Column("Next Credit Note No 05")]
        [StringLength(10)]
        public string? NextCreditNoteNo05 { get; set; }
        [Column("Next Credit Note No 06")]
        [StringLength(10)]
        public string? NextCreditNoteNo06 { get; set; }
        [Column("Next Credit Note No 07")]
        [StringLength(10)]
        public string? NextCreditNoteNo07 { get; set; }
        [Column("Next Credit Note No 08")]
        [StringLength(10)]
        public string? NextCreditNoteNo08 { get; set; }
        [Column("Next Credit Note No 09")]
        [StringLength(10)]
        public string? NextCreditNoteNo09 { get; set; }
        [Column("Next Credit Note No 10")]
        [StringLength(10)]
        public string? NextCreditNoteNo10 { get; set; }
        [Column("Next Debit Note No 01")]
        [StringLength(10)]
        public string? NextDebitNoteNo01 { get; set; }
        [Column("Next Debit Note No 02")]
        [StringLength(10)]
        public string? NextDebitNoteNo02 { get; set; }
        [Column("Next Debit Note No 03")]
        [StringLength(10)]
        public string? NextDebitNoteNo03 { get; set; }
        [Column("Next Debit Note No 04")]
        [StringLength(10)]
        public string? NextDebitNoteNo04 { get; set; }
        [Column("Next Debit Note No 05")]
        [StringLength(10)]
        public string? NextDebitNoteNo05 { get; set; }
        [Column("Next Debit Note No 06")]
        [StringLength(10)]
        public string? NextDebitNoteNo06 { get; set; }
        [Column("Next Debit Note No 07")]
        [StringLength(10)]
        public string? NextDebitNoteNo07 { get; set; }
        [Column("Next Debit Note No 08")]
        [StringLength(10)]
        public string? NextDebitNoteNo08 { get; set; }
        [Column("Next Debit Note No 09")]
        [StringLength(10)]
        public string? NextDebitNoteNo09 { get; set; }
        [Column("Next Debit Note No 10")]
        [StringLength(10)]
        public string? NextDebitNoteNo10 { get; set; }
        [Column("Next Invoice No 01")]
        [StringLength(10)]
        public string? NextInvoiceNo01 { get; set; }
        [Column("Next Invoice No 02")]
        [StringLength(10)]
        public string? NextInvoiceNo02 { get; set; }
        [Column("Next Invoice No 03")]
        [StringLength(10)]
        public string? NextInvoiceNo03 { get; set; }
        [Column("Next Invoice No 04")]
        [StringLength(10)]
        public string? NextInvoiceNo04 { get; set; }
        [Column("Next Invoice No 05")]
        [StringLength(10)]
        public string? NextInvoiceNo05 { get; set; }
        [Column("Next Invoice No 06")]
        [StringLength(10)]
        public string? NextInvoiceNo06 { get; set; }
        [Column("Next Invoice No 07")]
        [StringLength(10)]
        public string? NextInvoiceNo07 { get; set; }
        [Column("Next Invoice No 08")]
        [StringLength(10)]
        public string? NextInvoiceNo08 { get; set; }
        [Column("Next Invoice No 09")]
        [StringLength(10)]
        public string? NextInvoiceNo09 { get; set; }
        [Column("Next Invoice No 10")]
        [StringLength(10)]
        public string? NextInvoiceNo10 { get; set; }
        [Column("Ng Sign On Credit Note")]
        [StringLength(1)]
        public string? NgSignOnCreditNote { get; set; }
        [Column("No Of Days Back Date Invoice")]
        public int? NoOfDaysBackDateInvoice { get; set; }
        [Column("On Save Generate Inv No")]
        [StringLength(1)]
        public string? OnSaveGenerateInvNo { get; set; }
        [Column("Operation Flag")]
        [StringLength(1)]
        public string? OperationFlag { get; set; }
        [Column("Other Invoice Prefix 01")]
        [StringLength(5)]
        public string? OtherInvoicePrefix01 { get; set; }
        [Column("Other Invoice Prefix 02")]
        [StringLength(5)]
        public string? OtherInvoicePrefix02 { get; set; }
        [Column("Other Invoice Prefix 03")]
        [StringLength(5)]
        public string? OtherInvoicePrefix03 { get; set; }
        [Column("Other Invoice Prefix 04")]
        [StringLength(5)]
        public string? OtherInvoicePrefix04 { get; set; }
        [Column("Other Invoice Prefix 05")]
        [StringLength(5)]
        public string? OtherInvoicePrefix05 { get; set; }
        [Column("Other Invoice Prefix 06")]
        [StringLength(5)]
        public string? OtherInvoicePrefix06 { get; set; }
        [Column("Other Invoice Prefix 07")]
        [StringLength(5)]
        public string? OtherInvoicePrefix07 { get; set; }
        [Column("Other Invoice Prefix 08")]
        [StringLength(5)]
        public string? OtherInvoicePrefix08 { get; set; }
        [Column("Other Invoice Prefix 09")]
        [StringLength(5)]
        public string? OtherInvoicePrefix09 { get; set; }
        [Column("Other Invoice Prefix 10")]
        [StringLength(5)]
        public string? OtherInvoicePrefix10 { get; set; }
        [Column("Other Invoice Type 01")]
        [StringLength(20)]
        public string? OtherInvoiceType01 { get; set; }
        [Column("Other Invoice Type 02")]
        [StringLength(20)]
        public string? OtherInvoiceType02 { get; set; }
        [Column("Other Invoice Type 03")]
        [StringLength(20)]
        public string? OtherInvoiceType03 { get; set; }
        [Column("Other Invoice Type 04")]
        [StringLength(20)]
        public string? OtherInvoiceType04 { get; set; }
        [Column("Other Invoice Type 05")]
        [StringLength(20)]
        public string? OtherInvoiceType05 { get; set; }
        [Column("Other Invoice Type 06")]
        [StringLength(20)]
        public string? OtherInvoiceType06 { get; set; }
        [Column("Other Invoice Type 07")]
        [StringLength(20)]
        public string? OtherInvoiceType07 { get; set; }
        [Column("Other Invoice Type 08")]
        [StringLength(20)]
        public string? OtherInvoiceType08 { get; set; }
        [Column("Other Invoice Type 09")]
        [StringLength(20)]
        public string? OtherInvoiceType09 { get; set; }
        [Column("Other Invoice Type 10")]
        [StringLength(20)]
        public string? OtherInvoiceType10 { get; set; }
        [Column("Other Job Type 01")]
        [StringLength(10)]
        public string? OtherJobType01 { get; set; }
        [Column("Other Job Type 02")]
        [StringLength(10)]
        public string? OtherJobType02 { get; set; }
        [Column("Other Job Type 03")]
        [StringLength(10)]
        public string? OtherJobType03 { get; set; }
        [Column("Other Job Type 04")]
        [StringLength(10)]
        public string? OtherJobType04 { get; set; }
        [Column("Other Job Type 05")]
        [StringLength(10)]
        public string? OtherJobType05 { get; set; }
        [Column("Other Job Type 06")]
        [StringLength(10)]
        public string? OtherJobType06 { get; set; }
        [Column("Other Job Type 07")]
        [StringLength(10)]
        public string? OtherJobType07 { get; set; }
        [Column("Other Job Type 08")]
        [StringLength(10)]
        public string? OtherJobType08 { get; set; }
        [Column("Other Job Type 09")]
        [StringLength(10)]
        public string? OtherJobType09 { get; set; }
        [Column("Other Job Type 10")]
        [StringLength(10)]
        public string? OtherJobType10 { get; set; }
        [Column("Outlay Vat Item Code")]
        [StringLength(30)]
        public string? OutlayVatItemCode { get; set; }
        [Column("Post By Airline Flag")]
        [StringLength(1)]
        public string? PostByAirlineFlag { get; set; }
        [Column("Post Online Or Batch")]
        [StringLength(1)]
        public string? PostOnlineOrBatch { get; set; }
        [Column("Post Sales Ledger Flag")]
        [StringLength(1)]
        public string? PostSalesLedgerFlag { get; set; }
        [Column("Print Credit Note Sign Flag")]
        [StringLength(1)]
        public string? PrintCreditNoteSignFlag { get; set; }
        [Column("Print Upd Inv Date Flag")]
        [StringLength(1)]
        public string? PrintUpdInvDateFlag { get; set; }
        [Column("Prompt Credit Check Flag")]
        [StringLength(1)]
        public string? PromptCreditCheckFlag { get; set; }
        [Column("Prompt Duplicate Doc Flag")]
        [StringLength(1)]
        public string? PromptDuplicateDocFlag { get; set; }
        [Column("Reversal Flag")]
        [StringLength(1)]
        public string? ReversalFlag { get; set; }
        [Column("Reverse Post Online Or Batch")]
        [StringLength(1)]
        public string? ReversePostOnlineOrBatch { get; set; }
        [Column("Rounding Vat Amt Flag")]
        [StringLength(1)]
        public string? RoundingVatAmtFlag { get; set; }
        [Column("Sales Adjust Flag")]
        [StringLength(1)]
        public string? SalesAdjustFlag { get; set; }
        [Column("Sales By Customer Type Flag")]
        [StringLength(1)]
        public string? SalesByCustomerTypeFlag { get; set; }
        [Column("Sea Export Invoice Type")]
        [StringLength(1)]
        public string? SeaExportInvoiceType { get; set; }
        [Column("Sea Export Prefix")]
        [StringLength(5)]
        public string? SeaExportPrefix { get; set; }
        [Column("Sea Import Invoice Type")]
        [StringLength(1)]
        public string? SeaImportInvoiceType { get; set; }
        [Column("Sea Import Prefix")]
        [StringLength(5)]
        public string? SeaImportPrefix { get; set; }
        [Column("Show Charge Type Flag")]
        [StringLength(1)]
        public string? ShowChargeTypeFlag { get; set; }
        [Column("Show Misc Flag")]
        [StringLength(1)]
        public string? ShowMiscFlag { get; set; }
        [Column("Show Operation Post Flag")]
        [StringLength(1)]
        public string? ShowOperationPostFlag { get; set; }
        [Column("Show Original Curr Rate Flag")]
        [StringLength(1)]
        public string? ShowOriginalCurrRateFlag { get; set; }
        [Column("Show Vat Amt Flag")]
        [StringLength(1)]
        public string? ShowVatAmtFlag { get; set; }
        [Column("Suspense Invoice Charge Code")]
        [StringLength(30)]
        public string? SuspenseInvoiceChargeCode { get; set; }
        [Column("Suspense Invoice Type")]
        [StringLength(1)]
        public string? SuspenseInvoiceType { get; set; }
        [Column("Tax Inv Rec No Group Flag")]
        [StringLength(1)]
        public string? TaxInvRecNoGroupFlag { get; set; }
        [Column("Transport Invoice Type")]
        [StringLength(1)]
        public string? TransportInvoiceType { get; set; }
        [Column("Transport Prefix")]
        [StringLength(5)]
        public string? TransportPrefix { get; set; }
        [Column("Update Bar Code Value")]
        [StringLength(255)]
        public string? UpdateBarCodeValue { get; set; }
        [Column("Update Vat Base Amt Flag")]
        [StringLength(1)]
        public string? UpdateVatBaseAmtFlag { get; set; }
        [Column("Update Vat Code Flag")]
        [StringLength(1)]
        public string? UpdateVatCodeFlag { get; set; }
        [Column("Warehouse Invoice Type")]
        [StringLength(1)]
        public string? WarehouseInvoiceType { get; set; }
        [Column("Warehouse Prefix")]
        [StringLength(5)]
        public string? WarehousePrefix { get; set; }
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
