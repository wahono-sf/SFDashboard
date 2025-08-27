using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anam1")]
    public partial class Anam1
    {
        [Key]
        [StringLength(20)]
        public string AwbNo { get; set; } = null!;
        [StringLength(1)]
        public string? AwbType { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(80)]
        public string? AgentName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgentIssueDate { get; set; }
        public int? AgentIssueFormNo { get; set; }
        [StringLength(3)]
        public string? AgentReturnAwbCopy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AgentReturnDate { get; set; }
        public int? AgentReturnFormNo { get; set; }
        [StringLength(3)]
        public string? AgentReturnStatusCode { get; set; }
        [StringLength(3)]
        public string? CaptureFlag { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(50)]
        public string? ExecuteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecuteDate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(10)]
        public string? IssueAgentCode { get; set; }
        [StringLength(80)]
        public string? IssueAgentName { get; set; }
        [Column("OCCReservedBy")]
        [StringLength(50)]
        public string? OccreservedBy { get; set; }
        [Column("OCCReservedDate", TypeName = "datetime")]
        public DateTime? OccreservedDate { get; set; }
        [Column("OCCReservedFormNo")]
        public int? OccreservedFormNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        public int? ReceiptFormNo { get; set; }
        [StringLength(10)]
        public string? ReceiptNo { get; set; }
        [StringLength(50)]
        public string? ReleaseBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        public int? ReleaseFormNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? ReserveBy { get; set; }
        [StringLength(3)]
        public string? ReturnAwbCopy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        public int? ReturnFormNo { get; set; }
        [StringLength(3)]
        public string? ReturnStatusCode { get; set; }
        [StringLength(1)]
        public string? ShipmentType { get; set; }
        [StringLength(10)]
        public string? ShipperCode { get; set; }
        [StringLength(80)]
        public string? ShipperName { get; set; }
        [StringLength(10)]
        public string? Signature { get; set; }
        [StringLength(3)]
        public string? StatusCode { get; set; }
        [StringLength(50)]
        public string CreateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreateDateTime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("AgentIssueFormNo")]
        [InverseProperty("Anam1AgentIssueFormNoNavigations")]
        public virtual Anat1? AgentIssueFormNoNavigation { get; set; }
        [ForeignKey("AgentReturnFormNo")]
        [InverseProperty("Anam1AgentReturnFormNoNavigations")]
        public virtual Anat1? AgentReturnFormNoNavigation { get; set; }
        [ForeignKey("ReceiptFormNo")]
        [InverseProperty("Anam1ReceiptFormNoNavigations")]
        public virtual Anat1? ReceiptFormNoNavigation { get; set; }
        [ForeignKey("ReleaseFormNo")]
        [InverseProperty("Anam1ReleaseFormNoNavigations")]
        public virtual Anat1? ReleaseFormNoNavigation { get; set; }
        [ForeignKey("ReturnFormNo")]
        [InverseProperty("Anam1ReturnFormNoNavigations")]
        public virtual Anat1? ReturnFormNoNavigation { get; set; }
    }
}
