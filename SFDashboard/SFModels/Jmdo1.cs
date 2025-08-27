using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("jmdo1")]
    public partial class Jmdo1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectionDateTime { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDateTime { get; set; }
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
        [StringLength(22)]
        public string? DeliveryOrderNo { get; set; }
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
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [StringLength(50)]
        public string? DriverName { get; set; }
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [StringLength(30)]
        public string? DriverContactNo2 { get; set; }
        [StringLength(15)]
        public string? Driver2Code { get; set; }
        [StringLength(50)]
        public string? Driver2Name { get; set; }
        [StringLength(30)]
        public string? Driver2ContactNo1 { get; set; }
        [StringLength(30)]
        public string? Driver2ContactNo2 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        public int? Pcs { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(60)]
        public string? Remark1 { get; set; }
        [StringLength(60)]
        public string? Remark2 { get; set; }
        [StringLength(60)]
        public string? Remark3 { get; set; }
        [StringLength(60)]
        public string? Remark4 { get; set; }
        [StringLength(60)]
        public string? Remark5 { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
