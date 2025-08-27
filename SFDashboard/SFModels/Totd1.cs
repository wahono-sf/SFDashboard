using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("totd1")]
    public partial class Totd1
    {
        public Totd1()
        {
            Totd2s = new HashSet<Totd2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string? AdditionalInstruction1 { get; set; }
        [StringLength(50)]
        public string? AdditionalInstruction2 { get; set; }
        [StringLength(50)]
        public string? AdditionalInstruction3 { get; set; }
        [StringLength(10)]
        public string? BookingNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [StringLength(13)]
        public string? ContainerRefNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
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
        public virtual ICollection<Totd2> Totd2s { get; set; }
    }
}
