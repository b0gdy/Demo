using System.Collections.Generic;

namespace API.Entities
{
    public class Pacient
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNP { get; set; }

        // public List<Appointment> Appointment { get; set; }
    }
}
