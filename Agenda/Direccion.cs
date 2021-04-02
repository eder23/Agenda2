using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Direccion
    {
        string Calle;
        string Piso;
        string Ciudad;
        string CodigoPostal;

        public void SetCalle(string calle) { Calle = calle;  }
        public void SetPiso(string piso ) { Piso = piso; }
        public void SetCiudad(string ciudad) { Ciudad = ciudad; }
        public void SetCodigoPostal(string codigopostal) { CodigoPostal = codigopostal; }

        public string GetCalle() { return Calle; }
        public string GetPiso() { return Piso; }
        public string GetCiudad() { return Ciudad; }
        public string GetCodigoPostal() { return CodigoPostal; }
    }
}
