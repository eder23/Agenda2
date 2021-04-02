using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda
{
    class Agenda
    {
        List<Contacto> ListaContactos;
        string Path;
        public Agenda (string path ) {
            ListaContactos = new List<Contacto>();
            Path = path;
        }

        public bool CargarContactos()
        {
            if (File.Exists(Path))
            {
                ListaContactos.Clear();
                using (StreamReader sr = new StreamReader(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] datos = sr.ReadLine().Split('#');
                        if (datos.Length==11)
                        {
                            Contacto contacto = new Contacto();
                            contacto.SetNombre(datos[0]);
                            contacto.SetApellidos(datos[1]);
                            contacto.SetfechaNacimiento(datos[2]);
                            contacto.SetTelefonoMovil(datos[3]);
                            contacto.SetTelefonoFijo(datos[4]);
                            contacto.SetTelefonoTrabajo(datos[5]);
                            contacto.SetCalle(datos[6]);
                            contacto.SetPiso(datos[7]);
                            contacto.SetCiudad(datos[8]);
                            contacto.SetCodigoPostal(datos[9]);
                            contacto.SetEmail(datos[10]);
                            ListaContactos.Add(contacto);

                        }

                    }
                    sr.Close();

                }
                Console.WriteLine("INFO : Se han cargado un total de {0} contactos. ", ListaContactos.Count);
                return true;
            }
            return false;
            
        }


        public void CrearNuevoContacto(Contacto contacto)
        {
            ListaContactos.Add(contacto);
        }

        public bool GuardarContactos()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path,false))
                {
                    foreach (Contacto contact in ListaContactos)
                    {
                        sw.Write(contact.GetNombre() + "#");
                        sw.Write(contact.GetApellidos() + "#");
                        sw.Write(contact.GetFechaNacimiento() + "#");
                        sw.Write(contact.GetTelefonoMovil() + "#");
                        sw.Write(contact.GetTelefonoFijo() + "#");
                        sw.Write(contact.GetTelefonoTrabajo() + "#");
                        sw.Write(contact.GetCalle() + "#");
                        sw.Write(contact.GetPiso() + "#");
                        sw.Write(contact.GetCiudad() + "#");
                        sw.Write(contact.GetCodigoPostal() + "#");
                        sw.Write(contact.GetEmail() + "\n");
                    }
                    sw.Close();
                    Console.WriteLine("INFO : Contacto guardados correctamente.");
                    return true;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR : " + ex.Message); 
            }

            return false;
        }


        public void MostrarAgenda()
        {
            Console.WriteLine("##########  AGENDA  ##########");
            Console.WriteLine("Numero de contactos : {0}" , ListaContactos.Count);
            foreach (Contacto contacto in ListaContactos)
            {
                contacto.MostrarContacto();
                Console.WriteLine("############################");

            }
        }


        public List <Contacto> BuscarContactosPorNombre(string nombre)
        {
            List<Contacto> listaEncontrados = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (contacto.GetNombre() == nombre)
                {
                    listaEncontrados.Add(contacto);

                }
            }
            return listaEncontrados;
        }

        public List<Contacto> BuscarContactosPorTelefono(string telefono)
        {
            List<Contacto> listaEncontrados = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (contacto.GetTelefonoMovil() == telefono || contacto.GetTelefonoFijo() == telefono || contacto.GetTelefonoTrabajo() == telefono )

                {
                    listaEncontrados.Add(contacto);

                }
            }
            return listaEncontrados;
        }


        public void BorrarContactosPorNombre(string nombre)
        {
            List<Contacto> listaFinal = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (!(contacto.GetNombre()==nombre))
                {
                    listaFinal.Add(contacto);

                }
              
            }
            Console.WriteLine("INFO : Se han borrado {0} contactos. ", (ListaContactos.Count - listaFinal.Count));
            ListaContactos = listaFinal;
        }


        public void BorrarContactosPorTelefono(string telefono)
        {
            List<Contacto> listaFinal = new List<Contacto>();
            foreach (Contacto contacto in ListaContactos)
            {
                if (!(contacto.GetTelefonoMovil() == telefono || contacto.GetTelefonoFijo() == telefono || contacto.GetTelefonoTrabajo() == telefono))

                {
                    listaFinal.Add(contacto);

                }
                

            }
            Console.WriteLine("INFO : Se han borrado {0} contactos.", (ListaContactos.Count - listaFinal.Count));
            ListaContactos = listaFinal;
        }

    }
}
