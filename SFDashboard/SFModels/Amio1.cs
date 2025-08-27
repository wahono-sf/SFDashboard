using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amio1")]
    public partial class Amio1
    {
        public Amio1()
        {
            Amid1s = new HashSet<Amid1>();
            Amio2s = new HashSet<Amio2>();
        }

        [Key]
        [StringLength(5)]
        public string QuoteTableNo { get; set; } = null!;
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

        [InverseProperty("QuoteTableNoNavigation")]
        public virtual ICollection<Amid1> Amid1s { get; set; }
        [InverseProperty("QuoteTableNoNavigation")]
        public virtual ICollection<Amio2> Amio2s { get; set; }
    }
}
