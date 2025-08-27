using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("sidi1")]
    public partial class Sidi1
    {
        public Sidi1()
        {
            Sidi2s = new HashSet<Sidi2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualPickupDateTime { get; set; }
        [StringLength(30)]
        public string? BlNo { get; set; }
        public int? BlTrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectDateTime { get; set; }
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
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(10)]
        public string? DeliverToCode { get; set; }
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
        [StringLength(60)]
        public string? DeliveryInstruction6 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction7 { get; set; }
        [StringLength(60)]
        public string? DeliveryInstruction8 { get; set; }
        [StringLength(22)]
        public string? DeliveryInstructionNo { get; set; }
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [StringLength(10)]
        public string? DeliveryTo2Code { get; set; }
        [StringLength(80)]
        public string? DeliveryTo2Name { get; set; }
        [StringLength(50)]
        public string? DeliveryTo2Address1 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo2Address2 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo2Address3 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo2Address4 { get; set; }
        [StringLength(10)]
        public string? DeliveryTo3Code { get; set; }
        [StringLength(80)]
        public string? DeliveryTo3Name { get; set; }
        [StringLength(50)]
        public string? DeliveryTo3Address1 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo3Address2 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo3Address3 { get; set; }
        [StringLength(50)]
        public string? DeliveryTo3Address4 { get; set; }
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
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
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
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
        [StringLength(20)]
        public string? RequestTransportNo { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        public int? TotalPcs { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
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
        [StringLength(10)]
        public string? VehicleNo { get; set; }
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

        [ForeignKey("CommodityCode")]
        [InverseProperty("Sidi1s")]
        public virtual Rccm1? CommodityCodeNavigation { get; set; }
        [ForeignKey("DivisionCode")]
        [InverseProperty("Sidi1s")]
        public virtual Acdv1? DivisionCodeNavigation { get; set; }
        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Sidi2> Sidi2s { get; set; }
    }
}
