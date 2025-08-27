using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("WicePO1")]
    public partial class WicePo1
    {
        public WicePo1()
        {
            WicePo2s = new HashSet<WicePo2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? PurchaseOrderNo { get; set; }
        public int? BalanceQty { get; set; }
        [StringLength(50)]
        public string? Brand { get; set; }
        [StringLength(50)]
        public string? Color { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
        [StringLength(50)]
        public string? HsCode { get; set; }
        [StringLength(100)]
        public string? MaterialInformation { get; set; }
        public int? NoOfPkg { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PurchaseOrderDate { get; set; }
        public int? Qty { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string? Sku { get; set; }
        [StringLength(100)]
        public string? StyleNo { get; set; }
        [StringLength(50)]
        public string? SubCategory { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? UnitRate { get; set; }
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
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<WicePo2> WicePo2s { get; set; }
    }
}
