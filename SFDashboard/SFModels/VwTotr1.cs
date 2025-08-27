using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Keyless]
    public partial class VwTotr1
    {
        [Column("Trx No")]
        public int TrxNo { get; set; }
        [Column("Attachment Flag")]
        [StringLength(1)]
        public string? AttachmentFlag { get; set; }
        [Column("Collect Date Time")]
        [StringLength(16)]
        [Unicode(false)]
        public string? CollectDateTime { get; set; }
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
        [Column("Collect From Code")]
        [StringLength(10)]
        public string? CollectFromCode { get; set; }
        [Column("Collect From Name")]
        [StringLength(80)]
        public string? CollectFromName { get; set; }
        [Column("Commodity Code")]
        [StringLength(10)]
        public string? CommodityCode { get; set; }
        [Column("Commodity Description")]
        [StringLength(50)]
        public string? CommodityDescription { get; set; }
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
        [Column("Delivery To Address 1")]
        [StringLength(45)]
        public string? DeliveryToAddress1 { get; set; }
        [Column("Delivery To Address 2")]
        [StringLength(45)]
        public string? DeliveryToAddress2 { get; set; }
        [Column("Delivery To Address 3")]
        [StringLength(45)]
        public string? DeliveryToAddress3 { get; set; }
        [Column("Delivery To Address 4")]
        [StringLength(45)]
        public string? DeliveryToAddress4 { get; set; }
        [Column("Delivery To Code")]
        [StringLength(10)]
        public string? DeliveryToCode { get; set; }
        [Column("Delivery To Name")]
        [StringLength(80)]
        public string? DeliveryToName { get; set; }
        [Column("Job No")]
        [StringLength(20)]
        public string? JobNo { get; set; }
        [Column("Module Code")]
        [StringLength(2)]
        [Unicode(false)]
        public string ModuleCode { get; set; } = null!;
        [StringLength(255)]
        public string? Remark { get; set; }
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
        [Column("Transport Company Code")]
        [StringLength(10)]
        public string? TransportCompanyCode { get; set; }
        [Column("Transport Company Name")]
        [StringLength(80)]
        public string? TransportCompanyName { get; set; }
        [Column("Work Station")]
        [StringLength(50)]
        public string? WorkStation { get; set; }
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
