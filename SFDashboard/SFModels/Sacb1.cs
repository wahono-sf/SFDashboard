using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sacb1")]
    public partial class Sacb1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApproveDateTime { get; set; }
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [StringLength(30)]
        public string? BookingOrJobNo { get; set; }
        [StringLength(20)]
        public string? CustomsPrivilege { get; set; }
        [StringLength(20)]
        public string? CustomsPrivilege02 { get; set; }
        [StringLength(20)]
        public string? CustomsPrivilege03 { get; set; }
        [StringLength(20)]
        public string? CustomsPrivilege04 { get; set; }
        [StringLength(20)]
        public string? CustomsPrivilege05 { get; set; }
        [StringLength(255)]
        public string? CustomsRemarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntendedCargoDeliveryDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntendedCargoPickupDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IntendedCustomsReleaseDate { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseApprovedDate01 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseApprovedDate02 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseApprovedDate03 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseApprovedDate04 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LicenseApprovedDate05 { get; set; }
        [StringLength(20)]
        public string? LicenseNo01 { get; set; }
        [StringLength(20)]
        public string? LicenseNo02 { get; set; }
        [StringLength(20)]
        public string? LicenseNo03 { get; set; }
        [StringLength(20)]
        public string? LicenseNo04 { get; set; }
        [StringLength(20)]
        public string? LicenseNo05 { get; set; }
        [StringLength(20)]
        public string? LicenseType01 { get; set; }
        [StringLength(20)]
        public string? LicenseType02 { get; set; }
        [StringLength(20)]
        public string? LicenseType03 { get; set; }
        [StringLength(20)]
        public string? LicenseType04 { get; set; }
        [StringLength(20)]
        public string? LicenseType05 { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(5)]
        public string? PaperlessPortCode { get; set; }
        [StringLength(20)]
        public string? PaperlessTerminal { get; set; }
        [StringLength(50)]
        public string? CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDateTime { get; set; }
    }
}
