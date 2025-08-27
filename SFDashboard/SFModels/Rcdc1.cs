using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcdc1")]
    public partial class Rcdc1
    {
        public Rcdc1()
        {
            Amdc1s = new HashSet<Amdc1>();
        }

        [Key]
        [StringLength(5)]
        public string DistrictCode { get; set; } = null!;
        [StringLength(50)]
        public string? DistrictName { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
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

        [InverseProperty("DistrictCodeNavigation")]
        public virtual ICollection<Amdc1> Amdc1s { get; set; }
    }
}
