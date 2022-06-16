using Personelinformation.Business.Abstract;
using Personelinformation.Data.Abstract;
using Personelinformation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personelinformation.Business.Concrete
{
    public class InformationManager : IInformationService
    {
        IInformationRepository _InformationRepository;

        public InformationManager(IInformationRepository InformationRepository)
        {
            _InformationRepository = InformationRepository;
        }

        public async Task CreateAsync(Information entity)
        {
            await _InformationRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(Information entity)
        {
            await _InformationRepository.DeleteAsync(entity);
        }

        public async Task<List<Information>> GetAll()
        {
            return await _InformationRepository.GetAll();
        }

        public async Task<List<Information>> GetAllWithDetails()
        {
            return await _InformationRepository.GetAllWithDetails();
        }

        public async Task<Information> GetById(int id)
        {
            return await _InformationRepository.GetById(id);
        }

        public async Task UpdateAsync(Information entity)
        {
            await _InformationRepository.UpdateAsync(entity);
        }

    }
}
