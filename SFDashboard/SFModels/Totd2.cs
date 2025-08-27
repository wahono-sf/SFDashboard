using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("totd2")]
    public partial class Totd2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public int LineItemNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(15)]
        public string? DriverNo { get; set; }
        [StringLength(10)]
        public string? FromCode { get; set; }
        [StringLength(80)]
        public string? FromName { get; set; }
        [StringLength(50)]
        public string? FromAddress1 { get; set; }
        [StringLength(50)]
        public string? FromAddress2 { get; set; }
        [StringLength(50)]
        public string? FromAddress3 { get; set; }
        [StringLength(50)]
        public string? FromAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FromExecuteDateTime { get; set; }
        [StringLength(10)]
        public string? ParkingPlace { get; set; }
        [StringLength(10)]
        public string? ToCode { get; set; }
        [StringLength(80)]
        public string? ToName { get; set; }
        [StringLength(50)]
        public string? ToAddress1 { get; set; }
        [StringLength(50)]
        public string? ToAddress2 { get; set; }
        [StringLength(50)]
        public string? ToAddress3 { get; set; }
        [StringLength(50)]
        public string? ToAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ToExecuteDateTime { get; set; }
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [StringLength(6)]
        public string? TripCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TripCommissionAmt { get; set; }
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [StringLength(6)]
        public string? VehicleType { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }

        [ForeignKey("ParkingPlace")]
        [InverseProperty("Totd2s")]
        public virtual Torl1? ParkingPlaceNavigation { get; set; }
        [ForeignKey("TrxNo")]
        [InverseProperty("Totd2s")]
        public virtual Totd1 TrxNoNavigation { get; set; } = null!;
        [ForeignKey("VehicleType")]
        [InverseProperty("Totd2s")]
        public virtual Tovt1? VehicleTypeNavigation { get; set; }
    }
}
