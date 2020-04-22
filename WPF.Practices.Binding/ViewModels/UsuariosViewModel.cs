using System;
using System.Collections.Generic;
using WPF.Practices.Binding.Models;

namespace WPF.Practices.Binding.ViewModels
{
    public class UsuariosViewModel
    {
        public UsuariosViewModel()
        {
            Escuela = new Escuela();
            Escuela.Nombre = "San Nicolas";
            Escuela.Personas = ObtenerAlumnos();
        }

        public Escuela Escuela { get; set; }

        public List<Persona> ObtenerAlumnos()
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 0; i < 20; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "Jorge" + i;
                persona.Apellido = "Maza" + i;
                persona.Identificador = Guid.NewGuid().ToString();

                personas.Add(persona);
            }
            return personas;
        }
    }
}
