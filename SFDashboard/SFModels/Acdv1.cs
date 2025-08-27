using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("acdv1")]
    public partial class Acdv1
    {
        public Acdv1()
        {
            Aemp1s = new HashSet<Aemp1>();
            Plcp1s = new HashSet<Plcp1>();
            Rcsm1s = new HashSet<Rcsm1>();
            Semp1s = new HashSet<Semp1>();
            Sepi1s = new HashSet<Sepi1>();
            Sidi1s = new HashSet<Sidi1>();
            Sido1s = new HashSet<Sido1>();
            Slcu1s = new HashSet<Slcu1>();
        }

        [Key]
        [StringLength(10)]
        public string DivisionCode { get; set; } = null!;
        [StringLength(50)]
        public string? DivisionName { get; set; }
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

        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Aemp1> Aemp1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Plcp1> Plcp1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Rcsm1> Rcsm1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Semp1> Semp1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Sepi1> Sepi1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Sidi1> Sidi1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Sido1> Sido1s { get; set; }
        [InverseProperty("DivisionCodeNavigation")]
        public virtual ICollection<Slcu1> Slcu1s { get; set; }
    }
}
