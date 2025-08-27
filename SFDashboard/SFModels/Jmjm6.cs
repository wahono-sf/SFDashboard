using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmjm6")]
    public partial class Jmjm6
    {
        [Key]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(3)]
        public string? CargoStatusCode { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(45)]
        public string? DriverNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReadyDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecevieDateTime { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TruckDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UnLoadDateTime { get; set; }
        [StringLength(50)]
        public string? VehicleNo { get; set; }
    }
}
