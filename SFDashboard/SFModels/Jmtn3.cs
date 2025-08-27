using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmtn3")]
    public partial class Jmtn3
    {
        [Key]
        public int TrxNo { get; set; }
        [Key]
        [Column(TypeName = "decimal(5, 0)")]
        public decimal LineItemNo { get; set; }
        [StringLength(35)]
        public string? BrandName { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? CertQty { get; set; }
        [StringLength(50)]
        public string? CertUomCode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? CifFobAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CostStatementDate { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? CustomsAmt { get; set; }
        [Column(TypeName = "decimal(7, 4)")]
        public decimal? CustomsRate { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? CustomsRefundAmt { get; set; }
        [StringLength(50)]
        public string? CustomsUomCode { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DgIndFlag { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? DutyAmt { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? DutyQty { get; set; }
        [StringLength(50)]
        public string? DutyUomCode { get; set; }
        [StringLength(7)]
        public string? EngCapacity { get; set; }
        [StringLength(50)]
        public string? EngCapacityUomCode { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? ExciseAmt { get; set; }
        [Column(TypeName = "decimal(7, 4)")]
        public decimal? ExciseRate { get; set; }
        [StringLength(50)]
        public string? ExciseUomCode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? ExciseRefundAmt { get; set; }
        [StringLength(35)]
        public string? ExportHawbHblNo { get; set; }
        [StringLength(35)]
        public string? ExportMawbOblNo { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? GstAmt { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? GstRate { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? GstRefundAmt { get; set; }
        [StringLength(10)]
        public string? HsCode { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? HsSeqNo { get; set; }
        [StringLength(35)]
        public string? ImportHawbHblNo { get; set; }
        [StringLength(35)]
        public string? ImportMawbOblNo { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? InmostPackQty { get; set; }
        [StringLength(50)]
        public string? InmostPackQtyUomCode { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? InnerPackQty { get; set; }
        [StringLength(50)]
        public string? InnerPackQtyUomCode { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? InPackQty { get; set; }
        [StringLength(50)]
        public string? InPackQtyUomCode { get; set; }
        [StringLength(35)]
        public string? InvNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvDate { get; set; }
        [StringLength(35)]
        public string? Item01Descr1 { get; set; }
        [StringLength(35)]
        public string? Item01Descr2 { get; set; }
        [StringLength(35)]
        public string? Item01Descr3 { get; set; }
        [StringLength(35)]
        public string? Item01Descr4 { get; set; }
        [StringLength(35)]
        public string? Item01Descr5 { get; set; }
        [StringLength(35)]
        public string? Item02Descr1 { get; set; }
        [StringLength(35)]
        public string? Item02Descr2 { get; set; }
        [StringLength(35)]
        public string? Item02Descr3 { get; set; }
        [StringLength(35)]
        public string? Item02Descr4 { get; set; }
        [StringLength(35)]
        public string? Item02Descr5 { get; set; }
        [StringLength(35)]
        public string? Item03Descr1 { get; set; }
        [StringLength(35)]
        public string? Item03Descr2 { get; set; }
        [StringLength(35)]
        public string? Item03Descr3 { get; set; }
        [StringLength(35)]
        public string? Item03Descr4 { get; set; }
        [StringLength(35)]
        public string? Item03Descr5 { get; set; }
        [StringLength(35)]
        public string? Item04Descr1 { get; set; }
        [StringLength(35)]
        public string? Item04Descr2 { get; set; }
        [StringLength(35)]
        public string? Item04Descr3 { get; set; }
        [StringLength(35)]
        public string? Item04Descr4 { get; set; }
        [StringLength(35)]
        public string? Item04Descr5 { get; set; }
        [StringLength(35)]
        public string? Item05Descr1 { get; set; }
        [StringLength(35)]
        public string? Item05Descr2 { get; set; }
        [StringLength(35)]
        public string? Item05Descr3 { get; set; }
        [StringLength(35)]
        public string? Item05Descr4 { get; set; }
        [StringLength(35)]
        public string? Item05Descr5 { get; set; }
        [StringLength(35)]
        public string? Item06Descr1 { get; set; }
        [StringLength(35)]
        public string? Item06Descr2 { get; set; }
        [StringLength(35)]
        public string? Item06Descr3 { get; set; }
        [StringLength(35)]
        public string? Item06Descr4 { get; set; }
        [StringLength(35)]
        public string? Item06Descr5 { get; set; }
        [StringLength(35)]
        public string? Item07Descr1 { get; set; }
        [StringLength(35)]
        public string? Item07Descr2 { get; set; }
        [StringLength(35)]
        public string? Item07Descr3 { get; set; }
        [StringLength(35)]
        public string? Item07Descr4 { get; set; }
        [StringLength(35)]
        public string? Item07Descr5 { get; set; }
        [StringLength(35)]
        public string? Item08Descr1 { get; set; }
        [StringLength(35)]
        public string? Item08Descr2 { get; set; }
        [StringLength(35)]
        public string? Item08Descr3 { get; set; }
        [StringLength(35)]
        public string? Item08Descr4 { get; set; }
        [StringLength(35)]
        public string? Item08Descr5 { get; set; }
        [StringLength(35)]
        public string? Item09Descr1 { get; set; }
        [StringLength(35)]
        public string? Item09Descr2 { get; set; }
        [StringLength(35)]
        public string? Item09Descr3 { get; set; }
        [StringLength(35)]
        public string? Item09Descr4 { get; set; }
        [StringLength(35)]
        public string? Item09Descr5 { get; set; }
        [StringLength(35)]
        public string? Item10Descr1 { get; set; }
        [StringLength(35)]
        public string? Item10Descr2 { get; set; }
        [StringLength(35)]
        public string? Item10Descr3 { get; set; }
        [StringLength(35)]
        public string? Item10Descr4 { get; set; }
        [StringLength(35)]
        public string? Item10Descr5 { get; set; }
        [StringLength(17)]
        public string? Item1Mark01 { get; set; }
        [StringLength(17)]
        public string? Item1Mark02 { get; set; }
        [StringLength(17)]
        public string? Item1Mark03 { get; set; }
        [StringLength(17)]
        public string? Item1Mark04 { get; set; }
        [StringLength(17)]
        public string? Item1Mark05 { get; set; }
        [StringLength(17)]
        public string? Item1Mark06 { get; set; }
        [StringLength(17)]
        public string? Item1Mark07 { get; set; }
        [StringLength(17)]
        public string? Item1Mark08 { get; set; }
        [StringLength(17)]
        public string? Item1Mark09 { get; set; }
        [StringLength(17)]
        public string? Item1Mark10 { get; set; }
        [StringLength(17)]
        public string? Item2Mark01 { get; set; }
        [StringLength(17)]
        public string? Item2Mark02 { get; set; }
        [StringLength(17)]
        public string? Item2Mark03 { get; set; }
        [StringLength(17)]
        public string? Item2Mark04 { get; set; }
        [StringLength(17)]
        public string? Item2Mark05 { get; set; }
        [StringLength(17)]
        public string? Item2Mark06 { get; set; }
        [StringLength(17)]
        public string? Item2Mark07 { get; set; }
        [StringLength(17)]
        public string? Item2Mark08 { get; set; }
        [StringLength(17)]
        public string? Item2Mark09 { get; set; }
        [StringLength(17)]
        public string? Item2Mark10 { get; set; }
        [StringLength(17)]
        public string? Item3Mark01 { get; set; }
        [StringLength(17)]
        public string? Item3Mark02 { get; set; }
        [StringLength(17)]
        public string? Item3Mark03 { get; set; }
        [StringLength(17)]
        public string? Item3Mark04 { get; set; }
        [StringLength(17)]
        public string? Item3Mark05 { get; set; }
        [StringLength(17)]
        public string? Item3Mark06 { get; set; }
        [StringLength(17)]
        public string? Item3Mark07 { get; set; }
        [StringLength(17)]
        public string? Item3Mark08 { get; set; }
        [StringLength(17)]
        public string? Item3Mark09 { get; set; }
        [StringLength(17)]
        public string? Item3Mark10 { get; set; }
        [StringLength(17)]
        public string? Item4Mark01 { get; set; }
        [StringLength(17)]
        public string? Item4Mark02 { get; set; }
        [StringLength(17)]
        public string? Item4Mark03 { get; set; }
        [StringLength(17)]
        public string? Item4Mark04 { get; set; }
        [StringLength(17)]
        public string? Item4Mark05 { get; set; }
        [StringLength(17)]
        public string? Item4Mark06 { get; set; }
        [StringLength(17)]
        public string? Item4Mark07 { get; set; }
        [StringLength(17)]
        public string? Item4Mark08 { get; set; }
        [StringLength(17)]
        public string? Item4Mark09 { get; set; }
        [StringLength(17)]
        public string? Item4Mark10 { get; set; }
        [StringLength(10)]
        public string? ItemHsCode { get; set; }
        [StringLength(35)]
        public string? ItemInvoiceNo { get; set; }
        [Column(TypeName = "decimal(3, 0)")]
        public decimal? ItemPercentContent { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? ItemValue { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? LastSellingPrice { get; set; }
        [StringLength(30)]
        public string? LotNo { get; set; }
        [StringLength(2)]
        public string? MarkingRef { get; set; }
        [StringLength(35)]
        public string? Model { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? OptAmt { get; set; }
        [StringLength(3)]
        public string? OptCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? OptCurrRate { get; set; }
        [StringLength(2)]
        public string? OriginCountryOfGoods { get; set; }
        [StringLength(25)]
        public string? OriginCriterion01 { get; set; }
        [StringLength(25)]
        public string? OriginCriterion02 { get; set; }
        [StringLength(25)]
        public string? OriginCriterion03 { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? OtherDutyAmt { get; set; }
        [Column(TypeName = "decimal(7, 4)")]
        public decimal? OtherDutyRate { get; set; }
        [StringLength(50)]
        public string? OtherDutyUomCode { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal? OtherRefundAmt { get; set; }
        [Column(TypeName = "decimal(8, 0)")]
        public decimal? OutPackQty { get; set; }
        [StringLength(50)]
        public string? OutPackQtyUomCode { get; set; }
        [StringLength(7)]
        public string? PercentAlcohol { get; set; }
        [StringLength(3)]
        public string? PreferTaxCode { get; set; }
        [StringLength(30)]
        public string? PrevLotNo { get; set; }
        [StringLength(17)]
        public string? ProductCode1 { get; set; }
        [StringLength(17)]
        public string? ProductCode2 { get; set; }
        [StringLength(17)]
        public string? ProductCode3 { get; set; }
        [StringLength(17)]
        public string? ProductCode4 { get; set; }
        [StringLength(17)]
        public string? ProductCode5 { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? ProductQty1 { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? ProductQty2 { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? ProductQty3 { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? ProductQty4 { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? ProductQty5 { get; set; }
        [StringLength(50)]
        public string? ProductQtyUomCode1 { get; set; }
        [StringLength(50)]
        public string? ProductQtyUomCode2 { get; set; }
        [StringLength(50)]
        public string? ProductQtyUomCode3 { get; set; }
        [StringLength(50)]
        public string? ProductQtyUomCode4 { get; set; }
        [StringLength(50)]
        public string? ProductQtyUomCode5 { get; set; }
        [StringLength(25)]
        public string? OrgCriterion1 { get; set; }
        [StringLength(25)]
        public string? OrgCriterion2 { get; set; }
        [StringLength(25)]
        public string? OrgCriterion3 { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RegDate { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? TextileQty { get; set; }
        [StringLength(5)]
        public string? TextileRefCode { get; set; }
        [StringLength(50)]
        public string? TextileUomCode { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? TotalDutyQty { get; set; }
        [StringLength(50)]
        public string? TotalDutyUomCode { get; set; }
        [Column(TypeName = "decimal(15, 4)")]
        public decimal? UnitRate { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
    }
}
