using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi3.Model;

namespace WebApi3.Interface
{
    public interface IPetRepository
    {
        Pet Insert(Pet pet);
        Pet Delete(int id);
        Pet Get(int Id);
        Pet Update(Pet pet);
        
        List<Pet> ToList();

    }
}
