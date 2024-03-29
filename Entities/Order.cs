﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace baithiDMAWS.Entities
{
    [Table("OrderTbl")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }
        [Required]
        [StringLength(200)]
        public string ItemName { get; set; }

        [Required]
        public int ItemQty { get; set; }

        [Required]
        public DateTime OrderDelivery { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string OrderAddress { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
