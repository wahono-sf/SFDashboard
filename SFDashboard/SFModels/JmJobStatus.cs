using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class JmJobStatus
    {
        [Column("Job No")]
        [StringLength(30)]
        public string JobNo { get; set; } = null!;
        [Column("Booking Create Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingCreateDate { get; set; }
        [Column("Booking Confirmation Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? BookingConfirmationDate { get; set; }
        [Column("Cargo Pickup Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CargoPickupDate { get; set; }
        [Column("Cargo Receipt CFS Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CargoReceiptCfsDate { get; set; }
        [Column("HBL Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? HblDate { get; set; }
        [Column("OBL Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? OblDate { get; set; }
        [Column("Container Stuffing Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ContainerStuffingDate { get; set; }
        [Column("Job Costing Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? JobCostingDate { get; set; }
        [Column("Arrival Notice Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ArrivalNoticeDate { get; set; }
        [Column("D/O Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DOReleaseDate { get; set; }
        [Column("Container Unstuffing Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ContainerUnstuffingDate { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("DN Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DnDate { get; set; }
        [Column("CN Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CnDate { get; set; }
        [Column("Cash Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CashInvoiceDate { get; set; }
        [Column("Master DN Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MasterDnDate { get; set; }
        [Column("Master CN Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MasterCnDate { get; set; }
        [Column("Invoice Email")]
        [StringLength(1)]
        [Unicode(false)]
        public string InvoiceEmail { get; set; } = null!;
        [Column("PV Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PvDate { get; set; }
        [Column("PV Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PvApproveDate { get; set; }
        [Column("PV Cheque No")]
        [StringLength(20)]
        public string? PvChequeNo { get; set; }
        [Column("Master PV Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MasterPvDate { get; set; }
        [Column("Master PV Approve Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? MasterPvApproveDate { get; set; }
        [Column("Master PV Cheque No")]
        [StringLength(20)]
        public string? MasterPvChequeNo { get; set; }
        [Column("Vendor Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? VendorInvoiceDate { get; set; }
        [Column("Cargo Collection Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoCollectionDate { get; set; }
        [Column("Job Close Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? JobCloseDate { get; set; }
    }
}
