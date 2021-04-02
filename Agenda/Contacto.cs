using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacto
    {
        Persona persona;
        Direccion direccion;
        Telefono telefono;
        string Email;

        public Contacto()
        {
            persona = new Persona();
            direccion = new Direccion();
            telefono = new Telefono();
        }

        public void SetEmail(string email) { Email = email; }
        public string GetEmail() { return Email; }
        public void SetNombre(string nombre) { persona.SetNombre(nombre); }
        public void SetApellidos(string apellidos) { persona.SetApellidos(apellidos); }
        public void SetfechaNacimiento(string fechanacimiento) { persona.SetFechaNacimiento(fechanacimiento); }

        public string GetNombre() { return persona.GetNombre(); }
        public string GetApellidos() { return persona.GetApellidos(); }
        public string GetFechaNacimiento() { return persona.GetFechaNacimiento(); }
        public void SetTelefonoMovil(string movil) { telefono.SetTelefonoMovil(movil); }
        public void SetTelefonoFijo(string fijo) { telefono.SetTelefonoFijo(fijo); }
        public void SetTelefonoTrabajo(string trabajo) { telefono.SettelefonoTrabajo(trabajo); }

        public string GetTelefonoMovil() { return telefono.GetTelefonoMovil(); }
        public string GetTelefonoFijo() { return telefono.GetTelefonoFijo(); }
        public string GetTelefonoTrabajo() { return telefono.GetTelefonoTrabajo(); }
        public void SetCalle(string calle ) { direccion.SetCalle(calle); }
        public void SetPiso(string piso ) { direccion.SetPiso(piso); }
        public void SetCiudad(string ciudad) { direccion.SetCiudad(ciudad); }
        public void SetCodigoPostal (string codigopostal) { direccion.SetCodigoPostal(codigopostal); }

        public string GetCalle() { return direccion.GetCalle(); }
        public string GetPiso() { return direccion.GetPiso(); }
        public string GetCiudad() { return direccion.GetCiudad(); }
        public string GetCodigoPostal () { return direccion.GetCodigoPostal(); }

        public void MostrarContacto()
        {
            Console.WriteLine("----- Contacto -----");
            Console.WriteLine("Nombre: " + persona.GetNombre());
            Console.WriteLine("Apellidos: " + persona.GetApellidos());
            Console.WriteLine("Fecha de nacimiento:" + persona.GetFechaNacimiento());

            Console.WriteLine("Telefono movil : " + telefono.GetTelefonoMovil());
            Console.WriteLine("Telefono fijo: " + telefono.GetTelefonoFijo() );
            Console.WriteLine("Telefono trabajo : " + telefono.GetTelefonoTrabajo());
            Console.WriteLine("Calle : " + direccion.GetCalle());
            Console.WriteLine("Piso : " + direccion.GetPiso());
            Console.WriteLine("Ciudad: " + direccion.GetCiudad());
            Console.WriteLine("Codigo Postal: " + direccion.GetCodigoPostal());
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("--------------------------------");

        }

    }
}
