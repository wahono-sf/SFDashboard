using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SFDashboard.SFModels
{
    [Table("todo1")]
    public partial class Todo1
    {
        public Todo1()
        {
            Todo2s = new HashSet<Todo2>();
        }

        [Key]
        [StringLength(20)]
        public string DeliveryOrderNo { get; set; } = null!;
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ActualWt { get; set; }
        [StringLength(20)]
        public string? AwbNo { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? BalanceQty { get; set; }
        [StringLength(10)]
        public string? BillToCode { get; set; }
        [StringLength(80)]
        public string? BillToName { get; set; }
        [StringLength(50)]
        public string? CaseMark { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? ChargeWt { get; set; }
        [StringLength(10)]
        public string? ConsigneeCode { get; set; }
        [StringLength(80)]
        public string? ConsigneeName { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress1 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress2 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress3 { get; set; }
        [StringLength(50)]
        public string? ConsigneeAddress4 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfSigning { get; set; }
        [StringLength(30)]
        public string? DeliveryBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDateTime { get; set; }
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
        [StringLength(40)]
        public string? Description { get; set; }
        [StringLength(1)]
        public string? DocumentAttached { get; set; }
        [StringLength(6)]
        public string? FlightNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FlightDate { get; set; }
        [StringLength(20)]
        public string? HawbNo { get; set; }
        [StringLength(30)]
        public string? JobNo { get; set; }
        [StringLength(20)]
        public string? MawbNo { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf20ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf40ftContainer { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? NoOf45ftContainer { get; set; }
        [StringLength(3)]
        public string? OriginCode { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? PackagesNo { get; set; }
        [StringLength(20)]
        public string? PreparedBy { get; set; }
        [Column(TypeName = "decimal(13, 4)")]
        public decimal? QtyFromAwb { get; set; }
        [StringLength(50)]
        public string? Remarks { get; set; }
        [Column("SAwbNo")]
        [StringLength(20)]
        public string? SawbNo { get; set; }
        [StringLength(17)]
        public string? SigneeId { get; set; }
        [StringLength(20)]
        public string? SigneeName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOfSigning { get; set; }
        [StringLength(50)]
        public string? Userdefine01 { get; set; }
        [StringLength(50)]
        public string? Userdefine02 { get; set; }
        [StringLength(50)]
        public string? Userdefine03 { get; set; }
        [StringLength(50)]
        public string? Userdefine04 { get; set; }
        [StringLength(50)]
        public string? Userdefine05 { get; set; }
        [StringLength(50)]
        public string? Userdefine06 { get; set; }
        [StringLength(50)]
        public string? Userdefine07 { get; set; }
        [StringLength(50)]
        public string? Userdefine08 { get; set; }
        [StringLength(50)]
        public string? Userdefine09 { get; set; }
        [StringLength(50)]
        public string? Userdefine10 { get; set; }
        [StringLength(12)]
        public string? VehicalNo { get; set; }
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

        [InverseProperty("DeliveryOrderNoNavigation")]
        public virtual ICollection<Todo2> Todo2s { get; set; }
    }
}
