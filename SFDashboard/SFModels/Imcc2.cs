using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("Imcc2")]
    [Index("MovementTrxNo", Name = "INDEX_Imcc2_MovementTrxNo")]
    [Index("ProductTrxNo", Name = "INDEX_Imcc2_ProductTrxNo")]
    [Index("StoreNo", Name = "INDEX_Imcc2_StoreNo")]
    [Index("WarehouseCode", Name = "INDEX_Imcc2_WarehouseCode")]
    public partial class Imcc2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        public int? LooseQty { get; set; }
        public int? MovementTrxNo { get; set; }
        public int? OrgLooseQty { get; set; }
        public int? OrgPackingQty { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? OrgSpaceArea { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? OrgVolume { get; set; }
        [Column(TypeName = "numeric(13, 4)")]
        public decimal? OrgWeight { get; set; }
        public int? OrgWholeQty { get; set; }
        public int? PackingQty { get; set; }
        public int? ProductTrxNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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
