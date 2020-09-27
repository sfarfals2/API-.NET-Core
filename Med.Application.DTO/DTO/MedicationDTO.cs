using System;

namespace Med.Application.DTO.DTO
{
    public class MedicationDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
