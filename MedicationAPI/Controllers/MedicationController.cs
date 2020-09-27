using Med.Application.DTO.DTO;
using Med.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Med.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController : ControllerBase
    {
        private readonly IApplicationMedicationService _applicationMedicationService;

        public MedicationController(IApplicationMedicationService applicationMedicationService)
        {
            _applicationMedicationService = applicationMedicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MedicationDTO>> Get()
        {
            var medications = _applicationMedicationService.GetAll();
            return Ok(medications);
        }

        [HttpPost]
        public ActionResult Post([FromBody] MedicationDTO medicationDTO)
        {
            try
            {
                if (medicationDTO == null)
                    return BadRequest();

                var id =_applicationMedicationService.Add(medicationDTO);
                return Ok(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{medicationID}")]
        public ActionResult Delete(int medicationID)
        {
            try
            {
                _applicationMedicationService.Remove(medicationID);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
