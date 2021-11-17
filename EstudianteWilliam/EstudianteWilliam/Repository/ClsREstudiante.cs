using EstudianteWilliam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudianteWilliam.Repository
{
    public class ClsREstudiante
    {


        public void Create(estudiante estudiante)
        {

            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                try
                {

                    conexionBd.estudiante.Add(estudiante);
                    conexionBd.SaveChanges();
                  
                }
                catch (Exception ex)
                {
                  
                }

            }

        }

        public void Delete(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                estudiante = conexionBd.estudiante.Find(estudiante.idEstudiante);
                conexionBd.estudiante.Remove(estudiante);
                conexionBd.SaveChanges();


            }

        }

        public List<estudiante> ListOfDataOfTableEstudiante()
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                List<estudiante> ListaOFData = conexionBd.estudiante.ToList();
                //Select * from estudiante

                return ListaOFData;

            }


        }

        public void update(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                estudiante es = conexionBd.estudiante.Find(estudiante.idEstudiante);


                es.nombresEstudiante = estudiante.nombresEstudiante;
                es.apellidos = estudiante.apellidos;
                es.usuario = estudiante.usuario;
                es.contrasenia = estudiante.contrasenia;
                conexionBd.SaveChanges();
           



            }

        }


    }
}