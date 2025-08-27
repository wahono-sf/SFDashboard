using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smiq1")]
    public partial class Smiq1
    {
        public Smiq1()
        {
            Smiq2s = new HashSet<Smiq2>();
        }

        [Key]
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [StringLength(5)]
        public string? QuotationTableNo { get; set; }
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

        [ForeignKey("QuotationTableNo")]
        [InverseProperty("Smiq1s")]
        public virtual Smit1? QuotationTableNoNavigation { get; set; }
        [InverseProperty("CustomerCodeNavigation")]
        public virtual ICollection<Smiq2> Smiq2s { get; set; }
    }
}
