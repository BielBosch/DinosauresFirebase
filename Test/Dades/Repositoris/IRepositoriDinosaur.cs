using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Dades.Model;

namespace Test.Dades.Repositoris
{
    public interface IRepositoriDinosaur
    {
        Task<IReadOnlyCollection<FirebaseObject<Dinosaur>>> GetDinosaurs();
        Task CrearDinosaures(Dinosaur myDino);
        Task DeleteDino(string text);    


    }
}
