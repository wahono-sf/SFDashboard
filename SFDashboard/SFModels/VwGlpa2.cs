using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwGlpa2
    {
        [Column("Financial Year")]
        public short FinancialYear { get; set; }
        [Column("Close Mth 01 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth01GlFlag { get; set; }
        [Column("Close Mth 02 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth02GlFlag { get; set; }
        [Column("Close Mth 03 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth03GlFlag { get; set; }
        [Column("Close Mth 04 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth04GlFlag { get; set; }
        [Column("Close Mth 05 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth05GlFlag { get; set; }
        [Column("Close Mth 06 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth06GlFlag { get; set; }
        [Column("Close Mth 07 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth07GlFlag { get; set; }
        [Column("Close Mth 08 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth08GlFlag { get; set; }
        [Column("Close Mth 09 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth09GlFlag { get; set; }
        [Column("Close Mth 10 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth10GlFlag { get; set; }
        [Column("Close Mth 11 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth11GlFlag { get; set; }
        [Column("Close Mth 12 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth12GlFlag { get; set; }
        [Column("Close Mth 13 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth13GlFlag { get; set; }
        [Column("Close Mth 14 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth14GlFlag { get; set; }
        [Column("Close Mth 15 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth15GlFlag { get; set; }
        [Column("Close Mth 16 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth16GlFlag { get; set; }
        [Column("Close Mth 17 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth17GlFlag { get; set; }
        [Column("Close Mth 18 Gl Flag")]
        [StringLength(1)]
        public string? CloseMth18GlFlag { get; set; }
        [Column("Close Mth 01 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth01JmFlag { get; set; }
        [Column("Close Mth 02 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth02JmFlag { get; set; }
        [Column("Close Mth 03 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth03JmFlag { get; set; }
        [Column("Close Mth 04 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth04JmFlag { get; set; }
        [Column("Close Mth 05 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth05JmFlag { get; set; }
        [Column("Close Mth 06 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth06JmFlag { get; set; }
        [Column("Close Mth 07 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth07JmFlag { get; set; }
        [Column("Close Mth 08 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth08JmFlag { get; set; }
        [Column("Close Mth 09 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth09JmFlag { get; set; }
        [Column("Close Mth 10 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth10JmFlag { get; set; }
        [Column("Close Mth 11 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth11JmFlag { get; set; }
        [Column("Close Mth 12 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth12JmFlag { get; set; }
        [Column("Close Mth 13 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth13JmFlag { get; set; }
        [Column("Close Mth 14 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth14JmFlag { get; set; }
        [Column("Close Mth 15 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth15JmFlag { get; set; }
        [Column("Close Mth 16 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth16JmFlag { get; set; }
        [Column("Close Mth 17 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth17JmFlag { get; set; }
        [Column("Close Mth 18 Jm Flag")]
        [StringLength(1)]
        public string? CloseMth18JmFlag { get; set; }
        [Column("Close Mth 01 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth01PlFlag { get; set; }
        [Column("Close Mth 02 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth02PlFlag { get; set; }
        [Column("Close Mth 03 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth03PlFlag { get; set; }
        [Column("Close Mth 04 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth04PlFlag { get; set; }
        [Column("Close Mth 05 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth05PlFlag { get; set; }
        [Column("Close Mth 06 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth06PlFlag { get; set; }
        [Column("Close Mth 07 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth07PlFlag { get; set; }
        [Column("Close Mth 08 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth08PlFlag { get; set; }
        [Column("Close Mth 09 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth09PlFlag { get; set; }
        [Column("Close Mth 10 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth10PlFlag { get; set; }
        [Column("Close Mth 11 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth11PlFlag { get; set; }
        [Column("Close Mth 12 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth12PlFlag { get; set; }
        [Column("Close Mth 13 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth13PlFlag { get; set; }
        [Column("Close Mth 14 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth14PlFlag { get; set; }
        [Column("Close Mth 15 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth15PlFlag { get; set; }
        [Column("Close Mth 16 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth16PlFlag { get; set; }
        [Column("Close Mth 17 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth17PlFlag { get; set; }
        [Column("Close Mth 18 Pl Flag")]
        [StringLength(1)]
        public string? CloseMth18PlFlag { get; set; }
        [Column("Close Mth 01 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth01SlFlag { get; set; }
        [Column("Close Mth 02 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth02SlFlag { get; set; }
        [Column("Close Mth 03 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth03SlFlag { get; set; }
        [Column("Close Mth 04 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth04SlFlag { get; set; }
        [Column("Close Mth 05 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth05SlFlag { get; set; }
        [Column("Close Mth 06 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth06SlFlag { get; set; }
        [Column("Close Mth 07 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth07SlFlag { get; set; }
        [Column("Close Mth 08 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth08SlFlag { get; set; }
        [Column("Close Mth 09 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth09SlFlag { get; set; }
        [Column("Close Mth 10 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth10SlFlag { get; set; }
        [Column("Close Mth 11 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth11SlFlag { get; set; }
        [Column("Close Mth 12 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth12SlFlag { get; set; }
        [Column("Close Mth 13 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth13SlFlag { get; set; }
        [Column("Close Mth 14 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth14SlFlag { get; set; }
        [Column("Close Mth 15 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth15SlFlag { get; set; }
        [Column("Close Mth 16 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth16SlFlag { get; set; }
        [Column("Close Mth 17 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth17SlFlag { get; set; }
        [Column("Close Mth 18 Sl Flag")]
        [StringLength(1)]
        public string? CloseMth18SlFlag { get; set; }
        [Column("Close Year Flag")]
        [StringLength(1)]
        public string? CloseYearFlag { get; set; }
        [Column("Mth 01 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth01FromDate { get; set; }
        [Column("Mth 01To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth01toDate { get; set; }
        [Column("Mth 02 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth02FromDate { get; set; }
        [Column("Mth 02 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth02ToDate { get; set; }
        [Column("Mth 03 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth03FromDate { get; set; }
        [Column("Mth 03 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth03ToDate { get; set; }
        [Column("Mth 04 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth04FromDate { get; set; }
        [Column("Mth 04 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth04ToDate { get; set; }
        [Column("Mth 05 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth05FromDate { get; set; }
        [Column("Mth 05 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth05ToDate { get; set; }
        [Column("Mth 06 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth06FromDate { get; set; }
        [Column("Mth 06 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth06ToDate { get; set; }
        [Column("Mth 07 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth07FromDate { get; set; }
        [Column("Mth 07 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth07ToDate { get; set; }
        [Column("Mth 08 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth08FromDate { get; set; }
        [Column("Mth 08 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth08ToDate { get; set; }
        [Column("Mth 09 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth09FromDate { get; set; }
        [Column("Mth 09 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth09ToDate { get; set; }
        [Column("Mth 10 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth10FromDate { get; set; }
        [Column("Mth 10 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth10ToDate { get; set; }
        [Column("Mth 11 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth11FromDate { get; set; }
        [Column("Mth 11 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth11ToDate { get; set; }
        [Column("Mth 12 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth12FromDate { get; set; }
        [Column("Mth 12 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth12ToDate { get; set; }
        [Column("Mth 13 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth13FromDate { get; set; }
        [Column("Mth 13 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth13ToDate { get; set; }
        [Column("Mth 14 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth14FromDate { get; set; }
        [Column("Mth 14 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth14ToDate { get; set; }
        [Column("Mth 15 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth15FromDate { get; set; }
        [Column("Mth 15 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth15ToDate { get; set; }
        [Column("Mth 16 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth16FromDate { get; set; }
        [Column("Mth 16 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth16ToDate { get; set; }
        [Column("Mth 17 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth17FromDate { get; set; }
        [Column("Mth 17 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth17ToDate { get; set; }
        [Column("Mth 18 From Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth18FromDate { get; set; }
        [Column("Mth 18 To Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Mth18ToDate { get; set; }
        [Column("Vat Average Refund Rate", TypeName = "decimal(10, 3)")]
        public decimal? VatAverageRefundRate { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
