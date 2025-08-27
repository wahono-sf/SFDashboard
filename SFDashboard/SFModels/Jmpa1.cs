using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmpa1")]
    public partial class Jmpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Set as Y only the item has billing will provide the Cost Accrual
        /// </summary>
        [StringLength(1)]
        public string? AccrueBilledItemFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? AdjustPrefix { get; set; }
        [StringLength(1)]
        public string? ApproveCostingPostFlag { get; set; }
        /// <summary>
        /// If set as &apos;A&apos; or blank, then only access right =&apos;A&apos; can amend
        /// If set as &apos;S&apos;, then access right =&apos;A&apos; or &apos;S&apos; can amend
        /// If set as &apos;U&apos;, then all users can amend
        /// </summary>
        [StringLength(1)]
        public string? AppJobCostingAccessRight { get; set; }
        [StringLength(1)]
        public string? ApproveJobCostingInvoiceFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? AutoGenerateProvisionFlag { get; set; }
        [StringLength(1)]
        public string? CheckJobCostingCloseJobFlag { get; set; }
        [StringLength(6)]
        public string? CheckJobMthFlag { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? ClearingCostAccCode { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? ClearingSalesAccCode { get; set; }
        [StringLength(1)]
        public string? CloseJobPostFlag { get; set; }
        /// <summary>
        /// If set as Y, then it will lock the ivcr1/plvi2 grid. Also disable the button Charges/Quotation/Billing History/Warehouse Charges. When change ivcr1/Plvi1.JobNo, it should not prompt message and don&apos;t update job no to level2
        /// </summary>
        [StringLength(1)]
        public string? ControlJobCostingFlag { get; set; }
        [StringLength(1)]
        public string? CopyJobCustomerCodeFlag { get; set; }
        [StringLength(1)]
        public string? CostTableByCustFlag { get; set; }
        /// <summary>
        /// Set Y will allow user to create the Job from the entry form of the Ivcr1,Vendor Invoice and Cash Purchase
        /// </summary>
        [StringLength(1)]
        public string? CreateJobFlag { get; set; }
        [StringLength(1)]
        public string? DefaultCostVatFlag { get; set; }
        /// <summary>
        /// Set as Y,  it will auto default the customer code from the jmjm1 customer code if user try to remove the customer code under job costing screen.
        /// </summary>
        [StringLength(1)]
        public string? DefaultCustomerCodeFlag { get; set; }
        /// <summary>
        /// Default the Document List to display the Trx Type of Document e.g. IV for Invoice, CN for Credit Note, DN for Debite Note, CI for Cash Invoice, CR for Cash Receipt, 0 for Ivcr1_0, 1 for Ivcr1_1, 2 for Ivcr1_2, 3 for Ivcr1_3, 4 for Ivcr1_4, 5 for Ivcr1_5, 6 for Ivcr1_6, 7 for Ivcr1_7,  8 for Ivcr1_8, 9 for Ivcr1_9
        /// </summary>
        [StringLength(2)]
        public string? DefaultDocument { get; set; }
        [StringLength(1)]
        public string? FilterJobCostingCustomerVendorFlag { get; set; }
        /// <summary>
        /// Set as Y, hide Cost Back column under Quotation Costing screen and Job Costing screen.
        /// </summary>
        [StringLength(1)]
        public string? HideCostBackFlag { get; set; }
        /// <summary>
        /// Access Right to hide the Cost Column in Job Costing and select from Job Costing in the invoice entry
        /// </summary>
        [StringLength(1)]
        public string? HideCostFlag { get; set; }
        [StringLength(1)]
        public string? HideEditJobCostingFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will hide the Internal Costing button and Internal Costing tab on the Consol
        /// </summary>
        [StringLength(1)]
        public string? HideInternalCostingFlag { get; set; }
        [StringLength(1)]
        public string? HideInternalCostingColumnFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will hide the Job Costing button and Job Costing tab on the Consol
        /// </summary>
        [StringLength(1)]
        public string? HideJobCostingColumnFlag { get; set; }
        /// <summary>
        /// If set as C, then it will hide the Cust/Customer Name column in Job Costing / Internal Costing
        /// If set as V, then it will hide the Vendor/Vendor Name column in Job Costing / Internal Costing
        /// If set as Y, then it will hide the Cust/Customer Name/Vendor/Vendor Name column in Job Costing / Internal Costing
        /// </summary>
        [StringLength(1)]
        public string? HideJobCostingCustomerVendorFlag { get; set; }
        /// <summary>
        /// If set as Y, it will hide the Cust Name/Vendor Name column in Job Costing / Internal Costing
        /// </summary>
        [StringLength(1)]
        public string? HideJobCostingCustomerVendorNameFlag { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then it will hide the Job Costing button and Job Costing tab on the Consol
        /// </summary>
        [StringLength(1)]
        public string? HideJobCostingFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ImplementDate { get; set; }
        /// <summary>
        /// Set access right for close job under Event Log tab. A - Only Access Right = A can close; S - Access Right = A&amp;S can close; U - Access Right = U&amp;S&amp;A can close.
        /// </summary>
        [StringLength(1)]
        public string? JobClosingAccessRight { get; set; }
        [StringLength(1)]
        public string? JobCostingMarginFlag { get; set; }
        [StringLength(1)]
        public string? JobCostingVendorFlag { get; set; }
        /// <summary>
        /// if set as &apos;Y&apos; then allow user to change the JobDate in Sebl1, Sibl1, Aeaw1, Aiaw1, Tobk1
        /// </summary>
        [StringLength(1)]
        public string? JobDateFlag { get; set; }
        /// <summary>
        /// Set as Y, for Job Provision Generation, use Jmjm2.TrxNo not in pl_All_Purchase_2.[Job Item Trx No] /iv_All_Invoice_2.[Job Item Trx No]
        ///  to generate provision
        /// </summary>
        [StringLength(1)]
        public string? JobItemTrxNoProvFlag { get; set; }
        /// <summary>
        /// Set
        /// </summary>
        [StringLength(1)]
        public string? JobNoByShipmentFlag { get; set; }
        /// <summary>
        /// Sepecify the Job Running No.
        /// </summary>
        public byte? JobSeqLength { get; set; }
        /// <summary>
        /// Define the Last Post Date
        /// 1. If PostDate&lt;Last Post Date then prompt &apos; You have done the posting for this date. You cannot back date the posting&apos;. 
        /// 2. If the Post Date &gt;= LastPostDate, then proceed the posting.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastPostDate { get; set; }
        [StringLength(1)]
        public string? LockBilledJobCostingFlag { get; set; }
        /// <summary>
        /// If set as Y, in Ivcr1 and Plvi1 F4 seach Job should filter the status =CLS
        /// </summary>
        [StringLength(1)]
        public string? LockClosedJobFlag { get; set; }
        [StringLength(1)]
        public string? LockDocumentAccessRight { get; set; }
        [StringLength(1)]
        public string? LockIvCurrRateFlag { get; set; }
        [StringLength(1)]
        public string? LockJobCostingTab { get; set; }
        [StringLength(1)]
        public string? LockPlCurrRateFlag { get; set; }
        /// <summary>
        /// If set as Y, Access Right = &apos;U&apos;, will lock the Salesman Code in BL and jmjm1
        /// </summary>
        [StringLength(1)]
        public string? LockSalesmanFlag { get; set; }
        /// <summary>
        /// Set as Y, Under Job Costing click Master Cost button, it will use the Volume in jmjm1 to split cost from master to house. It is only for the Module Code =SE and SI.
        /// 
        /// </summary>
        [StringLength(1)]
        public string? MasterCostByVol { get; set; }
        [StringLength(10)]
        public string? MultiModalJobType { get; set; }
        [StringLength(1)]
        public string? MultipleJobCostingMatchFlag { get; set; }
        /// <summary>
        /// Next Journal No. for the Job Provision Posting
        /// </summary>
        [StringLength(7)]
        public string? NextJournalNo { get; set; }
        [StringLength(10)]
        public string? PlColumn { get; set; }
        /// <summary>
        /// If set as Y,  the &quot;Credit Note To Vendor&quot; and &quot;Credit Note To Customer&quot; under P&amp;L Summary screen should exchange. The &quot;Grand Total&quot; compute should also change.(TrxType=3)
        /// </summary>
        [Column("PLSummaryCrNoteFlag")]
        [StringLength(1)]
        public string? PlsummaryCrNoteFlag { get; set; }
        /// <summary>
        /// Set the sub tab order under Profit &amp; Loss tab. CDS - show Comparision, Details then Summary tab; blank or SDC - show Summary, Details then Comparision
        /// </summary>
        [StringLength(3)]
        public string? ProfitLossOrder { get; set; }
        /// <summary>
        /// Define the Ref No Prefix for Provision Posting in glyl1
        /// </summary>
        [StringLength(5)]
        public string? ProvisionPrefix { get; set; }
        /// <summary>
        /// Set access right for Re-open Job button under Event Log tab. O - the access right =&apos;U&apos;, then the User = the laste update by where statuscode=&apos;CLS&apos; also can re-open the Job. A - Only access right = A can click re-open job buttom.
        /// </summary>
        [StringLength(1)]
        public string? ReopenJobRight { get; set; }
        /// <summary>
        /// If set as &apos;Y&apos;, then show the &apos;All Invoice&apos; and &apos;All Payment&apos; tab under the Document List. Those 2 tabs show all the ivcr1 and plvi1 where TrxType in (&apos;1&apos;,&apos;2&apos;,&apos;3&apos;,3&apos;,&apos;4&apos;,&apos;5&apos;)
        /// </summary>
        [StringLength(1)]
        public string? ShowAllInvoicePurchaseFlag { get; set; }
        /// <summary>
        /// If set as Y, then show on the Document List and only supervisor and above can tick the Billing Flag
        /// </summary>
        [StringLength(1)]
        public string? ShowBillingFlag { get; set; }
        /// <summary>
        /// Set as Y, Show Job Costing Remark as a column instead of picture icon under Job Costing screen.
        /// </summary>
        [StringLength(1)]
        public string? ShowJobCostingRemarkFlag { get; set; }
        [StringLength(1)]
        public string? ShowOriginalJobFlag { get; set; }
        /// <summary>
        /// Set as Y, Show Salesman Cost column and Salesman Cost button under Job Costing screen. Blank or N - hide them.
        /// </summary>
        [StringLength(1)]
        public string? ShowSalesmanCostFlag { get; set; }
        [StringLength(1)]
        public string? SplitJobCostingFlag { get; set; }
        [StringLength(1)]
        public string? UnlockDocumentAccessRight { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(15)]
        public string? UnuseField1 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(15)]
        public string? UnuseField2 { get; set; }
        /// <summary>
        /// If set as Y, when insert the record to jmjm2, will update the Customer Code and Customer Name in Correspondence to jmjm2
        /// </summary>
        [StringLength(1)]
        public string? UpdateCustomerFlag { get; set; }
        [StringLength(1)]
        public string? VendorProvCostFlag { get; set; }
        /// <summary>
        /// Set as Y, click WIP Post button under Daily Posting it will call the store procedure spi_Jm_Wip_Close
        /// </summary>
        [StringLength(1)]
        public string? WipPostFlag { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? WipPrepaymentAccCode { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? WipProvisionAccCode { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? WipTradeCreditorAccCode { get; set; }
        /// <summary>
        /// Set Acc Code for WIP in Job Costing
        /// </summary>
        [StringLength(15)]
        public string? WipTradeDebtorAccCode { get; set; }
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
