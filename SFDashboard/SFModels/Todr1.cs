using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("todr1")]
    public partial class Todr1
    {
        [Key]
        [StringLength(15)]
        public string DriverCode { get; set; } = null!;
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AirportPassExpiryDate { get; set; }
        [StringLength(50)]
        public string? AirportPassNo { get; set; }
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(30)]
        public string? ContactNo1 { get; set; }
        [StringLength(30)]
        public string? ContactNo2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }
        [StringLength(20)]
        public string? DriverLoginId { get; set; }
        [StringLength(50)]
        public string? FinNo { get; set; }
        [StringLength(50)]
        public string? GdlNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HazmatDateTime { get; set; }
        [StringLength(25)]
        public string? HazmatPassNo { get; set; }
        [Column("ICOrPassPortNo")]
        [StringLength(25)]
        public string? IcorPassPortNo { get; set; }
        [Column("ICType")]
        [StringLength(3)]
        public string? Ictype { get; set; }
        [Column("IUNo")]
        [StringLength(50)]
        public string? Iuno { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JurongPortExpiryDate { get; set; }
        [StringLength(50)]
        public string? JurongPortPassNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenceEffectiveDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenceExpiryDate { get; set; }
        [StringLength(3)]
        public string? LicenceClass { get; set; }
        [StringLength(25)]
        public string? LicenceNo { get; set; }
        [StringLength(30)]
        public string? Nationality { get; set; }
        [Column("PSAPassExpiryDate", TypeName = "datetime")]
        public DateTime? PsapassExpiryDate { get; set; }
        [Column("PSAPassNo")]
        [StringLength(50)]
        public string? PsapassNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PsocDateTime { get; set; }
        [StringLength(25)]
        public string? PsocPassNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal? TripRate { get; set; }
        [StringLength(50)]
        public string? WalkieTalkieNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkPermitExpiryDate { get; set; }
        [StringLength(50)]
        public string? WorkPermitNo { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
    }
}
