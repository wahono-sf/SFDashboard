using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class ImPurchaseOrder
    {
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? Name { get; set; }
        [Column("Order Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OrderDate { get; set; }
        [Column("PO No")]
        [StringLength(20)]
        public string? PoNo { get; set; }
        [Column("ETA")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Eta { get; set; }
        [Column("Vendor Code")]
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [Column("Vendor Name")]
        [StringLength(80)]
        public string? VendorName { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        [Column("Company Code")]
        [StringLength(50)]
        public string? CompanyCode { get; set; }
        [Column("Rcv Date")]
        [StringLength(50)]
        public string? RcvDate { get; set; }
        public int? TrxNo { get; set; }
        public short? LineItemNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Amt { get; set; }
        public int? BalanceQty { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(13, 6)")]
        public decimal? CurrRate { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? ItemType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LocalAmt { get; set; }
        [StringLength(24)]
        public string? ProductCode { get; set; }
        public int? Qty { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitPrice { get; set; }
        [StringLength(24)]
        public string? VendorProductCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
    }
}
