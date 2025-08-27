using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwRcam1
    {
        [Column("Airline Code")]
        [StringLength(3)]
        public string AirlineCode { get; set; } = null!;
        [Column("Address 1")]
        [StringLength(45)]
        public string? Address1 { get; set; }
        [Column("Address 2")]
        [StringLength(45)]
        public string? Address2 { get; set; }
        [Column("Address 3")]
        [StringLength(45)]
        public string? Address3 { get; set; }
        [Column("Address 4")]
        [StringLength(45)]
        public string? Address4 { get; set; }
        [Column("Airline ID")]
        [StringLength(2)]
        public string AirlineId { get; set; } = null!;
        [Column("Airline Name")]
        [StringLength(50)]
        public string? AirlineName { get; set; }
        [Column("Analysis Code")]
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cias Sats Flag")]
        [StringLength(5)]
        public string? CiasSatsFlag { get; set; }
        [Column("City Code")]
        [StringLength(3)]
        public string? CityCode { get; set; }
        [Column("Commission Percent", TypeName = "decimal(6, 3)")]
        public decimal? CommissionPercent { get; set; }
        [Column("Contact Name")]
        [StringLength(50)]
        public string? ContactName { get; set; }
        [Column("Country Code")]
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [Column("Iata Code")]
        [StringLength(7)]
        public string? IataCode { get; set; }
        [Column("Neutral Awb Flag")]
        [StringLength(1)]
        public string? NeutralAwbFlag { get; set; }
        [Column("No Of Column")]
        public byte? NoOfColumn { get; set; }
        [Column("No Of Row")]
        public byte? NoOfRow { get; set; }
        [Column("Pima Address")]
        [StringLength(15)]
        public string? PimaAddress { get; set; }
        [Column("Pima Address Other")]
        [StringLength(15)]
        public string? PimaAddressOther { get; set; }
        [Column("Principal Acc Code")]
        [StringLength(16)]
        public string? PrincipalAccCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Send To Ccn Auto Flag")]
        [StringLength(1)]
        public string? SendToCcnAutoFlag { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [Column("Tty Address Awb")]
        [StringLength(9)]
        public string? TtyAddressAwb { get; set; }
        [Column("Tty Address Other")]
        [StringLength(9)]
        public string? TtyAddressOther { get; set; }
        [Column("Web Site")]
        [StringLength(50)]
        public string? WebSite { get; set; }
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
