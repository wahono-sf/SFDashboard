using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwSebl21
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Line Item No")]
        public short LineItemNo { get; set; }
        [Column("Allotment No")]
        [StringLength(50)]
        public string? AllotmentNo { get; set; }
        [Column("Bl No")]
        [StringLength(30)]
        public string? BlNo { get; set; }
        [StringLength(10)]
        public string? Berth { get; set; }
        [Column("Bill Flag")]
        [StringLength(1)]
        public string? BillFlag { get; set; }
        [Column("Cargo Location")]
        [StringLength(255)]
        public string? CargoLocation { get; set; }
        [Column("Cargo Status Code")]
        [StringLength(3)]
        public string? CargoStatusCode { get; set; }
        [Column("Charge Weight", TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column("Commodity Code")]
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
        [Column("Completion Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CompletionDate { get; set; }
        [Column("Container Remark")]
        [StringLength(500)]
        public string? ContainerRemark { get; set; }
        [Column("Container Return Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ContainerReturnDate { get; set; }
        [Column("Container Return Type")]
        [StringLength(1)]
        public string? ContainerReturnType { get; set; }
        [Column("Container Transfer Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ContainerTransferDate { get; set; }
        [Column("Container Line Item No")]
        public short ContainerLineItemNo { get; set; }
        [Column("Container Master Job No")]
        [StringLength(30)]
        public string? ContainerMasterJobNo { get; set; }
        [Column("Container No")]
        [StringLength(13)]
        public string? ContainerNo { get; set; }
        [Column("Container Type")]
        [StringLength(5)]
        public string? ContainerType { get; set; }
        [Column("Depot Code")]
        [StringLength(10)]
        public string? DepotCode { get; set; }
        [Column("Dest Name")]
        [StringLength(30)]
        public string? DestName { get; set; }
        [Column("DG Flag")]
        [StringLength(5)]
        public string? DgFlag { get; set; }
        [Column("Discharge Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DischargeDate { get; set; }
        [Column("DO Release Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? DoReleaseDate { get; set; }
        [Column("Empty Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? EmptyDate { get; set; }
        [Column("Final Dest Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? FinalDestDate { get; set; }
        [Column("Freight Collect", TypeName = "decimal(13, 2)")]
        public decimal? FreightCollect { get; set; }
        [Column("Goods Description 01")]
        [StringLength(50)]
        public string? GoodsDescription01 { get; set; }
        [Column("Goods Description 02")]
        [StringLength(50)]
        public string? GoodsDescription02 { get; set; }
        [Column("Goods Description 03")]
        [StringLength(50)]
        public string? GoodsDescription03 { get; set; }
        [Column("Goods Description 04")]
        [StringLength(50)]
        public string? GoodsDescription04 { get; set; }
        [Column("Goods Description 05")]
        [StringLength(50)]
        public string? GoodsDescription05 { get; set; }
        [Column("Goods Description 06")]
        [StringLength(50)]
        public string? GoodsDescription06 { get; set; }
        [Column("Goods Description 07")]
        [StringLength(50)]
        public string? GoodsDescription07 { get; set; }
        [Column("Goods Description 08")]
        [StringLength(50)]
        public string? GoodsDescription08 { get; set; }
        [Column("Goods Description 09")]
        [StringLength(50)]
        public string? GoodsDescription09 { get; set; }
        [Column("Goods Description 10")]
        [StringLength(50)]
        public string? GoodsDescription10 { get; set; }
        [Column("Goods Description 11")]
        [StringLength(50)]
        public string? GoodsDescription11 { get; set; }
        [Column("Goods Description 12")]
        [StringLength(50)]
        public string? GoodsDescription12 { get; set; }
        [Column("Goods Description 13")]
        [StringLength(50)]
        public string? GoodsDescription13 { get; set; }
        [Column("Goods Description 14")]
        [StringLength(50)]
        public string? GoodsDescription14 { get; set; }
        [Column("Goods Description 15")]
        [StringLength(50)]
        public string? GoodsDescription15 { get; set; }
        [Column("Goods Description 16")]
        [StringLength(50)]
        public string? GoodsDescription16 { get; set; }
        [Column("Goods Description 17")]
        [StringLength(50)]
        public string? GoodsDescription17 { get; set; }
        [Column("Goods Description 18")]
        [StringLength(50)]
        public string? GoodsDescription18 { get; set; }
        [Column("Goods Description 19")]
        [StringLength(50)]
        public string? GoodsDescription19 { get; set; }
        [Column("Goods Description 20")]
        [StringLength(50)]
        public string? GoodsDescription20 { get; set; }
        [Column("Gross Weight", TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column("H/O Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? HODate { get; set; }
        [StringLength(20)]
        public string? Imco { get; set; }
        [Column("Laden Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? LadenDate { get; set; }
        [Column("Mark No 01")]
        [StringLength(25)]
        public string? MarkNo01 { get; set; }
        [Column("Mark No 02")]
        [StringLength(25)]
        public string? MarkNo02 { get; set; }
        [Column("Mark No 03")]
        [StringLength(25)]
        public string? MarkNo03 { get; set; }
        [Column("Mark No 04")]
        [StringLength(25)]
        public string? MarkNo04 { get; set; }
        [Column("Mark No 05")]
        [StringLength(25)]
        public string? MarkNo05 { get; set; }
        [Column("Mark No 06")]
        [StringLength(25)]
        public string? MarkNo06 { get; set; }
        [Column("Mark No 07")]
        [StringLength(25)]
        public string? MarkNo07 { get; set; }
        [Column("Mark No 08")]
        [StringLength(25)]
        public string? MarkNo08 { get; set; }
        [Column("Mark No 09")]
        [StringLength(25)]
        public string? MarkNo09 { get; set; }
        [Column("Mark No 10")]
        [StringLength(25)]
        public string? MarkNo10 { get; set; }
        [Column("Mark No 11")]
        [StringLength(25)]
        public string? MarkNo11 { get; set; }
        [Column("Mark No 12")]
        [StringLength(25)]
        public string? MarkNo12 { get; set; }
        [Column("Mark No 13")]
        [StringLength(25)]
        public string? MarkNo13 { get; set; }
        [Column("Mark No 14")]
        [StringLength(25)]
        public string? MarkNo14 { get; set; }
        [Column("Mark No 15")]
        [StringLength(25)]
        public string? MarkNo15 { get; set; }
        [Column("Mark No 16")]
        [StringLength(25)]
        public string? MarkNo16 { get; set; }
        [Column("Mark No 17")]
        [StringLength(25)]
        public string? MarkNo17 { get; set; }
        [Column("Mark No 18")]
        [StringLength(25)]
        public string? MarkNo18 { get; set; }
        [Column("Mark No 19")]
        [StringLength(25)]
        public string? MarkNo19 { get; set; }
        [Column("Mark No 20")]
        [StringLength(25)]
        public string? MarkNo20 { get; set; }
        [Column("Mark No Image", TypeName = "image")]
        public byte[]? MarkNoImage { get; set; }
        [Column("Measurement Type")]
        [StringLength(2)]
        public string? MeasurementType { get; set; }
        [Column("Net Weight", TypeName = "decimal(13, 4)")]
        public decimal? NetWeight { get; set; }
        public int? Oid { get; set; }
        [StringLength(80)]
        public string? Owner { get; set; }
        public int? Pcs { get; set; }
        [Column("Pcs 01")]
        public int? Pcs01 { get; set; }
        [Column("Pcs 02")]
        public int? Pcs02 { get; set; }
        [Column("Pcs 03")]
        public int? Pcs03 { get; set; }
        [Column("Pcs 04")]
        public int? Pcs04 { get; set; }
        [Column("Pcs 05")]
        public int? Pcs05 { get; set; }
        [Column("Pcs 06")]
        public int? Pcs06 { get; set; }
        [Column("Pcs 07")]
        public int? Pcs07 { get; set; }
        [Column("Pcs 08")]
        public int? Pcs08 { get; set; }
        [Column("Pcs 09")]
        public int? Pcs09 { get; set; }
        [Column("Pcs 10")]
        public int? Pcs10 { get; set; }
        [Column("Pcs 11")]
        public int? Pcs11 { get; set; }
        [Column("Pcs 12")]
        public int? Pcs12 { get; set; }
        [Column("Pcs 13")]
        public int? Pcs13 { get; set; }
        [Column("Pcs 14")]
        public int? Pcs14 { get; set; }
        [Column("Pcs 15")]
        public int? Pcs15 { get; set; }
        [Column("Pcs 16")]
        public int? Pcs16 { get; set; }
        [Column("Pcs 17")]
        public int? Pcs17 { get; set; }
        [Column("Pcs 18")]
        public int? Pcs18 { get; set; }
        [Column("Pcs 19")]
        public int? Pcs19 { get; set; }
        [Column("Pcs 20")]
        public int? Pcs20 { get; set; }
        [Column("Pcs 21")]
        public int? Pcs21 { get; set; }
        [Column("Pcs 22")]
        public int? Pcs22 { get; set; }
        [Column("Pcs 23")]
        public int? Pcs23 { get; set; }
        [Column("Pcs 24")]
        public int? Pcs24 { get; set; }
        [Column("Pickup Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? PickupDate { get; set; }
        [Column("Pick Up Ref")]
        [StringLength(20)]
        public string? PickUpRef { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Remark Template Name")]
        [StringLength(50)]
        public string? RemarkTemplateName { get; set; }
        [Column("Required Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? RequiredDateTime { get; set; }
        [Column("Seal No")]
        [StringLength(30)]
        public string? SealNo { get; set; }
        [Column("Trucking Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckingDate { get; set; }
        [Column("Truck Out Date")]
        [StringLength(16)]
        [Unicode(false)]
        public string? TruckOutDate { get; set; }
        [Column("Trx Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? TrxDate { get; set; }
        [Column("Ucr No")]
        [StringLength(50)]
        public string? UcrNo { get; set; }
        [Column("Uom Code")]
        [StringLength(50)]
        public string? UomCode { get; set; }
        [Column("Uom Description")]
        [StringLength(50)]
        public string? UomDescription { get; set; }
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
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [Column("Volumetric Weight Ratio")]
        public short? VolumetricWeightRatio { get; set; }
        [Column("Weight Remark")]
        [StringLength(50)]
        public string? WeightRemark { get; set; }
    }
}
