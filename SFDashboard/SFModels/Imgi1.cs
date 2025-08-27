using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgi1")]
    [Index("ContainerNo", Name = "INDEX_Imgi1_ContainerNo")]
    [Index("CustomerCode", Name = "INDEX_Imgi1_CustomerCode")]
    [Index("CustomerName", Name = "INDEX_Imgi1_CustomerName")]
    [Index("DeliveryOrderNo", Name = "INDEX_Imgi1_DeliveryOrderNo")]
    [Index("DeliveryToCode", Name = "INDEX_Imgi1_DeliveryToCode")]
    [Index("GoodsIssueNoteNo", Name = "INDEX_Imgi1_GoodsIssueNoteNo")]
    [Index("InvoiceNo", Name = "INDEX_Imgi1_InvoiceNo")]
    [Index("IssueDateTime", Name = "INDEX_Imgi1_IssueDateTime")]
    [Index("JobNo", Name = "INDEX_Imgi1_JobNo")]
    [Index("MawbOblNo", Name = "INDEX_Imgi1_MawbOblNo")]
    [Index("RefNo", Name = "INDEX_Imgi1_RefNo")]
    [Index("TransportCompanyCode", Name = "INDEX_Imgi1_TransportCompanyCode")]
    [Index("VesselName", Name = "INDEX_Imgi1_VesselName")]
    public partial class Imgi1
    {
        [Key]
        public int TrxNo { get; set; }
        [StringLength(1)]
        public string? BillableFlag { get; set; }
        [StringLength(60)]
        public string? BillingInstruction1 { get; set; }
        [StringLength(60)]
        public string? BillingInstruction2 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? BillQty { get; set; }
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
        public string? CollectFromContactName { get; set; }
        [StringLength(50)]
        public string? CompleteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompleteDate { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [StringLength(20)]
        public string? CustGinNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(2000)]
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
        [StringLength(50)]
        public string? DeliveryToContactName { get; set; }
        [StringLength(50)]
        public string? Description1 { get; set; }
        [StringLength(50)]
        public string? Description2 { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(45)]
        public string? DestName { get; set; }
        [StringLength(15)]
        public string? DriverCode1 { get; set; }
        [StringLength(80)]
        public string? DriverName1 { get; set; }
        [StringLength(15)]
        public string? DriverCode2 { get; set; }
        [StringLength(80)]
        public string? DriverName2 { get; set; }
        public int? EdiCount { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [StringLength(20)]
        public string GoodsIssueNoteNo { get; set; } = null!;
        [StringLength(50)]
        public string? HawbHblNo { get; set; }
        [StringLength(2000)]
        public string? InvoiceNo { get; set; }
        [StringLength(50)]
        public string? IssueBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IssueDateTime { get; set; }
        [StringLength(50)]
        public string? IssueTo { get; set; }
        [StringLength(10)]
        public string? IssueType { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastBillDate { get; set; }
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        public int? OrderType { get; set; }
        public int? PackingTrxNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PickDateTime { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(2000)]
        public string? Remark { get; set; }
        [StringLength(20)]
        public string? SalesOrderNo { get; set; }
        [StringLength(1)]
        public string? ScrapFlag { get; set; }
        [StringLength(255)]
        public string? SealNo { get; set; }
        [StringLength(2000)]
        public string? SerialNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ShippingWeight { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(10)]
        public string? TableNo { get; set; }
        [StringLength(2000)]
        public string? TotalIssueDimension { get; set; }
        public int? TotalIssueQty { get; set; }
        public int? TotalIssueQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueSpace { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalIssueWeight { get; set; }
        public int? TotalItem { get; set; }
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
        [StringLength(30)]
        public string? TransportJobNo { get; set; }
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
        [StringLength(50)]
        public string? UserDefine11 { get; set; }
        [StringLength(50)]
        public string? UserDefine12 { get; set; }
        [StringLength(50)]
        public string? UserDefine13 { get; set; }
        [StringLength(50)]
        public string? UserDefine14 { get; set; }
        [StringLength(50)]
        public string? UserDefine15 { get; set; }
        [StringLength(50)]
        public string? UserDefine16 { get; set; }
        [StringLength(50)]
        public string? UserDefine17 { get; set; }
        [StringLength(50)]
        public string? UserDefine18 { get; set; }
        [StringLength(50)]
        public string? UserDefine19 { get; set; }
        [StringLength(50)]
        public string? UserDefine20 { get; set; }
        [StringLength(12)]
        public string? VehicleNo1 { get; set; }
        [StringLength(12)]
        public string? VehicleNo2 { get; set; }
        [StringLength(80)]
        public string? VesselName { get; set; }
        [StringLength(50)]
        public string WorkStation { get; set; } = null!;
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
