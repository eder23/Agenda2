using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static Agenda AgendaContactos;
        static int ObtenerOpcion (string texto)
        {
            bool leido = false;
            int valorLeido = 0;
            while (!leido)
            {
                try
                {
                    Console.Write(texto);
                    valorLeido = Convert.ToInt32(Console.ReadLine());
                    leido = true;

                }
                catch (Exception ex)
                {

                    Console.WriteLine("ERROR : Tienes que introducir un numero."); ;
                }
            }
            return valorLeido;
        }

        static void MostrarMenu()
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1.- Mostrar contactos");
            Console.WriteLine("2.- Buscar contactos");
            Console.WriteLine("3.- Crear contacto nuevo");
            Console.WriteLine("4.- Borrar contactos");
            Console.WriteLine("5.- Guardar contactos");
            Console.WriteLine("6.- Salir");
        }


        static void BuscarContactos()
        {
            Console.WriteLine("Buscar contactos:" );
            Console.WriteLine("1.- Por nombre");
            Console.WriteLine("2.- Por Telefono");
            Console.WriteLine("3.- Volver");
            bool finBuscar = false;
            while (!finBuscar)
            {
                int opcion = ObtenerOpcion("Opcion: ");
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el nombre a buscar:");
                        List<Contacto> encontradosNombre = AgendaContactos.BuscarContactosPorNombre(Console.ReadLine());
                        if (encontradosNombre.Count > 0)
                        {
                            Console.WriteLine("########## CONTACTOS ENCONTRADOS ###########");
                            foreach (Contacto contacto in encontradosNombre)
                            {
                                contacto.MostrarContacto();
                            }

                            Console.WriteLine("############################");
                        }
                        else
                        {
                            Console.WriteLine("INFO : No se han encontrado contactos con ese nombre.");

                        }

                        finBuscar = true;
                        break;

                    case 2:
                        Console.Write("Introduzca el nombre a buscar:");
                        List<Contacto> encontradosTelefono = AgendaContactos.BuscarContactosPorTelefono(Console.ReadLine());
                        if (encontradosTelefono.Count > 0)
                        {
                            Console.WriteLine("########## CONTACTOS ENCONTRADOS ###########");
                            foreach (Contacto contacto in encontradosTelefono)
                            {
                                contacto.MostrarContacto();
                            }

                            Console.WriteLine("############################");
                        }
                        else
                        {
                            Console.WriteLine("INFO : No se han encontrado contactos con ese Telefono.");

                        }

                        finBuscar = true;
                        break;

                    case 3:
                        finBuscar = true;
                        break;
                   
                }

            }

        }


        static void ProcesoCrearContactos()
        {
            Contacto contacto = new Contacto();
            Console.Write("Introduce el nombre : ");
            contacto.SetNombre(Console.ReadLine());
            Console.Write("Introduce los apellidos : ");
            contacto.SetApellidos(Console.ReadLine());
            Console.Write("Introduce la fecha de nacimiento : ");
            contacto.SetfechaNacimiento(Console.ReadLine());
            Console.Write("Introduce el telefono movil : ");
            contacto.SetTelefonoMovil(Console.ReadLine());
            Console.Write("Introduce el telefono fijo : ");
            contacto.SetTelefonoFijo(Console.ReadLine());
            Console.Write("Introduce el telefono de trabajo : ");
            contacto.SetTelefonoTrabajo(Console.ReadLine());
            Console.Write("Introduce la calle : ");
            contacto.SetCalle(Console.ReadLine());
            Console.Write("Introduce el piso : ");
            contacto.SetPiso(Console.ReadLine());
            Console.Write("Introduce la ciudad : ");
            contacto.SetCiudad(Console.ReadLine());
            Console.Write("Introduce el codigo postal : ");
            contacto.SetCodigoPostal(Console.ReadLine());
            Console.Write("Introduzca el email : ");
            contacto.SetEmail(Console.ReadLine());
            AgendaContactos.CrearNuevoContacto(contacto);

        }

        static void BorrarContacto()
        {
            Console.WriteLine("Buscar contactos a borrar por : ");
            Console.WriteLine("1.- Por nombre ");
            Console.WriteLine("2.- Por Telefono");
            Console.WriteLine("3.- Volver");
            bool finBuscar = false;
            while (!finBuscar)
            {
                int opcion = ObtenerOpcion("Opcion: ");
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduzca el nombre : ");
                        AgendaContactos.BorrarContactosPorNombre(Console.ReadLine());
                        finBuscar = true;
                        break;

                    case 2:
                        Console.Write("Introduzca el telefono : ");
                        AgendaContactos.BorrarContactosPorTelefono(Console.ReadLine());
                        finBuscar = true;
                        break;

                    case 3:
                        finBuscar = true;
                        break;

                    default:
                        break;
                }
            }

        }


        static void Main(string[] args)
        {
            AgendaContactos = new Agenda("Agenda.txt");
            if (!AgendaContactos.CargarContactos())
            {
                Console.WriteLine("ERROR : No se pueden cargar los contactos del fichero.");

            }
            bool fin = false;

            while (!fin)
            {
                MostrarMenu();
                switch (ObtenerOpcion("Opcion: "))
                {
                    case 1:
                        AgendaContactos.MostrarAgenda();
                        break;
                    case 2:
                        BuscarContactos();
                        break;
                    case 3:
                        ProcesoCrearContactos();
                        break;
                    case 4:
                        BorrarContacto();
                        break;
                    case 5:
                        AgendaContactos.GuardarContactos();
                        break;
                    case 6:
                        fin = true;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadLine();

        }
    }
}
