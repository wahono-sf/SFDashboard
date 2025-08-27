using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smef1")]
    public partial class Smef1
    {
        public Smef1()
        {
            Smef2s = new HashSet<Smef2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BafRate { get; set; }
        [StringLength(50)]
        public string? BafUomCode { get; set; }
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? DdcRate { get; set; }
        [StringLength(50)]
        public string? DdcUomCode { get; set; }
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [StringLength(3)]
        public string OriginCode { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(5)]
        public string Via { get; set; } = null!;
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
        public virtual ICollection<Smef2> Smef2s { get; set; }
    }
}
