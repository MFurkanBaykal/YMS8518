using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi3.Interface;
using WebApi3.Model;

namespace WebApi3.Services
{

    public class PetRepository : IPetRepository
    {
        private readonly DataContext dataContext;
        private DataContext _dataContext;
        public PetRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Pet Delete(int id)
        {
            var pet = Get(id);
            _dataContext.Pets.Remove(pet);
            _dataContext.SaveChanges();
            return pet;
        }

        public Pet Get(int Id)
        {
            return _dataContext.Pets.Find(Id);
        }

        public Pet Insert(Pet pet)
        {
            _dataContext.Pets.Add(pet);
            _dataContext.SaveChanges();
            return pet;
        }

       

        public List<Pet> ToList()
        {
            return _dataContext.Pets.ToList();
        }

        public Pet Update(Pet pet)
        {
            _dataContext.Pets.Update(pet);
            _dataContext.SaveChanges();
            return pet;
        }
    }
}
