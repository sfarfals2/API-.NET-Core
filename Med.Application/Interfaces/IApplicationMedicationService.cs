using Med.Application.DTO.DTO;
using System.Collections.Generic;

namespace Med.Application.Interfaces
{
    public interface IApplicationMedicationService
    {
        int Add(MedicationDTO obj);

        MedicationDTO GetById(int id);

        IEnumerable<MedicationDTO> GetAll();

        void Remove(int obj);

        void Dispose();
    }
}
