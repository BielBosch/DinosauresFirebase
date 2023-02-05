using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Dades.Model;

namespace Test.Domini
{
    public interface IDominiDinosaur
    {
        Task<IReadOnlyCollection<FirebaseObject<Dinosaur>>> ObtenirDinosaures();
        Task CrearDinosaures(Dinosaur myDino); //Task que crea dinosaures
        Task DeleteDino(string text);//Task que elimina dinosaures        
    }
}
