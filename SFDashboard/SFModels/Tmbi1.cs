using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("tmbi1")]
    public partial class Tmbi1
    {
        public Tmbi1()
        {
            Tmbi2s = new HashSet<Tmbi2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(5)]
        public string? CargoType { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Tmbi2> Tmbi2s { get; set; }
    }
}
