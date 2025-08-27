using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn4
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Casc Code 1")]
        [StringLength(35)]
        public string? CascCode1 { get; set; }
        [Column("Casc Code 2")]
        [StringLength(35)]
        public string? CascCode2 { get; set; }
        [Column("Casc Code 3")]
        [StringLength(35)]
        public string? CascCode3 { get; set; }
        [Column("Casc Line Item No")]
        public short CascLineItemNo { get; set; }
        [Column("Casc Seq No")]
        public short? CascSeqNo { get; set; }
        [Column("Product Line Item No")]
        public short ProductLineItemNo { get; set; }
    }
}
