using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwOmtx4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Container No")]
        [StringLength(50)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        public int? Qty { get; set; }
        [Column("Order ID")]
        [StringLength(50)]
        public string? OrderId { get; set; }
        [Column("Order No")]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [Column("Order No Bar Code")]
        [StringLength(50)]
        public string? OrderNoBarCode { get; set; }
        [Column("Sort No")]
        public int SortNo { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
