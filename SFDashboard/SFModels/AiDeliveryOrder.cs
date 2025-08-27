using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class AiDeliveryOrder
    {
        [Column("Delivery Order No")]
        [StringLength(20)]
        public string DeliveryOrderNo { get; set; } = null!;
        [Column("Actual Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ActualDeliveryDateTime { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Available Pcs")]
        public int? AvailablePcs { get; set; }
        [Column("Awb No")]
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column("Case Mark 1")]
        [StringLength(50)]
        public string? CaseMark1 { get; set; }
        [Column("Case Mark 2")]
        [StringLength(50)]
        public string? CaseMark2 { get; set; }
        [Column("Case Mark 3")]
        [StringLength(50)]
        public string? CaseMark3 { get; set; }
        [Column("Case Mark 4")]
        [StringLength(50)]
        public string? CaseMark4 { get; set; }
        [Column("Case Mark 5")]
        [StringLength(50)]
        public string? CaseMark5 { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
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
        [Column("Delivery By")]
        [StringLength(50)]
        public string? DeliveryBy { get; set; }
        [Column("Delivery Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDate { get; set; }
        [Column("Delivery Pcs")]
        public int? DeliveryPcs { get; set; }
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
        [StringLength(50)]
        public string? Description { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Doc Attach Flag 1")]
        [StringLength(1)]
        public string? DocAttachFlag1 { get; set; }
        [Column("Doc Attach Flag 2")]
        [StringLength(1)]
        public string? DocAttachFlag2 { get; set; }
        [Column("Doc Attach Flag 3")]
        [StringLength(1)]
        public string? DocAttachFlag3 { get; set; }
        [Column("Doc Attach Flag 4")]
        [StringLength(1)]
        public string? DocAttachFlag4 { get; set; }
        [Column("Doc Attach Flag 5")]
        [StringLength(1)]
        public string? DocAttachFlag5 { get; set; }
        [Column("Doc Attach Flag 6")]
        [StringLength(1)]
        public string? DocAttachFlag6 { get; set; }
        [Column("Doc Attach Flag 7")]
        [StringLength(1)]
        public string? DocAttachFlag7 { get; set; }
        [Column("Doc Attach Flag 8")]
        [StringLength(1)]
        public string? DocAttachFlag8 { get; set; }
        [Column("Doc Attach Remark 1")]
        [StringLength(50)]
        public string? DocAttachRemark1 { get; set; }
        [Column("Doc Attach Remark 2")]
        [StringLength(50)]
        public string? DocAttachRemark2 { get; set; }
        [Column("Doc Attach Remark 3")]
        [StringLength(50)]
        public string? DocAttachRemark3 { get; set; }
        [Column("Doc Attach Remark 4")]
        [StringLength(50)]
        public string? DocAttachRemark4 { get; set; }
        [Column("Doc Attach Remark 5")]
        [StringLength(50)]
        public string? DocAttachRemark5 { get; set; }
        [Column("Doc Attach Remark 6")]
        [StringLength(50)]
        public string? DocAttachRemark6 { get; set; }
        [Column("Doc Attach Remark 7")]
        [StringLength(50)]
        public string? DocAttachRemark7 { get; set; }
        [Column("Doc Attach Remark 8")]
        [StringLength(50)]
        public string? DocAttachRemark8 { get; set; }
        [Column("Flight Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FlightDate { get; set; }
        [Column("Flight No")]
        [StringLength(12)]
        public string? FlightNo { get; set; }
        [Column("H Awb No")]
        [StringLength(20)]
        public string? HAwbNo { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("M Awb No")]
        [StringLength(20)]
        public string? MAwbNo { get; set; }
        [Column("Original Pcs")]
        public int? OriginalPcs { get; set; }
        [Column("Origin Code")]
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column("Prepared By")]
        [StringLength(50)]
        public string? PreparedBy { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark 1")]
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [Column("Remark 2")]
        [StringLength(50)]
        public string? Remark2 { get; set; }
        [Column("Remark 3")]
        [StringLength(50)]
        public string? Remark3 { get; set; }
        [Column("Remark 4")]
        [StringLength(50)]
        public string? Remark4 { get; set; }
        [Column("Remark 5")]
        [StringLength(50)]
        public string? Remark5 { get; set; }
        [Column("Sign By")]
        [StringLength(50)]
        public string? SignBy { get; set; }
        [Column("Sign Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? SignDateTime { get; set; }
        [Column("Sign ID")]
        [StringLength(17)]
        public string? SignId { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("S M Awb No")]
        [StringLength(20)]
        public string? SMAwbNo { get; set; }
        [Column("User Define 01")]
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [Column("User Define 02")]
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [Column("User Define 03")]
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [Column("User Define 04")]
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [Column("User Define 05")]
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [Column("User Define 06")]
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [Column("User Define 07")]
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [Column("User Define 08")]
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [Column("User Define 09")]
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [Column("User Define 10")]
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [Column("Vehicle No")]
        [StringLength(30)]
        public string? VehicleNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
