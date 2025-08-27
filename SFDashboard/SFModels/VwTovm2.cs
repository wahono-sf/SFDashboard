using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTovm2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("Available Flag")]
        [StringLength(1)]
        public string? AvailableFlag { get; set; }
        [Column("Charge Code")]
        [StringLength(30)]
        public string? ChargeCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? Mileage { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Service Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ServiceDate { get; set; }
        [Column("Service End Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ServiceEndDate { get; set; }
        [Column("Service Type")]
        [StringLength(5)]
        public string? ServiceType { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
    }
}
