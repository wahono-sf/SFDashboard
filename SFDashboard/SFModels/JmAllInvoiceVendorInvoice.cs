using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmAllInvoiceVendorInvoice
    {
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Vendor Invoice")]
        [StringLength(20)]
        public string? VendorInvoice { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Vendor Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? VendorInvoiceDate { get; set; }
        [Column("Job Type")]
        [StringLength(2)]
        public string? JobType { get; set; }
        [Column("Container No")]
        [StringLength(500)]
        public string? ContainerNo { get; set; }
        [Column("Vessel Code")]
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [Column("Awb Bl No")]
        [StringLength(20)]
        public string? AwbBlNo { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("DN USD Amt", TypeName = "decimal(13, 2)")]
        public decimal? DnUsdAmt { get; set; }
        [Column("CN USD Amt", TypeName = "decimal(13, 2)")]
        public decimal? CnUsdAmt { get; set; }
        [Column("Vendor CN/DN USD Amt", TypeName = "decimal(14, 2)")]
        public decimal? VendorCnDnUsdAmt { get; set; }
        [Column("Vendor Vat USD Amt", TypeName = "decimal(13, 2)")]
        public decimal? VendorVatUsdAmt { get; set; }
        [Column("Vendor DN/PV IDR Amt", TypeName = "decimal(14, 2)")]
        public decimal? VendorDnPvIdrAmt { get; set; }
        [Column("Invoice/DN IDR Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceDnIdrAmt { get; set; }
        [Column("Invoice Vat IDR Amt", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceVatIdrAmt { get; set; }
        [Column("CN IDR Amt", TypeName = "decimal(13, 2)")]
        public decimal? CnIdrAmt { get; set; }
        [Column("Vendor Invoice IDR Amt", TypeName = "decimal(14, 2)")]
        public decimal? VendorInvoiceIdrAmt { get; set; }
    }
}
