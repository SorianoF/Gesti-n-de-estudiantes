using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_estudiantes
{
    public class OperationResult
    {
        public string Message { get; set; }
        //Mensaje de la operacion
        public bool Success { get; set; }
        //Inidicador de exito o fallo
        public string Data { get; set; }
        //Datos opcionales de salida 

        //Metodo estatico para crear una respuesta exictosa 
        public static OperationResult Ok(dynamic data = null) =>
            new OperationResult { Success = true, Data = data, Message = "Operacion Exitosa" };

        public static OperationResult Fail(String message) =>
            new OperationResult { Success = false, Message = message, Data = null };
    }
}
