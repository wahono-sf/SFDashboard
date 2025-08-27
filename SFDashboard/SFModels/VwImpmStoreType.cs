using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwImpmStoreType
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Balance Dimension Qty")]
        public int BalanceDimensionQty { get; set; }
        [Column("Balance Loose Qty")]
        public int? BalanceLooseQty { get; set; }
        [Column("Balance Packing Qty")]
        public int? BalancePackingQty { get; set; }
        [Column("Balance Space Area", TypeName = "decimal(13, 4)")]
        public decimal? BalanceSpaceArea { get; set; }
        [Column("Balance Volume", TypeName = "decimal(13, 4)")]
        public decimal? BalanceVolume { get; set; }
        [Column("Balance Weight", TypeName = "decimal(13, 4)")]
        public decimal? BalanceWeight { get; set; }
        [Column("Balance Whole Qty")]
        public int? BalanceWholeQty { get; set; }
        [Column("Batch No")]
        [StringLength(12)]
        public string? BatchNo { get; set; }
        [Column("Batch Line Item No")]
        public int? BatchLineItemNo { get; set; }
        [Column("Billable Flag")]
        [StringLength(1)]
        public string? BillableFlag { get; set; }
        [Column("Bill Flag")]
        [StringLength(1)]
        public string? BillFlag { get; set; }
        [Column("Billing Start Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? BillingStartDate { get; set; }
        [Column("Brand Name")]
        [StringLength(50)]
        public string? BrandName { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(2000)]
        public string? Description { get; set; }
        [Column("Dimension Flag")]
        [StringLength(1)]
        public string? DimensionFlag { get; set; }
        [Column("Doc Ref No")]
        [StringLength(2000)]
        public string? DocRefNo { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
        [Column("From To Location")]
        [StringLength(50)]
        public string? FromToLocation { get; set; }
        [Column("From To Store No")]
        [StringLength(14)]
        public string? FromToStoreNo { get; set; }
        [Column("From To Warehouse Code")]
        [StringLength(6)]
        public string? FromToWarehouseCode { get; set; }
        [Column("Goods Description")]
        [StringLength(2000)]
        public string? GoodsDescription { get; set; }
        [Column("Goods Receive Or Issue No")]
        [StringLength(20)]
        public string? GoodsReceiveOrIssueNo { get; set; }
        [StringLength(25)]
        public string? Grade { get; set; }
        [Column("GRN Ref No")]
        [StringLength(50)]
        public string? GrnRefNo { get; set; }
        [Column("Last Bill Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastBillDate { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [Column("Loose Qty")]
        public int? LooseQty { get; set; }
        [Column("Lot No")]
        [StringLength(20)]
        public string? LotNo { get; set; }
        [Column("Manufacture Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ManufactureDate { get; set; }
        [Column("Mark No")]
        [StringLength(2000)]
        public string? MarkNo { get; set; }
        [Column("Mawb Or Obl No")]
        [StringLength(50)]
        public string? MawbOrOblNo { get; set; }
        [Column("Movement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MovementDate { get; set; }
        [Column("Note Line Item No")]
        public short? NoteLineItemNo { get; set; }
        [Column("Packing No")]
        [StringLength(50)]
        public string? PackingNo { get; set; }
        [Column("Packing Qty")]
        public int? PackingQty { get; set; }
        [Column("Part No Trx No")]
        public int? PartNoTrxNo { get; set; }
        [Column("Part No")]
        [StringLength(50)]
        public string? PartNo { get; set; }
        [Column("Permit No")]
        [StringLength(20)]
        public string? PermitNo { get; set; }
        [Column("Pick Flag")]
        [StringLength(1)]
        public string? PickFlag { get; set; }
        [Column("Product Code")]
        [StringLength(255)]
        public string? ProductCode { get; set; }
        [Column("Product Name")]
        [StringLength(255)]
        public string? ProductName { get; set; }
        [Column("Product Trx No")]
        public int? ProductTrxNo { get; set; }
        [Column("Rate Class Code")]
        [StringLength(1)]
        public string? RateClassCode { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Space Area", TypeName = "decimal(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [Column("Staging Area Flag")]
        [StringLength(1)]
        public string? StagingAreaFlag { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column("Trx Type")]
        [StringLength(1)]
        public string? TrxType { get; set; }
        [Column("Unit Price", TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [Column("Unit Volume", TypeName = "decimal(15, 6)")]
        public decimal? UnitVolume { get; set; }
        [Column("Unit Weight", TypeName = "decimal(13, 4)")]
        public decimal? UnitWeight { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("User Define 1")]
        [StringLength(50)]
        public string? UserDefine1 { get; set; }
        [Column("User Define 2")]
        [StringLength(50)]
        public string? UserDefine2 { get; set; }
        [Column("User Define 3")]
        [StringLength(50)]
        public string? UserDefine3 { get; set; }
        [Column("User Define 4")]
        [StringLength(50)]
        public string? UserDefine4 { get; set; }
        [Column("User Define 5")]
        [StringLength(50)]
        public string? UserDefine5 { get; set; }
        [Column("User Define 6")]
        [StringLength(50)]
        public string? UserDefine6 { get; set; }
        [Column("User Define 7")]
        [StringLength(50)]
        public string? UserDefine7 { get; set; }
        [Column("User Define 8")]
        [StringLength(50)]
        public string? UserDefine8 { get; set; }
        [Column("User Define 9")]
        [StringLength(50)]
        public string? UserDefine9 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("User Define 11")]
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [Column("User Define 12")]
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [Column("User Define 13")]
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [Column("User Define 14")]
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [Column("User Define 15")]
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [Column("User Define 16")]
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [Column("User Define 17")]
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [Column("User Define 18")]
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [Column("User Define 19")]
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [Column("User Define 20")]
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [Column("Vessel Name")]
        [StringLength(80)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(15, 6)")]
        public decimal? Volume { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Whole Qty")]
        public int? WholeQty { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
