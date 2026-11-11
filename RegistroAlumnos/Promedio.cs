
using System;

class Promedio
{
    public void RegistrarNotas()
    {
        Console.WriteLine("\n===== REGISTRO DE NOTAS =====");

        Console.Write("Ingrese el ID del alumno: ");
        int id = Convert.ToInt32(Console.ReadLine());

        int posicion = General.ids.IndexOf(id);

        if (posicion != -1)
        {
            Console.Write("Ingrese la cantidad de cursos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            double suma = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese la nota del curso " + i + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());

                suma = suma + nota;
            }

            double promedio = suma / cantidad;

            General.promedios[posicion] = promedio;

            Console.WriteLine("\nPromedio del alumno: " + promedio.ToString("F2"));
        }
        else
        {
            Console.WriteLine("No se encontro el alumno.");
        }
    }
}
