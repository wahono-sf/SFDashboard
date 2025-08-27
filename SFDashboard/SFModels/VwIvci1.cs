using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwIvci1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Customer ID")]
        [StringLength(10)]
        public string? CustomerId { get; set; }
        [Column("Customer Name")]
        [StringLength(50)]
        public string? CustomerName { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Batch No")]
        [StringLength(20)]
        public string? BatchNo { get; set; }
        [Column("Booking Or Job No")]
        [StringLength(30)]
        public string? BookingOrJobNo { get; set; }
        [Column("Commercial Invoice No")]
        [StringLength(35)]
        public string? CommercialInvoiceNo { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Commodity ID")]
        [StringLength(10)]
        public string? CommodityId { get; set; }
        [Column("Company ID")]
        [StringLength(10)]
        public string? CompanyId { get; set; }
        [Column("Container No")]
        [StringLength(30)]
        public string? ContainerNo { get; set; }
        [Column("Country Of Origin")]
        [StringLength(2)]
        public string? CountryOfOrigin { get; set; }
        [Column("Customs Entry No")]
        [StringLength(20)]
        public string? CustomsEntryNo { get; set; }
        [Column("Customs Previlege")]
        [StringLength(20)]
        public string? CustomsPrevilege { get; set; }
        [Column("Declaration Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DeclarationDateTime { get; set; }
        [Column("Declaration No")]
        [StringLength(35)]
        public string? DeclarationNo { get; set; }
        [Column("Declaration Status")]
        [StringLength(3)]
        public string? DeclarationStatus { get; set; }
        [Column("Declaration Type")]
        [StringLength(20)]
        public string? DeclarationType { get; set; }
        [Column("Delivery Location")]
        [StringLength(35)]
        public string? DeliveryLocation { get; set; }
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(3)]
        public string? Destination { get; set; }
        [Column("Division ID")]
        [StringLength(10)]
        public string? DivisionId { get; set; }
        [Column("Domestic Doc No")]
        [StringLength(20)]
        public string? DomesticDocNo { get; set; }
        [Column("EDI No")]
        [StringLength(20)]
        public string? EdiNo { get; set; }
        [Column("Entry Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EntryDate { get; set; }
        [Column("Flight No Or Voy")]
        [StringLength(20)]
        public string? FlightNoOrVoy { get; set; }
        [Column("Formality Code")]
        [StringLength(10)]
        public string? FormalityCode { get; set; }
        [Column("Freight Currency")]
        [StringLength(3)]
        public string? FreightCurrency { get; set; }
        [Column("Freight Value", TypeName = "decimal(13, 2)")]
        public decimal? FreightValue { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 2)")]
        public decimal? GrossWeight { get; set; }
        [Column("HAwb Or HBl Or Truck Way Bill No")]
        [StringLength(20)]
        public string? HawbOrHblOrTruckWayBillNo { get; set; }
        [Column("Insurance Currency")]
        [StringLength(3)]
        public string? InsuranceCurrency { get; set; }
        [Column("Insurance Value", TypeName = "decimal(13, 2)")]
        public decimal? InsuranceValue { get; set; }
        [Column("Invoice Currency")]
        [StringLength(3)]
        public string? InvoiceCurrency { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice Value", TypeName = "decimal(13, 2)")]
        public decimal? InvoiceValue { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Net Weight", TypeName = "decimal(13, 2)")]
        public decimal? NetWeight { get; set; }
        [Column("Number Of Package", TypeName = "decimal(10, 0)")]
        public decimal? NumberOfPackage { get; set; }
        [Column("Pickup Location")]
        [StringLength(35)]
        public string? PickupLocation { get; set; }
        [Column("PO No")]
        [StringLength(10)]
        public string? PoNo { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal? Quantity { get; set; }
        [Column("Release Date Time")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ReleaseDateTime { get; set; }
        [Column("Release Port")]
        [StringLength(20)]
        public string? ReleasePort { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Shipment Mode")]
        [StringLength(3)]
        public string? ShipmentMode { get; set; }
        [Column("Shipment Type")]
        [StringLength(3)]
        public string? ShipmentType { get; set; }
        [Column("Shipping Marks 1")]
        [StringLength(30)]
        public string? ShippingMarks1 { get; set; }
        [Column("Shipping Marks 2")]
        [StringLength(30)]
        public string? ShippingMarks2 { get; set; }
        [Column("Shipping Marks 3")]
        [StringLength(30)]
        public string? ShippingMarks3 { get; set; }
        [Column("Shipping Marks 4")]
        [StringLength(30)]
        public string? ShippingMarks4 { get; set; }
        [Column("Shipping Marks 5")]
        [StringLength(30)]
        public string? ShippingMarks5 { get; set; }
        [Column("Shipping Marks 6")]
        [StringLength(30)]
        public string? ShippingMarks6 { get; set; }
        [Column("Total Tax", TypeName = "decimal(13, 2)")]
        public decimal? TotalTax { get; set; }
        [Column("Uom Package")]
        [StringLength(3)]
        public string? UomPackage { get; set; }
        [Column("Uom Quantity")]
        [StringLength(3)]
        public string? UomQuantity { get; set; }
        [Column("Uom Weight")]
        [StringLength(3)]
        public string? UomWeight { get; set; }
        [Column("Uom Volume")]
        [StringLength(3)]
        public string? UomVolume { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(3)]
        public string Status { get; set; } = null!;
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
    }
}
