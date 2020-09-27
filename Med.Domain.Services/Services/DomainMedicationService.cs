using Med.Domain.Core.Interfaces.Repositories;
using Med.Domain.Core.Interfaces.Services;
using Med.Domain.Models;
using System.Collections.Generic;

namespace Med.Domain.Services.Services
{
    public class DomainMedicationService : IDomainMedicationService
    {
        private readonly IMedicationRepository _medicationRepository;

        public DomainMedicationService(IMedicationRepository medicationRepository)
        {
            _medicationRepository = medicationRepository;
        }
        public Medication Add(Medication obj)
        {
            _medicationRepository.Add(obj);
            return obj;
        }

        public IEnumerable<Medication> GetAll()
        {
            return _medicationRepository.GetAll();
        }

        public Medication GetById(int id)
        {
            return _medicationRepository.GetById(id);
        }

        public void Remove(Medication obj)
        {
            _medicationRepository.Remove(obj);
        }

        public void Update(Medication obj)
        {
            _medicationRepository.Update(obj);
        }

        public void Dispose()
        {
            _medicationRepository.Dispose();
        }
    }
}
