using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Telefono
    {
        string TelefonoMovil;
        string TelefonoFijo;
        string TelefonoTrabajo;
        public void SetTelefonoMovil(string movil) { TelefonoMovil = movil; }
        public void SetTelefonoFijo(string fijo) { TelefonoFijo = fijo; }
        public void SettelefonoTrabajo (string trabajo) { TelefonoTrabajo = trabajo; }

        public string GetTelefonoMovil() { return TelefonoMovil; }
        public string GetTelefonoFijo() { return TelefonoFijo; }
        public string GetTelefonoTrabajo() { return TelefonoTrabajo; }
    }
}
