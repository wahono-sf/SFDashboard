using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTotd2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [Column("Driver No")]
        [StringLength(15)]
        public string? DriverNo { get; set; }
        [Column("From Code")]
        [StringLength(10)]
        public string? FromCode { get; set; }
        [Column("From Name")]
        [StringLength(80)]
        public string? FromName { get; set; }
        [Column("From Address 1")]
        [StringLength(45)]
        public string? FromAddress1 { get; set; }
        [Column("From Address 2")]
        [StringLength(45)]
        public string? FromAddress2 { get; set; }
        [Column("From Address 3")]
        [StringLength(45)]
        public string? FromAddress3 { get; set; }
        [Column("From Address 4")]
        [StringLength(45)]
        public string? FromAddress4 { get; set; }
        [Column("From Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FromDateTime { get; set; }
        [Column("From Execute Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? FromExecuteDateTime { get; set; }
        [Column("Parking Place")]
        [StringLength(10)]
        public string? ParkingPlace { get; set; }
        [Column("To Code")]
        [StringLength(10)]
        public string? ToCode { get; set; }
        [Column("To Name")]
        [StringLength(80)]
        public string? ToName { get; set; }
        [Column("To Address 1")]
        [StringLength(45)]
        public string? ToAddress1 { get; set; }
        [Column("To Address 2")]
        [StringLength(45)]
        public string? ToAddress2 { get; set; }
        [Column("To Address 3")]
        [StringLength(45)]
        public string? ToAddress3 { get; set; }
        [Column("To Address 4")]
        [StringLength(45)]
        public string? ToAddress4 { get; set; }
        [Column("To Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ToDateTime { get; set; }
        [Column("To Execute Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ToExecuteDateTime { get; set; }
        [Column("Trailer No")]
        [StringLength(12)]
        public string? TrailerNo { get; set; }
        [Column("Trip Code")]
        [StringLength(6)]
        public string? TripCode { get; set; }
        [Column("Trip Commission Amt", TypeName = "decimal(13, 4)")]
        public decimal? TripCommissionAmt { get; set; }
        [Column("Vehicle No")]
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column("Vehicle Type")]
        [StringLength(6)]
        public string? VehicleType { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
