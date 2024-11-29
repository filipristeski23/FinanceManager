using FinanceManager.Server.Data.DTOs;

namespace FinanceManager.Server.Services.Interfaces
{
    public interface IEachPurchaseService
    {

        Task<EachPurchaseDTO> PostEachPurchase(EachPurchaseDTO eachPurchaseDTO);

        Task<EachPurchaseDTO> UpdateEachPurchase(EachPurchaseDTO eachPurchaseDTO, int id);

        Task<bool> DeleteEachPurchase(int id);

        Task<IEnumerable<EachPurchaseDTO>> GetAllEachPurchase();

        Task<EachPurchaseDTO> GetEachPurchaseById(int id);  

    }
}
