using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmce3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item")]
        public int LineItem { get; set; }
        [StringLength(3)]
        public string? Code { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Doc Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DocDate { get; set; }
        [Column("Reference No")]
        [StringLength(50)]
        public string? ReferenceNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? Station { get; set; }
        [Column("Type Of Date")]
        [StringLength(1)]
        public string? TypeOfDate { get; set; }
    }
}
