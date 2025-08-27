using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aect1")]
    public partial class Aect1
    {
        public Aect1()
        {
            Aect2s = new HashSet<Aect2>();
        }

        [Key]
        [StringLength(8)]
        public string CargoTrfFormNo { get; set; } = null!;
        [StringLength(1)]
        public string? ContainerFlag { get; set; }
        [StringLength(10)]
        public string? DestCompanyCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? ShipmentConfirmFlag { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrfDate { get; set; }
        [StringLength(1)]
        public string? UrgentFlag { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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

        [InverseProperty("CargoTrfFormNoNavigation")]
        public virtual ICollection<Aect2> Aect2s { get; set; }
    }
}
