using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("App Issue Verify Status")]
        [StringLength(3)]
        public string? AppIssueVerifyStatus { get; set; }
        [Column("App Pick Confirm Status")]
        [StringLength(3)]
        public string? AppPickConfirmStatus { get; set; }
        [Column("App Putaway Confirm Status")]
        [StringLength(3)]
        public string? AppPutawayConfirmStatus { get; set; }
        [Column("App Tally Confirm Status")]
        [StringLength(3)]
        public string? AppTallyConfirmStatus { get; set; }
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bar Code Field")]
        [StringLength(255)]
        public string? BarCodeField { get; set; }
        [Column("Check Valid PO Flag")]
        [StringLength(1)]
        public string? CheckValidPoFlag { get; set; }
        [Column("Complete Flag")]
        [StringLength(1)]
        public string? CompleteFlag { get; set; }
        [Column("Default Acc Code")]
        [StringLength(15)]
        public string? DefaultAccCode { get; set; }
        [Column("Default Auto Generate Inv Flag")]
        [StringLength(1)]
        public string? DefaultAutoGenerateInvFlag { get; set; }
        [Column("Default Customer Code")]
        [StringLength(10)]
        public string? DefaultCustomerCode { get; set; }
        [Column("Default Freight Warehouse Code")]
        [StringLength(6)]
        public string? DefaultFreightWarehouseCode { get; set; }
        [Column("Default Packing No")]
        [StringLength(25)]
        public string? DefaultPackingNo { get; set; }
        [Column("Default Product Code")]
        [StringLength(255)]
        public string? DefaultProductCode { get; set; }
        [Column("Default Store No")]
        [StringLength(14)]
        public string? DefaultStoreNo { get; set; }
        [Column("Default Warehouse Code")]
        [StringLength(6)]
        public string? DefaultWarehouseCode { get; set; }
        [Column("First Day Of Week")]
        public int? FirstDayOfWeek { get; set; }
        [Column("Handling Charge Item")]
        [StringLength(10)]
        public string? HandlingChargeItem { get; set; }
        [Column("Lock Dimension Flag")]
        [StringLength(1)]
        public string? LockDimensionFlag { get; set; }
        [Column("Lot Master Flag")]
        [StringLength(1)]
        public string? LotMasterFlag { get; set; }
        [Column("Next Goods Transfer No")]
        [StringLength(11)]
        public string? NextGoodsTransferNo { get; set; }
        [Column("Next Goods Issue No")]
        [StringLength(11)]
        public string? NextGoodsIssueNo { get; set; }
        [Column("Next Goods Receipt No")]
        [StringLength(11)]
        public string? NextGoodsReceiptNo { get; set; }
        [Column("Next Purchase Order No")]
        [StringLength(10)]
        public string? NextPurchaseOrderNo { get; set; }
        [Column("Next Sales Order No")]
        [StringLength(10)]
        public string? NextSalesOrderNo { get; set; }
        [Column("Prompt Bal Flag")]
        [StringLength(1)]
        public string? PromptBalFlag { get; set; }
        [Column("Set Vol Dec Place")]
        public int? SetVolDecPlace { get; set; }
        [Column("Show Cust In Product Flag")]
        [StringLength(1)]
        public string? ShowCustInProductFlag { get; set; }
        [Column("Storage Charge Item")]
        [StringLength(30)]
        public string? StorageChargeItem { get; set; }
        [Column("Update Packing Qty On Split Flag")]
        [StringLength(1)]
        public string? UpdatePackingQtyOnSplitFlag { get; set; }
        [Column("Update Product Code From Grn Flag")]
        [StringLength(1)]
        public string? UpdateProductCodeFromGrnFlag { get; set; }
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
