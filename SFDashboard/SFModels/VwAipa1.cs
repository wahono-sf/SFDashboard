using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwAipa1
    {
        [Column("Unique Key")]
        [StringLength(1)]
        public string UniqueKey { get; set; } = null!;
        [Column("Bank Acc Code")]
        [StringLength(15)]
        public string? BankAccCode { get; set; }
        [Column("Bank Code")]
        [StringLength(10)]
        public string? BankCode { get; set; }
        [Column("CAF Code")]
        [StringLength(30)]
        public string? CafCode { get; set; }
        [Column("CAF Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? CafMinAmt { get; set; }
        [Column("CAF Rate", TypeName = "decimal(13, 2)")]
        public decimal? CafRate { get; set; }
        [Column("Cash Acc Code")]
        [StringLength(15)]
        public string? CashAccCode { get; set; }
        [Column("Cash Receipt Prefix")]
        [StringLength(5)]
        public string? CashReceiptPrefix { get; set; }
        [Column("Charge Round Up Flag")]
        [StringLength(1)]
        public string? ChargeRoundUpFlag { get; set; }
        [Column("Default Other")]
        [StringLength(1)]
        public string? DefaultOther { get; set; }
        [Column("Default Uom Code")]
        [StringLength(3)]
        public string? DefaultUomCode { get; set; }
        [Column("Default Weight Value")]
        [StringLength(1)]
        public string? DefaultWeightValue { get; set; }
        [Column("Direct House Flag")]
        [StringLength(1)]
        public string? DirectHouseFlag { get; set; }
        [Column("Doc Attach Label 1")]
        [StringLength(50)]
        public string? DocAttachLabel1 { get; set; }
        [Column("Doc Attach Label 2")]
        [StringLength(50)]
        public string? DocAttachLabel2 { get; set; }
        [Column("Doc Attach Label 3")]
        [StringLength(50)]
        public string? DocAttachLabel3 { get; set; }
        [Column("Doc Attach Label 4")]
        [StringLength(50)]
        public string? DocAttachLabel4 { get; set; }
        [Column("Doc Attach Label 5")]
        [StringLength(50)]
        public string? DocAttachLabel5 { get; set; }
        [Column("Doc Attach Label 6")]
        [StringLength(50)]
        public string? DocAttachLabel6 { get; set; }
        [Column("Doc Attach Label 7")]
        [StringLength(50)]
        public string? DocAttachLabel7 { get; set; }
        [Column("Doc Attach Label 8")]
        [StringLength(50)]
        public string? DocAttachLabel8 { get; set; }
        [Column("Document Footer 1")]
        [StringLength(255)]
        public string? DocumentFooter1 { get; set; }
        [Column("Document Footer 2")]
        [StringLength(255)]
        public string? DocumentFooter2 { get; set; }
        [Column("FCB Code")]
        [StringLength(30)]
        public string? FcbCode { get; set; }
        [Column("FCB Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? FcbMinAmt { get; set; }
        [Column("FCB Rate", TypeName = "decimal(13, 2)")]
        public decimal? FcbRate { get; set; }
        [Column("Frt Chg Col Code")]
        [StringLength(30)]
        public string? FrtChgColCode { get; set; }
        [Column("Frt Chg Col Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? FrtChgColMinAmt { get; set; }
        [Column("Frt Chg Col Rate", TypeName = "decimal(13, 2)")]
        public decimal? FrtChgColRate { get; set; }
        [Column("Frt Item Code")]
        [StringLength(30)]
        public string? FrtItemCode { get; set; }
        [Column("Frt Item Markup Flag")]
        [StringLength(1)]
        public string? FrtItemMarkupFlag { get; set; }
        [Column("Job Date Type")]
        [StringLength(3)]
        public string? JobDateType { get; set; }
        [Column("Job No Auto Flag")]
        [StringLength(1)]
        public string? JobNoAutoFlag { get; set; }
        [Column("Job Prefix 1")]
        [StringLength(3)]
        public string? JobPrefix1 { get; set; }
        [Column("Job Prefix 2")]
        [StringLength(3)]
        public string? JobPrefix2 { get; set; }
        [Column("Job Prefix 3")]
        [StringLength(3)]
        public string? JobPrefix3 { get; set; }
        [Column("Job Prefix 4")]
        [StringLength(3)]
        public string? JobPrefix4 { get; set; }
        [Column("Job Prefix 5")]
        [StringLength(3)]
        public string? JobPrefix5 { get; set; }
        [StringLength(1)]
        public string? K1 { get; set; }
        [StringLength(1)]
        public string? K2 { get; set; }
        [StringLength(1)]
        public string? K3 { get; set; }
        [StringLength(1)]
        public string? K4 { get; set; }
        [StringLength(1)]
        public string? K5 { get; set; }
        [StringLength(1)]
        public string? K6 { get; set; }
        [StringLength(1)]
        public string? K7 { get; set; }
        [StringLength(1)]
        public string? K8 { get; set; }
        [StringLength(1)]
        public string? K9 { get; set; }
        [Column("Last Post Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LastPostDate { get; set; }
        [Column("Markup Code")]
        [StringLength(5)]
        public string? MarkupCode { get; set; }
        [Column("Markup Rate", TypeName = "decimal(6, 3)")]
        public decimal? MarkupRate { get; set; }
        [Column("Next Cash Receipt No")]
        [StringLength(10)]
        public string? NextCashReceiptNo { get; set; }
        [Column("Next Coload Job No")]
        [StringLength(7)]
        public string? NextColoadJobNo { get; set; }
        [Column("Next Consol Job No")]
        [StringLength(7)]
        public string? NextConsolJobNo { get; set; }
        [Column("Next Consol Manifest No")]
        [StringLength(10)]
        public string? NextConsolManifestNo { get; set; }
        [Column("Next Delivery Order No")]
        [StringLength(10)]
        public string? NextDeliveryOrderNo { get; set; }
        [Column("Next Direct Job No")]
        [StringLength(7)]
        public string? NextDirectJobNo { get; set; }
        [Column("Next Direct Manifest No")]
        [StringLength(10)]
        public string? NextDirectManifestNo { get; set; }
        [Column("Next Job No")]
        [StringLength(7)]
        public string? NextJobNo { get; set; }
        [Column("Next Job No Mth 01")]
        [StringLength(4)]
        public string? NextJobNoMth01 { get; set; }
        [Column("Next Job No Mth 02")]
        [StringLength(4)]
        public string? NextJobNoMth02 { get; set; }
        [Column("Next Job No Mth 03")]
        [StringLength(4)]
        public string? NextJobNoMth03 { get; set; }
        [Column("Next Job No Mth 04")]
        [StringLength(4)]
        public string? NextJobNoMth04 { get; set; }
        [Column("Next Job No Mth 05")]
        [StringLength(4)]
        public string? NextJobNoMth05 { get; set; }
        [Column("Next Job No Mth 06")]
        [StringLength(4)]
        public string? NextJobNoMth06 { get; set; }
        [Column("Next Job No Mth 07")]
        [StringLength(4)]
        public string? NextJobNoMth07 { get; set; }
        [Column("Next Job No Mth 08")]
        [StringLength(4)]
        public string? NextJobNoMth08 { get; set; }
        [Column("Next Job No Mth 09")]
        [StringLength(4)]
        public string? NextJobNoMth09 { get; set; }
        [Column("Next Job No Mth 10")]
        [StringLength(4)]
        public string? NextJobNoMth10 { get; set; }
        [Column("Next Job No Mth 11")]
        [StringLength(4)]
        public string? NextJobNoMth11 { get; set; }
        [Column("Next Job No Mth 12")]
        [StringLength(4)]
        public string? NextJobNoMth12 { get; set; }
        [Column("Next S M Awb Job No")]
        [StringLength(7)]
        public string? NextSMAwbJobNo { get; set; }
        [Column("Next Trf Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? NextTrfDate { get; set; }
        [Column("Order Item Code")]
        [StringLength(30)]
        public string? OrderItemCode { get; set; }
        [Column("Post By")]
        [StringLength(50)]
        public string? PostBy { get; set; }
        [Column("Thc Code")]
        [StringLength(30)]
        public string? ThcCode { get; set; }
        [Column("Thc Min Amt", TypeName = "decimal(13, 2)")]
        public decimal? ThcMinAmt { get; set; }
        [Column("Thc Rate", TypeName = "decimal(13, 2)")]
        public decimal? ThcRate { get; set; }
        [Column("Total Charge Collect Flag")]
        [StringLength(1)]
        public string? TotalChargeCollectFlag { get; set; }
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
