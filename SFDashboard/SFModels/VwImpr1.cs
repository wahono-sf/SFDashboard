using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpr1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Acc Code")]
        [StringLength(15)]
        public string? AccCode { get; set; }
        [Column("Alcohol Percent", TypeName = "decimal(13, 3)")]
        public decimal? AlcoholPercent { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Brand Name")]
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Column("Check Dim Qty Flag")]
        [StringLength(1)]
        public string? CheckDimQtyFlag { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Cost Amt", TypeName = "decimal(13, 2)")]
        public decimal? CostAmt { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("DG Indicator")]
        [StringLength(1)]
        public string? DgIndicator { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Expiry Date Flag")]
        [StringLength(1)]
        public string? ExpiryDateFlag { get; set; }
        [Column("Expiry Prompt Days")]
        public int? ExpiryPromptDays { get; set; }
        [Column("HS Code")]
        [StringLength(8)]
        public string? HsCode { get; set; }
        [Column("HS Product Code")]
        [StringLength(35)]
        public string? HsProductCode { get; set; }
        [Column("Issue Method")]
        [StringLength(50)]
        public string? IssueMethod { get; set; }
        [Column("Kit Master Flag")]
        [StringLength(1)]
        public string? KitMasterFlag { get; set; }
        [Column("Loose Height", TypeName = "decimal(13, 4)")]
        public decimal? LooseHeight { get; set; }
        [Column("Loose Incoming Qty")]
        public int? LooseIncomingQty { get; set; }
        [Column("Loose Length", TypeName = "decimal(13, 4)")]
        public decimal? LooseLength { get; set; }
        [Column("Loose On Order Qty")]
        public int? LooseOnOrderQty { get; set; }
        [Column("Loose Reserved Qty")]
        public int? LooseReservedQty { get; set; }
        [Column("Loose Space Area", TypeName = "decimal(13, 4)")]
        public decimal? LooseSpaceArea { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Loose Qty On Hand")]
        public int? LooseQtyOnHand { get; set; }
        [Column("Loose Uom Code")]
        [StringLength(3)]
        public string? LooseUomCode { get; set; }
        [Column("Loose Volume", TypeName = "decimal(15, 6)")]
        public decimal? LooseVolume { get; set; }
        [Column("Loose Width", TypeName = "decimal(13, 4)")]
        public decimal? LooseWidth { get; set; }
        [Column("Loose Weight", TypeName = "decimal(13, 4)")]
        public decimal? LooseWeight { get; set; }
        [Column("Manufacturing Date Flag")]
        [StringLength(1)]
        public string? ManufacturingDateFlag { get; set; }
        [Column("Min Selling Price", TypeName = "decimal(13, 2)")]
        public decimal? MinSellingPrice { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [Column("No Of Stick", TypeName = "decimal(13, 2)")]
        public decimal? NoOfStick { get; set; }
        [Column("Packing Height", TypeName = "decimal(13, 4)")]
        public decimal? PackingHeight { get; set; }
        [Column("Packing Incoming Qty")]
        public int? PackingIncomingQty { get; set; }
        [Column("Packing Length", TypeName = "decimal(13, 4)")]
        public decimal? PackingLength { get; set; }
        [Column("Packing On Order Qty")]
        public int? PackingOnOrderQty { get; set; }
        [Column("Packing Package Size")]
        public int? PackingPackageSize { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Packing Qty On Hand")]
        public int? PackingQtyOnHand { get; set; }
        [Column("Packing Reserved Qty")]
        public int? PackingReservedQty { get; set; }
        [Column("Packing Space Area", TypeName = "decimal(13, 4)")]
        public decimal? PackingSpaceArea { get; set; }
        [Column("Packing Uom Code")]
        [StringLength(3)]
        public string? PackingUomCode { get; set; }
        [Column("Packing Volume", TypeName = "decimal(15, 6)")]
        public decimal? PackingVolume { get; set; }
        [Column("Packing Weight", TypeName = "decimal(13, 4)")]
        public decimal? PackingWeight { get; set; }
        [Column("Packing Width", TypeName = "decimal(13, 4)")]
        public decimal? PackingWidth { get; set; }
        [Column("Prod Cast Ref Format")]
        [StringLength(50)]
        public string? ProdCastRefFormat { get; set; }
        [Column("Product Class Code")]
        [StringLength(20)]
        public string? ProductClassCode { get; set; }
        [Column("Product Class Description")]
        [StringLength(50)]
        public string? ProductClassDescription { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string ProductCode { get; set; } = null!;
        [Column("Product Name")]
        [StringLength(255)]
        public string? ProductName { get; set; }
        [Column("Put Away Method")]
        [StringLength(50)]
        public string? PutAwayMethod { get; set; }
        [Column("Qty Per Pallet")]
        public int? QtyPerPallet { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [Column("Reorder Qty")]
        public int? ReorderQty { get; set; }
        [Column("Selling Price", TypeName = "decimal(13, 2)")]
        public decimal? SellingPrice { get; set; }
        [Column("Serial No Flag")]
        [StringLength(1)]
        public string? SerialNoFlag { get; set; }
        [Column("Shipping Weight", TypeName = "decimal(13, 4)")]
        public decimal? ShippingWeight { get; set; }
        [Column("Storage Type")]
        [StringLength(3)]
        public string? StorageType { get; set; }
        [Column("Store Type")]
        [StringLength(3)]
        public string? StoreType { get; set; }
        [Column("Tariff Code")]
        [StringLength(15)]
        public string? TariffCode { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column("Unit Vol", TypeName = "decimal(13, 4)")]
        public decimal? UnitVol { get; set; }
        [Column("Unit Vol Flag")]
        [StringLength(1)]
        public string? UnitVolFlag { get; set; }
        [Column("Unit Wt", TypeName = "decimal(13, 4)")]
        public decimal? UnitWt { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("Volume Per Bottle", TypeName = "decimal(13, 3)")]
        public decimal? VolumePerBottle { get; set; }
        [Column("Warranty Mth")]
        public int? WarrantyMth { get; set; }
        [Column("Whole Height", TypeName = "decimal(13, 4)")]
        public decimal? WholeHeight { get; set; }
        [Column("Whole Incoming Qty")]
        public int? WholeIncomingQty { get; set; }
        [Column("Whole Length", TypeName = "decimal(13, 4)")]
        public decimal? WholeLength { get; set; }
        [Column("Whole On Order Qty")]
        public int? WholeOnOrderQty { get; set; }
        [Column("Whole Package Size")]
        public int? WholePackageSize { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Whole Qty On Hand")]
        public int? WholeQtyOnHand { get; set; }
        [Column("Whole Reserved Qty")]
        public int? WholeReservedQty { get; set; }
        [Column("Whole Space Area", TypeName = "decimal(13, 4)")]
        public decimal? WholeSpaceArea { get; set; }
        [Column("Whole Uom Code")]
        [StringLength(3)]
        public string? WholeUomCode { get; set; }
        [Column("Whole Volume", TypeName = "decimal(15, 6)")]
        public decimal? WholeVolume { get; set; }
        [Column("Whole Weight", TypeName = "decimal(13, 4)")]
        public decimal? WholeWeight { get; set; }
        [Column("Whole Width", TypeName = "decimal(13, 4)")]
        public decimal? WholeWidth { get; set; }
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
