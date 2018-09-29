﻿using System;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Orders.Models;

namespace SecretTarot.Module.Payments.Models
{
    public class Payment : EntityBase
    {
        public long OrderId { get; set; }

        public Order Order { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }

        public decimal Amount { get; set; }

        public decimal PaymentFee { get; set; }

        public string PaymentMethod { get; set; }

        public string GatewayTransactionId { get; set; }

        public PaymentStatus Status { get; set; }

        public string FailureMessage { get; set; }
    }
}
