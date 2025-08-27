using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amid1")]
    public partial class Amid1
    {
        public Amid1()
        {
            Amid2s = new HashSet<Amid2>();
        }

        [Key]
        [StringLength(10)]
        public string BusinessPartyCode { get; set; } = null!;
        [StringLength(5)]
        public string? QuoteTableNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("QuoteTableNo")]
        [InverseProperty("Amid1s")]
        public virtual Amio1? QuoteTableNoNavigation { get; set; }
        [InverseProperty("BusinessPartyCodeNavigation")]
        public virtual ICollection<Amid2> Amid2s { get; set; }
    }
}
