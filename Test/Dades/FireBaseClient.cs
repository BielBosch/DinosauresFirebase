using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Dades
{
    public class FireBaseClient
    {
        /// <summary>
        /// Devuelve un cliente de conexión con una base de datos de Firebase
        /// </summary>
        /// <param name="URL">URL de la base de datos de Firebase</param>
        /// <param name="secret">Secreto de la Base de datos, parámetro opcional, si la BD es pública, no se ha de especificar</param>
        /// <returns>FirebaseClient</returns>
        public static FirebaseClient GetFireBaseClient()
        {
            string URL = "https://projectedam-1fbce-default-rtdb.europe-west1.firebasedatabase.app/";
            string secret = "kZE3Jd52uoSGseZV2ucYJpdfY9IjfurCC23gbus1\r\n";
            FirebaseClient firebaseClient;
            if (string.IsNullOrEmpty(secret))
            {
                firebaseClient = new FirebaseClient(URL);
            }
            else
            {
                firebaseClient = new FirebaseClient(
                URL,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(secret)
                });
            }
            return firebaseClient;
        }
    }
}
