using Gestión_de_estudiantes;

namespace Gestión_de_estudiantes;
public class Program
{
    public static void Main(string[]args)
    {
        // Crear una asignatura con un grupo
        Asignatura asignatura = new Asignatura("Programacion Orientada a Objetos");
        Grupo grupo1 = new Grupo("Grupo A");
        asignatura.AgregarGrupo(grupo1);

        // Entrada estudiante 
        Console.WriteLine("==== Agregar estudiantes ===");
        Console.WriteLine("Cuantos estudiantes deseas agregar? "); 
        int  cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Estudiante #{i + 1}");
            Console.Write("Nombre: "); 
            string nombre = Console.ReadLine();

            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();

            Console.Write("Tipo (1: Presencial, 2: Distancia): "); 
            int tipo  = int.Parse(Console.ReadLine());

            // Crear instancia del estudiante segun el tipo 
            Estudiante nuevoEstudiante = tipo == 1
                ? new EstudiantePresencial(nombre, matricula)
                : new EstudianteDistancia(nombre, matricula);

            grupo1.AgregarEstudiante(nuevoEstudiante);
        }

        // Registro de notas y generacion de reportes 
        grupo1.RegistrarCalificaciones();
        grupo1.MostrarListaCalificaciones();

        double porcentaje = grupo1.CalcularPorcentajeAprobados();
        Console.WriteLine($"Porcentaje de estudiantes aprobados: {porcentaje}");
    }
}