using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public List<Grupo> Grupos { get; set; } = new List<Grupo>(); 

        public Asignatura(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarGrupo(Grupo grupo)
        {
            Grupos.Add(grupo); 
        }
    }
}
