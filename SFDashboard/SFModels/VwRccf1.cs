using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRccf1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string ContainerNo { get; set; } = null!;
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [StringLength(9)]
        public string? Approvals { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Capacity { get; set; }
        [Column("Comm_Date", TypeName = "datetime")]
        public DateTime? CommDate { get; set; }
        [Column("Date_Manu", TypeName = "datetime")]
        public DateTime? DateManu { get; set; }
        [Column("Ext_Coat")]
        [StringLength(50)]
        public string? ExtCoat { get; set; }
        [Column("External Breadth", TypeName = "decimal(13, 4)")]
        public decimal? ExternalBreadth { get; set; }
        [Column("External Height", TypeName = "decimal(13, 4)")]
        public decimal? ExternalHeight { get; set; }
        [Column("External Length", TypeName = "decimal(13, 4)")]
        public decimal? ExternalLength { get; set; }
        [Column("Inspection Type")]
        [StringLength(10)]
        public string? InspectionType { get; set; }
        [Column("Internal Breadth", TypeName = "decimal(13, 4)")]
        public decimal? InternalBreadth { get; set; }
        [Column("Internal Height", TypeName = "decimal(13, 4)")]
        public decimal? InternalHeight { get; set; }
        [Column("Internal Length", TypeName = "decimal(13, 4)")]
        public decimal? InternalLength { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Last Inspection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastInspectionDate { get; set; }
        [Column("Lease Rate", TypeName = "decimal(16, 2)")]
        public decimal? LeaseRate { get; set; }
        [Column("Lease Term", TypeName = "decimal(16, 1)")]
        public decimal? LeaseTerm { get; set; }
        [StringLength(80)]
        public string? Lessor { get; set; }
        [Column("Lessor Code")]
        [StringLength(10)]
        public string? LessorCode { get; set; }
        [Column("Lessor Type")]
        [StringLength(10)]
        public string? LessorType { get; set; }
        [StringLength(70)]
        public string? Manufacturer { get; set; }
        [StringLength(70)]
        public string? Material { get; set; }
        [Column("Max_g_Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGWeight { get; set; }
        [Column("Max Payload", TypeName = "decimal(13, 4)")]
        public decimal? MaxPayload { get; set; }
        [Column("Name_of_File")]
        [StringLength(40)]
        public string? NameOfFile { get; set; }
        [Column("Next Inspection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextInspectionDate { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column("Off Hire Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? OffHireDateTime { get; set; }
        [Column("On Hire Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? OnHireDateTime { get; set; }
        [StringLength(40)]
        public string? Plate { get; set; }
        [Column("Principle Code")]
        [StringLength(10)]
        public string? PrincipleCode { get; set; }
        [Column("Principle Name")]
        [StringLength(80)]
        public string? PrincipleName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Replacement Value", TypeName = "decimal(16, 2)")]
        public decimal? ReplacementValue { get; set; }
        [Column("Tank Cat")]
        public int? TankCat { get; set; }
        [Column("Tare_Weight", TypeName = "decimal(13, 4)")]
        public decimal? TareWeight { get; set; }
        [Column("Test_press", TypeName = "decimal(5, 2)")]
        public decimal? TestPress { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Thickness { get; set; }
        [Column("Use Flag")]
        [StringLength(1)]
        public string? UseFlag { get; set; }
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
