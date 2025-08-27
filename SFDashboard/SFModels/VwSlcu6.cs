using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSlcu6
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public int LineItemNo { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [Column("Effective Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EffectiveDate { get; set; }
        [Column("Expiry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExpiryDate { get; set; }
    }
}
