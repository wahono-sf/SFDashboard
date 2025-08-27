using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("anat1")]
    public partial class Anat1
    {
        public Anat1()
        {
            Anam1AgentIssueFormNoNavigations = new HashSet<Anam1>();
            Anam1AgentReturnFormNoNavigations = new HashSet<Anam1>();
            Anam1ReceiptFormNoNavigations = new HashSet<Anam1>();
            Anam1ReleaseFormNoNavigations = new HashSet<Anam1>();
            Anam1ReturnFormNoNavigations = new HashSet<Anam1>();
            Anat2s = new HashSet<Anat2>();
        }

        [Key]
        public int FormNo { get; set; }
        [StringLength(3)]
        public string? AwbCode { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(80)]
        public string? AgentName { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        public byte? EdiCount { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(17)]
        public string? FirstAwbSeqNo { get; set; }
        [StringLength(80)]
        public string? Footer1 { get; set; }
        [StringLength(80)]
        public string? Footer2 { get; set; }
        [StringLength(80)]
        public string? Footer3 { get; set; }
        [StringLength(80)]
        public string? Footer4 { get; set; }
        [StringLength(80)]
        public string? Footer5 { get; set; }
        [StringLength(17)]
        public string? LastAwbSeqNo { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(10)]
        public string? ProductCode { get; set; }
        [StringLength(10)]
        public string? ReceiptNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        public int? TotalNoOfAwb { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TrxDate { get; set; }
        [StringLength(2)]
        public string? TrxType { get; set; }
        [StringLength(3)]
        public string StatusCode { get; set; } = null!;
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

        [ForeignKey("AwbCode")]
        [InverseProperty("Anat1s")]
        public virtual Anac1? AwbCodeNavigation { get; set; }
        [InverseProperty("AgentIssueFormNoNavigation")]
        public virtual ICollection<Anam1> Anam1AgentIssueFormNoNavigations { get; set; }
        [InverseProperty("AgentReturnFormNoNavigation")]
        public virtual ICollection<Anam1> Anam1AgentReturnFormNoNavigations { get; set; }
        [InverseProperty("ReceiptFormNoNavigation")]
        public virtual ICollection<Anam1> Anam1ReceiptFormNoNavigations { get; set; }
        [InverseProperty("ReleaseFormNoNavigation")]
        public virtual ICollection<Anam1> Anam1ReleaseFormNoNavigations { get; set; }
        [InverseProperty("ReturnFormNoNavigation")]
        public virtual ICollection<Anam1> Anam1ReturnFormNoNavigations { get; set; }
        [InverseProperty("FormNoNavigation")]
        public virtual ICollection<Anat2> Anat2s { get; set; }
    }
}
