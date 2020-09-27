using FluentValidation;
using Med.Application.DTO.DTO;

namespace Med.API.Validators
{
    public class MedicationDTOValidator : AbstractValidator<MedicationDTO>
    {
        public MedicationDTOValidator()
        {
            RuleFor(x => x.Quantity).NotNull().GreaterThan(0);
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.CreationDate).NotNull().NotEmpty();
        }
    }
}
