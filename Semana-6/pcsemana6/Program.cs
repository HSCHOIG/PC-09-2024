using System;
 
namespace semana6_LuisAguilar /*nombre del proyecto nombre del espacio de trabajo*/
{
     class semana6 /* clase general */
    {
        /*
        ESTE toma la edad de una persona, calcula y muestra edad futura
        */
 
        // Metodo tipo void ()
        static void Main(string[] args) /*INICIO*/
        {
            /*sección de declaración de variables inicializamos variables */
            string nombre; /*tipo texto */
             edad; /*tipo entero*/
            int futuro = 10; /* constante 10 años mas */
            int edadfuturo;
            long Sumatoria; /*con decimales */
 
            /*Mensajes en consola*/
            Console.WriteLine("Hola usuario! \n Ingresa  tu nombre");
 
                nombre = Console.ReadLine()
            
            /*Mostrar mensaje en pantalla*/
            Console.WriteLine("Ingresa  tu  edad");
                edad = Int32.Parse(Console.ReadLine());
 
            Console.WriteLine("Eres un super usuario " + nombre + " de" + edad + " años");
            Console.ReadKey(); /*ENTER */
                edadfuturo = edad + futuro;
            Console.WriteLine("En 10 años tendrás " + edadfuturo);
            Console.ReadKey();
 
            Console.WriteLine("!Bye!");
            Console.ReadKey();
 
        }
    }
 
}