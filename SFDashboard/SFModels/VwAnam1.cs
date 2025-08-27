using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAnam1
    {
        [Column("Awb No")]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [Column("Awb Code")]
        [StringLength(3)]
        public string? AwbCode { get; set; }
        [Column("Agent Code")]
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [Column("Agent Issue Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgentIssueDate { get; set; }
        [Column("Agent Issue Form No")]
        public int? AgentIssueFormNo { get; set; }
        [Column("Agent Name")]
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column("Agent Return Awb Copy")]
        [StringLength(3)]
        public string? AgentReturnAwbCopy { get; set; }
        [Column("Agent Return Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? AgentReturnDate { get; set; }
        [Column("Agent Return Form No")]
        public int? AgentReturnFormNo { get; set; }
        [Column("Agent Return Status Code")]
        [StringLength(3)]
        public string? AgentReturnStatusCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb Type")]
        [StringLength(1)]
        public string? AwbType { get; set; }
        [Column("Capture Flag")]
        [StringLength(3)]
        public string? CaptureFlag { get; set; }
        [Column("Dest Code")]
        [StringLength(3)]
        public string? DestCode { get; set; }
        [Column("Execute By")]
        [StringLength(50)]
        public string? ExecuteBy { get; set; }
        [Column("Execute Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ExecuteDate { get; set; }
        [Column("First Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FirstFlightDate { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Issue Agent Code")]
        [StringLength(10)]
        public string? IssueAgentCode { get; set; }
        [Column("Issue Agent Name")]
        [StringLength(80)]
        public string? IssueAgentName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("OCC Reserved By")]
        [StringLength(50)]
        public string? OccReservedBy { get; set; }
        [Column("OCC Reserved Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? OccReservedDate { get; set; }
        [Column("OCC Reserved Form No")]
        public int? OccReservedFormNo { get; set; }
        public int? Pcs { get; set; }
        [Column("Product Code")]
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column("Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReceiptDate { get; set; }
        [Column("Receipt Form No")]
        public int? ReceiptFormNo { get; set; }
        [Column("Receipt No")]
        [StringLength(10)]
        public string? ReceiptNo { get; set; }
        [Column("Release By")]
        [StringLength(50)]
        public string? ReleaseBy { get; set; }
        [Column("Release Form No")]
        public int? ReleaseFormNo { get; set; }
        [Column("Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReleaseDate { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Reserve By")]
        [StringLength(50)]
        public string? ReserveBy { get; set; }
        [Column("Return Awb Copy")]
        [StringLength(3)]
        public string? ReturnAwbCopy { get; set; }
        [Column("Return Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReturnDate { get; set; }
        [Column("Return Form No")]
        public int? ReturnFormNo { get; set; }
        [Column("Return Status Code")]
        [StringLength(3)]
        public string? ReturnStatusCode { get; set; }
        [Column("Shipment Type")]
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [Column("Shipper Code")]
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [Column("Shipper Name")]
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(10)]
        public string? Signature { get; set; }
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
        public string? Status { get; set; }
    }
}
