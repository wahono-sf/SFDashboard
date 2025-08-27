using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whpa1")]
    public partial class Whpa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Update the Account Code for the Sales Item when transferring warehouse product invoice.
        /// </summary>
        [StringLength(15)]
        public string? AccCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Address1 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Address2 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Address3 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(1)]
        public string? AddLotNoFlag { get; set; }
        /// <summary>
        /// Control the button in Whiv1
        /// If set as &quot;CUSTOMER&quot;
        /// - 1. Disable the button “Billing By Warrant” 
        /// - 2. Hide the button “Delivery Order Items”
        /// If set as “ORDER”
        /// - 1. Hide the label “ Period From Date” and “Period To Date” and “Your Ref No”
        /// - 2. the label “Batch No” change to “Sales Order No”
        /// - 3. Disable the button “Billing By Customer” and “Billing By Warrant”
        /// - 4. Hide the grid
        /// If set as “WARRANT”
        /// - 1. Hide the button “Delivery Order”
        /// - 2. Disable the button “Billing By Customer”
        /// </summary>
        [StringLength(10)]
        public string? BillingType { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? ContactName { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(3)]
        public string? CurrCode { get; set; }
        /// <summary>
        /// Define the Storage Charge Code to Charge Item Code in Whiv when do Billing By Customer, if MinAmt &gt; Total Amt. If leave blank, default “CLSTO”
        /// </summary>
        [StringLength(30)]
        public string? DefaultStorageChargeCode { get; set; }
        /// <summary>
        /// Print to footer 1 of the documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to footer 2 of the documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(30)]
        public string? Fax { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FeetSquare { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastRunEodDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MeterSquare { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextContractNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? Position { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RenewNoticeDate { get; set; }
        /// <summary>
        /// Default the Show Billing Detail Flag to Billing by Customer / Billing By Warrant
        /// </summary>
        [StringLength(1)]
        public string? ShowBillingDetailFlag { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(30)]
        public string? TelePhone { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TerminateNotice { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? UomCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(80)]
        public string? WarehouseName { get; set; }
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

        [ForeignKey("UomCode")]
        [InverseProperty("Whpa1s")]
        public virtual Rcum1? UomCodeNavigation { get; set; }
    }
}
