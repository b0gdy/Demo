using System.Collections.Generic;
using API.DTOs;
using API.Entities;
using API.Repositories.MedicRepository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicController : ControllerBase
    {
        public IMedicRepository IMedicRepository { get; set; }
        public MedicController(IMedicRepository repository)
        {
            IMedicRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Medic>> Get()
        {
            return IMedicRepository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Medic> Get(int id)
        {
            return IMedicRepository.Get(id);
        }

        [HttpPost]
        public Medic Post(MedicDTO value)
        {
            Medic model = new Medic()
            {
                UserName = value.UserName
            };
            return IMedicRepository.Create(model);
        }

        [HttpPut("{id}")]
        public Medic Put(int id, MedicDTO value)
        {
            Medic model = IMedicRepository.Get(id);
            if(value.UserName != null)
            {
                model.UserName = value.UserName;
            }
            return IMedicRepository.Update(model);
        }

        [HttpDelete("{id}")]
        public Medic Delete(int id)
        {
            Medic medic = IMedicRepository.Get(id);
            return IMedicRepository.Delete(medic);
        }
    }
}