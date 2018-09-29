using System;
using System.Collections.Generic;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Orders.ViewModels
{
    public class OrderHistoryListItem
    {
        public long Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public decimal SubTotal { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public IList<OrderHistoryProductVm> OrderItems { get; set; } = new List<OrderHistoryProductVm>();
    }
}
