using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("rcal1")]
    public partial class Rcal1
    {
        [Key]
        [StringLength(3)]
        public string AirlineCode { get; set; } = null!;
        [StringLength(50)]
        public string? AirlineName { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [Column("AirlineID")]
        [StringLength(3)]
        public string AirlineId { get; set; } = null!;
        [Column(TypeName = "image")]
        public byte[]? AirlineImage { get; set; }
        [StringLength(10)]
        public string? AnalysisCode { get; set; }
        [StringLength(10)]
        public string? BusinessPartyCode { get; set; }
        [StringLength(5)]
        public string? CiasSatsFlag { get; set; }
        [StringLength(3)]
        public string? CityCode { get; set; }
        [StringLength(45)]
        public string? CityName { get; set; }
        [StringLength(1)]
        public string? CommissionBased { get; set; }
        [StringLength(1)]
        public string? CommissionOnNormalRate { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? CommissionPercent { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Fax { get; set; }
        [StringLength(7)]
        public string? IataCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? LeftMargin { get; set; }
        [StringLength(1)]
        public string? NeutralAwbFlag { get; set; }
        public byte? NoOfColumn { get; set; }
        public byte? NoOfRow { get; set; }
        [StringLength(15)]
        public string? PimaAddress { get; set; }
        [StringLength(15)]
        public string? PimaAddressOther { get; set; }
        [StringLength(16)]
        public string? PrincipalAccCode { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(1)]
        public string? SendToCcnAutoFlag { get; set; }
        [StringLength(30)]
        public string? Telephone { get; set; }
        [StringLength(10)]
        public string? Telex { get; set; }
        [StringLength(20)]
        public string? TerminalCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TopMargin { get; set; }
        [StringLength(9)]
        public string? TtyAddressAwb { get; set; }
        [StringLength(9)]
        public string? TtyAddressOther { get; set; }
        [StringLength(10)]
        public string? VatCode { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? VatRate { get; set; }
        [StringLength(10)]
        public string? VendorCode { get; set; }
        [StringLength(50)]
        public string? WebSite { get; set; }
        [Column("WHTCode")]
        [StringLength(3)]
        public string? Whtcode { get; set; }
        [Column("WHTRate", TypeName = "decimal(13, 2)")]
        public decimal? Whtrate { get; set; }
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
    }
}
