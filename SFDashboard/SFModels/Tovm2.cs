using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tovm2")]
    public partial class Tovm2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [StringLength(1)]
        public string? AvailableFlag { get; set; }
        [StringLength(30)]
        public string? ChargeCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        public int? Mileage { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ServiceDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ServiceEndDate { get; set; }
        [StringLength(5)]
        public string? ServiceType { get; set; }
        [StringLength(10)]
        public string? Status { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
    }
}
