using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Accrue Billed Item Flag")]
        [StringLength(1)]
        public string? AccrueBilledItemFlag { get; set; }
        [Column("Adjust Prefix")]
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        [Column("Approve Costing Post Flag")]
        [StringLength(1)]
        public string? ApproveCostingPostFlag { get; set; }
        [Column("Approve Job Costing Access Right")]
        [StringLength(1)]
        public string? ApproveJobCostingAccessRight { get; set; }
        [Column("Approve Job Costing Invoice Flag")]
        [StringLength(1)]
        public string? ApproveJobCostingInvoiceFlag { get; set; }
        [Column("Auto Generate Provision Flag")]
        [StringLength(1)]
        public string? AutoGenerateProvisionFlag { get; set; }
        [Column("Check Job Costing Close Job Flag")]
        [StringLength(1)]
        public string? CheckJobCostingCloseJobFlag { get; set; }
        [Column("Check Job Mth Flag")]
        [StringLength(6)]
        public string? CheckJobMthFlag { get; set; }
        [Column("Clearing Cost Acc Code")]
        [StringLength(15)]
        public string? ClearingCostAccCode { get; set; }
        [Column("Clearing Sales Acc Code")]
        [StringLength(15)]
        public string? ClearingSalesAccCode { get; set; }
        [Column("Close Job Post Flag")]
        [StringLength(1)]
        public string? CloseJobPostFlag { get; set; }
        [Column("Control Job Costing Flag")]
        [StringLength(1)]
        public string? ControlJobCostingFlag { get; set; }
        [Column("Copy Job Customer Code Flag")]
        [StringLength(1)]
        public string? CopyJobCustomerCodeFlag { get; set; }
        [Column("Cost Table By Customer Flag")]
        [StringLength(1)]
        public string? CostTableByCustomerFlag { get; set; }
        [Column("Create Job Flag")]
        [StringLength(1)]
        public string? CreateJobFlag { get; set; }
        [Column("Default Cost Vat Flag")]
        [StringLength(1)]
        public string? DefaultCostVatFlag { get; set; }
        [Column("Default Customer Code Flag")]
        [StringLength(1)]
        public string? DefaultCustomerCodeFlag { get; set; }
        [Column("Default Document")]
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
        [Column("Filter Job Costing Customer Vendor Flag")]
        [StringLength(1)]
        public string? FilterJobCostingCustomerVendorFlag { get; set; }
        [Column("Hide Cost Back Flag")]
        [StringLength(1)]
        public string? HideCostBackFlag { get; set; }
        [Column("Hide Cost Flag")]
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        [Column("Hide Edit Job Costing Flag")]
        [StringLength(1)]
        public string? HideEditJobCostingFlag { get; set; }
        [Column("Hide Internal Costing Column Flag")]
        [StringLength(1)]
        public string? HideInternalCostingColumnFlag { get; set; }
        [Column("Hide Internal Costing Flag")]
        [StringLength(1)]
        public string? HideInternalCostingFlag { get; set; }
        [Column("Hide Job Costing Column Flag")]
        [StringLength(1)]
        public string? HideJobCostingColumnFlag { get; set; }
        [Column("Hide Job Costing Customer Vendor Flag")]
        [StringLength(1)]
        public string? HideJobCostingCustomerVendorFlag { get; set; }
        [Column("Hide Job Costing Customer Vendor Name Flag")]
        [StringLength(1)]
        public string? HideJobCostingCustomerVendorNameFlag { get; set; }
        [Column("Hide Job Costing Flag")]
        [StringLength(1)]
        public string? HideJobCostingFlag { get; set; }
        [Column("Implement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ImplementDate { get; set; }
        [Column("Job Closing Access Right")]
        [StringLength(1)]
        public string? JobClosingAccessRight { get; set; }
        [Column("Job Costing Margin Flag")]
        [StringLength(1)]
        public string? JobCostingMarginFlag { get; set; }
        [Column("Job Costing Vendor Flag")]
        [StringLength(1)]
        public string? JobCostingVendorFlag { get; set; }
        [Column("Job Date Flag")]
        [StringLength(1)]
        public string? JobDateFlag { get; set; }
        [Column("Job Item Trx No Prov Flag")]
        [StringLength(1)]
        public string? JobItemTrxNoProvFlag { get; set; }
        [Column("Job No By Shipment Flag")]
        [StringLength(1)]
        public string? JobNoByShipmentFlag { get; set; }
        [Column("Job Seq Length")]
        public byte? JobSeqLength { get; set; }
        [Column("Last Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastPostDate { get; set; }
        [Column("Lock Billed Job Costing Flag")]
        [StringLength(1)]
        public string? LockBilledJobCostingFlag { get; set; }
        [Column("Lock Closed Job Flag")]
        [StringLength(1)]
        public string? LockClosedJobFlag { get; set; }
        [Column("Lock Document Access Right")]
        [StringLength(1)]
        public string? LockDocumentAccessRight { get; set; }
        [Column("Lock Iv Curr Rate Flag")]
        [StringLength(1)]
        public string? LockIvCurrRateFlag { get; set; }
        [Column("Lock Job Costing Tab")]
        [StringLength(1)]
        public string? LockJobCostingTab { get; set; }
        [Column("Lock Pl Curr Rate Flag")]
        [StringLength(1)]
        public string? LockPlCurrRateFlag { get; set; }
        [Column("Lock Salesman Flag")]
        [StringLength(1)]
        public string? LockSalesmanFlag { get; set; }
        [Column("Master Cost By Volume")]
        [StringLength(1)]
        public string? MasterCostByVolume { get; set; }
        [Column("Multi Modal Job Type")]
        [StringLength(10)]
        public string? MultiModalJobType { get; set; }
        [Column("Multiple Job Costing Match Flag")]
        [StringLength(1)]
        public string? MultipleJobCostingMatchFlag { get; set; }
        [Column("Next Journal No")]
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        [Column("PL Column")]
        [StringLength(10)]
        public string? PlColumn { get; set; }
        [Column("P&L Summary Credit Note Flag")]
        [StringLength(1)]
        public string? PLSummaryCreditNoteFlag { get; set; }
        [Column("Profit Loss Order")]
        [StringLength(3)]
        public string? ProfitLossOrder { get; set; }
        [Column("Provision Prefix")]
        [StringLength(5)]
        public string? ProvisionPrefix { get; set; }
        [Column("Reopen Job Right")]
        [StringLength(1)]
        public string? ReopenJobRight { get; set; }
        [Column("Show All Invoice Purchase Flag")]
        [StringLength(1)]
        public string? ShowAllInvoicePurchaseFlag { get; set; }
        [Column("Show Billing Flag")]
        [StringLength(1)]
        public string? ShowBillingFlag { get; set; }
        [Column("Show Job Costing Remark Flag")]
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        [Column("Show Original Job Flag")]
        [StringLength(1)]
        public string? ShowOriginalJobFlag { get; set; }
        [Column("Show Salesman Cost Flag")]
        [StringLength(1)]
        public string? ShowSalesmanCostFlag { get; set; }
        [Column("Split Job Costing Flag")]
        [StringLength(1)]
        public string? SplitJobCostingFlag { get; set; }
        [Column("Unlock Document Access Right")]
        [StringLength(1)]
        public string? UnlockDocumentAccessRight { get; set; }
        [Column("Unuse Field 1")]
        [StringLength(15)]
        public string? UnuseField1 { get; set; }
        [Column("Unuse Field 2")]
        [StringLength(15)]
        public string? UnuseField2 { get; set; }
        [Column("Update Customer Flag")]
        [StringLength(1)]
        public string? UpdateCustomerFlag { get; set; }
        [Column("Vendor Provision Cost Flag")]
        [StringLength(1)]
        public string? VendorProvisionCostFlag { get; set; }
        [Column("WIP Post Flag")]
        [StringLength(1)]
        public string? WipPostFlag { get; set; }
        [Column(" WIP Prepayment Acc Code")]
        [StringLength(15)]
        public string? WipPrepaymentAccCode { get; set; }
        [Column("WIP Provision Acc Code")]
        [StringLength(15)]
        public string? WipProvisionAccCode { get; set; }
        [Column("WIP Trade Creditor Acc Code")]
        [StringLength(15)]
        public string? WipTradeCreditorAccCode { get; set; }
        [Column("WIP Trade Debtor Acc Code")]
        [StringLength(15)]
        public string? WipTradeDebtorAccCode { get; set; }
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
