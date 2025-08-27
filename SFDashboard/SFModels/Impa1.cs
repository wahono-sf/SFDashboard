using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("impa1")]
    public partial class Impa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [StringLength(3)]
        public string? AppIssueVerifyStatus { get; set; }
        [StringLength(3)]
        public string? AppPickConfirmStatus { get; set; }
        [StringLength(3)]
        public string? AppPutawayConfirmStatus { get; set; }
        [StringLength(3)]
        public string? AppTallyConfirmStatus { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        /// <summary>
        /// Define the field the barcode should read from.
        /// </summary>
        [StringLength(255)]
        public string? BarCodeField { get; set; }
        /// <summary>
        /// If set as Y, during &quot;ASN Excel Upload&quot;, check that PO No is valid from Impo1.PurchaseOrderNo
        /// </summary>
        [StringLength(1)]
        public string? CheckValidPoFlag { get; set; }
        /// <summary>
        /// Enable/Disable the Completion features
        /// </summary>
        [StringLength(1)]
        public string? CompleteFlag { get; set; }
        /// <summary>
        /// Default Account Code to Account Code in Product Master
        /// </summary>
        [StringLength(15)]
        public string? DefaultAccCode { get; set; }
        [StringLength(1)]
        public string? DefaultAutoGenerateInvFlag { get; set; }
        /// <summary>
        /// Default Customer Code to Goods Receipt Note / Goods Issue Note
        /// </summary>
        [StringLength(10)]
        public string? DefaultCustomerCode { get; set; }
        [StringLength(6)]
        public string? DefaultFreightWarehouseCode { get; set; }
        [StringLength(25)]
        public string? DefaultPackingNo { get; set; }
        [StringLength(255)]
        public string? DefaultProductCode { get; set; }
        /// <summary>
        /// Default Store No to Boods Info in Goods Receipt Note
        /// </summary>
        [StringLength(14)]
        public string? DefaultStoreNo { get; set; }
        /// <summary>
        /// Default Warehouse Code to Goods Receipt Note
        /// </summary>
        [StringLength(6)]
        public string? DefaultWarehouseCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        public int? FirstDayOfWeek { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? HandlingChargeItem { get; set; }
        /// <summary>
        /// If set to Y, user cannot change the “DimensionFlag” in the Goods Receipt Note, it will pull the DimensionFlag from the Product Master (Impr1)
        /// </summary>
        [StringLength(1)]
        public string? LockDimensionFlag { get; set; }
        [StringLength(1)]
        public string? LotMasterFlag { get; set; }
        /// <summary>
        /// Next Goods Issue No
        /// </summary>
        [StringLength(11)]
        public string? NextGoodsIssueNo { get; set; }
        /// <summary>
        /// Next Goods Receipt No
        /// </summary>
        [StringLength(11)]
        public string? NextGoodsReceiptNo { get; set; }
        /// <summary>
        /// Next Goods Transfer No
        /// </summary>
        [StringLength(11)]
        public string? NextGoodsTransferNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextPurchaseOrderNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextSalesOrderNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("PromptBalFLag")]
        [StringLength(1)]
        public string? PromptBalFlag { get; set; }
        /// <summary>
        /// Define the decimal places for the computed volume in impr1,impr2 and imgr2
        /// </summary>
        public int? SetVolDecPlace { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(1)]
        public string? ShowCustInProductFlag { get; set; }
        /// <summary>
        /// Define Warehouse Charge Code for identifying the Warehouse Charge Code in Billing Template during DailyBilling
        /// </summary>
        [StringLength(30)]
        public string? StorageChargeItem { get; set; }
        [StringLength(1)]
        public string? UpdatePackingQtyOnSplitFlag { get; set; }
        [StringLength(1)]
        public string? UpdateProductCodeFromGrnFlag { get; set; }
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
