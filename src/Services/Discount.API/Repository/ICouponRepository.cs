using Discount.API.Models;

namespace Discount.API.Repository
{
    public interface ICouponRepository
    {
        Task<Coupon> GetDiscount(string ProductId);
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> UpdateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string ProductId);

    }
}
