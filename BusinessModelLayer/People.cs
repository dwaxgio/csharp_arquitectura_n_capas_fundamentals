using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModelLayer
{
    // 1. Creo proyecto de formulario
    // 2. Creo DataLayer con mapeo de la db con EF
    // 3. Creo BusinessModelLayer con clase People, dado que se va a establecer una funcionalidad de la tabla de DB Personas

    public class People
    {
        // 3.1 Agregar en Referencias a DataLayer para utilizar las entidades de la DB
        // 3.2 Así mismo, si voy a utilizar dependencias de EF en proyecto BusinessModelLayer, agregar el nuget de EntityFramework
        // 3.3 Agregar a App.config codigo de ConectionStrings de DataLayer

        // Creo lista de People
        public static List<DataLayer.Personas> lstGetPeople()
        {
            // Implementacion de contexto a db
            using(DataLayer.CapasEntities DB = new DataLayer.CapasEntities())
            {
                // Return de datos persona
                return DB.Personas.ToList(); // Regrasa lista de tipo datos.personas
            }
        }
    }
}
