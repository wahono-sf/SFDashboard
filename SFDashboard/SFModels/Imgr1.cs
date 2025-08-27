using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("imgr1")]
    [Index("ContainerNo", Name = "INDEX_Imgr1_ContainerNo")]
    [Index("CustomerCode", Name = "INDEX_Imgr1_CustomerCode")]
    [Index("CustomerName", Name = "INDEX_Imgr1_CustomerName")]
    [Index("DeliveryOrderNo", Name = "INDEX_Imgr1_DeliveryOrderNo")]
    [Index("GoodsReceiptNoteNo", Name = "INDEX_Imgr1_GoodsReceiptNoteNo")]
    [Index("InvoiceNo", Name = "INDEX_Imgr1_InvoiceNo")]
    [Index("JobNo", Name = "INDEX_Imgr1_JobNo")]
    [Index("LastBillDate", Name = "INDEX_Imgr1_LastBillDate")]
    [Index("MawbOblNo", Name = "INDEX_Imgr1_MawbOblNo")]
    [Index("ReceiptDate", Name = "INDEX_Imgr1_ReceiptDate")]
    [Index("RefNo", Name = "INDEX_Imgr1_RefNo")]
    [Index("VesselName", Name = "INDEX_Imgr1_VesselName")]
    [Index("WarehouseCode", Name = "INDEX_Imgr1_WarehouseCode")]
    [Index("WarehouseName", Name = "INDEX_Imgr1_WarehouseName")]
    public partial class Imgr1
    {
        public Imgr1()
        {
            Imgr2s = new HashSet<Imgr2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(20)]
        public string GoodsReceiptNoteNo { get; set; } = null!;
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
        [StringLength(255)]
        public string? ContainerNo { get; set; }
        [StringLength(13)]
        public string? ContainerNo1 { get; set; }
        [StringLength(13)]
        public string? ContainerNo2 { get; set; }
        [StringLength(13)]
        public string? ContainerNo3 { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [StringLength(20)]
        public string? CustGrnNo { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(50)]
        public string? CustomerAddress1 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress2 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress3 { get; set; }
        [StringLength(50)]
        public string? CustomerAddress4 { get; set; }
        [StringLength(50)]
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
        public int? EdiCount { get; set; }
        [StringLength(50)]
        public string? EventTemplateName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExecuteDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightAmt { get; set; }
        [StringLength(3)]
        public string? FreightCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? FreightCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightLocalAmt { get; set; }
        [StringLength(50)]
        public string? HawbHblNo { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceAmt { get; set; }
        [StringLength(3)]
        public string? InsuranceCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? InsuranceCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(50)]
        public string? InvoiceNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastBillDate { get; set; }
        [StringLength(50)]
        public string? MawbOblNo { get; set; }
        public int? OrderType { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(45)]
        public string? OriginName { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OthChgAmt { get; set; }
        [StringLength(3)]
        public string? OthChgCurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? OthChgCurrRate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? OthChgLocalAmt { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(20)]
        public string? PurchaseOrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PutAwayDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceiptDate { get; set; }
        [StringLength(50)]
        public string? ReceiveBy { get; set; }
        [StringLength(50)]
        public string? ReceiveFrom { get; set; }
        [StringLength(50)]
        public string? RefNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(255)]
        public string? SealNo { get; set; }
        [StringLength(30)]
        public string? SourceJobNo { get; set; }
        [StringLength(10)]
        public string? TableNo { get; set; }
        [StringLength(50)]
        public string? TallyBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TallyDateTime { get; set; }
        [StringLength(30)]
        public string? TemponaryNo { get; set; }
        [Column("TotalCIFAmt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCifamt { get; set; }
        [Column("TotalCIFVatAmt", TypeName = "decimal(13, 2)")]
        public decimal? TotalCifvatAmt { get; set; }
        public int? TotalItem { get; set; }
        public int? TotalReceiptQty { get; set; }
        public int? TotalReceiptQty1 { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptSpace { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptVolume { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? TotalReceiptWeight { get; set; }
        [StringLength(10)]
        public string? TotalVatCode { get; set; }
        [Column(TypeName = "decimal(6, 3)")]
        public decimal? TotalVatRate { get; set; }
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
        public string? TransportCompanyContactName { get; set; }
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
        [StringLength(80)]
        public string? VesselName { get; set; }
        [StringLength(6)]
        public string? WarehouseCode { get; set; }
        [StringLength(80)]
        public string? WarehouseName { get; set; }
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

        [InverseProperty("TrxNoNavigation")]
        public virtual ICollection<Imgr2> Imgr2s { get; set; }
    }
}
