using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("glpa2")]
    public partial class Glpa2
    {
        [Key]
        public short FinancialYear { get; set; }
        [StringLength(1)]
        public string? CloseMth01GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth02GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth03GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth04GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth05GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth06GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth07GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth08GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth09GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth10GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth11GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth12GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth13GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth14GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth15GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth16GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth17GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth18GlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth01JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth02JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth03JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth04JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth05JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth06JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth07JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth08JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth09JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth10JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth11JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth12JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth13JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth14JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth15JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth16JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth17JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth18JmFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth01PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth02PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth03PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth04PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth05PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth06PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth07PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth08PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth09PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth10PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth11PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth12PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth13PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth14PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth15PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth16PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth17PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth18PlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth01SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth02SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth03SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth04SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth05SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth06SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth07SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth08SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth09SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth10SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth11SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth12SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth13SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth14SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth15SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth16SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth17SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseMth18SlFlag { get; set; }
        [StringLength(1)]
        public string? CloseYearFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth01FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth01ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth02FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth02ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth03FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth03ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth04FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth04ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth05FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth05ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth06FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth06ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth07FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth07ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth08FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth08ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth09FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth09ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth10FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth10ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth11FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth11ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth12FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth12ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth13FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth13ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth14FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth14ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth15FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth15ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth16FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth16ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth17FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth17ToDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth18FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Mth18ToDate { get; set; }
        [Column(TypeName = "decimal(10, 3)")]
        public decimal? VatAverageRefundRate { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
    }
}
