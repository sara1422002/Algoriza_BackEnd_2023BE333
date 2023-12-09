using Algoriza_BE_333.Repository;
using Core.Domain;
using Core.Service;

namespace Repository
{
    public class AdminSettingPageService : IAdminSettingPageService
    {
        private readonly ApplicationDbContext _dbContext;
        public AdminSettingPageService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<DiscountCodeCoupoun> CreateDiscountCode(DiscountCodeCoupoun discountcodecoupoun)
        {
            var newdiscountcode = new DiscountCodeCoupoun()
            {
                Id = discountcodecoupoun.Id,
                DiscountPrice = discountcodecoupoun.DiscountPrice,
                DiscountType = discountcodecoupoun.DiscountType,
                Valid = discountcodecoupoun.Valid,


            };

            _dbContext.discounts.Add(newdiscountcode);
            _dbContext.SaveChanges();
            return newdiscountcode;
        }

        public DiscountCodeCoupoun UpdateDiscountcode(DiscountCodeCoupoun updateDiscountCode)
        {
            var existingDiscountCode = _dbContext.discounts.Find(updateDiscountCode.Id);
            if (existingDiscountCode == null)
            {
                return null;
            }
            existingDiscountCode.Id = updateDiscountCode.Id;
            existingDiscountCode.DiscountType = updateDiscountCode.DiscountType;
            existingDiscountCode.DiscountPrice = updateDiscountCode.DiscountPrice;
            existingDiscountCode.Valid = updateDiscountCode.Valid; 

            _dbContext.SaveChanges();
            return existingDiscountCode;

        }

        public DiscountCodeCoupoun DeleteDiscountCode(int id)
        {
            var CodeToDelete = _dbContext.discounts.Find(id);
            if (CodeToDelete == null)
            {
                return null; // Return null if the doctor with the specified ID is not found
            }
            _dbContext.discounts.Remove(CodeToDelete);
            _dbContext.SaveChanges();
            return CodeToDelete;

        }

    }
}
