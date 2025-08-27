using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("csbk1")]
    public partial class Csbk1
    {
        public Csbk1()
        {
            Csbk2s = new HashSet<Csbk2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(10)]
        public string? AgentCode { get; set; }
        [StringLength(80)]
        public string? AgentName { get; set; }
        [StringLength(10)]
        public string BookingNo { get; set; } = null!;
        [StringLength(10)]
        public string? BookingCustomerCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BookingDateTime { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChargeRate { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CloseDateTime { get; set; }
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
        public string? CollectFromContactName { get; set; }
        [StringLength(30)]
        public string? CollectFromTelephone { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(50)]
        public string? ContactName { get; set; }
        [StringLength(50)]
        public string? ContactEmail { get; set; }
        [StringLength(30)]
        public string? ContactFax { get; set; }
        [StringLength(30)]
        public string? ContactTelephone { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
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
        public string? CustomerRefNo { get; set; }
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
        [StringLength(30)]
        public string? DeliveryToTelephone { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DepositAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [StringLength(1)]
        public string? InternetBooking { get; set; }
        public int? ItemNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(10)]
        public string? JobStatusCode { get; set; }
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? PaidAmt { get; set; }
        [StringLength(50)]
        public string? ReceiptNo { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(3000)]
        public string? SpecialInstruction { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? SurchargeRate { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalAmt { get; set; }
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
        [Column(TypeName = "decimal(14, 3)")]
        public decimal? VolumetricWeight { get; set; }
        [Column("VoyageID")]
        [StringLength(10)]
        public string? VoyageId { get; set; }
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
        public virtual ICollection<Csbk2> Csbk2s { get; set; }
    }
}
