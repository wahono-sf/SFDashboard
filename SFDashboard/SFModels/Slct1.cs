using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("slct1")]
    public partial class Slct1
    {
        public Slct1()
        {
            Slcu1s = new HashSet<Slcu1>();
        }

        [Key]
        [StringLength(5)]
        public string CustomerType { get; set; } = null!;
        [StringLength(30)]
        public string? CustomerTypeName { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
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

        [InverseProperty("CustomerTypeNavigation")]
        public virtual ICollection<Slcu1> Slcu1s { get; set; }
    }
}
