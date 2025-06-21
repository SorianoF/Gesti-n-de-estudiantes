using estudiantesGestion;
using Gestión_de_estudiantes;

namespace Gestión_de_estudiantes;
public class Program
{
    public static void Main(string[]args)
    {
        var gestor = new GestorAsignaturas();
        gestor.Iniciar();
    }
}