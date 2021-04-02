using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Persona
    {
        string Nombre;
        string Apellidos;
        string FechaNacimiento;
        public void SetNombre(string nombre) { Nombre = nombre; }
        public void SetApellidos(string  apellidos ) { Apellidos = apellidos; }
        public void SetFechaNacimiento(string fechanacimiento) { FechaNacimiento = fechanacimiento; }
        public string GetNombre() { return Nombre; }
        public string GetApellidos() { return Apellidos; }
        public string GetFechaNacimiento() { return FechaNacimiento; }
       



    }
}
