using Med.Application.DTO.DTO;
using Med.Domain.Models;
using System.Collections.Generic;

namespace Med.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMedicationMapper
    {
        Medication MapperToEntity(MedicationDTO clienteDTO);

        IEnumerable<MedicationDTO> MapperListMedications(IEnumerable<Medication> clientes);

        MedicationDTO MapperToDTO(Medication Cliente);
    }
}
