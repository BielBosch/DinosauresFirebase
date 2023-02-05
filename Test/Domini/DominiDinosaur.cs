using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Dades.Model;
using Test.Dades.Repositoris;

namespace Test.Domini
{
    public class DominiDinosaur : IDominiDinosaur
    {
        public IRepositoriDinosaur RepositoriDinosaur { get; set; }

        public DominiDinosaur() {
            RepositoriDinosaur = new RepositoriDinosaur();
        }

        public Task<IReadOnlyCollection<FirebaseObject<Dinosaur>>> ObtenirDinosaures()
        {
            return RepositoriDinosaur.GetDinosaurs();
        }


        public Task CrearDinosaures(Dinosaur myDino)
        {
            return RepositoriDinosaur.CrearDinosaures(myDino);
        }
        public Task DeleteDino(string myDino)
        {
            return RepositoriDinosaur.DeleteDino(myDino);
        }
    }
}
