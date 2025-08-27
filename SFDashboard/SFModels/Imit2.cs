using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imit2")]
    [Index("MovementTrxNo", Name = "INDEX_Imit2_MovementTrxNo")]
    [Index("NewStoreNo", Name = "INDEX_Imit2_NewStoreNo")]
    [Index("NewWarehouseCode", Name = "INDEX_Imit2_NewWarehouseCode")]
    [Index("ProductTrxNo", Name = "INDEX_Imit2_ProductTrxNo")]
    [Index("StoreNo", Name = "INDEX_Imit2_StoreNo")]
    [Index("WarehouseCode", Name = "INDEX_Imit2_WarehouseCode")]
    public partial class Imit2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        public int? LooseQty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        public int? MovementTrxNo { get; set; }
        [StringLength(14)]
        public string? NewStoreNo { get; set; }
        [StringLength(6)]
        public string? NewWarehouseCode { get; set; }
        public int? PackingQty { get; set; }
        public int? ProductTrxNo { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? SpaceArea { get; set; }
        [StringLength(14)]
        public string? StoreNo { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? Weight { get; set; }
        public int? WholeQty { get; set; }
        [StringLength(50)]
        public string? Updateby { get; set; }
    }
}
