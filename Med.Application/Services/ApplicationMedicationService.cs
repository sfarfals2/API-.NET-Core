using Med.Application.DTO.DTO;
using Med.Application.Interfaces;
using Med.Domain.Core.Interfaces.Services;
using Med.Infrastructure.CrossCutting.Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace Med.Application.Services
{
    public class ApplicationMedicationService : IApplicationMedicationService
    {
        private readonly IDomainMedicationService _domainMedicationService;
        private readonly IMedicationMapper _medicationMapper;

        public ApplicationMedicationService(IDomainMedicationService domainMedicationService, IMedicationMapper medicationMapper)
        {
            _domainMedicationService = domainMedicationService;
            _medicationMapper = medicationMapper;
        }

        public int Add(MedicationDTO medicationDTO)
        {
            var medication = _medicationMapper.MapperToEntity(medicationDTO);
            _domainMedicationService.Add(medication);
            return medication.Id;
        }

        public IEnumerable<MedicationDTO> GetAll()
        {
            var medications = _domainMedicationService.GetAll();
            return _medicationMapper.MapperListMedications(medications);
        }

        public MedicationDTO GetById(int id)
        {
            var medication = _domainMedicationService.GetById(id);
            return _medicationMapper.MapperToDTO(medication);
        }

        public void Remove(int id)
        {
            try
            {
                var medication = _domainMedicationService.GetById(id);
                _domainMedicationService.Remove(medication);
            }
            catch (Exception e)
            {
                throw new Exception("Error deleting medication, for a better error handling we could have validation inside the application layer to verify that the object exists and return a custom error", e);
            }
        }

        public void Dispose()
        {
            _domainMedicationService.Dispose();
        }
    }
}
