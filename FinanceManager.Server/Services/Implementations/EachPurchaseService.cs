using AutoMapper;
using FinanceManager.Server.Application;
using FinanceManager.Server.Data.DTOs;
using FinanceManager.Server.Data.Entities;
using FinanceManager.Server.Repositories.Implementations;
using FinanceManager.Server.Repositories.Interfaces;
using FinanceManager.Server.Services.Interfaces;

namespace FinanceManager.Server.Services.Implementations
{
    public class EachPurchaseService : IEachPurchaseService
    {

        private readonly IEachPurchase _repository;

        private readonly IMapper _mapper;

        public EachPurchaseService(IEachPurchase repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EachPurchaseDTO> PostEachPurchase(EachPurchaseDTO eachPurchaseDTO)
        {
            var entities = _mapper.Map<EachPurchaseEntity>(eachPurchaseDTO);
            var createdEntity = await _repository.PostEachPurchase(entities);
            return _mapper.Map<EachPurchaseDTO>(createdEntity);
        }

        public async Task<EachPurchaseDTO> UpdateEachPurchase(EachPurchaseDTO eachPurchaseDTO, int id)
        {
            var entities = _mapper.Map<EachPurchaseEntity>(eachPurchaseDTO);
            var updatedEntity = await _repository.UpdateEachPurchase(entities, id);
            return _mapper.Map<EachPurchaseDTO>(updatedEntity);
        }

        public async Task<bool> DeleteEachPurchase(int id)
        {
            return await _repository.DeleteEachPurchase(id);
        }

        public async Task<IEnumerable<EachPurchaseDTO>> GetAllEachPurchase()
        {
            var entities = await _repository.GetAllEachPurchase();
            return _mapper.Map<IEnumerable<EachPurchaseDTO>>(entities);
        }

        public async Task<EachPurchaseDTO>GetEachPurchaseById(int id)
        {
            var entity = await _repository.GetEachPurchaseById(id);
            if(entity == null)
            {
                throw new DirectoryNotFoundException("Purchase not found");
            }
            return _mapper.Map<EachPurchaseDTO>(entity);
        }






    }
}
