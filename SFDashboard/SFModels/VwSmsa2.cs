using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmsa2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [StringLength(1000)]
        public string? Action { get; set; }
        [StringLength(1000)]
        public string? Conclusion { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateTime { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3000)]
        public string? Discussion { get; set; }
        [Column("Quotation No")]
        [StringLength(20)]
        public string? QuotationNo { get; set; }
        [StringLength(25)]
        public string? Reference { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? Status { get; set; }
        [StringLength(5)]
        public string? Type { get; set; }
    }
}
