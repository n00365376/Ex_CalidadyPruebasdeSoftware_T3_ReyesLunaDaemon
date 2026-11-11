
using System;

class Visualizar
{
    public void Mostrar()
    {
        Console.WriteLine("\n===== LISTA DE ALUMNOS =====");

        if (General.ids.Count > 0)
        {
            for (int i = 0; i < General.ids.Count; i++)
            {
                Console.WriteLine("\nAlumno N° " + (i + 1));
                Console.WriteLine("----------------------------");

                Console.WriteLine("ID: " + General.ids[i]);
                Console.WriteLine("Nombre: " + General.nombres[i]);
                Console.WriteLine("Edad: " + General.edades[i]);
                Console.WriteLine("Salon: " + General.salones[i]);

                if (General.promedios[i] == -1)
                {
                    Console.WriteLine("Promedio: Pendiente");
                }
                else
                {
                    Console.WriteLine("Promedio: " + General.promedios[i].ToString("F2"));
                }
            }

            Console.WriteLine("\nTotal de alumnos: " + General.ids.Count);
        }
        else
        {
            Console.WriteLine("No hay alumnos registrados.");
        }
    }
}
