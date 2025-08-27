using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("ivci1")]
    [Index("BookingOrJobNo", Name = "INDEX_Ivci1_BookingOrJobNo")]
    [Index("ModuleCode", Name = "INDEX_Ivci1_ModuleCode")]
    public partial class Ivci1
    {
        [Key]
        public int TrxNo { get; set; }
        [Column("CustomerID")]
        [StringLength(10)]
        public string? CustomerId { get; set; }
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [StringLength(30)]
        public string? BookingOrJobNo { get; set; }
        [StringLength(35)]
        public string? CommercialInvoiceNo { get; set; }
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("CommodityID")]
        [StringLength(10)]
        public string? CommodityId { get; set; }
        [Column("CompanyID")]
        [StringLength(10)]
        public string? CompanyId { get; set; }
        [StringLength(30)]
        public string? ContainerNo { get; set; }
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [StringLength(20)]
        public string? CustomsEntryNo { get; set; }
        [StringLength(20)]
        public string? CustomsPrevilege { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeclarationDateTime { get; set; }
        [StringLength(35)]
        public string? DeclarationNo { get; set; }
        [StringLength(3)]
        public string? DeclarationStatus { get; set; }
        [StringLength(20)]
        public string? DeclarationType { get; set; }
        [StringLength(35)]
        public string? DeliveryLocation { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3)]
        public string? Destination { get; set; }
        [Column("DivisionID")]
        [StringLength(10)]
        public string? DivisionId { get; set; }
        [StringLength(20)]
        public string? DomesticDocNo { get; set; }
        [Column("EDINo")]
        [StringLength(20)]
        public string? Edino { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(10)]
        public string? FormalityCode { get; set; }
        [StringLength(20)]
        public string? FlightNoOrVoy { get; set; }
        [StringLength(3)]
        public string? FreightCurrency { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightValue { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(30)]
        public string? HawbOrHblOrTruckWayBillNo { get; set; }
        [StringLength(3)]
        public string? InsuranceCurrency { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InsuranceValue { get; set; }
        [StringLength(3)]
        public string? InvoiceCurrency { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceValue { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? NumberOfPackage { get; set; }
        [StringLength(35)]
        public string? PickupLocation { get; set; }
        [Column("PONo")]
        [StringLength(10)]
        public string? Pono { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReleaseDateTime { get; set; }
        [StringLength(20)]
        public string? ReleasePort { get; set; }
        [StringLength(30)]
        public string? SealNo { get; set; }
        [StringLength(3)]
        public string? ShipmentMode { get; set; }
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [StringLength(30)]
        public string? ShippingMarks1 { get; set; }
        [StringLength(30)]
        public string? ShippingMarks2 { get; set; }
        [StringLength(30)]
        public string? ShippingMarks3 { get; set; }
        [StringLength(30)]
        public string? ShippingMarks4 { get; set; }
        [StringLength(30)]
        public string? ShippingMarks5 { get; set; }
        [StringLength(30)]
        public string? ShippingMarks6 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalTax { get; set; }
        [StringLength(50)]
        public string? UomPackage { get; set; }
        [StringLength(50)]
        public string? UomQuantity { get; set; }
        [StringLength(50)]
        public string? UomWeight { get; set; }
        [StringLength(50)]
        public string? UomVolume { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
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
