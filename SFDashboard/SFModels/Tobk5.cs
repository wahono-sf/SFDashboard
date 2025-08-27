using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tobk5")]
    public partial class Tobk5
    {
        [Key]
        [StringLength(50)]
        public string BookingNo { get; set; } = null!;
        [Key]
        public short BookingLineItemNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChargeDate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Qty { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 5)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
    }
}
