using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmce2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Any Excise")]
        [StringLength(1)]
        public string? AnyExcise { get; set; }
        [StringLength(50)]
        public string? Brand { get; set; }
        [Column("Cept Flag")]
        [StringLength(1)]
        public string? CeptFlag { get; set; }
        [Column("Chasis No")]
        [StringLength(50)]
        public string? ChasisNo { get; set; }
        [Column("Custom Tariff Qty", TypeName = "decimal(13, 4)")]
        public decimal? CustomTariffQty { get; set; }
        [Column("Custom Tariff Uom")]
        [StringLength(3)]
        public string? CustomTariffUom { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(80)]
        public string? Description { get; set; }
        [Column("Duty Exempted", TypeName = "decimal(13, 4)")]
        public decimal? DutyExempted { get; set; }
        [Column("Duty Exm Av")]
        [StringLength(1)]
        public string? DutyExmAv { get; set; }
        [Column("Duty Method")]
        [StringLength(1)]
        public string? DutyMethod { get; set; }
        [Column("Duty Type")]
        [StringLength(1)]
        public string? DutyType { get; set; }
        [Column("Engine No")]
        [StringLength(50)]
        public string? EngineNo { get; set; }
        [Column("Excise Duty Amt", TypeName = "decimal(13, 4)")]
        public decimal? ExciseDutyAmt { get; set; }
        [Column("Excise Duty Rate", TypeName = "decimal(13, 4)")]
        public decimal? ExciseDutyRate { get; set; }
        [Column("Excise Exm Av")]
        [StringLength(1)]
        public string? ExciseExmAv { get; set; }
        [Column("Excise Rate Exmp", TypeName = "decimal(13, 4)")]
        public decimal? ExciseRateExmp { get; set; }
        [Column("Excise Spec", TypeName = "decimal(13, 4)")]
        public decimal? ExciseSpec { get; set; }
        [Column("Excise Spec Exmp", TypeName = "decimal(13, 4)")]
        public decimal? ExciseSpecExmp { get; set; }
        [Column("Excise Type")]
        [StringLength(1)]
        public string? ExciseType { get; set; }
        [Column("Excise Unit")]
        [StringLength(3)]
        public string? ExciseUnit { get; set; }
        [Column("Export Duty Amt", TypeName = "decimal(13, 4)")]
        public decimal? ExportDutyAmt { get; set; }
        [Column("Export Duty Rate", TypeName = "decimal(13, 4)")]
        public decimal? ExportDutyRate { get; set; }
        [Column("Ex Spec Uom")]
        [StringLength(3)]
        public string? ExSpecUom { get; set; }
        [Column("Extra Desc")]
        [StringLength(1)]
        public string? ExtraDesc { get; set; }
        [Column("Gazetted Value", TypeName = "decimal(13, 4)")]
        public decimal? GazettedValue { get; set; }
        [Column("Hs Type")]
        [StringLength(1)]
        public string? HsType { get; set; }
        [Column("Import Duty Amt", TypeName = "decimal(13, 4)")]
        public decimal? ImportDutyAmt { get; set; }
        [Column("Import Duty Rate", TypeName = "decimal(13, 4)")]
        public decimal? ImportDutyRate { get; set; }
        [Column("Invoice Item Value", TypeName = "decimal(13, 4)")]
        public decimal? InvoiceItemValue { get; set; }
        [Column("Item Code")]
        [StringLength(30)]
        public string? ItemCode { get; set; }
        [Column("Liqour_Percentage", TypeName = "decimal(13, 4)")]
        public decimal? LiqourPercentage { get; set; }
        [Column("Manufacture Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ManufactureDate { get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [Column("No Of Package")]
        public int? NoOfPackage { get; set; }
        [Column("Other Tax Amt", TypeName = "decimal(13, 4)")]
        public decimal? OtherTaxAmt { get; set; }
        [Column("Other Tax Rate", TypeName = "decimal(13, 4)")]
        public decimal? OtherTaxRate { get; set; }
        [Column("Other Tax Type")]
        [StringLength(5)]
        public string? OtherTaxType { get; set; }
        [Column("Product Code")]
        [StringLength(24)]
        public string? ProductCode { get; set; }
        [Column("Product Name")]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [StringLength(1000)]
        public string? Remark { get; set; }
        [Column("Spec Exempted", TypeName = "decimal(13, 4)")]
        public decimal? SpecExempted { get; set; }
        [Column("Spec Rate", TypeName = "decimal(13, 4)")]
        public decimal? SpecRate { get; set; }
        [Column("Spec Uom")]
        [StringLength(3)]
        public string? SpecUom { get; set; }
        [Column("S Tax Exempted", TypeName = "decimal(13, 4)")]
        public decimal? STaxExempted { get; set; }
        [Column("Tariff Code")]
        [StringLength(15)]
        public string? TariffCode { get; set; }
        [Column("Tariff Uom")]
        [StringLength(3)]
        public string? TariffUom { get; set; }
        [Column("Type Of Package")]
        [StringLength(3)]
        public string? TypeOfPackage { get; set; }
        [Column("Unit Value Fob", TypeName = "decimal(13, 4)")]
        public decimal? UnitValueFob { get; set; }
        [Column("Value Per Unit", TypeName = "decimal(13, 4)")]
        public decimal? ValuePerUnit { get; set; }
        [StringLength(1)]
        public string? Vehicle { get; set; }
    }
}
