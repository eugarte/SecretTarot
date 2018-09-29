using System.Threading.Tasks;
using SecretTarot.Module.Pricing.Services;
using SecretTarot.Module.ShoppingCart.ViewModels;

namespace SecretTarot.Module.ShoppingCart.Services
{
    public interface ICartService
    {
        Task AddToCart(long userId, long productId, int quantity);

        Task<CartVm> GetCart(long userId);

        Task<CouponValidationResult> ApplyCoupon(long userId, string couponCode);

        Task MigrateCart(long fromUserId, long toUserId);
    }
}
