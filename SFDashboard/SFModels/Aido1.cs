using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("aido1")]
    public partial class Aido1
    {
        [Key]
        [StringLength(20)]
        public string DeliveryOrderNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? ActualDeliveryDateTime { get; set; }
        [StringLength(50)]
        public string? ApproveBy { get; set; }
        public int? AvailablePcs { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [StringLength(50)]
        public string? CaseMark1 { get; set; }
        [StringLength(50)]
        public string? CaseMark2 { get; set; }
        [StringLength(50)]
        public string? CaseMark3 { get; set; }
        [StringLength(50)]
        public string? CaseMark4 { get; set; }
        [StringLength(50)]
        public string? CaseMark5 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [StringLength(50)]
        public string? DeliveryBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction1 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction2 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction3 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction4 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction5 { get; set; }
        public int? DeliveryPcs { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag1 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag2 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag3 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag4 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag5 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag6 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag7 { get; set; }
        [StringLength(1)]
        public string? DocAttachFlag8 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark1 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark2 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark3 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark4 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark5 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark6 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark7 { get; set; }
        [StringLength(50)]
        public string? DocAttachRemark8 { get; set; }
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(12)]
        public string? FlightNo { get; set; }
        [Column("HAwbNo")]
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("MAwbNo")]
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [StringLength(255)]
        public string? Note { get; set; }
        public int? OriginalPcs { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [StringLength(50)]
        public string? PreparedBy { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [StringLength(50)]
        public string? Remark2 { get; set; }
        [StringLength(50)]
        public string? Remark3 { get; set; }
        [StringLength(50)]
        public string? Remark4 { get; set; }
        [StringLength(50)]
        public string? Remark5 { get; set; }
        [StringLength(50)]
        public string? SignBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SignDateTime { get; set; }
        [StringLength(17)]
        public string? SignId { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("SMAwbNo")]
        [StringLength(20)]
        public string? SmawbNo { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? TransportAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportAddress4 { get; set; }
        [StringLength(255)]
        public string? UserDefine01 { get; set; }
        [StringLength(255)]
        public string? UserDefine02 { get; set; }
        [StringLength(255)]
        public string? UserDefine03 { get; set; }
        [StringLength(255)]
        public string? UserDefine04 { get; set; }
        [StringLength(255)]
        public string? UserDefine05 { get; set; }
        [StringLength(255)]
        public string? UserDefine06 { get; set; }
        [StringLength(255)]
        public string? UserDefine07 { get; set; }
        [StringLength(255)]
        public string? UserDefine08 { get; set; }
        [StringLength(255)]
        public string? UserDefine09 { get; set; }
        [StringLength(255)]
        public string? UserDefine10 { get; set; }
        [StringLength(30)]
        public string? VehicleNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Weight { get; set; }
        public int TrxNo { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
    }
}
