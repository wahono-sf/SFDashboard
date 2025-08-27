using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwPopo3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [StringLength(80)]
        public string? Comments { get; set; }
        [Column("Entered By")]
        [StringLength(50)]
        public string? EnteredBy { get; set; }
        [Column("Event Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EventDate { get; set; }
        [Column("Event Line No")]
        [StringLength(50)]
        public string? EventLineNo { get; set; }
        [Column("Event Title")]
        [StringLength(50)]
        public string? EventTitle { get; set; }
        [Column("PO Line")]
        public int? PoLine { get; set; }
        [Column("Create Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CreateDate { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
    }
}
