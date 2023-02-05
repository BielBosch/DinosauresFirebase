using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Dades.Model;

namespace Test.Dades.Repositoris
{
    public class RepositoriDinosaur : IRepositoriDinosaur
    {
        public FirebaseClient Firebase { get; set; }

        public RepositoriDinosaur()
        {
            Firebase = FireBaseClient.GetFireBaseClient();
        }

        public async Task<IReadOnlyCollection<FirebaseObject<Dinosaur>>> GetDinosaurs()
        {
            return await Firebase.Child("dinosaurs")
                .OrderByKey()
                .OnceAsync<Dinosaur>();
        }

        //public async Task<FirebaseObject<Dinosaur>> CrearDinosaures(Dinosaur myDino)
         
        public async Task CrearDinosaures(Dinosaur myDino)

        {
            await Firebase
           .Child("dinosaurs")
           .Child(myDino.nom)
           .PutAsync(myDino);
        }

        public async Task DeleteDino(string myDino)

        {
            await Firebase
           .Child("dinosaurs")
           .Child(myDino)
               .DeleteAsync();
        }
    }
}
