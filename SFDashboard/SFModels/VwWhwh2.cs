using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWhwh2
    {
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Balance Space", TypeName = "decimal(13, 2)")]
        public decimal? BalanceSpace { get; set; }
        [Column("Bill Flag")]
        [StringLength(1)]
        public string? BillFlag { get; set; }
        [Column("Bin Qty")]
        public int? BinQty { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Length { get; set; }
        [Column("Pallet Space", TypeName = "decimal(13, 2)")]
        public decimal? PalletSpace { get; set; }
        [Column("Phase Picking Flag")]
        [StringLength(1)]
        public string? PhasePickingFlag { get; set; }
        [Column("Pick Flag")]
        [StringLength(1)]
        public string? PickFlag { get; set; }
        [Column("Sort Store No")]
        [StringLength(14)]
        public string? SortStoreNo { get; set; }
        [Column("Staging Area Flag")]
        [StringLength(1)]
        public string? StagingAreaFlag { get; set; }
        [Column("Store Location")]
        [StringLength(50)]
        public string? StoreLocation { get; set; }
        [Column("Store No")]
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column("Store Qty")]
        public int? StoreQty { get; set; }
        [Column("Store Space", TypeName = "decimal(13, 2)")]
        public decimal? StoreSpace { get; set; }
        [Column("Used Space", TypeName = "decimal(13, 2)")]
        public decimal? UsedSpace { get; set; }
        [Column("User Flag")]
        [StringLength(1)]
        public string? UserFlag { get; set; }
        [Column("Warehouse Code")]
        [StringLength(6)]
        public string WarehouseCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Width { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
