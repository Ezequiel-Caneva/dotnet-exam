using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public class Docente: Persona
    {
        public int DocenteId { get; set; }  
        public int Antiguidad { get; set; } 

        public Docente()
        { }     
        public Docente(int id, int docenteid, string Nombre, string Apellido)
        {
            this.Id = id;
            DocenteId = docenteid;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
    }
}
