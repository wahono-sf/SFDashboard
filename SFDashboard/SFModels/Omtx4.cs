using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("omtx4")]
    public partial class Omtx4
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int SortNo { get; set; }
        [StringLength(50)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        public int? Qty { get; set; }
        [StringLength(50)]
        public string? OrderId { get; set; }
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [StringLength(50)]
        public string? OrderNoBarCode { get; set; }
        [StringLength(1)]
        public string? Type { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
