using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;

namespace API.Repositories.MedicRepository
{
    public class MedicRepository : IMedicRepository
    {
        public DataContext _context { get; set; }
        public MedicRepository(DataContext context)
        {
            _context = context;
        }

        public List<Medic> GetAll()
        {
            return _context.Medics.ToList();
        }
        
        public Medic Get(int Id)
        {
            return _context.Medics.SingleOrDefault(x => x.Id == Id);
        }

        public Medic Create(Medic medic)
        {
            var result = _context.Add<Medic>(medic);
            _context.SaveChanges();
            return result.Entity;
        }

        public Medic Update(Medic Medic)
        {
            _context.Entry(Medic).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Medic;
        }

        public Medic Delete(Medic Medic)
        {
            var result = _context.Remove(Medic);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}