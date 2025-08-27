using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSidi1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Actual Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? ActualPickupDateTime { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [Column("Bl Trx No")]
        public int? BlTrxNo { get; set; }
        [Column("Collect Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CollectDateTime { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(45)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(45)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(45)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(45)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Customer Code")]
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [Column("Customer Name")]
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [Column("Deliver To Code")]
        [StringLength(10)]
        public string? DeliverToCode { get; set; }
        [Column("Deliver To Name")]
        [StringLength(80)]
        public string? DeliverToName { get; set; }
        [Column("Deliver To Address 1")]
        [StringLength(45)]
        public string? DeliverToAddress1 { get; set; }
        [Column("Deliver To Address 2")]
        [StringLength(45)]
        public string? DeliverToAddress2 { get; set; }
        [Column("Deliver To Address 3")]
        [StringLength(45)]
        public string? DeliverToAddress3 { get; set; }
        [Column("Deliver To Address 4")]
        [StringLength(45)]
        public string? DeliverToAddress4 { get; set; }
        [Column("Delivery Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? DeliveryDateTime { get; set; }
        [Column("Delivery Instruction 1")]
        [StringLength(60)]
        public string? DeliveryInstruction1 { get; set; }
        [Column("Delivery Instruction 2")]
        [StringLength(60)]
        public string? DeliveryInstruction2 { get; set; }
        [Column("Delivery Instruction 3")]
        [StringLength(60)]
        public string? DeliveryInstruction3 { get; set; }
        [Column("Delivery Instruction 4")]
        [StringLength(60)]
        public string? DeliveryInstruction4 { get; set; }
        [Column("Delivery Instruction 5")]
        [StringLength(60)]
        public string? DeliveryInstruction5 { get; set; }
        [Column("Delivery Instruction 6")]
        [StringLength(60)]
        public string? DeliveryInstruction6 { get; set; }
        [Column("Delivery Instruction 7")]
        [StringLength(60)]
        public string? DeliveryInstruction7 { get; set; }
        [Column("Delivery Instruction 8")]
        [StringLength(60)]
        public string? DeliveryInstruction8 { get; set; }
        [Column("Delivery Instruction No")]
        [StringLength(22)]
        public string? DeliveryInstructionNo { get; set; }
        [Column("Delivery Instruction Template Name")]
        [StringLength(50)]
        public string? DeliveryInstructionTemplateName { get; set; }
        [Column("Delivery To 2 Code")]
        [StringLength(10)]
        public string? DeliveryTo2Code { get; set; }
        [Column("Delivery To 2 Name")]
        [StringLength(80)]
        public string? DeliveryTo2Name { get; set; }
        [Column("Delivery To 2 Address 1")]
        [StringLength(45)]
        public string? DeliveryTo2Address1 { get; set; }
        [Column("Delivery To 2 Address 2")]
        [StringLength(45)]
        public string? DeliveryTo2Address2 { get; set; }
        [Column("Delivery To 2 Address 3")]
        [StringLength(45)]
        public string? DeliveryTo2Address3 { get; set; }
        [Column("Delivery To 2 Address 4")]
        [StringLength(45)]
        public string? DeliveryTo2Address4 { get; set; }
        [Column("Delivery To 3 Code")]
        [StringLength(10)]
        public string? DeliveryTo3Code { get; set; }
        [Column("Delivery To 3 Name")]
        [StringLength(80)]
        public string? DeliveryTo3Name { get; set; }
        [Column("Delivery To 3 Address 1")]
        [StringLength(45)]
        public string? DeliveryTo3Address1 { get; set; }
        [Column("Delivery To 3 Address 2")]
        [StringLength(45)]
        public string? DeliveryTo3Address2 { get; set; }
        [Column("Delivery To 3 Address 3")]
        [StringLength(45)]
        public string? DeliveryTo3Address3 { get; set; }
        [Column("Delivery To 3 Address 4")]
        [StringLength(45)]
        public string? DeliveryTo3Address4 { get; set; }
        [Column("Delivery Type")]
        [StringLength(5)]
        public string? DeliveryType { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Edi Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Feeder Vessel Name")]
        [StringLength(50)]
        public string? FeederVesselName { get; set; }
        [Column("Feeder Voyage")]
        [StringLength(20)]
        public string? FeederVoyage { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Letter Of Credit No")]
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        [Column("No Of 20ft Container")]
        public int? NoOf20ftContainer { get; set; }
        [Column("No Of 40ft Container")]
        public int? NoOf40ftContainer { get; set; }
        [Column("No Of 45ft Container")]
        public int? NoOf45ftContainer { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark 1")]
        [StringLength(60)]
        public string? Remark1 { get; set; }
        [Column("Remark 2")]
        [StringLength(60)]
        public string? Remark2 { get; set; }
        [Column("Remark 3")]
        [StringLength(60)]
        public string? Remark3 { get; set; }
        [Column("Remark 4")]
        [StringLength(60)]
        public string? Remark4 { get; set; }
        [Column("Remark 5")]
        [StringLength(60)]
        public string? Remark5 { get; set; }
        [Column("Request Transport No")]
        [StringLength(20)]
        public string? RequestTransportNo { get; set; }
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Total Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? TotalGrossWeight { get; set; }
        [Column("Total Pcs")]
        public int? TotalPcs { get; set; }
        [Column("Total Volume", TypeName = "decimal(13, 4)")]
        public decimal? TotalVolume { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Company Address 1")]
        [StringLength(50)]
        public string? TransportCompanyAddress1 { get; set; }
        [Column("Transport Company Address 2")]
        [StringLength(50)]
        public string? TransportCompanyAddress2 { get; set; }
        [Column("Transport Company Address 3")]
        [StringLength(50)]
        public string? TransportCompanyAddress3 { get; set; }
        [Column("Transport Company Address 4")]
        [StringLength(50)]
        public string? TransportCompanyAddress4 { get; set; }
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
        [Column("Vehicle No")]
        [StringLength(10)]
        public string? VehicleNo { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
        [Column("Branch Code")]
        [StringLength(10)]
        public string? BranchCode { get; set; }
        [Column("Department Code")]
        [StringLength(10)]
        public string? DepartmentCode { get; set; }
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
