using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ssst1")]
    public partial class Ssst1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string ConsigneeCode { get; set; } = null!;
        [StringLength(10)]
        public string CustomerCode { get; set; } = null!;
        [Column("DBlChargeWeight", TypeName = "decimal(13, 4)")]
        public decimal? DblChargeWeight { get; set; }
        [Column("DBlFrtAmt", TypeName = "decimal(13, 2)")]
        public decimal? DblFrtAmt { get; set; }
        [Column("DBlFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? DblFrtCostAmt { get; set; }
        [Column("DBlPcs")]
        public int? DblPcs { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtBillAmt { get; set; }
        [Column("HBlChargeWeight", TypeName = "decimal(13, 2)")]
        public decimal? HblChargeWeight { get; set; }
        [Column("HBlFrtAmt", TypeName = "decimal(13, 2)")]
        public decimal? HblFrtAmt { get; set; }
        [Column("HBlFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? HblFrtCostAmt { get; set; }
        [Column("HBlPcs")]
        public int? HblPcs { get; set; }
        [StringLength(6)]
        public string JobMth { get; set; } = null!;
        [Column("MBlChargeWeight", TypeName = "decimal(13, 4)")]
        public decimal? MblChargeWeight { get; set; }
        [Column("MBlFrtAmt", TypeName = "decimal(13, 2)")]
        public decimal? MblFrtAmt { get; set; }
        [Column("MBlFrtCostAmt", TypeName = "decimal(13, 2)")]
        public decimal? MblFrtCostAmt { get; set; }
        [Column("MBlPcs")]
        public int? MblPcs { get; set; }
        [Column("NoOfDBlShipment")]
        public int? NoOfDblShipment { get; set; }
        [Column("NoOfMBlShipment")]
        public int? NoOfMblShipment { get; set; }
        [Column("NoOfHBlShipment")]
        public int? NoOfHblShipment { get; set; }
        public int? NoOfOtherShipment { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        [Column("NoOfDBlUse")]
        public int? NoOfDblUse { get; set; }
        [Column("NoOfMBlUse")]
        public int? NoOfMblUse { get; set; }
        [Column("NoOfHBlUse")]
        public int? NoOfHblUse { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OtherChargeWeight { get; set; }
        public int? OtherPcs { get; set; }
        [StringLength(3)]
        public string PortOfLoadingCode { get; set; } = null!;
        [StringLength(3)]
        public string PortOfDischargeCode { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(12)]
        public string ShippingLineCode { get; set; } = null!;
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalFrtCostAmt { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalSalesAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        public int? TotalNoOfShipment { get; set; }
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

        [ForeignKey("PortOfDischargeCode")]
        [InverseProperty("Ssst1PortOfDischargeCodeNavigations")]
        public virtual Rcap1 PortOfDischargeCodeNavigation { get; set; } = null!;
        [ForeignKey("PortOfLoadingCode")]
        [InverseProperty("Ssst1PortOfLoadingCodeNavigations")]
        public virtual Rcap1 PortOfLoadingCodeNavigation { get; set; } = null!;
        [ForeignKey("ShippingLineCode")]
        [InverseProperty("Ssst1s")]
        public virtual Rcsl1 ShippingLineCodeNavigation { get; set; } = null!;
    }
}
