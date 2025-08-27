using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwToct1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Confirm Current Driver")]
        [StringLength(15)]
        public string? ConfirmCurrentDriver { get; set; }
        [Column("Confirm Current From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmCurrentFromDateTime { get; set; }
        [Column("Confirm Current From")]
        [StringLength(10)]
        public string? ConfirmCurrentFrom { get; set; }
        [Column("Confirm Current To")]
        [StringLength(10)]
        public string? ConfirmCurrentTo { get; set; }
        [Column("Confirm Current To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmCurrentToDateTime { get; set; }
        [Column("Confirm Current Park At")]
        [StringLength(10)]
        public string? ConfirmCurrentParkAt { get; set; }
        [Column("Confirm Last Driver")]
        [StringLength(15)]
        public string? ConfirmLastDriver { get; set; }
        [Column("Confirm Last From")]
        [StringLength(10)]
        public string? ConfirmLastFrom { get; set; }
        [Column("Confirm Last From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmLastFromDateTime { get; set; }
        [Column("Confirm Last Park At")]
        [StringLength(10)]
        public string? ConfirmLastParkAt { get; set; }
        [Column("Confirm Last To")]
        [StringLength(10)]
        public string? ConfirmLastTo { get; set; }
        [Column("Confirm Last To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ConfirmLastToDateTime { get; set; }
        [Column("Container Ref No")]
        [StringLength(13)]
        public string? ContainerRefNo { get; set; }
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
        [Column("Plan Current To")]
        [StringLength(10)]
        public string? PlanCurrentTo { get; set; }
        [Column("Plan Current To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PlanCurrentToDateTime { get; set; }
        [Column("Plan Current Park At")]
        [StringLength(10)]
        public string? PlanCurrentParkAt { get; set; }
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
        [Column("Trailer No")]
        [StringLength(12)]
        public string? TrailerNo { get; set; }
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
