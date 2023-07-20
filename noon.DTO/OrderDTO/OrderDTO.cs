﻿using noon.DTO.ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noon.DTO.OrderDTO
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public string userId { get; set; }
        public string? BuyerEmail { set; get; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public int ShipToAddressId { get; set; }
        public int PaymentIntentId { set; get; }
        public int DeliveryMethodId { get; set; }
        public decimal? Subtotal { set; get; }

        public IReadOnlyList<OrderItemDTO> Items { get; set; }
    }
}
