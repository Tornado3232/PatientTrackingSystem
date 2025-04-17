namespace PatientTrackingSystem.Server.Dtos
{
    public class PredictionDto
    {
        public int PatientId { get; set; }
        public string RiskLevel { get; set; } = "Low";
        public string Suggestion { get; set; } = "You are Healthy!!!";
    }
}
