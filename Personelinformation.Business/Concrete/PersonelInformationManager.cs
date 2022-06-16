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
    public class PersonelInformationManager : IPersonelInformationService
    {
        IPersonelInformationRepository _PersonelInformationRepository;

        public PersonelInformationManager(IPersonelInformationRepository PersonelInformationRepository)
        {
            _PersonelInformationRepository = PersonelInformationRepository;
        }

        public async Task CreateAsync(PersonelInformation entity)
        {
            await _PersonelInformationRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(PersonelInformation entity)
        {
            await _PersonelInformationRepository.DeleteAsync(entity);
        }

        public async Task<List<PersonelInformation>> GetAll()
        {
            return await _PersonelInformationRepository.GetAll();
        }

        public async Task<PersonelInformation> GetById(int id)
        {
            return await _PersonelInformationRepository.GetById(id);
        }

        public async Task UpdateAsync(PersonelInformation entity)
        {
            await _PersonelInformationRepository.UpdateAsync(entity);
        }
    }
}
