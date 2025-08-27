using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTodo1
    {
        [Column("Delivery Order No")]
        [StringLength(20)]
        public string DeliveryOrderNo { get; set; } = null!;
        [Column("Actual Wt", TypeName = "decimal(13, 4)")]
        public decimal? ActualWt { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Balance Qty", TypeName = "decimal(13, 4)")]
        public decimal? BalanceQty { get; set; }
        [Column("Bill To Code")]
        [StringLength(10)]
        public string? BillToCode { get; set; }
        [Column("Bill To Name")]
        [StringLength(80)]
        public string? BillToName { get; set; }
        [Column("Case Mark")]
        [StringLength(50)]
        public string? CaseMark { get; set; }
        [Column("Charge Wt", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWt { get; set; }
        [Column("Consignee Code")]
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [Column("Consignee Name")]
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [Column("Consignee Address 1")]
        [StringLength(45)]
        public string? ConsigneeAddress1 { get; set; }
        [Column("Consignee Address 2")]
        [StringLength(45)]
        public string? ConsigneeAddress2 { get; set; }
        [Column("Consignee Address 3")]
        [StringLength(45)]
        public string? ConsigneeAddress3 { get; set; }
        [Column("Consignee Address 4")]
        [StringLength(45)]
        public string? ConsigneeAddress4 { get; set; }
        [Column("Date Of Signing")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DateOfSigning { get; set; }
        [Column("Delivery By")]
        [StringLength(30)]
        public string? DeliveryBy { get; set; }
        [Column("Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDateTime { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(45)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(45)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(45)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(45)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(40)]
        public string? Description { get; set; }
        [Column("Document Attached")]
        [StringLength(1)]
        public string? DocumentAttached { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Flight No")]
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column("Hawb No")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Mawb No")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [Column("No Of 20ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container", TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftContainer { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Packages No", TypeName = "decimal(13, 4)")]
        public decimal? PackagesNo { get; set; }
        [Column("Prepared By")]
        [StringLength(20)]
        public string? PreparedBy { get; set; }
        [Column("Qty From Awb", TypeName = "decimal(13, 4)")]
        public decimal? QtyFromAwb { get; set; }
        [StringLength(50)]
        public string? Remarks { get; set; }
        [Column("Sawb No")]
        [StringLength(20)]
        public string? SawbNo { get; set; }
        [Column("Signee ID")]
        [StringLength(17)]
        public string? SigneeId { get; set; }
        [Column("Signee Name")]
        [StringLength(20)]
        public string? SigneeName { get; set; }
        [Column("Time Of Signing")]
        [StringLength(5)]
        [Unicode(false)]
        public string? TimeOfSigning { get; set; }
        [Column("User Define 01")]
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column("Vehical No")]
        [StringLength(12)]
        public string? VehicalNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
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
