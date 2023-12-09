using Core.Domain;

namespace Core.Service
{
    public interface IAdminSettingPageService
    {
        Task<DiscountCodeCoupoun> CreateDiscountCode(DiscountCodeCoupoun discountcodecoupoun);
        public DiscountCodeCoupoun UpdateDiscountcode(DiscountCodeCoupoun updateDiscountCode);

        public DiscountCodeCoupoun DeleteDiscountCode(int id);

    }
}
