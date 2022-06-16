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
    public class DetailInformationManager : IDetailInformationService
    {
        IDetailInformationRepository _detailInformationRepository;

        public DetailInformationManager(IDetailInformationRepository detailInformationRepository)
        {
            _detailInformationRepository = detailInformationRepository;
        }

        public async Task CreateAsync(DetailInformation entity)
        {
            await _detailInformationRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(DetailInformation entity)
        {
            await _detailInformationRepository.DeleteAsync(entity);
        }

        public async Task<List<DetailInformation>> GetAll()
        {
          return  await _detailInformationRepository.GetAll();
        }

        public async Task<DetailInformation> GetById(int id)
        {
          return  await _detailInformationRepository.GetById(id);
        }

        public async Task UpdateAsync(DetailInformation entity)
        {
           await _detailInformationRepository.UpdateAsync(entity);
        }
    }
}
