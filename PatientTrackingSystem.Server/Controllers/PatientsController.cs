using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientTrackingSystem.Server.Data;
using PatientTrackingSystem.Server.Dtos;
using PatientTrackingSystem.Server.Models;

namespace PatientTrackingSystem.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PatientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
        {
            var patients = await _context.Patients
                .ToListAsync();

            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _context.Patients
                .FirstOrDefaultAsync(p => p.Id == id);

            if (patient == null)
                return NotFound();
            var result = new Patient
            {
                Name = patient.Name,
                Surname = patient.Surname,
                Birthdate = patient.Birthdate
            };

            //var result = new PatientDetailDto
            //{
            //    Name = patient.Name,
            //    Surname = patient.Surname,
            //    Birthdate = patient.Birthdate
            //};

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            //var patient = new Patient
            //{
            //    Name = dto.Name,
            //    Surname = dto.Surname,
            //    Birthdate = dto.Birthdate
            //};

            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, Patient patient)
        {
            var patientWithId = await _context.Patients.FindAsync(id);
            if (patientWithId == null)
                return NotFound();

            patientWithId.Name = patient.Name;
            patientWithId.Surname = patient.Surname;
            patientWithId.Birthdate = patient.Birthdate;

            _context.Patients.Update(patientWithId);
            await _context.SaveChangesAsync();

            return Ok(patientWithId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
                return NotFound();

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
