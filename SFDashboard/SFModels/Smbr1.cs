using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("smbr1")]
    public partial class Smbr1
    {
        public Smbr1()
        {
            Smbr2s = new HashSet<Smbr2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? BafRate { get; set; }
        [StringLength(50)]
        public string? BafUomCode { get; set; }
        [StringLength(3)]
        public string CurrCode { get; set; } = null!;
        [StringLength(3)]
        public string DestCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 3)")]
        public decimal? DdcRate { get; set; }
        [StringLength(50)]
        public string? DdcUomCode { get; set; }
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
        public virtual ICollection<Smbr2> Smbr2s { get; set; }
    }
}
