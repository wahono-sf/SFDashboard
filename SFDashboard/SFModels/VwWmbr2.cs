using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwWmbr2
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Billing Charge Type")]
        [StringLength(3)]
        public string? BillingChargeType { get; set; }
        [Column("Billing Cycle Code")]
        [StringLength(3)]
        public string? BillingCycleCode { get; set; }
        [Column("Billing Rate", TypeName = "decimal(13, 4)")]
        public decimal? BillingRate { get; set; }
        [Column("Bonded Amt", TypeName = "decimal(13, 2)")]
        public decimal? BondedAmt { get; set; }
        [Column("Break Formula 01")]
        [StringLength(50)]
        public string? BreakFormula01 { get; set; }
        [Column("Break Formula 02")]
        [StringLength(50)]
        public string? BreakFormula02 { get; set; }
        [Column("Break Formula 03")]
        [StringLength(50)]
        public string? BreakFormula03 { get; set; }
        [Column("Break Formula 04")]
        [StringLength(50)]
        public string? BreakFormula04 { get; set; }
        [Column("Break Formula 05")]
        [StringLength(50)]
        public string? BreakFormula05 { get; set; }
        [Column("Break Formula 06")]
        [StringLength(50)]
        public string? BreakFormula06 { get; set; }
        [Column("Break Formula 07")]
        [StringLength(50)]
        public string? BreakFormula07 { get; set; }
        [Column("Break Formula 08")]
        [StringLength(50)]
        public string? BreakFormula08 { get; set; }
        [Column("Break Formula 09")]
        [StringLength(50)]
        public string? BreakFormula09 { get; set; }
        [Column("Break Formula 10")]
        [StringLength(50)]
        public string? BreakFormula10 { get; set; }
        [Column("Break Point 01", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint01 { get; set; }
        [Column("Break Point 02", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint02 { get; set; }
        [Column("Break Point 03", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint03 { get; set; }
        [Column("Break Point 04", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint04 { get; set; }
        [Column("Break Point 05", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint05 { get; set; }
        [Column("Break Point 06", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint06 { get; set; }
        [Column("Break Point 07", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint07 { get; set; }
        [Column("Break Point 08", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint08 { get; set; }
        [Column("Break Point 09", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint09 { get; set; }
        [Column("Break Point 10", TypeName = "decimal(13, 4)")]
        public decimal? BreakPoint10 { get; set; }
        [Column("Break Rate 01", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate01 { get; set; }
        [Column("Break Rate 02", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate02 { get; set; }
        [Column("Break Rate 03", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate03 { get; set; }
        [Column("Break Rate 04", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate04 { get; set; }
        [Column("Break Rate 05", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate05 { get; set; }
        [Column("Break Rate 06", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate06 { get; set; }
        [Column("Break Rate 07", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate07 { get; set; }
        [Column("Break Rate 08", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate08 { get; set; }
        [Column("Break Rate 09", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate09 { get; set; }
        [Column("Break Rate 10", TypeName = "decimal(13, 2)")]
        public decimal? BreakRate10 { get; set; }
        [Column("Break Unit")]
        [StringLength(3)]
        public string? BreakUnit { get; set; }
        [Column("Charge Type")]
        [StringLength(1)]
        public string? ChargeType { get; set; }
        [Column("Charge Unit")]
        [StringLength(3)]
        public string? ChargeUnit { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Discount Percent", TypeName = "decimal(5, 2)")]
        public decimal? DiscountPercent { get; set; }
        [Column("Discount Start Type")]
        [StringLength(3)]
        public string? DiscountStartType { get; set; }
        [Column("Free Day Flag")]
        [StringLength(10)]
        public string? FreeDayFlag { get; set; }
        [Column("Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? MinAmt { get; set; }
        [Column("Min Amt Per Invoice", TypeName = "decimal(13, 2)")]
        public decimal? MinAmtPerInvoice { get; set; }
        [Column("Product Class Code")]
        [StringLength(10)]
        public string? ProductClassCode { get; set; }
        [Column("Pro Rate Flag")]
        [StringLength(10)]
        public string? ProRateFlag { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Item Code")]
        [StringLength(30)]
        public string? SalesItemCode { get; set; }
        [Column("Std Amt", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt { get; set; }
        [Column("Std Amt 01", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt01 { get; set; }
        [Column("Std Amt 02", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt02 { get; set; }
        [Column("Std Amt 03", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt03 { get; set; }
        [Column("Std Amt 04", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt04 { get; set; }
        [Column("Std Amt 05", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt05 { get; set; }
        [Column("Std Amt 06", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt06 { get; set; }
        [Column("Std Amt 07", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt07 { get; set; }
        [Column("Std Amt 08", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt08 { get; set; }
        [Column("Std Amt 09", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt09 { get; set; }
        [Column("Std Amt 10", TypeName = "decimal(13, 2)")]
        public decimal? StdAmt10 { get; set; }
        [Column("Table No")]
        [StringLength(10)]
        public string TableNo { get; set; } = null!;
        [Column("Uom Code")]
        [StringLength(3)]
        public string? UomCode { get; set; }
        [Column("Updated By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
    }
}
