using Med.Domain.Models;
using System.Collections.Generic;

namespace Med.Domain.Core.Interfaces.Repositories
{
    public interface IMedicationRepository
    {
        Medication Add(Medication obj);

        Medication GetById(int id);

        IEnumerable<Medication> GetAll();

        void Update(Medication obj);

        void Remove(Medication obj);

        void Dispose();
    }
}
