using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glex1")]
    public partial class Glex1
    {
        public Glex1()
        {
            Amif1s = new HashSet<Amif1>();
            Asjd2s = new HashSet<Asjd2>();
            Asjd3s = new HashSet<Asjd3>();
            Glfb1s = new HashSet<Glfb1>();
            Glfv1s = new HashSet<Glfv1>();
            Glml1s = new HashSet<Glml1>();
            Glpa1s = new HashSet<Glpa1>();
            Ivch2s = new HashSet<Ivch2>();
            Ivcr2s = new HashSet<Ivcr2>();
            Omtx6s = new HashSet<Omtx6>();
            Plaj1s = new HashSet<Plaj1>();
            Plcp1s = new HashSet<Plcp1>();
            Plcs1s = new HashSet<Plcs1>();
            Pltx1s = new HashSet<Pltx1>();
            Plvx1s = new HashSet<Plvx1>();
            Sebk3s = new HashSet<Sebk3>();
            Secp1s = new HashSet<Secp1>();
            Sepa1s = new HashSet<Sepa1>();
            Sepi1s = new HashSet<Sepi1>();
            Sepi2s = new HashSet<Sepi2>();
            Slaj1s = new HashSet<Slaj1>();
            Slcs1s = new HashSet<Slcs1>();
            Smhq2s = new HashSet<Smhq2>();
            Smht2s = new HashSet<Smht2>();
            Smif1s = new HashSet<Smif1>();
            Ssjd1s = new HashSet<Ssjd1>();
        }

        [Key]
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [StringLength(30)]
        public string? CurrDescription { get; set; }
        [StringLength(30)]
        public string? LargeCurrName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? MarkupPercent { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(30)]
        public string? SmallCurrName { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? VariancePercent { get; set; }
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

        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Amif1> Amif1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Asjd2> Asjd2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Asjd3> Asjd3s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Glfb1> Glfb1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Glfv1> Glfv1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Glml1> Glml1s { get; set; }
        [InverseProperty("LocalCurrCodeNavigation")]
        public virtual ICollection<Glpa1> Glpa1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Ivch2> Ivch2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Ivcr2> Ivcr2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Omtx6> Omtx6s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Plaj1> Plaj1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Plcp1> Plcp1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Plcs1> Plcs1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Pltx1> Pltx1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Plvx1> Plvx1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Sebk3> Sebk3s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Secp1> Secp1s { get; set; }
        [InverseProperty("BlCurrCodeNavigation")]
        public virtual ICollection<Sepa1> Sepa1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Sepi1> Sepi1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Sepi2> Sepi2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Slaj1> Slaj1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Slcs1> Slcs1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Smhq2> Smhq2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Smht2> Smht2s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Smif1> Smif1s { get; set; }
        [InverseProperty("CurrCodeNavigation")]
        public virtual ICollection<Ssjd1> Ssjd1s { get; set; }
    }
}
