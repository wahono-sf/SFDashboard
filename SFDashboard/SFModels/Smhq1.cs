using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smhq1")]
    public partial class Smhq1
    {
        public Smhq1()
        {
            Smhq2s = new HashSet<Smhq2>();
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
        [InverseProperty("Smhq1s")]
        public virtual Smht1? QuotationTableNoNavigation { get; set; }
        [InverseProperty("CustomerCodeNavigation")]
        public virtual ICollection<Smhq2> Smhq2s { get; set; }
    }
}
