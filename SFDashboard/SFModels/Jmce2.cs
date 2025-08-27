using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmce2")]
    public partial class Jmce2
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        public short LineItemNo { get; set; }
        [StringLength(1)]
        public string? AnyExcise { get; set; }
        [StringLength(50)]
        public string? Brand { get; set; }
        [StringLength(1)]
        public string? CeptFlag { get; set; }
        [StringLength(50)]
        public string? ChasisNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? CustomTariffQty { get; set; }
        [StringLength(50)]
        public string? CustomTariffUom { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(80)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? DutyExempted { get; set; }
        [StringLength(1)]
        public string? DutyExmAv { get; set; }
        [StringLength(1)]
        public string? DutyMethod { get; set; }
        [StringLength(1)]
        public string? DutyType { get; set; }
        [StringLength(50)]
        public string? EngineNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExciseDutyAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExciseDutyRate { get; set; }
        [StringLength(1)]
        public string? ExciseExmAv { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExciseRateExmp { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExciseSpec { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExciseSpecExmp { get; set; }
        [StringLength(1)]
        public string? ExciseType { get; set; }
        [StringLength(3)]
        public string? ExciseUnit { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExportDutyAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ExportDutyRate { get; set; }
        [StringLength(50)]
        public string? ExSpecUom { get; set; }
        [StringLength(1)]
        public string? ExtraDesc { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GazettedValue { get; set; }
        [StringLength(1)]
        public string? HsType { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ImportDutyAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ImportDutyRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? InvoiceItemValue { get; set; }
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Liqour_Percentage", TypeName = "decimal(13, 4)")]
        public decimal? LiqourPercentage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ManufactureDate { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        public int? NoOfPackage { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OtherTaxAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? OtherTaxRate { get; set; }
        [StringLength(5)]
        public string? OtherTaxType { get; set; }
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [StringLength(50)]
        public string? ProductName { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpecExempted { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? SpecRate { get; set; }
        [StringLength(50)]
        public string? SpecUom { get; set; }
        [Column("STaxExempted", TypeName = "decimal(13, 4)")]
        public decimal? StaxExempted { get; set; }
        [StringLength(15)]
        public string? TariffCode { get; set; }
        [StringLength(50)]
        public string? TariffUom { get; set; }
        [StringLength(3)]
        public string? TypeOfPackage { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? UnitValueFob { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ValuePerUnit { get; set; }
        [StringLength(1)]
        public string? Vehicle { get; set; }
    }
}
