using EstudianteWilliam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteWilliam.Services
{
    interface IEstudiante
    {

        //CRUD

        //C
        void Create(estudiante estudiante);
        //D
        void Delete(estudiante estudiante);

        void update(estudiante estudiante);

        List<estudiante> ListOfDataOfTableEstudiante();


    }
}
