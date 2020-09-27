using Med.Application.DTO.DTO;
using Med.Domain.Models;
using Med.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Med.Infrastructure.CrossCutting.Adapter.Map
{
    public class MedicationMapper : IMedicationMapper
    {
        public IEnumerable<MedicationDTO> MapperListMedications(IEnumerable<Medication> medications)
        {
            return medications.Select(x => MapperToDTO(x));
        }

        public MedicationDTO MapperToDTO(Medication medication)
        {
            return new MedicationDTO()
            {
                Id = medication.Id,
                Name = medication.Name,
                Quantity = medication.Quantity,
                CreationDate = medication.CreationDate
            };
        }

        public Medication MapperToEntity(MedicationDTO medicationDTO)
        {
            return new Medication
            {
                Id = medicationDTO.Id,
                Name = medicationDTO.Name,
                Quantity = medicationDTO.Quantity,
                CreationDate = medicationDTO.CreationDate
            };
        }
    }
}
