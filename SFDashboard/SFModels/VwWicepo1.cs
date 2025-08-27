using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWicepo1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Balance Qty")]
        public int? BalanceQty { get; set; }
        [StringLength(50)]
        public string? Brand { get; set; }
        [StringLength(50)]
        public string? Color { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
        [Column("HS Code")]
        [StringLength(50)]
        public string? HsCode { get; set; }
        [Column("Material Information")]
        [StringLength(100)]
        public string? MaterialInformation { get; set; }
        [Column("No Of Pkg")]
        public int? NoOfPkg { get; set; }
        [Column("Purchase Order Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PurchaseOrderDate { get; set; }
        [Column("Purchase Order No")]
        [StringLength(50)]
        public string? PurchaseOrderNo { get; set; }
        public int? Qty { get; set; }
        [Column("Ref No")]
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string? Sku { get; set; }
        [Column("Style No")]
        [StringLength(100)]
        public string? StyleNo { get; set; }
        [Column("Sub Category")]
        [StringLength(50)]
        public string? SubCategory { get; set; }
        [Column("Unit Rate", TypeName = "decimal(13, 2)")]
        public decimal? UnitRate { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
    }
}
