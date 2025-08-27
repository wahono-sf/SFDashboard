using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tovt1")]
    public partial class Tovt1
    {
        public Tovt1()
        {
            Totd2s = new HashSet<Totd2>();
            Tovl1s = new HashSet<Tovl1>();
        }

        [Key]
        [StringLength(6)]
        public string VehicleType { get; set; } = null!;
        [StringLength(255)]
        public string? VehicleTypeDescription { get; set; }
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

        [InverseProperty("VehicleTypeNavigation")]
        public virtual ICollection<Totd2> Totd2s { get; set; }
        [InverseProperty("VehicleTypeNavigation")]
        public virtual ICollection<Tovl1> Tovl1s { get; set; }
    }
}
