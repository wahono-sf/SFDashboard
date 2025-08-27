using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("torl1")]
    public partial class Torl1
    {
        public Torl1()
        {
            Toct1ConfirmCurrentParkAtNavigations = new HashSet<Toct1>();
            Toct1ConfirmLastParkAtNavigations = new HashSet<Toct1>();
            Toct1PlanCurrentParkAtNavigations = new HashSet<Toct1>();
            Toct1PlanLastParkAtNavigations = new HashSet<Toct1>();
            Totd2s = new HashSet<Totd2>();
            Tovl1ConfirmedCurrentParkAtNavigations = new HashSet<Tovl1>();
            Tovl1ConfirmedLastParkAtNavigations = new HashSet<Tovl1>();
            Tovl1PlanCurrentParkAtNavigations = new HashSet<Tovl1>();
            Tovl1PlanLastParkAtNavigations = new HashSet<Tovl1>();
        }

        [Key]
        [StringLength(10)]
        public string ReleaseCode { get; set; } = null!;
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(10)]
        public string? DistrictCode { get; set; }
        [StringLength(50)]
        public string? ReleaseName1 { get; set; }
        [StringLength(50)]
        public string? ReleaseName2 { get; set; }
        [StringLength(50)]
        public string? ReleaseAddress1 { get; set; }
        [StringLength(50)]
        public string? ReleaseAddress2 { get; set; }
        [StringLength(50)]
        public string? ReleaseAddress3 { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string? ZoneCode { get; set; }
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

        [InverseProperty("ConfirmCurrentParkAtNavigation")]
        public virtual ICollection<Toct1> Toct1ConfirmCurrentParkAtNavigations { get; set; }
        [InverseProperty("ConfirmLastParkAtNavigation")]
        public virtual ICollection<Toct1> Toct1ConfirmLastParkAtNavigations { get; set; }
        [InverseProperty("PlanCurrentParkAtNavigation")]
        public virtual ICollection<Toct1> Toct1PlanCurrentParkAtNavigations { get; set; }
        [InverseProperty("PlanLastParkAtNavigation")]
        public virtual ICollection<Toct1> Toct1PlanLastParkAtNavigations { get; set; }
        [InverseProperty("ParkingPlaceNavigation")]
        public virtual ICollection<Totd2> Totd2s { get; set; }
        [InverseProperty("ConfirmedCurrentParkAtNavigation")]
        public virtual ICollection<Tovl1> Tovl1ConfirmedCurrentParkAtNavigations { get; set; }
        [InverseProperty("ConfirmedLastParkAtNavigation")]
        public virtual ICollection<Tovl1> Tovl1ConfirmedLastParkAtNavigations { get; set; }
        [InverseProperty("PlanCurrentParkAtNavigation")]
        public virtual ICollection<Tovl1> Tovl1PlanCurrentParkAtNavigations { get; set; }
        [InverseProperty("PlanLastParkAtNavigation")]
        public virtual ICollection<Tovl1> Tovl1PlanLastParkAtNavigations { get; set; }
    }
}
