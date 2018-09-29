﻿using System;
using SecretTarot.Infrastructure.Models;
using SecretTarot.Module.Core.Models;

namespace SecretTarot.Module.Pricing.Models
{
    public class CartRuleUsage : EntityBase
    {
        public CartRuleUsage()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public long CartRuleId { get; set; }

        public CartRule CartRule { get; set; }

        public long? CouponId { get; set; }

        public Coupon Coupon { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public long OrderId { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
