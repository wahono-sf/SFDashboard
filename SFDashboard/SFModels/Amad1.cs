using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("amad1")]
    public partial class Amad1
    {
        public Amad1()
        {
            Amad2s = new HashSet<Amad2>();
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
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [InverseProperty("BusinessPartyCodeNavigation")]
        public virtual ICollection<Amad2> Amad2s { get; set; }
    }
}
