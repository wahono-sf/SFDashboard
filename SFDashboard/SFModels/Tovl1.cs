using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tovl1")]
    public partial class Tovl1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [StringLength(6)]
        public string? VehicleType { get; set; }
        [StringLength(15)]
        public string? ConfirmedCurrentDriver { get; set; }
        [StringLength(10)]
        public string? ConfirmedCurrentFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmedCurrentFromDateTime { get; set; }
        [StringLength(10)]
        public string? ConfirmedCurrentParkAt { get; set; }
        [StringLength(10)]
        public string? ConfirmedCurrentTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmedCurrentToDateTime { get; set; }
        [StringLength(15)]
        public string? ConfirmedLastDriver { get; set; }
        [StringLength(10)]
        public string? ConfirmedLastFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmedLastFromDateTime { get; set; }
        [StringLength(10)]
        public string? ConfirmedLastParkAt { get; set; }
        [StringLength(10)]
        public string? ConfirmedLastTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmedLastToDateTime { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(15)]
        public string? PlanCurrentDriver { get; set; }
        [StringLength(10)]
        public string? PlanCurrentFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanCurrentFromDateTime { get; set; }
        [StringLength(10)]
        public string? PlanCurrentParkAt { get; set; }
        [StringLength(10)]
        public string? PlanCurrentTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanCurrentToDateTime { get; set; }
        [StringLength(15)]
        public string? PlanLastDriver { get; set; }
        [StringLength(10)]
        public string? PlanLastFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanLastFromDateTime { get; set; }
        [StringLength(10)]
        public string? PlanLastParkAt { get; set; }
        [StringLength(10)]
        public string? PlanLastTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlanLastToDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [ForeignKey("ConfirmedCurrentParkAt")]
        [InverseProperty("Tovl1ConfirmedCurrentParkAtNavigations")]
        public virtual Torl1? ConfirmedCurrentParkAtNavigation { get; set; }
        [ForeignKey("ConfirmedLastParkAt")]
        [InverseProperty("Tovl1ConfirmedLastParkAtNavigations")]
        public virtual Torl1? ConfirmedLastParkAtNavigation { get; set; }
        [ForeignKey("PlanCurrentParkAt")]
        [InverseProperty("Tovl1PlanCurrentParkAtNavigations")]
        public virtual Torl1? PlanCurrentParkAtNavigation { get; set; }
        [ForeignKey("PlanLastParkAt")]
        [InverseProperty("Tovl1PlanLastParkAtNavigations")]
        public virtual Torl1? PlanLastParkAtNavigation { get; set; }
        [ForeignKey("VehicleType")]
        [InverseProperty("Tovl1s")]
        public virtual Tovt1? VehicleTypeNavigation { get; set; }
    }
}
