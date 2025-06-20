using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public class EstudiantePresencial : Estudiante
    {
        public EstudiantePresencial(string nombre, string matricula) : base(nombre, matricula) { }
        public override double CalcularNotaFinal()
        {
            return NotaExamen * 0.6 + NotaPractica * 0.4;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Tipo: Presencial");
        }
    }
}
