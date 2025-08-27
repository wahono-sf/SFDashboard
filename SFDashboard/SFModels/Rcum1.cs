using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcum1")]
    public partial class Rcum1
    {
        public Rcum1()
        {
            Ivch2s = new HashSet<Ivch2>();
            Ivcr2s = new HashSet<Ivcr2>();
            Omtx6s = new HashSet<Omtx6>();
            Sebh2s = new HashSet<Sebh2>();
            Sebk2s = new HashSet<Sebk2>();
            Sebk3s = new HashSet<Sebk3>();
            Semp2s = new HashSet<Semp2>();
            Sepi2s = new HashSet<Sepi2>();
            Sidi2s = new HashSet<Sidi2>();
            Sido2s = new HashSet<Sido2>();
            Smhq2s = new HashSet<Smhq2>();
            Smht2s = new HashSet<Smht2>();
            Smiq2s = new HashSet<Smiq2>();
            Smit2s = new HashSet<Smit2>();
            Smpa1DefineUomCode01Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode02Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode03Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode04Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode05Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode06Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode07Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode08Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode09Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode10Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode11Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode12Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode13Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode14Navigations = new HashSet<Smpa1>();
            Smpa1DefineUomCode15Navigations = new HashSet<Smpa1>();
            Todo2s = new HashSet<Todo2>();
            Whpa1s = new HashSet<Whpa1>();
            Whwh1s = new HashSet<Whwh1>();
        }

        [Key]
        [StringLength(50)]
        public string UomCode { get; set; } = null!;
        [StringLength(50)]
        public string? UomDescription { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? ConversionFactor { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? UomType { get; set; }
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

        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Ivch2> Ivch2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Omtx6> Omtx6s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sebh2> Sebh2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sebk2> Sebk2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sebk3> Sebk3s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Semp2> Semp2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sepi2> Sepi2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sidi2> Sidi2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Sido2> Sido2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Smhq2> Smhq2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Smht2> Smht2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Smiq2> Smiq2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Smit2> Smit2s { get; set; }
        [InverseProperty("DefineUomCode01Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode01Navigations { get; set; }
        [InverseProperty("DefineUomCode02Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode02Navigations { get; set; }
        [InverseProperty("DefineUomCode03Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode03Navigations { get; set; }
        [InverseProperty("DefineUomCode04Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode04Navigations { get; set; }
        [InverseProperty("DefineUomCode05Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode05Navigations { get; set; }
        [InverseProperty("DefineUomCode06Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode06Navigations { get; set; }
        [InverseProperty("DefineUomCode07Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode07Navigations { get; set; }
        [InverseProperty("DefineUomCode08Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode08Navigations { get; set; }
        [InverseProperty("DefineUomCode09Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode09Navigations { get; set; }
        [InverseProperty("DefineUomCode10Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode10Navigations { get; set; }
        [InverseProperty("DefineUomCode11Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode11Navigations { get; set; }
        [InverseProperty("DefineUomCode12Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode12Navigations { get; set; }
        [InverseProperty("DefineUomCode13Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode13Navigations { get; set; }
        [InverseProperty("DefineUomCode14Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode14Navigations { get; set; }
        [InverseProperty("DefineUomCode15Navigation")]
        public virtual ICollection<Smpa1> Smpa1DefineUomCode15Navigations { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Todo2> Todo2s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Whpa1> Whpa1s { get; set; }
        [InverseProperty("UomCodeNavigation")]
        public virtual ICollection<Whwh1> Whwh1s { get; set; }
    }
}
