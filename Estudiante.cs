using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public abstract class Estudiante
    {
        public string Nombre {  get; set; }
        public string Matricula { get; set; }
        public double NotaExamen {  get; set; }
        public double NotaPractica { get; set; }

        public Estudiante(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

        //Método abstracto que debe ser implementado por las subclases
        public abstract double CalcularNotaFinal();

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Matricula: {Matricula}");
        }
    }
}
