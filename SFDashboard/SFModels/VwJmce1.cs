using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwJmce1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Cif Value", TypeName = "decimal(13, 4)")]
        public decimal? CifValue { get; set; }
        [StringLength(1)]
        public string? Containerised { get; set; }
        [Column("Country Of Goods Pmt Code")]
        [StringLength(2)]
        public string? CountryOfGoodsPmtCode { get; set; }
        [Column("Curr Code")]
        [StringLength(3)]
        public string? CurrCode { get; set; }
        [Column("Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? CurrRate { get; set; }
        [StringLength(50)]
        public string? Declarant { get; set; }
        [Column("Declaration Type")]
        [StringLength(10)]
        public string? DeclarationType { get; set; }
        [StringLength(50)]
        public string? Designation { get; set; }
        [Column("Fob Value", TypeName = "decimal(13, 4)")]
        public decimal? FobValue { get; set; }
        [Column("Freight Curr Code")]
        [StringLength(3)]
        public string? FreightCurrCode { get; set; }
        [Column("Freight Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? FreightCurrRate { get; set; }
        [Column("Freight Value", TypeName = "decimal(13, 4)")]
        public decimal? FreightValue { get; set; }
        [Column("Freight Qty", TypeName = "decimal(13, 4)")]
        public decimal? FreightQty { get; set; }
        [Column("General Reference No")]
        [StringLength(50)]
        public string? GeneralReferenceNo { get; set; }
        [Column("General Type")]
        [StringLength(2)]
        public string? GeneralType { get; set; }
        [Column("Id Of Declarant")]
        [StringLength(20)]
        public string? IdOfDeclarant { get; set; }
        [Column("Import Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ImportDate { get; set; }
        [Column("Insurance Curr Code")]
        [StringLength(3)]
        public string? InsuranceCurrCode { get; set; }
        [Column("Insurance Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? InsuranceCurrRate { get; set; }
        [Column("Insurance Qty", TypeName = "decimal(13, 4)")]
        public decimal? InsuranceQty { get; set; }
        [Column("Insurance Value", TypeName = "decimal(13, 4)")]
        public decimal? InsuranceValue { get; set; }
        [Column("Invoice Date")]
        [StringLength(10)]
        [Unicode(false)]
        public string? InvoiceDate { get; set; }
        [Column("Invoice No")]
        [StringLength(20)]
        public string? InvoiceNo { get; set; }
        [Column("Invoice Value", TypeName = "decimal(13, 4)")]
        public decimal? InvoiceValue { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Job Type")]
        [StringLength(10)]
        public string? JobType { get; set; }
        [Column("Main Type")]
        [StringLength(5)]
        public string? MainType { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        public string? ModuleCode { get; set; }
        [Column("Name Of Declarant")]
        [StringLength(50)]
        public string? NameOfDeclarant { get; set; }
        [Column("Other Charges", TypeName = "decimal(13, 4)")]
        public decimal? OtherCharges { get; set; }
        [Column("Port Charges Curr Code")]
        [StringLength(3)]
        public string? PortChargesCurrCode { get; set; }
        [Column("Port Charges Curr Rate", TypeName = "decimal(17, 10)")]
        public decimal? PortChargesCurrRate { get; set; }
        [Column("Port Charges Qty", TypeName = "decimal(13, 4)")]
        public decimal? PortChargesQty { get; set; }
        [Column("Port Charges", TypeName = "decimal(13, 4)")]
        public decimal? PortCharges { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("Sales Reference No")]
        [StringLength(50)]
        public string? SalesReferenceNo { get; set; }
        [Column("Sales Registration No")]
        [StringLength(20)]
        public string? SalesRegistrationNo { get; set; }
        [Column("Sales Station")]
        [StringLength(10)]
        public string? SalesStation { get; set; }
        [Column("Sales Type")]
        [StringLength(2)]
        public string? SalesType { get; set; }
        [Column("S/Document")]
        [StringLength(1)]
        public string? SDocument { get; set; }
        [Column("Special Reference No")]
        [StringLength(50)]
        public string? SpecialReferenceNo { get; set; }
        [Column("Special Type")]
        [StringLength(2)]
        public string? SpecialType { get; set; }
        [Column("Terminal Opr")]
        [StringLength(10)]
        public string? TerminalOpr { get; set; }
        [Column("Transport Mode")]
        [StringLength(20)]
        public string? TransportMode { get; set; }
        [Column("With Clause")]
        [StringLength(1)]
        public string? WithClause { get; set; }
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
