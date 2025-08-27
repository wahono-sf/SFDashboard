using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rccm1")]
    public partial class Rccm1
    {
        public Rccm1()
        {
            Amac1CommodityCode01Navigations = new HashSet<Amac1>();
            Amac1CommodityCode02Navigations = new HashSet<Amac1>();
            Amac1CommodityCode03Navigations = new HashSet<Amac1>();
            Amac1CommodityCode04Navigations = new HashSet<Amac1>();
            Amac1CommodityCode05Navigations = new HashSet<Amac1>();
            Amac1CommodityCode06Navigations = new HashSet<Amac1>();
            Amac1CommodityCode07Navigations = new HashSet<Amac1>();
            Amac1CommodityCode08Navigations = new HashSet<Amac1>();
            Amac1CommodityCode09Navigations = new HashSet<Amac1>();
            Amac1CommodityCode10Navigations = new HashSet<Amac1>();
            Amac1CommodityCode11Navigations = new HashSet<Amac1>();
            Amac1CommodityCode12Navigations = new HashSet<Amac1>();
            Amac1CommodityCode13Navigations = new HashSet<Amac1>();
            Amac1CommodityCode14Navigations = new HashSet<Amac1>();
            Amac1CommodityCode15Navigations = new HashSet<Amac1>();
            Amac1CommodityCode16Navigations = new HashSet<Amac1>();
            Amac1CommodityCode17Navigations = new HashSet<Amac1>();
            Amac1CommodityCode18Navigations = new HashSet<Amac1>();
            Amac1CommodityCode19Navigations = new HashSet<Amac1>();
            Amac1CommodityCode20Navigations = new HashSet<Amac1>();
            Amif1CommodityCode01Navigations = new HashSet<Amif1>();
            Amif1CommodityCode02Navigations = new HashSet<Amif1>();
            Amif1CommodityCode03Navigations = new HashSet<Amif1>();
            Amif1CommodityCode04Navigations = new HashSet<Amif1>();
            Amif1CommodityCode05Navigations = new HashSet<Amif1>();
            Amif1CommodityCode06Navigations = new HashSet<Amif1>();
            Amif1CommodityCode07Navigations = new HashSet<Amif1>();
            Amif1CommodityCode08Navigations = new HashSet<Amif1>();
            Amif1CommodityCode09Navigations = new HashSet<Amif1>();
            Amif1CommodityCode10Navigations = new HashSet<Amif1>();
            Amif1CommodityCode11Navigations = new HashSet<Amif1>();
            Amif1CommodityCode12Navigations = new HashSet<Amif1>();
            Amif1CommodityCode13Navigations = new HashSet<Amif1>();
            Amif1CommodityCode14Navigations = new HashSet<Amif1>();
            Amif1CommodityCode15Navigations = new HashSet<Amif1>();
            Amif1CommodityCode16Navigations = new HashSet<Amif1>();
            Amif1CommodityCode17Navigations = new HashSet<Amif1>();
            Amif1CommodityCode18Navigations = new HashSet<Amif1>();
            Amif1CommodityCode19Navigations = new HashSet<Amif1>();
            Amif1CommodityCode20Navigations = new HashSet<Amif1>();
            Sidi1s = new HashSet<Sidi1>();
            Smec2s = new HashSet<Smec2>();
            Smic2s = new HashSet<Smic2>();
            Smif2s = new HashSet<Smif2>();
        }

        [Key]
        [StringLength(50)]
        public string CommodityCode { get; set; } = null!;
        [StringLength(12)]
        public string? CasNo { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [StringLength(255)]
        public string? ChemicalComposition { get; set; }
        [StringLength(50)]
        public string? CommodityType { get; set; }
        [StringLength(50)]
        public string? Density { get; set; }
        [StringLength(1)]
        public string? DgPackingGroup { get; set; }
        [StringLength(1)]
        public string? DutiableFlag { get; set; }
        [StringLength(20)]
        public string? FlashPoint { get; set; }
        [Column("FOSFAFlag")]
        [StringLength(1)]
        public string? Fosfaflag { get; set; }
        [Column("IMCO")]
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("KOSHERFlag")]
        [StringLength(1)]
        public string? Kosherflag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("UNNo")]
        [StringLength(20)]
        public string? Unno { get; set; }
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

        [InverseProperty("CommodityCode01Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode01Navigations { get; set; }
        [InverseProperty("CommodityCode02Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode02Navigations { get; set; }
        [InverseProperty("CommodityCode03Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode03Navigations { get; set; }
        [InverseProperty("CommodityCode04Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode04Navigations { get; set; }
        [InverseProperty("CommodityCode05Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode05Navigations { get; set; }
        [InverseProperty("CommodityCode06Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode06Navigations { get; set; }
        [InverseProperty("CommodityCode07Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode07Navigations { get; set; }
        [InverseProperty("CommodityCode08Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode08Navigations { get; set; }
        [InverseProperty("CommodityCode09Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode09Navigations { get; set; }
        [InverseProperty("CommodityCode10Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode10Navigations { get; set; }
        [InverseProperty("CommodityCode11Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode11Navigations { get; set; }
        [InverseProperty("CommodityCode12Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode12Navigations { get; set; }
        [InverseProperty("CommodityCode13Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode13Navigations { get; set; }
        [InverseProperty("CommodityCode14Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode14Navigations { get; set; }
        [InverseProperty("CommodityCode15Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode15Navigations { get; set; }
        [InverseProperty("CommodityCode16Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode16Navigations { get; set; }
        [InverseProperty("CommodityCode17Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode17Navigations { get; set; }
        [InverseProperty("CommodityCode18Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode18Navigations { get; set; }
        [InverseProperty("CommodityCode19Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode19Navigations { get; set; }
        [InverseProperty("CommodityCode20Navigation")]
        public virtual ICollection<Amac1> Amac1CommodityCode20Navigations { get; set; }
        [InverseProperty("CommodityCode01Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode01Navigations { get; set; }
        [InverseProperty("CommodityCode02Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode02Navigations { get; set; }
        [InverseProperty("CommodityCode03Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode03Navigations { get; set; }
        [InverseProperty("CommodityCode04Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode04Navigations { get; set; }
        [InverseProperty("CommodityCode05Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode05Navigations { get; set; }
        [InverseProperty("CommodityCode06Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode06Navigations { get; set; }
        [InverseProperty("CommodityCode07Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode07Navigations { get; set; }
        [InverseProperty("CommodityCode08Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode08Navigations { get; set; }
        [InverseProperty("CommodityCode09Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode09Navigations { get; set; }
        [InverseProperty("CommodityCode10Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode10Navigations { get; set; }
        [InverseProperty("CommodityCode11Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode11Navigations { get; set; }
        [InverseProperty("CommodityCode12Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode12Navigations { get; set; }
        [InverseProperty("CommodityCode13Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode13Navigations { get; set; }
        [InverseProperty("CommodityCode14Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode14Navigations { get; set; }
        [InverseProperty("CommodityCode15Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode15Navigations { get; set; }
        [InverseProperty("CommodityCode16Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode16Navigations { get; set; }
        [InverseProperty("CommodityCode17Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode17Navigations { get; set; }
        [InverseProperty("CommodityCode18Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode18Navigations { get; set; }
        [InverseProperty("CommodityCode19Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode19Navigations { get; set; }
        [InverseProperty("CommodityCode20Navigation")]
        public virtual ICollection<Amif1> Amif1CommodityCode20Navigations { get; set; }
        [InverseProperty("CommodityCodeNavigation")]
        public virtual ICollection<Sidi1> Sidi1s { get; set; }
        [InverseProperty("CommodityCodeNavigation")]
        public virtual ICollection<Smec2> Smec2s { get; set; }
        [InverseProperty("CommodityCodeNavigation")]
        public virtual ICollection<Smic2> Smic2s { get; set; }
        [InverseProperty("CommodityCodeNavigation")]
        public virtual ICollection<Smif2> Smif2s { get; set; }
    }
}
