using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseFirstEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (databaseFirstEntities db = new databaseFirstEntities())
            {
                var lst = db.Estudiante;

                foreach (var alumno in lst)
                {
                    Console.WriteLine($"ID: {alumno.id} Nombre: {alumno.nombre} Apellido: {alumno.apellido} Edad: {alumno.edad}");
                }

                Console.WriteLine("Estudiantes de 22 años o mas.");

                var estudiantesMayoresDe22 = db.Estudiante
                    .Where(alumno => alumno.edad >= 22)
                    .OrderBy(alumno => alumno.nombre)
                    .ToList();

                foreach (var alumno in estudiantesMayoresDe22)
                {
                    Console.WriteLine($"ID: {alumno.id} Nombre: {alumno.nombre} Apellido: {alumno.apellido} Edad: {alumno.edad}");

                }

                Console.ReadLine();

            }
        }
    }
}
