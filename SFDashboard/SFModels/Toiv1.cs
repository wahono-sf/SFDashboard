using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("toiv1")]
    public partial class Toiv1
    {
        public Toiv1()
        {
            Toiv2s = new HashSet<Toiv2>();
        }

        [Key]
        public int TrxNo { get; set; }
        [StringLength(15)]
        public string? AccCode { get; set; }
        [StringLength(50)]
        public string? Address1 { get; set; }
        [StringLength(50)]
        public string? Address2 { get; set; }
        [StringLength(50)]
        public string? Address3 { get; set; }
        [StringLength(50)]
        public string? Address4 { get; set; }
        [StringLength(20)]
        public string? ApplyToInvoice { get; set; }
        [StringLength(80)]
        public string? AttnName { get; set; }
        [StringLength(10)]
        public string? BillingPartyCode { get; set; }
        [StringLength(1)]
        public string? BillInst { get; set; }
        [Column("BLNo")]
        [StringLength(30)]
        public string? Blno { get; set; }
        [StringLength(1)]
        public string? CancelledFlag { get; set; }
        [StringLength(3)]
        public string? CargoType { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? CashAmt { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? ChequeLocalAmt { get; set; }
        [StringLength(18)]
        public string? ChequeNo { get; set; }
        [StringLength(50)]
        public string? CollectBy { get; set; }
        [StringLength(50)]
        public string? CommodityCode { get; set; }
        [StringLength(2)]
        public string? CountryCode { get; set; }
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column(TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(80)]
        public string? CustomerName { get; set; }
        [StringLength(3)]
        public string? DestCode { get; set; }
        [StringLength(5)]
        public string? DistrictCode { get; set; }
        [StringLength(10)]
        public string? DivisionCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        public byte? EdiCount { get; set; }
        public byte? EmailCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtaDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EtdDate { get; set; }
        public byte? ExportCount { get; set; }
        public byte? FaxCount { get; set; }
        [StringLength(30)]
        public string? FeederVessel { get; set; }
        [StringLength(12)]
        public string? FeederVoyage { get; set; }
        [StringLength(5)]
        public string? FifthViaPortCode { get; set; }
        [StringLength(5)]
        public string? FirstViaPortCode { get; set; }
        [StringLength(60)]
        public string? Footer1 { get; set; }
        [StringLength(60)]
        public string? Footer2 { get; set; }
        [StringLength(60)]
        public string? Footer3 { get; set; }
        [StringLength(60)]
        public string? Footer4 { get; set; }
        [StringLength(60)]
        public string? Footer5 { get; set; }
        [StringLength(1)]
        public string? FootNoteFlag { get; set; }
        [StringLength(5)]
        public string? FourthViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? FreightCostAmt { get; set; }
        [StringLength(50)]
        public string? GoodsDescription1 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription2 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription3 { get; set; }
        [StringLength(50)]
        public string? GoodsDescription4 { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? GrossProfit { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? GrossWeight { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Grt { get; set; }
        [Column("HBLNo")]
        [StringLength(30)]
        public string? Hblno { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceAndVatLocalAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceCostAmt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? InvoiceLocalAmt { get; set; }
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [StringLength(1)]
        public string? InvoiceType { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(100)]
        public string? JobType { get; set; }
        [StringLength(15)]
        public string? LetterOfCreditNo { get; set; }
        public int? NoOf20ftContainer { get; set; }
        public int? NoOf40ftContainer { get; set; }
        public int? NoOf45ftContainer { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Nrt { get; set; }
        [Column("OBLNo")]
        [StringLength(30)]
        public string? Oblno { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [StringLength(24)]
        public string? OurRef { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? Pcs { get; set; }
        [StringLength(5)]
        public string? PortOfDischargeCode { get; set; }
        [StringLength(45)]
        public string? PortOfDischargeName { get; set; }
        [StringLength(5)]
        public string? PortOfLoadingCode { get; set; }
        [StringLength(45)]
        public string? PortOfLoadingName { get; set; }
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PostDate { get; set; }
        [StringLength(1)]
        public string? PostFlag { get; set; }
        [StringLength(6)]
        public string? PostMth { get; set; }
        [StringLength(1)]
        public string? PostReceivedFlag { get; set; }
        public byte? PrintCount { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [StringLength(10)]
        public string? SalesmanCode { get; set; }
        [StringLength(4)]
        public string? ScrNo { get; set; }
        [StringLength(5)]
        public string? SecondViaPortCode { get; set; }
        [StringLength(20)]
        public string? SiteCode { get; set; }
        [StringLength(3)]
        public string? TermCode { get; set; }
        [StringLength(5)]
        public string? ThirdViaPortCode { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCashAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalChequeAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalCostAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalExmAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalCashAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalChequeAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalLocalVatAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalStdAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalVatAmt { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal? TotalZeroAmt { get; set; }
        [StringLength(1)]
        public string? TrxType { get; set; }
        [StringLength(50)]
        public string? VesselCode { get; set; }
        [StringLength(80)]
        public string? VesselName { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? Volume { get; set; }
        [StringLength(12)]
        public string? VoyageOrFlightNo { get; set; }
        [StringLength(24)]
        public string? YourRef { get; set; }
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
        public virtual ICollection<Toiv2> Toiv2s { get; set; }
    }
}
