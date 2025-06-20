using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public class EstudianteDistancia : Estudiante
    {
        public EstudianteDistancia(string nombre, string matricula) : base(nombre, matricula) { }
        public override double CalcularNotaFinal()
        {
            return NotaExamen * 0.7 + NotaPractica * 0.3;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Tipo: Distancia"); 
        }
    }
}
