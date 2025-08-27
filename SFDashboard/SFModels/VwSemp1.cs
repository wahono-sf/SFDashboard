using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSemp1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Booking No")]
        [StringLength(30)]
        public string? BookingNo { get; set; }
        [Column("Cargo Receipt Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CargoReceiptDate { get; set; }
        [Column("Cargo Receipt Flag")]
        [StringLength(1)]
        public string? CargoReceiptFlag { get; set; }
        [Column("Cargo Type")]
        [StringLength(5)]
        public string? CargoType { get; set; }
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Collect From Address 1")]
        [StringLength(50)]
        public string? CollectFromAddress1 { get; set; }
        [Column("Collect From Address 2")]
        [StringLength(50)]
        public string? CollectFromAddress2 { get; set; }
        [Column("Collect From Address 3")]
        [StringLength(50)]
        public string? CollectFromAddress3 { get; set; }
        [Column("Collect From Address 4")]
        [StringLength(50)]
        public string? CollectFromAddress4 { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
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
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Delivery To Address 1")]
        [StringLength(50)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(50)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(50)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(50)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To 2 Code")]
        [StringLength(10)]
        public string? DeliveryTo2Code { get; set; }
        [Column("Delivery To 2 Name")]
        [StringLength(80)]
        public string? DeliveryTo2Name { get; set; }
        [Column("Delivery To 2 Address 1")]
        [StringLength(50)]
        public string? DeliveryTo2Address1 { get; set; }
        [Column("Delivery To 2 Address 2")]
        [StringLength(50)]
        public string? DeliveryTo2Address2 { get; set; }
        [Column("Delivery To 2 Address 3")]
        [StringLength(50)]
        public string? DeliveryTo2Address3 { get; set; }
        [Column("Delivery To 2 Address 4")]
        [StringLength(50)]
        public string? DeliveryTo2Address4 { get; set; }
        [Column("Delivery To 3 Code")]
        [StringLength(10)]
        public string? DeliveryTo3Code { get; set; }
        [Column("Delivery To 3 Name")]
        [StringLength(80)]
        public string? DeliveryTo3Name { get; set; }
        [Column("Delivery To 3 Address 1")]
        [StringLength(50)]
        public string? DeliveryTo3Address1 { get; set; }
        [Column("Delivery To 3 Address 2")]
        [StringLength(50)]
        public string? DeliveryTo3Address2 { get; set; }
        [Column("Delivery To 3 Address 3")]
        [StringLength(50)]
        public string? DeliveryTo3Address3 { get; set; }
        [Column("Delivery To 3 Address 4")]
        [StringLength(50)]
        public string? DeliveryTo3Address4 { get; set; }
        [Column("Delivery Type")]
        [StringLength(4)]
        public string? DeliveryType { get; set; }
        [Column("Division Code")]
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column("Driver Code")]
        [StringLength(15)]
        public string? DriverCode { get; set; }
        [Column("Driver Name")]
        [StringLength(45)]
        public string? DriverName { get; set; }
        [Column("Driver Contact No 1")]
        [StringLength(30)]
        public string? DriverContactNo1 { get; set; }
        [Column("Driver Contact No 2")]
        [StringLength(30)]
        public string? DriverContactNo2 { get; set; }
        [Column("Driver2 Code")]
        [StringLength(15)]
        public string? Driver2Code { get; set; }
        [Column("Driver2 Name")]
        [StringLength(50)]
        public string? Driver2Name { get; set; }
        [Column("Driver2 Contact No 1")]
        [StringLength(30)]
        public string? Driver2ContactNo1 { get; set; }
        [Column("Driver2 Contact No 2")]
        [StringLength(30)]
        public string? Driver2ContactNo2 { get; set; }
        [Column("EDI Count")]
        public byte? EdiCount { get; set; }
        [Column("Email Count")]
        public byte? EmailCount { get; set; }
        [Column("ETA Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtaDate { get; set; }
        [Column("ETD Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EtdDate { get; set; }
        [Column("Export Count")]
        public byte? ExportCount { get; set; }
        [Column("Fax Count")]
        public byte? FaxCount { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("Job No")]
        [StringLength(30)]
        public string? JobNo { get; set; }
        [Column("Order Type")]
        [StringLength(5)]
        public string? OrderType { get; set; }
        public int? Pcs { get; set; }
        [Column("Pickup Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? PickupDateTime { get; set; }
        [Column("Pickup Date Time Remark")]
        [StringLength(50)]
        public string? PickupDateTimeRemark { get; set; }
        [Column("Pickup No")]
        [StringLength(20)]
        public string? PickupNo { get; set; }
        [StringLength(10)]
        public string? Place { get; set; }
        [Column("Print Count")]
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark 1")]
        [StringLength(50)]
        public string? Remark1 { get; set; }
        [Column("Remark 2")]
        [StringLength(50)]
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
        [Column("Site Code")]
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [Column("Trailer No")]
        [StringLength(20)]
        public string? TrailerNo { get; set; }
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Transport Address 1")]
        [StringLength(50)]
        public string? TransportAddress1 { get; set; }
        [Column("Transport Address 2")]
        [StringLength(50)]
        public string? TransportAddress2 { get; set; }
        [Column("Transport Address 3")]
        [StringLength(50)]
        public string? TransportAddress3 { get; set; }
        [Column("Transport Address 4")]
        [StringLength(50)]
        public string? TransportAddress4 { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
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
        [StringLength(12)]
        public string? VehicleNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Wages { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Wages2 { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
