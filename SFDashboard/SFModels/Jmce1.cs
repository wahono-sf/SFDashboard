using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmce1")]
    public partial class Jmce1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CifValue { get; set; }
        [StringLength(1)]
        public string? Containerised { get; set; }
        [StringLength(2)]
        public string? CountryOfGoodsPmtCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Declarant { get; set; }
        [StringLength(10)]
        public string? DeclarationType { get; set; }
        [StringLength(50)]
        public string? Designation { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FobValue { get; set; }
        [StringLength(3)]
        public string? FrCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? FrCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FreightValue { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? FrQty { get; set; }
        [StringLength(50)]
        public string? GeneralReferenceNo { get; set; }
        [StringLength(2)]
        public string? GeneralType { get; set; }
        [StringLength(20)]
        public string? IdOfDeclarant { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ImportDate { get; set; }
        [StringLength(3)]
        public string? InCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? InCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InsuranceValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InvoiceValue { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(5)]
        public string? MainType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [StringLength(50)]
        public string? NameOfDeclarant { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OtherCharges { get; set; }
        [StringLength(3)]
        public string? PoCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? PoCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PoQty { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PortCharges { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? SalesReferenceNo { get; set; }
        [StringLength(20)]
        public string? SalesRegistrationNo { get; set; }
        [StringLength(10)]
        public string? SalesStation { get; set; }
        [StringLength(2)]
        public string? SalesType { get; set; }
        [Column("SDocument")]
        [StringLength(1)]
        public string? Sdocument { get; set; }
        [StringLength(50)]
        public string? SpecialReferenceNo { get; set; }
        [StringLength(2)]
        public string? SpecialType { get; set; }
        [StringLength(10)]
        public string? TerminalOpr { get; set; }
        [StringLength(20)]
        public string? TransportMode { get; set; }
        [StringLength(1)]
        public string? WithClause { get; set; }
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
