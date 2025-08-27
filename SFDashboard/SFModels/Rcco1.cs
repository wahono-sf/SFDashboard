using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcco1")]
    public partial class Rcco1
    {
        public Rcco1()
        {
            Semp2s = new HashSet<Semp2>();
            Sidi2s = new HashSet<Sidi2>();
            Sido2s = new HashSet<Sido2>();
            Smec2ContainerType01Navigations = new HashSet<Smec2>();
            Smec2ContainerType02Navigations = new HashSet<Smec2>();
            Smec2ContainerType03Navigations = new HashSet<Smec2>();
            Smec2ContainerType04Navigations = new HashSet<Smec2>();
            Smec2ContainerType05Navigations = new HashSet<Smec2>();
            Smec2ContainerType06Navigations = new HashSet<Smec2>();
            Smec2ContainerType07Navigations = new HashSet<Smec2>();
            Smec2ContainerType08Navigations = new HashSet<Smec2>();
            Smec2ContainerType09Navigations = new HashSet<Smec2>();
            Smec2ContainerType10Navigations = new HashSet<Smec2>();
            Smec2ContainerType11Navigations = new HashSet<Smec2>();
            Smec2ContainerType12Navigations = new HashSet<Smec2>();
            Smec2ContainerType13Navigations = new HashSet<Smec2>();
            Smec2ContainerType14Navigations = new HashSet<Smec2>();
            Smec2ContainerType15Navigations = new HashSet<Smec2>();
            Todo2s = new HashSet<Todo2>();
        }

        [Key]
        [StringLength(5)]
        public string ContainerType { get; set; } = null!;
        [StringLength(50)]
        public string? ContainerDescription { get; set; }
        [StringLength(2)]
        public string? ContainerSize { get; set; }
        [Column(TypeName = "ntext")]
        public string? Approvals { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Capacity { get; set; }
        [Column("Ext_Coat")]
        [StringLength(50)]
        public string? ExtCoat { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalBreadth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExternalLength { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalBreadth { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalHeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InternalLength { get; set; }
        [StringLength(2)]
        public string? IsoSize { get; set; }
        [StringLength(70)]
        public string? Material { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxCubicFt { get; set; }
        [Column("Max_G_Weight", TypeName = "decimal(13, 4)")]
        public decimal? MaxGWeight { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxPayload { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? MaxWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NoOfTeu { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(70)]
        public string? Stacking { get; set; }
        [Column("Tare_Weight", TypeName = "decimal(13, 4)")]
        public decimal? TareWeight { get; set; }
        [StringLength(20)]
        public string? TemperatureDegree { get; set; }
        [StringLength(1)]
        public string? TemperatureFlag { get; set; }
        [Column("Test_Press", TypeName = "decimal(5, 2)")]
        public decimal? TestPress { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Thickness { get; set; }
        [Column("Work_Press", TypeName = "decimal(5, 2)")]
        public decimal? WorkPress { get; set; }
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

        [InverseProperty("ContainerTypeNavigation")]
        public virtual ICollection<Semp2> Semp2s { get; set; }
        [InverseProperty("ContainerTypeNavigation")]
        public virtual ICollection<Sidi2> Sidi2s { get; set; }
        [InverseProperty("ContainerTypeNavigation")]
        public virtual ICollection<Sido2> Sido2s { get; set; }
        [InverseProperty("ContainerType01Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType01Navigations { get; set; }
        [InverseProperty("ContainerType02Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType02Navigations { get; set; }
        [InverseProperty("ContainerType03Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType03Navigations { get; set; }
        [InverseProperty("ContainerType04Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType04Navigations { get; set; }
        [InverseProperty("ContainerType05Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType05Navigations { get; set; }
        [InverseProperty("ContainerType06Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType06Navigations { get; set; }
        [InverseProperty("ContainerType07Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType07Navigations { get; set; }
        [InverseProperty("ContainerType08Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType08Navigations { get; set; }
        [InverseProperty("ContainerType09Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType09Navigations { get; set; }
        [InverseProperty("ContainerType10Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType10Navigations { get; set; }
        [InverseProperty("ContainerType11Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType11Navigations { get; set; }
        [InverseProperty("ContainerType12Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType12Navigations { get; set; }
        [InverseProperty("ContainerType13Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType13Navigations { get; set; }
        [InverseProperty("ContainerType14Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType14Navigations { get; set; }
        [InverseProperty("ContainerType15Navigation")]
        public virtual ICollection<Smec2> Smec2ContainerType15Navigations { get; set; }
        [InverseProperty("ContainerTypeNavigation")]
        public virtual ICollection<Todo2> Todo2s { get; set; }
    }
}
