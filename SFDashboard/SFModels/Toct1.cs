using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("toct1")]
    public partial class Toct1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? ConfirmCurrentDriver { get; set; }
        [StringLength(10)]
        public string? ConfirmCurrentFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmCurrentFromDateTime { get; set; }
        [StringLength(10)]
        public string? ConfirmCurrentParkAt { get; set; }
        [StringLength(10)]
        public string? ConfirmCurrentTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmCurrentToDateTime { get; set; }
        [StringLength(15)]
        public string? ConfirmLastDriver { get; set; }
        [StringLength(10)]
        public string? ConfirmLastFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmLastFromDateTime { get; set; }
        [StringLength(10)]
        public string? ConfirmLastParkAt { get; set; }
        [StringLength(10)]
        public string? ConfirmLastTo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ConfirmLastToDateTime { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(13)]
        public string? ContainerRefNo { get; set; }
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
        [StringLength(12)]
        public string? TrailerNo { get; set; }
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

        [ForeignKey("ConfirmCurrentParkAt")]
        [InverseProperty("Toct1ConfirmCurrentParkAtNavigations")]
        public virtual Torl1? ConfirmCurrentParkAtNavigation { get; set; }
        [ForeignKey("ConfirmLastParkAt")]
        [InverseProperty("Toct1ConfirmLastParkAtNavigations")]
        public virtual Torl1? ConfirmLastParkAtNavigation { get; set; }
        [ForeignKey("PlanCurrentParkAt")]
        [InverseProperty("Toct1PlanCurrentParkAtNavigations")]
        public virtual Torl1? PlanCurrentParkAtNavigation { get; set; }
        [ForeignKey("PlanLastParkAt")]
        [InverseProperty("Toct1PlanLastParkAtNavigations")]
        public virtual Torl1? PlanLastParkAtNavigation { get; set; }
    }
}
