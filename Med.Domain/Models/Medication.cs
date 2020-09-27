using System;

namespace Med.Domain.Models
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
