﻿using System.Threading.Tasks;

namespace SecretTarot.Module.Pricing.Services
{
    public interface ICouponService
    {
        Task<CouponValidationResult> Validate(string couponCode, CartInfoForCoupon cart);

        void AddCouponUsage(long userId, long orderId, CouponValidationResult couponValidationResult);
    }
}
