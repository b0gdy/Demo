using System.Collections.Generic;
using API.Entities;

namespace API.Repositories.MedicRepository
{
    public interface IMedicRepository
    {
        List<Medic> GetAll();
        Medic Get(int id);
        Medic Create(Medic Medic);
        Medic Update(Medic Medic);
        Medic Delete(Medic Medic);
    }
}