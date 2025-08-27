using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smht1")]
    public partial class Smht1
    {
        public Smht1()
        {
            Smhq1s = new HashSet<Smhq1>();
            Smht2s = new HashSet<Smht2>();
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
        public virtual ICollection<Smhq1> Smhq1s { get; set; }
        [InverseProperty("QuotationTableNoNavigation")]
        public virtual ICollection<Smht2> Smht2s { get; set; }
    }
}
