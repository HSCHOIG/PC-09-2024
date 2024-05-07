using System;

class Program
{
    public static string[] nombres = new string[10];
    public static int[] notas = new int[10];

    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Escriba nombre " + (i + 1) + ": ");
            nombres[i] = Console.ReadLine();
            Console.Write("Escriba la nota del alumno " + (i + 1) + ": ");
            if (int.TryParse(Console.ReadLine(), out notas[i])) { }
            else
            {
                Console.WriteLine("Ingrese una nota valida.");
                i--;
            }
        }

        while (true)
        {
            Console.WriteLine("1. Nombres y notas");
            Console.WriteLine("2. Nombres y notas que aprobaron");
            Console.WriteLine("3. Nombres y notas que no aprobaron");
            Console.WriteLine("4. Promedio de la clase");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Notas();
                    break;
                case 2:
                    NotasA();
                    break;
                case 3:
                    NotasR();
                    break;
                case 4:
                    Promedio();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Ingrese valor valido");
                    break;
            }
        }
    }

    public static void Notas()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1) + " : " + nombres[i]);
            Console.WriteLine("Nota: " + notas[i]);
        }
    }

    public static void NotasA()
    {
        Console.WriteLine("Nombres y notas de estudiantes que aprobaron:");
        for (int i = 0; i < 10; i++)
        {
            if (notas[i] >= 60)
            {
                Console.WriteLine("Estudiante " + (i + 1) + " : " + nombres[i]);
                Console.WriteLine("Nota: " + notas[i]);
            }
        }
    }

    public static void NotasR()
    {
        Console.WriteLine("Nombres y notas de estudiantes que no aprobaron:");
        for (int i = 0; i < 10; i++)
        {
            if (notas[i] < 60)
            {
                Console.WriteLine("Estudiante " + (i + 1) + " : " + nombres[i]);
                Console.WriteLine("Nota: " + notas[i]);
            }
        }
    }

    public static void Promedio()
    {
        int suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += notas[i];
        }
        double promedio = (double)suma / 10;
        Console.WriteLine("Promedio de la clase: " + promedio);
    }
}
