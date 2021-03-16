using System;

namespace API.DTOs
{
    public class AppointmentDTO
    {
        public DateTime Time { get; set; }

        public int PacientId { get; set; }
        public int MedicId { get; set; }
    }
}