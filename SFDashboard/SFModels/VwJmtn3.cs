using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmtn3
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No", TypeName = "decimal(5, 0)")]
        public decimal LineItemNo { get; set; }
        [Column("Brand Name")]
        [StringLength(35)]
        public string? BrandName { get; set; }
        [Column("Cert Qty", TypeName = "decimal(16, 4)")]
        public decimal? CertQty { get; set; }
        [Column("Cert Uom Code")]
        [StringLength(50)]
        public string? CertUomCode { get; set; }
        [Column("Cif Fob Amt", TypeName = "decimal(16, 2)")]
        public decimal? CifFobAmt { get; set; }
        [Column("Cost Statement Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CostStatementDate { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [Column("Customs Amt", TypeName = "decimal(15, 2)")]
        public decimal? CustomsAmt { get; set; }
        [Column("Customs Rate", TypeName = "decimal(7, 4)")]
        public decimal? CustomsRate { get; set; }
        [Column("Customs Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? CustomsRefundAmt { get; set; }
        [Column("Customs Uom Code")]
        [StringLength(50)]
        public string? CustomsUomCode { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }
        [Column("Dg Ind Flag")]
        [StringLength(1)]
        public string? DgIndFlag { get; set; }
        [Column("Duty Amt", TypeName = "decimal(15, 2)")]
        public decimal? DutyAmt { get; set; }
        [Column("Duty Qty", TypeName = "decimal(16, 4)")]
        public decimal? DutyQty { get; set; }
        [Column("Duty Uom Code")]
        [StringLength(50)]
        public string? DutyUomCode { get; set; }
        [Column("Eng Capacity")]
        [StringLength(7)]
        public string? EngCapacity { get; set; }
        [Column("Eng Capacity Uom Code")]
        [StringLength(50)]
        public string? EngCapacityUomCode { get; set; }
        [Column("Excise Amt", TypeName = "decimal(15, 2)")]
        public decimal? ExciseAmt { get; set; }
        [Column("Excise Rate", TypeName = "decimal(7, 4)")]
        public decimal? ExciseRate { get; set; }
        [Column("Excise Uom Code")]
        [StringLength(50)]
        public string? ExciseUomCode { get; set; }
        [Column("Excise Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? ExciseRefundAmt { get; set; }
        [Column("Export Hawb Hbl No")]
        [StringLength(35)]
        public string? ExportHawbHblNo { get; set; }
        [Column("Export Mawb Obl No")]
        [StringLength(35)]
        public string? ExportMawbOblNo { get; set; }
        [Column("Gst Amt", TypeName = "decimal(15, 2)")]
        public decimal? GstAmt { get; set; }
        [Column("Gst Rate", TypeName = "decimal(2, 0)")]
        public decimal? GstRate { get; set; }
        [Column("Gst Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? GstRefundAmt { get; set; }
        [Column("Hs Code")]
        [StringLength(10)]
        public string? HsCode { get; set; }
        [Column("Hs Seq No", TypeName = "decimal(4, 0)")]
        public decimal? HsSeqNo { get; set; }
        [Column("Import Hawb Hbl No")]
        [StringLength(35)]
        public string? ImportHawbHblNo { get; set; }
        [Column("Import Mawb Obl No")]
        [StringLength(35)]
        public string? ImportMawbOblNo { get; set; }
        [Column("Inmost Pack Qty", TypeName = "decimal(8, 0)")]
        public decimal? InmostPackQty { get; set; }
        [Column("Inmost Pack Qty Uom Code")]
        [StringLength(50)]
        public string? InmostPackQtyUomCode { get; set; }
        [Column("Inner Pack Qty", TypeName = "decimal(8, 0)")]
        public decimal? InnerPackQty { get; set; }
        [Column("Inner Pack Qty Uom Code")]
        [StringLength(50)]
        public string? InnerPackQtyUomCode { get; set; }
        [Column("In Pack Qty", TypeName = "decimal(8, 0)")]
        public decimal? InPackQty { get; set; }
        [Column("In Pack Qty Uom Code")]
        [StringLength(50)]
        public string? InPackQtyUomCode { get; set; }
        [Column("Inv No")]
        [StringLength(35)]
        public string? InvNo { get; set; }
        [Column("Inv Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvDate { get; set; }
        [Column("Item 01 Descr 1")]
        [StringLength(35)]
        public string? Item01Descr1 { get; set; }
        [Column("Item 01 Descr 2")]
        [StringLength(35)]
        public string? Item01Descr2 { get; set; }
        [Column("Item 01 Descr 3")]
        [StringLength(35)]
        public string? Item01Descr3 { get; set; }
        [Column("Item 01 Descr 4")]
        [StringLength(35)]
        public string? Item01Descr4 { get; set; }
        [Column("Item 01 Descr 5")]
        [StringLength(35)]
        public string? Item01Descr5 { get; set; }
        [Column("Item 02 Descr 1")]
        [StringLength(35)]
        public string? Item02Descr1 { get; set; }
        [Column("Item 02 Descr 2")]
        [StringLength(35)]
        public string? Item02Descr2 { get; set; }
        [Column("Item 02 Descr 3")]
        [StringLength(35)]
        public string? Item02Descr3 { get; set; }
        [Column("Item 02 Descr 4")]
        [StringLength(35)]
        public string? Item02Descr4 { get; set; }
        [Column("Item 02 Descr 5")]
        [StringLength(35)]
        public string? Item02Descr5 { get; set; }
        [Column("Item 03 Descr 1")]
        [StringLength(35)]
        public string? Item03Descr1 { get; set; }
        [Column("Item 03 Descr 2")]
        [StringLength(35)]
        public string? Item03Descr2 { get; set; }
        [Column("Item 03 Descr 3")]
        [StringLength(35)]
        public string? Item03Descr3 { get; set; }
        [Column("Item 03 Descr 4")]
        [StringLength(35)]
        public string? Item03Descr4 { get; set; }
        [Column("Item 03 Descr 5")]
        [StringLength(35)]
        public string? Item03Descr5 { get; set; }
        [Column("Item 04 Descr 1")]
        [StringLength(35)]
        public string? Item04Descr1 { get; set; }
        [Column("Item 04 Descr 2")]
        [StringLength(35)]
        public string? Item04Descr2 { get; set; }
        [Column("Item 04 Descr 3")]
        [StringLength(35)]
        public string? Item04Descr3 { get; set; }
        [Column("Item 04 Descr 4")]
        [StringLength(35)]
        public string? Item04Descr4 { get; set; }
        [Column("Item 04 Descr 5")]
        [StringLength(35)]
        public string? Item04Descr5 { get; set; }
        [Column("Item 05 Descr 1")]
        [StringLength(35)]
        public string? Item05Descr1 { get; set; }
        [Column("Item 05 Descr 2")]
        [StringLength(35)]
        public string? Item05Descr2 { get; set; }
        [Column("Item 05 Descr 3")]
        [StringLength(35)]
        public string? Item05Descr3 { get; set; }
        [Column("Item 05 Descr 4")]
        [StringLength(35)]
        public string? Item05Descr4 { get; set; }
        [Column("Item 05 Descr 5")]
        [StringLength(35)]
        public string? Item05Descr5 { get; set; }
        [Column("Item 06 Descr 1")]
        [StringLength(35)]
        public string? Item06Descr1 { get; set; }
        [Column("Item 06 Descr 2")]
        [StringLength(35)]
        public string? Item06Descr2 { get; set; }
        [Column("Item 06 Descr 3")]
        [StringLength(35)]
        public string? Item06Descr3 { get; set; }
        [Column("Item 06 Descr 4")]
        [StringLength(35)]
        public string? Item06Descr4 { get; set; }
        [Column("Item 06 Descr 5")]
        [StringLength(35)]
        public string? Item06Descr5 { get; set; }
        [Column("Item 07 Descr 1")]
        [StringLength(35)]
        public string? Item07Descr1 { get; set; }
        [Column("Item 07 Descr 2")]
        [StringLength(35)]
        public string? Item07Descr2 { get; set; }
        [Column("Item 07 Descr 3")]
        [StringLength(35)]
        public string? Item07Descr3 { get; set; }
        [Column("Item 07 Descr 4")]
        [StringLength(35)]
        public string? Item07Descr4 { get; set; }
        [Column("Item 07 Descr 5")]
        [StringLength(35)]
        public string? Item07Descr5 { get; set; }
        [Column("Item 08 Descr 1")]
        [StringLength(35)]
        public string? Item08Descr1 { get; set; }
        [Column("Item 08 Descr 2")]
        [StringLength(35)]
        public string? Item08Descr2 { get; set; }
        [Column("Item 08 Descr 3")]
        [StringLength(35)]
        public string? Item08Descr3 { get; set; }
        [Column("Item 08 Descr 4")]
        [StringLength(35)]
        public string? Item08Descr4 { get; set; }
        [Column("Item 08 Descr 5")]
        [StringLength(35)]
        public string? Item08Descr5 { get; set; }
        [Column("Item 09 Descr 1")]
        [StringLength(35)]
        public string? Item09Descr1 { get; set; }
        [Column("Item 09 Descr 2")]
        [StringLength(35)]
        public string? Item09Descr2 { get; set; }
        [Column("Item 09 Descr 3")]
        [StringLength(35)]
        public string? Item09Descr3 { get; set; }
        [Column("Item 09 Descr 4")]
        [StringLength(35)]
        public string? Item09Descr4 { get; set; }
        [Column("Item 09 Descr 5")]
        [StringLength(35)]
        public string? Item09Descr5 { get; set; }
        [Column("Item 10 Descr 1")]
        [StringLength(35)]
        public string? Item10Descr1 { get; set; }
        [Column("Item 10 Descr 2")]
        [StringLength(35)]
        public string? Item10Descr2 { get; set; }
        [Column("Item 10 Descr 3")]
        [StringLength(35)]
        public string? Item10Descr3 { get; set; }
        [Column("Item 10 Descr 4")]
        [StringLength(35)]
        public string? Item10Descr4 { get; set; }
        [Column("Item 10 Descr 5")]
        [StringLength(35)]
        public string? Item10Descr5 { get; set; }
        [Column("Item 1 Mark 01")]
        [StringLength(17)]
        public string? Item1Mark01 { get; set; }
        [Column("Item 1 Mark 02")]
        [StringLength(17)]
        public string? Item1Mark02 { get; set; }
        [Column("Item 1 Mark 03")]
        [StringLength(17)]
        public string? Item1Mark03 { get; set; }
        [Column("Item 1 Mark 04")]
        [StringLength(17)]
        public string? Item1Mark04 { get; set; }
        [Column("Item 1 Mark 05")]
        [StringLength(17)]
        public string? Item1Mark05 { get; set; }
        [Column("Item 1 Mark 06")]
        [StringLength(17)]
        public string? Item1Mark06 { get; set; }
        [Column("Item 1 Mark 07")]
        [StringLength(17)]
        public string? Item1Mark07 { get; set; }
        [Column("Item 1 Mark 08")]
        [StringLength(17)]
        public string? Item1Mark08 { get; set; }
        [Column("Item 1 Mark 09")]
        [StringLength(17)]
        public string? Item1Mark09 { get; set; }
        [Column("Item 1 Mark 10")]
        [StringLength(17)]
        public string? Item1Mark10 { get; set; }
        [Column("Item 2 Mark 01")]
        [StringLength(17)]
        public string? Item2Mark01 { get; set; }
        [Column("Item 2 Mark 02")]
        [StringLength(17)]
        public string? Item2Mark02 { get; set; }
        [Column("Item 2 Mark 03")]
        [StringLength(17)]
        public string? Item2Mark03 { get; set; }
        [Column("Item 2 Mark 04")]
        [StringLength(17)]
        public string? Item2Mark04 { get; set; }
        [Column("Item 2 Mark 05")]
        [StringLength(17)]
        public string? Item2Mark05 { get; set; }
        [Column("Item 2 Mark 06")]
        [StringLength(17)]
        public string? Item2Mark06 { get; set; }
        [Column("Item 2 Mark 07")]
        [StringLength(17)]
        public string? Item2Mark07 { get; set; }
        [Column("Item 2 Mark 08")]
        [StringLength(17)]
        public string? Item2Mark08 { get; set; }
        [Column("Item 2 Mark 09")]
        [StringLength(17)]
        public string? Item2Mark09 { get; set; }
        [Column("Item 2 Mark 10")]
        [StringLength(17)]
        public string? Item2Mark10 { get; set; }
        [Column("Item 3 Mark 01")]
        [StringLength(17)]
        public string? Item3Mark01 { get; set; }
        [Column("Item 3 Mark 02")]
        [StringLength(17)]
        public string? Item3Mark02 { get; set; }
        [Column("Item 3 Mark 03")]
        [StringLength(17)]
        public string? Item3Mark03 { get; set; }
        [Column("Item 3 Mark 04")]
        [StringLength(17)]
        public string? Item3Mark04 { get; set; }
        [Column("Item 3 Mark 05")]
        [StringLength(17)]
        public string? Item3Mark05 { get; set; }
        [Column("Item 3 Mark 06")]
        [StringLength(17)]
        public string? Item3Mark06 { get; set; }
        [Column("Item 3 Mark 07")]
        [StringLength(17)]
        public string? Item3Mark07 { get; set; }
        [Column("Item 3 Mark 08")]
        [StringLength(17)]
        public string? Item3Mark08 { get; set; }
        [Column("Item 3 Mark 09")]
        [StringLength(17)]
        public string? Item3Mark09 { get; set; }
        [Column("Item 3 Mark 10")]
        [StringLength(17)]
        public string? Item3Mark10 { get; set; }
        [Column("Item 4 Mark 01")]
        [StringLength(17)]
        public string? Item4Mark01 { get; set; }
        [Column("Item 4 Mark 02")]
        [StringLength(17)]
        public string? Item4Mark02 { get; set; }
        [Column("Item 4 Mark 03")]
        [StringLength(17)]
        public string? Item4Mark03 { get; set; }
        [Column("Item 4 Mark 04")]
        [StringLength(17)]
        public string? Item4Mark04 { get; set; }
        [Column("Item 4 Mark 05")]
        [StringLength(17)]
        public string? Item4Mark05 { get; set; }
        [Column("Item 4 Mark 06")]
        [StringLength(17)]
        public string? Item4Mark06 { get; set; }
        [Column("Item 4 Mark 07")]
        [StringLength(17)]
        public string? Item4Mark07 { get; set; }
        [Column("Item 4 Mark 08")]
        [StringLength(17)]
        public string? Item4Mark08 { get; set; }
        [Column("Item 4 Mark 09")]
        [StringLength(17)]
        public string? Item4Mark09 { get; set; }
        [Column("Item 4 Mark 10")]
        [StringLength(17)]
        public string? Item4Mark10 { get; set; }
        [Column("Item Hs Code")]
        [StringLength(10)]
        public string? ItemHsCode { get; set; }
        [Column("Item Invoice No")]
        [StringLength(35)]
        public string? ItemInvoiceNo { get; set; }
        [Column("Item Percent Content", TypeName = "decimal(3, 0)")]
        public decimal? ItemPercentContent { get; set; }
        [Column("Item Value", TypeName = "decimal(16, 4)")]
        public decimal? ItemValue { get; set; }
        [Column("Last Selling Price", TypeName = "decimal(16, 2)")]
        public decimal? LastSellingPrice { get; set; }
        [Column("Lot No")]
        [StringLength(30)]
        public string? LotNo { get; set; }
        [Column("Marking Ref")]
        [StringLength(2)]
        public string? MarkingRef { get; set; }
        [StringLength(35)]
        public string? Model { get; set; }
        [Column("Opt Amt", TypeName = "decimal(15, 2)")]
        public decimal? OptAmt { get; set; }
        [Column("Opt Curr Code")]
        [StringLength(3)]
        public string? OptCurrCode { get; set; }
        [Column("Opt Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? OptCurrRate { get; set; }
        [Column("Origin Country Of Goods")]
        [StringLength(2)]
        public string? OriginCountryOfGoods { get; set; }
        [Column("Origin Criterion 01")]
        [StringLength(25)]
        public string? OriginCriterion01 { get; set; }
        [Column("Origin Criterion 02")]
        [StringLength(25)]
        public string? OriginCriterion02 { get; set; }
        [Column("Origin Criterion 03")]
        [StringLength(25)]
        public string? OriginCriterion03 { get; set; }
        [Column("Other Duty Amt", TypeName = "decimal(15, 2)")]
        public decimal? OtherDutyAmt { get; set; }
        [Column("Other Duty Rate", TypeName = "decimal(7, 4)")]
        public decimal? OtherDutyRate { get; set; }
        [Column("Other Duty Uom Code")]
        [StringLength(6)]
        public string? OtherDutyUomCode { get; set; }
        [Column("Other Refund Amt", TypeName = "decimal(16, 2)")]
        public decimal? OtherRefundAmt { get; set; }
        [Column("Out Pack Qty", TypeName = "decimal(8, 0)")]
        public decimal? OutPackQty { get; set; }
        [Column("Out Pack Qty Uom Code")]
        [StringLength(50)]
        public string? OutPackQtyUomCode { get; set; }
        [Column("Percent Alcohol")]
        [StringLength(7)]
        public string? PercentAlcohol { get; set; }
        [Column("Prefer Tax Code")]
        [StringLength(3)]
        public string? PreferTaxCode { get; set; }
        [Column("Prev Lot No")]
        [StringLength(30)]
        public string? PrevLotNo { get; set; }
        [Column("Product Code 1")]
        [StringLength(17)]
        public string? ProductCode1 { get; set; }
        [Column("Product Code 2")]
        [StringLength(17)]
        public string? ProductCode2 { get; set; }
        [Column("Product Code 3")]
        [StringLength(17)]
        public string? ProductCode3 { get; set; }
        [Column("Product Code 4")]
        [StringLength(17)]
        public string? ProductCode4 { get; set; }
        [Column("Product Code 5")]
        [StringLength(17)]
        public string? ProductCode5 { get; set; }
        [Column("Product Qty 1", TypeName = "decimal(15, 4)")]
        public decimal? ProductQty1 { get; set; }
        [Column("Product Qty 2", TypeName = "decimal(15, 4)")]
        public decimal? ProductQty2 { get; set; }
        [Column("Product Qty 3", TypeName = "decimal(15, 4)")]
        public decimal? ProductQty3 { get; set; }
        [Column("Product Qty 4", TypeName = "decimal(15, 4)")]
        public decimal? ProductQty4 { get; set; }
        [Column("Product Qty 5", TypeName = "decimal(15, 4)")]
        public decimal? ProductQty5 { get; set; }
        [Column("Product Qty Uom Code 1")]
        [StringLength(50)]
        public string? ProductQtyUomCode1 { get; set; }
        [Column("Product Qty Uom Code 2")]
        [StringLength(50)]
        public string? ProductQtyUomCode2 { get; set; }
        [Column("Product Qty Uom Code 3")]
        [StringLength(50)]
        public string? ProductQtyUomCode3 { get; set; }
        [Column("Product Qty Uom Code 4")]
        [StringLength(50)]
        public string? ProductQtyUomCode4 { get; set; }
        [Column("Product Qty Uom Code 5")]
        [StringLength(50)]
        public string? ProductQtyUomCode5 { get; set; }
        [Column("Org Criterion 1")]
        [StringLength(25)]
        public string? OrgCriterion1 { get; set; }
        [Column("Org Criterion 2")]
        [StringLength(25)]
        public string? OrgCriterion2 { get; set; }
        [Column("Org Criterion 3")]
        [StringLength(25)]
        public string? OrgCriterion3 { get; set; }
        [Column(TypeName = "decimal(16, 4)")]
        public decimal? Qty { get; set; }
        [Column("Reg Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? RegDate { get; set; }
        [Column("Textile Qty", TypeName = "decimal(16, 4)")]
        public decimal? TextileQty { get; set; }
        [Column("Textile Ref Code")]
        [StringLength(5)]
        public string? TextileRefCode { get; set; }
        [Column("Textile Uom Code")]
        [StringLength(50)]
        public string? TextileUomCode { get; set; }
        [Column("Total Duty Qty", TypeName = "decimal(15, 4)")]
        public decimal? TotalDutyQty { get; set; }
        [Column("Total Duty Uom Code")]
        [StringLength(50)]
        public string? TotalDutyUomCode { get; set; }
        [Column("Unit Rate", TypeName = "decimal(15, 4)")]
        public decimal? UnitRate { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
    }
}
