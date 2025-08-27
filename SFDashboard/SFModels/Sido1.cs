using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sido1")]
    public partial class Sido1
    {
        public Sido1()
        {
            Sido2s = new HashSet<Sido2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        public int? BlTrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectDateTime { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
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
        [StringLength(60)]
        public string? DeliveryInstruction6 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction7 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction8 { get; set; }
        [StringLength(22)]
        public string? DeliveryInstructionNo { get; set; }
        [StringLength(50)]
        public string? DeliveryOnBehalfName { get; set; }
        [StringLength(22)]
        public string? DeliveryOrderNo { get; set; }
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [StringLength(80)]
        public string? DeliverToName { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress1 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress2 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress3 { get; set; }
        [StringLength(50)]
        public string? DeliverToAddress4 { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
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
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        public byte? PrintCount { get; set; }
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
        [StringLength(50)]
        public string? SignBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SignDateTime { get; set; }
        [StringLength(17)]
        public string? SignId { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
        [StringLength(50)]
        public string? UserDefine01 { get; set; }
        [StringLength(50)]
        public string? UserDefine02 { get; set; }
        [StringLength(50)]
        public string? UserDefine03 { get; set; }
        [StringLength(50)]
        public string? UserDefine04 { get; set; }
        [StringLength(50)]
        public string? UserDefine05 { get; set; }
        [StringLength(50)]
        public string? UserDefine06 { get; set; }
        [StringLength(50)]
        public string? UserDefine07 { get; set; }
        [StringLength(50)]
        public string? UserDefine08 { get; set; }
        [StringLength(50)]
        public string? UserDefine09 { get; set; }
        [StringLength(50)]
        public string? UserDefine10 { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Wages { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Wages2 { get; set; }
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
        public DateTime CreateDatetime { get; set; }
        [StringLength(50)]
        public string UpdateBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UpdateDateTime { get; set; }
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }

        [ForeignKey("DivisionCode")]
        [InverseProperty("Sido1s")]
        public virtual Acdv1? DivisionCodeNavigation { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sido2> Sido2s { get; set; }
    }
}
