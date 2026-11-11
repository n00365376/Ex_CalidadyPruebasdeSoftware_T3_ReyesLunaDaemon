
using System;
using System.Collections.Generic;

class General
{
    public static List<int> ids = new List<int>();
    public static List<string> nombres = new List<string>();
    public static List<int> edades = new List<int>();
    public static List<string> salones = new List<string>();
    public static List<double> promedios = new List<double>();

    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n===== SISTEMA DE ALUMNOS =====");
            Console.WriteLine("1. Registrar alumno");
            Console.WriteLine("2. Registrar notas");
            Console.WriteLine("3. Visualizar alumnos");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                int id = ids.Count + 1;

                Console.WriteLine("\nID del alumno: " + id);

                Console.Write("Ingrese el nombre completo: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Ingrese la edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el salon: ");
                string salon = Console.ReadLine() ?? "";

                ids.Add(id);
                nombres.Add(nombre);
                edades.Add(edad);
                salones.Add(salon);
                promedios.Add(-1);

                Console.WriteLine("\nAlumno registrado correctamente.");
            }
            else if (opcion == 2)
            {
                Promedio promedio = new Promedio();
                promedio.RegistrarNotas();
            }
            else if (opcion == 3)
            {
                Visualizar visualizar = new Visualizar();
                visualizar.Mostrar();
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Saliendo del sistema...");
            }
            else
            {
                Console.WriteLine("Opcion incorrecta.");
            }

        } while (opcion != 4);
    }
}
