using FinanceManager.Server.Data;
using FinanceManager.Server.Data.Entities;
using FinanceManager.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;


namespace FinanceManager.Server.Repositories.Implementations
{
    public class EachPurchaseImplementation : IEachPurchase
    {

        private readonly ApplicationDbContext _context;

        public EachPurchaseImplementation(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<EachPurchaseEntity> PostEachPurchase(EachPurchaseEntity eachPurchaseEntity)
        {
            _context.EachPurchases.Add(eachPurchaseEntity);

            await _context.SaveChangesAsync();

            return eachPurchaseEntity;
        }

        public async Task<EachPurchaseEntity> UpdateEachPurchase(EachPurchaseEntity eachPurchaseEntity, int id)
        {
            var oldEachPurchase = await _context.EachPurchases.FirstOrDefaultAsync(p => p.Id == id);

            if (oldEachPurchase == null)
            {
                return null;
            }

            oldEachPurchase.BillName = eachPurchaseEntity.BillName;
            oldEachPurchase.BillDate = eachPurchaseEntity.BillDate;
            oldEachPurchase.BillAmount = eachPurchaseEntity.BillAmount;
            oldEachPurchase.SelectOption = eachPurchaseEntity.SelectOption;

            await _context.SaveChangesAsync();
            return oldEachPurchase;
        }

        public async Task<bool> DeleteEachPurchase (int id)
        {
            var oldEachPurchase = await _context.EachPurchases.FirstOrDefaultAsync(p => p.Id == id);

            if (oldEachPurchase == null)
            {
                return false;
            }

            _context.EachPurchases.Remove(oldEachPurchase);

            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<IEnumerable<EachPurchaseEntity>> GetAllEachPurchase()
        {
            return await _context.EachPurchases.ToListAsync();
        }

        public async Task<EachPurchaseEntity> GetEachPurchaseById(int id)
        {
            return await _context.EachPurchases.FirstOrDefaultAsync(p => p.Id == id);
        }

    }
}
