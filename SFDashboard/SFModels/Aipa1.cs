using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aipa1")]
    public partial class Aipa1
    {
        [Key]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        /// <summary>
        /// Bank Account Code@vw_glch1,acc code
        /// </summary>
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        /// <summary>
        /// Define the BankCode to default the BankCode in ivcr1_5
        /// </summary>
        [StringLength(10)]
        public string? BankCode { get; set; }
        /// <summary>
        /// Define the CAF charge code when click the Freight button on the Job Costing
        /// </summary>
        [Column("CAFCode")]
        [StringLength(30)]
        public string? Cafcode { get; set; }
        /// <summary>
        /// Define the CAF Min Amt
        /// </summary>
        [Column("CAFMinAmt", TypeName = "decimal(13, 2)")]
        public decimal? CafminAmt { get; set; }
        /// <summary>
        /// Define the CAF Rate
        /// </summary>
        [Column("CAFRate", TypeName = "decimal(13, 2)")]
        public decimal? Cafrate { get; set; }
        /// <summary>
        /// Default the Cash Acc Code to the Cash Receipt
        /// </summary>
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? CashReceiptPrefix { get; set; }
        [StringLength(1)]
        public string? ChgRoundUpFlag { get; set; }
        /// <summary>
        /// Default the Other Charge as P - Prepaid or C- Collect when entering a new AWB
        /// </summary>
        [StringLength(1)]
        public string? DefaultOther { get; set; }
        /// <summary>
        /// Default the Unit of Measurement Code when entering a new AWB. The code must be a valid code in UOM Table
        /// </summary>
        [StringLength(50)]
        public string? DefaultUomCode { get; set; }
        /// <summary>
        /// Default the Freight Charge as P - Prepaid or C- Collect when entering a new AWB
        /// </summary>
        [StringLength(1)]
        public string? DefaultWeightValue { get; set; }
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        /// <summary>
        /// Define the 1st Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel1 { get; set; }
        /// <summary>
        /// Define the 2nd Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel2 { get; set; }
        /// <summary>
        /// Define the 3rd Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel3 { get; set; }
        /// <summary>
        /// Define the 4th Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel4 { get; set; }
        /// <summary>
        /// Define the 5th Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel5 { get; set; }
        /// <summary>
        /// Define the 6th Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel6 { get; set; }
        /// <summary>
        /// Define the 7th Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel7 { get; set; }
        /// <summary>
        /// Define the 8th Documents Attached label name on the Case Marks tab in aido1
        /// </summary>
        [StringLength(50)]
        public string? DocAttachLabel8 { get; set; }
        /// <summary>
        /// Print to Footer 1 of the Air Import related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        /// <summary>
        /// Print to Footer 2 of the Air Import related documents
        /// </summary>
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        /// <summary>
        /// Define the FCB charge code when click the Freight button on the Job Costing
        /// </summary>
        [Column("FCBCode")]
        [StringLength(30)]
        public string? Fcbcode { get; set; }
        /// <summary>
        /// Define the FCB Min Amt
        /// </summary>
        [Column("FCBMinAmt", TypeName = "decimal(13, 2)")]
        public decimal? FcbminAmt { get; set; }
        /// <summary>
        /// Defint the FCB Rate
        /// </summary>
        [Column("FCBRate", TypeName = "decimal(13, 2)")]
        public decimal? Fcbrate { get; set; }
        /// <summary>
        /// Default Freight Charge Collect Item Code in the Job Costing.  It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FrtChgColCode { get; set; }
        /// <summary>
        /// Default Freight Charge Collect minimum amount in the Job Costing
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtChgColMinAmt { get; set; }
        /// <summary>
        /// Default Freight Charge Collect unit rate in the Job Costing
        /// </summary>
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FrtChgColRate { get; set; }
        /// <summary>
        /// Define the Item Code for the Freight Charge. It must be a valid code in Charge List in Account Reference
        /// </summary>
        [StringLength(30)]
        public string? FrtItemCode { get; set; }
        [StringLength(1)]
        public string? FrtItemMarkupFlag { get; set; }
        /// <summary>
        /// Job Date is always update as Create Date.
        /// </summary>
        [StringLength(3)]
        public string? JobDateType { get; set; }
        /// <summary>
        /// Job running no. is created by Job running no. is created by C - Continously, M - Monthly, S - Shipment Type
        /// </summary>
        [StringLength(1)]
        public string? JobNoAutoFlag { get; set; }
        /// <summary>
        /// Job Prefix 1 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix1 { get; set; }
        /// <summary>
        /// Job Prefix 2 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix2 { get; set; }
        /// <summary>
        /// Job Prefix 3 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix3 { get; set; }
        /// <summary>
        /// Job Prefix 4 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix4 { get; set; }
        /// <summary>
        /// Job Prefix 5 Format select one value from YY,MM,DST or FXX
        /// </summary>
        [StringLength(3)]
        public string? JobPrefix5 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K1
        /// </summary>
        [StringLength(1)]
        public string? K1 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K2
        /// </summary>
        [StringLength(1)]
        public string? K2 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K3
        /// </summary>
        [StringLength(1)]
        public string? K3 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K4
        /// </summary>
        [StringLength(1)]
        public string? K4 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K5
        /// </summary>
        [StringLength(1)]
        public string? K5 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K6
        /// </summary>
        [StringLength(1)]
        public string? K6 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K7
        /// </summary>
        [StringLength(1)]
        public string? K7 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K8
        /// </summary>
        [StringLength(1)]
        public string? K8 { get; set; }
        /// <summary>
        /// For Malaysia Custom System Form K9
        /// </summary>
        [StringLength(1)]
        public string? K9 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? LastPostDate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(5)]
        public string? MarkupCode { get; set; }
        /// <summary>
        /// Foreign Exchnage Rate markup in percentage
        /// </summary>
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? MarkupRate { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextCashReceiptNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextColoadJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextConsolManifestNo { get; set; }
        /// <summary>
        /// Next Delivery Order No
        /// </summary>
        [StringLength(10)]
        public string? NextDeliveryOrderNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(10)]
        public string? NextDirectManifestNo { get; set; }
        /// <summary>
        /// Next Job No when Job No Flag is set as C
        /// </summary>
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        /// <summary>
        /// Next Job No for Mth 01 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth01 { get; set; }
        /// <summary>
        /// Next Job No for Mth 02 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth02 { get; set; }
        /// <summary>
        /// Next Job No for Mth 03 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth03 { get; set; }
        /// <summary>
        /// Next Job No for Mth 04 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth04 { get; set; }
        /// <summary>
        /// Next Job No for Mth 05 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth05 { get; set; }
        /// <summary>
        /// Next Job No for Mth 06 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth06 { get; set; }
        /// <summary>
        /// Next Job No for Mth 07 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth07 { get; set; }
        /// <summary>
        /// Next Job No for Mth 08 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth08 { get; set; }
        /// <summary>
        /// Next Job No for Mth 09 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth09 { get; set; }
        /// <summary>
        /// Next Job No for Mth 10 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth10 { get; set; }
        /// <summary>
        /// Next Job No for Mth 11 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth11 { get; set; }
        /// <summary>
        /// Next Job No for Mth 12 when Job No Flag is set as M
        /// </summary>
        [StringLength(4)]
        public string? NextJobNoMth12 { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column("NextSMAwbJobNo")]
        [StringLength(7)]
        public string? NextSmawbJobNo { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? NextTrfDate { get; set; }
        [StringLength(30)]
        public string? OrderItemCode { get; set; }
        /// <summary>
        /// NOT IN USE
        /// </summary>
        [StringLength(50)]
        public string? PostBy { get; set; }
        [StringLength(30)]
        public string? ThcCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThcMinAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ThcRate { get; set; }
        [StringLength(1)]
        public string? TotalChargeCollectFlag { get; set; }
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
    }
}
