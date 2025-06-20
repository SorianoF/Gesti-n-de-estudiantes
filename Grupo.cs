using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public class Grupo
    {
        public string NombreGrupo { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public Grupo(string nombre)
        {
            NombreGrupo = nombre;
        }

        public OperationResult AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            return OperationResult.Ok();
        }

        public OperationResult RegistrarCalificaciones()
        {
            if (Estudiantes.Count == 0)
                return OperationResult.Fail("No hay estudiantes en este grupo");

            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine($"Ingrese nota de examen para {estudiante.Nombre}:");
                estudiante.NotaExamen = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese nota de práctica para {estudiante.Nombre}:");
                estudiante.NotaPractica = double.Parse(Console.ReadLine());
            }

            return OperationResult.Ok();  
        }

        //Imprime los datos y nota final de cada estudiante 
        public void MostrarListaCalificaciones()
        {
            Console.WriteLine($"\nListado de calificaciones - Grupo {NombreGrupo}"); 
            foreach(var estudiante in Estudiantes)
            {
                estudiante.MostrarDatos();
                double notaFinal = estudiante.CalcularNotaFinal();
                Console.WriteLine($"Nota final: {notaFinal}");
            }
        }

        //Calcula el porcentaje de los estudiantes aprobados 
        public double CalcularPorcentajeAprobados()
        {
            int total = Estudiantes.Count;
            int aprobados = Estudiantes.Count(e => e.CalcularNotaFinal() >= 70);
            return total == 0 ? 0 : (aprobados * 100.0 / total);
        }

    }
}
