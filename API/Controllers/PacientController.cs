using System.Collections.Generic;
using API.DTOs;
using API.Entities;
using API.Repositories.PacientRepository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientController : ControllerBase
    {
        public IPacientRepository IPacientRepository { get; set; }
        public PacientController(IPacientRepository repository)
        {
            IPacientRepository = repository;
        }

        // GET: api/Provider
        [HttpGet]
        public ActionResult<IEnumerable<Pacient>> Get()
        {
            return IPacientRepository.GetAll();
        }

        // GET: api/Provider/5
        [HttpGet("{id}")]
        public ActionResult<Pacient> Get(int id)
        {
            return IPacientRepository.Get(id);
        }

        // POST: api/Provider
        [HttpPost]
        public Pacient Post(PacientDTO value)
        {
            Pacient model = new Pacient()
            {
                UserName = value.UserName,
                FirstName = value.FirstName,
                LastName = value.LastName,
                CNP = value.CNP,
            };
            return IPacientRepository.Create(model);
        }

        // PUT: api/Provider/5
        [HttpPut("{id}")]
        public Pacient Put(int id, PacientDTO value)
        {
            Pacient model = IPacientRepository.Get(id);
            if (value.UserName != null)
            {
                model.UserName = value.UserName;
            }
            if (value.FirstName != null)
            {
                model.FirstName = value.FirstName;
            }
            if (value.LastName != null)
            {
                model.LastName = value.LastName;
            }
            if (value.CNP != null)
            {
                model.CNP = value.CNP;
            }
            return IPacientRepository.Update(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Pacient Delete(int id)
        {
            Pacient Pacient = IPacientRepository.Get(id);
            return IPacientRepository.Delete(Pacient);
        }
    }
}