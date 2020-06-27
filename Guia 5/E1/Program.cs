using System;
using System.Collections.Generic;
using System.Linq;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 = new Persona(35, "Juan", "Perez");
            Persona p2 = new Persona(16, "Juan", "Ludenberg");
            Persona p3 = new Persona(60, "Carlos", "Perez");
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);

            List<Persona> mayoresDeEdad = personas.Where(persona => persona.Edad >= 18).ToList();
            Console.WriteLine("Mayores de Edad:\n");
            mayoresDeEdad.ForEach(persona => Console.WriteLine("Nombre: " + persona.Nombre + "\nApellido: " + persona.Apellido + "\nEdad: " + persona.Edad));

            List<Persona> Juanes = personas.Where(personas => personas.Nombre == "Juan").ToList();
            Console.WriteLine("\nLos Juanes:\n");
            Juanes.ForEach(persona => Console.WriteLine("Nombre: " + persona.Nombre + "\nApellido: " + persona.Apellido + "\nEdad: " + persona.Edad));

            List<Persona> Perez = personas.Where(personas => personas.Apellido == "Perez").ToList();
            Console.WriteLine("\nLos Perez:\n");
            Perez.ForEach(persona => Console.WriteLine("Nombre: " + persona.Nombre + "\nApellido: " + persona.Apellido + "\nEdad: " + persona.Edad));


        }
    }
}
