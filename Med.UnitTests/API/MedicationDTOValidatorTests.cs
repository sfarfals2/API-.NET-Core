using Med.API.Validators;
using Med.Application.DTO.DTO;
using NUnit.Framework;
using System;

namespace Med.UnitTests.API
{
    [TestFixture]
    public class MedicationDTOValidatorTests
    {
        private MedicationDTOValidator _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new MedicationDTOValidator();
        }

        [Test]
        public void Validate_InvalidRequest_ReturnsInvalidRequestResponse()
        {
            // Arrange
            var req = new MedicationDTO()
            {
                CreationDate = DateTime.Now,
                Id = 0,
                Name = "",
                Quantity = -10
            };

            // Act
            var result = _validator.Validate(req);

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.AreEqual(result.Errors.Count, 2);

        }

        [Test]
        public void Validate_ValidRequest_ReturnsValidRequestResponse()
        {
            // Arrange
            var req = new MedicationDTO()
            {
                CreationDate = DateTime.Now,
                Id = 0,
                Name = "Coronakiller",
                Quantity = 10
            };

            // Act
            var result = _validator.Validate(req);

            // Assert
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(result.Errors.Count, 0);
        }
    }
}
