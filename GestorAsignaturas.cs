using Gestión_de_estudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiantesGestion
{
    public class GestorAsignaturas
    {
        public void Iniciar()
        {
            Asignatura asignatura = new Asignatura("Programación Orientada a Objetos");
            Grupo grupo1 = new Grupo("Grupo A");
            asignatura.AgregarGrupo(grupo1);

            Console.WriteLine("==== Agregar estudiantes ===");
            Console.Write("¿Cuántos estudiantes deseas agregar? ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                return;
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nEstudiante #{i + 1}");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();

                Console.Write("Tipo (1: Presencial, 2: Distancia): ");
                if (!int.TryParse(Console.ReadLine(), out int tipo) || (tipo != 1 && tipo != 2))
                {
                    Console.WriteLine("Tipo inválido. Se omitirá este estudiante.");
                    i--;
                    continue;
                }

                Estudiante nuevoEstudiante = tipo == 1
                    ? new EstudiantePresencial(nombre, matricula)
                    : new EstudianteDistancia(nombre, matricula);

                grupo1.AgregarEstudiante(nuevoEstudiante);
            }

            grupo1.RegistrarCalificaciones();
            grupo1.MostrarListaCalificaciones();

            double porcentaje = grupo1.CalcularPorcentajeAprobados();
            Console.WriteLine($"\nPorcentaje de estudiantes aprobados: {porcentaje}%");
        }
    }
}
