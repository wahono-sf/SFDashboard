using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smit1")]
    public partial class Smit1
    {
        public Smit1()
        {
            Smiq1s = new HashSet<Smiq1>();
            Smit2s = new HashSet<Smit2>();
        }

        [Key]
        [StringLength(5)]
        public string QuotationTableNo { get; set; } = null!;
        [StringLength(50)]
        public string? Description { get; set; }
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

        [InverseProperty("QuotationTableNoNavigation")]
        public virtual ICollection<Smiq1> Smiq1s { get; set; }
        [InverseProperty("QuotationTableNoNavigation")]
        public virtual ICollection<Smit2> Smit2s { get; set; }
    }
}
