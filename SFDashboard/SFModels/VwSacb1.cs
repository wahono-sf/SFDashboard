using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSacb1
    {
        public int TrxNo { get; set; }
        [Column("Approve By")]
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        [Column("Approve Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ApproveDateTime { get; set; }
        [Column("Booking No")]
        [StringLength(20)]
        public string? BookingNo { get; set; }
        [Column("Booking Or Job No")]
        [StringLength(30)]
        public string? BookingOrJobNo { get; set; }
        [Column("Customs Privilege")]
        [StringLength(20)]
        public string? CustomsPrivilege { get; set; }
        [Column("Customs Privilege 02")]
        [StringLength(20)]
        public string? CustomsPrivilege02 { get; set; }
        [Column("Customs Privilege 03")]
        [StringLength(20)]
        public string? CustomsPrivilege03 { get; set; }
        [Column("Customs Privilege 04")]
        [StringLength(20)]
        public string? CustomsPrivilege04 { get; set; }
        [Column("Customs Privilege 05")]
        [StringLength(20)]
        public string? CustomsPrivilege05 { get; set; }
        [Column("Customs Remarks")]
        [StringLength(255)]
        public string? CustomsRemarks { get; set; }
        [Column("Intended Cargo Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? IntendedCargoDeliveryDateTime { get; set; }
        [Column("Intended Cargo Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? IntendedCargoPickupDateTime { get; set; }
        [Column("Intended Customs Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IntendedCustomsReleaseDate { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("License Approved Date 01")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenseApprovedDate01 { get; set; }
        [Column("License Approved Date 02")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenseApprovedDate02 { get; set; }
        [Column("License Approved Date 03")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenseApprovedDate03 { get; set; }
        [Column("License Approved Date 04")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenseApprovedDate04 { get; set; }
        [Column("License Approved Date 05")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LicenseApprovedDate05 { get; set; }
        [Column("License No 01")]
        [StringLength(20)]
        public string? LicenseNo01 { get; set; }
        [Column("License No 02")]
        [StringLength(20)]
        public string? LicenseNo02 { get; set; }
        [Column("License No 03")]
        [StringLength(20)]
        public string? LicenseNo03 { get; set; }
        [Column("License No 04")]
        [StringLength(20)]
        public string? LicenseNo04 { get; set; }
        [Column("License No 05")]
        [StringLength(20)]
        public string? LicenseNo05 { get; set; }
        [Column("License Type 01")]
        [StringLength(20)]
        public string? LicenseType01 { get; set; }
        [Column("License Type 02")]
        [StringLength(20)]
        public string? LicenseType02 { get; set; }
        [Column("License Type 03")]
        [StringLength(20)]
        public string? LicenseType03 { get; set; }
        [Column("License Type 04")]
        [StringLength(20)]
        public string? LicenseType04 { get; set; }
        [Column("License Type 05")]
        [StringLength(20)]
        public string? LicenseType05 { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Paperless Port Code")]
        [StringLength(5)]
        public string? PaperlessPortCode { get; set; }
        [Column("Paperless Terminal")]
        [StringLength(20)]
        public string? PaperlessTerminal { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
    }
}
