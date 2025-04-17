﻿namespace PatientTrackingSystem.Server.Dtos
{
    public class PatientCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
    }
}
