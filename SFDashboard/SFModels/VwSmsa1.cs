using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSmsa1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Closed Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ClosedDate { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
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
        [Column("Est Sales Amt", TypeName = "decimal(13, 2)")]
        public decimal? EstSalesAmt { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(250)]
        public string? Note { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Salesman Code")]
        [StringLength(10)]
        public string SalesmanCode { get; set; } = null!;
        [StringLength(20)]
        public string? Stage { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [Column("Created By")]
        [StringLength(50)]
        public string CreatedBy { get; set; } = null!;
        [Column("Created At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CreatedAt { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string UpdatedBy { get; set; } = null!;
        [Column("Updated At")]
        [StringLength(16)]
        [Unicode(false)]
        public string? UpdatedAt { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
    }
}
