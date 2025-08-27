using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTovl1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column("Confirmed Current Driver")]
        [StringLength(15)]
        public string? ConfirmedCurrentDriver { get; set; }
        [Column("Confirmed Current From")]
        [StringLength(10)]
        public string? ConfirmedCurrentFrom { get; set; }
        [Column("Confirmed Current From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmedCurrentFromDateTime { get; set; }
        [Column("Confirmed Current Park At")]
        [StringLength(10)]
        public string? ConfirmedCurrentParkAt { get; set; }
        [Column("Confirmed Current To")]
        [StringLength(10)]
        public string? ConfirmedCurrentTo { get; set; }
        [Column("Confirmed Current To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmedCurrentToDateTime { get; set; }
        [Column("Confirmed Last Driver")]
        [StringLength(15)]
        public string? ConfirmedLastDriver { get; set; }
        [Column("Confirmed Last From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmedLastFromDateTime { get; set; }
        [Column("Confirmed Last From")]
        [StringLength(10)]
        public string? ConfirmedLastFrom { get; set; }
        [Column("Confirmed Last Park At")]
        [StringLength(10)]
        public string? ConfirmedLastParkAt { get; set; }
        [Column("Confirmed Last To")]
        [StringLength(10)]
        public string? ConfirmedLastTo { get; set; }
        [Column("Confirmed Last To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmedLastToDateTime { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Plan Current Driver")]
        [StringLength(15)]
        public string? PlanCurrentDriver { get; set; }
        [Column("Plan Current From")]
        [StringLength(10)]
        public string? PlanCurrentFrom { get; set; }
        [Column("Plan Current From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PlanCurrentFromDateTime { get; set; }
        [Column("Plan Current Park At")]
        [StringLength(10)]
        public string? PlanCurrentParkAt { get; set; }
        [Column("Plan Current To")]
        [StringLength(10)]
        public string? PlanCurrentTo { get; set; }
        [Column("Plan Current To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PlanCurrentToDateTime { get; set; }
        [Column("Plan Last Driver")]
        [StringLength(15)]
        public string? PlanLastDriver { get; set; }
        [Column("Plan Last From")]
        [StringLength(10)]
        public string? PlanLastFrom { get; set; }
        [Column("Plan Last From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PlanLastFromDateTime { get; set; }
        [Column("Plan Last Park At")]
        [StringLength(10)]
        public string? PlanLastParkAt { get; set; }
        [Column("Plan Last To")]
        [StringLength(10)]
        public string? PlanLastTo { get; set; }
        [Column("Plan Last To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PlanLastToDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Vehicle Type")]
        [StringLength(6)]
        public string? VehicleType { get; set; }
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
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
