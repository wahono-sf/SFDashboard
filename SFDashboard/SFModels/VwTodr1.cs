using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTodr1
    {
        [Column("Driver Code")]
        [StringLength(15)]
        public string DriverCode { get; set; } = null!;
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        [Column("Airport Pass Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AirportPassExpiryDate { get; set; }
        [Column("Airport Pass No")]
        [StringLength(50)]
        public string? AirportPassNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Attendent Flag")]
        [StringLength(1)]
        public string? AttendentFlag { get; set; }
        [Column("Business Party Code")]
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [Column("Contact No 1")]
        [StringLength(30)]
        public string? ContactNo1 { get; set; }
        [Column("Contact No 2")]
        [StringLength(30)]
        public string? ContactNo2 { get; set; }
        [Column("Date Of Birth")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateOfBirth { get; set; }
        [Column("Driver Login ID")]
        [StringLength(20)]
        public string? DriverLoginId { get; set; }
        [Column("Fin No")]
        [StringLength(50)]
        public string? FinNo { get; set; }
        [Column("Gdl No")]
        [StringLength(50)]
        public string? GdlNo { get; set; }
        [Column("Hazmat Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? HazmatDateTime { get; set; }
        [Column("Hazmat Pass No")]
        [StringLength(25)]
        public string? HazmatPassNo { get; set; }
        [Column("IC Or Pass Port No")]
        [StringLength(25)]
        public string? IcOrPassPortNo { get; set; }
        [Column("IC Type")]
        [StringLength(3)]
        public string? IcType { get; set; }
        [Column("IU No")]
        [StringLength(50)]
        public string? IuNo { get; set; }
        [Column("Jurong Port Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? JurongPortExpiryDate { get; set; }
        [Column("Jurong Port Pass No")]
        [StringLength(50)]
        public string? JurongPortPassNo { get; set; }
        [Column("Licence Class")]
        [StringLength(3)]
        public string? LicenceClass { get; set; }
        [Column("Licence Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenceEffectiveDate { get; set; }
        [Column("Licence Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenceExpiryDate { get; set; }
        [Column("Licence No")]
        [StringLength(25)]
        public string? LicenceNo { get; set; }
        [StringLength(30)]
        public string? Nationality { get; set; }
        [Column("PSA Pass Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PsaPassExpiryDate { get; set; }
        [Column("PSA Pass No")]
        [StringLength(50)]
        public string? PsaPassNo { get; set; }
        [Column("Psoc Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PsocDateTime { get; set; }
        [Column("Psoc Pass No")]
        [StringLength(25)]
        public string? PsocPassNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Trip Rate", TypeName = "decimal(9, 4)")]
        public decimal? TripRate { get; set; }
        [Column("Walkie Talkie No")]
        [StringLength(50)]
        public string? WalkieTalkieNo { get; set; }
        [Column("Work Permit Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? WorkPermitExpiryDate { get; set; }
        [Column("Work Permit No")]
        [StringLength(50)]
        public string? WorkPermitNo { get; set; }
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
