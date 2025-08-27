using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("whbt1")]
    public partial class Whbt1
    {
        public Whbt1()
        {
            Whbt2s = new HashSet<Whbt2>();
        }

        [Key]
        [StringLength(5)]
        public string TableNo { get; set; } = null!;
        [StringLength(50)]
        public string? Description { get; set; }
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

        [InverseProperty("TableNoNavigation")]
        public virtual ICollection<Whbt2> Whbt2s { get; set; }
    }
}
