using FinanceManager.Server.Data.Entities;

namespace FinanceManager.Server.Repositories.Interfaces
{
    public interface IEachPurchase
    {

        Task<EachPurchaseEntity> PostEachPurchase(EachPurchaseEntity eachPurchaseEntity);

        Task<EachPurchaseEntity> UpdateEachPurchase(EachPurchaseEntity eachPurchaseEntity, int id);

        Task<bool> DeleteEachPurchase(int id);

        Task<IEnumerable<EachPurchaseEntity>> GetAllEachPurchase();

        Task<EachPurchaseEntity> GetEachPurchaseById(int id);

    }
}
