using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aect2")]
    public partial class Aect2
    {
        [Key]
        [StringLength(8)]
        public string CargoTrfFormNo { get; set; } = null!;
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? AwbType { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(50)]
        public string? Content { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(50)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }

        [ForeignKey("CargoTrfFormNo")]
        [InverseProperty("Aect2s")]
        public virtual Aect1 CargoTrfFormNoNavigation { get; set; } = null!;
    }
}
