using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PatientTrackingSystem.Server.Dtos;

namespace PatientTrackingSystem.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PredictionController : ControllerBase
    {
        [HttpGet("{patientId}")]
        public ActionResult<PredictionDto> GetPrediction(int patientId)
        {
            var prediction = new PredictionDto
            {
                PatientId = patientId,
                RiskLevel = "Moderate",
                Suggestion = "Monitor vitals and schedule a follow-up in 3 months."
            };

            return Ok(prediction);
        }
    }
}
