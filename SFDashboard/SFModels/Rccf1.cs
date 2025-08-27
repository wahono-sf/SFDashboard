using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rccf1")]
    public partial class Rccf1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(13)]
        public string ContainerNo { get; set; } = null!;
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [StringLength(9)]
        public string? Approvals { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Capacity { get; set; }
        [Column("Comm_Date", TypeName = "datetime")]
        public DateTime? CommDate { get; set; }
        [Column("Date_Manu", TypeName = "datetime")]
        public DateTime? DateManu { get; set; }
        [Column("Ext_Coat")]
        [StringLength(50)]
        public string? ExtCoat { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalBreadth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalLength { get; set; }
        [StringLength(10)]
        public string? InspectionType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalBreadth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalLength { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastInspectionDate { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? LeaseRate { get; set; }
        [Column(TypeName = "decimal(16, 1)")]
        public decimal? LeaseTerm { get; set; }
        [StringLength(80)]
        public string? Lessor { get; set; }
        [StringLength(10)]
        public string? LessorCode { get; set; }
        [StringLength(10)]
        public string? LessorType { get; set; }
        [StringLength(70)]
        public string? Manufacturer { get; set; }
        [StringLength(70)]
        public string? Material { get; set; }
        [Column("Max_g_Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxPayload { get; set; }
        [Column("Name_of_file")]
        [StringLength(40)]
        public string? NameOfFile { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextInspectionDate { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OnHireDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OffHireDateTime { get; set; }
        [StringLength(40)]
        public string? Plate { get; set; }
        [StringLength(10)]
        public string? PrincipleCode { get; set; }
        [StringLength(80)]
        public string? PrincipleName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ReplacementValue { get; set; }
        [Column("Tank_Cat")]
        public int? TankCat { get; set; }
        [Column("Tare_Weight", TypeName = "decimal(13, 4)")]
        public decimal? TareWeight { get; set; }
        [Column("Test_press", TypeName = "decimal(5, 2)")]
        public decimal? TestPress { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Thickness { get; set; }
        [StringLength(1)]
        public string? UseFlag { get; set; }
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
    }
}
