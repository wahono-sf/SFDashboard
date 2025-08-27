using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTobk5
    {
        [Column("Booking No")]
        [StringLength(50)]
        public string BookingNo { get; set; } = null!;
        [Column("Booking Line Item No")]
        public short BookingLineItemNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        [Column("Charge Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ChargeDate { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Driver Code")]
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
        [Column("Unit Rate", TypeName = "decimal(13, 5)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
    }
}
