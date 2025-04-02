// See https://aka.ms/new-console-template for more information
// Ejercicio N°5 - Practica N°1

using MetodologiasDeProgramacion.Clases;
using MetodologiasDeProgramacion.Interfaces;

namespace MetodologiasDeProgramacion;
public class Program
{
    static void Main(string[] args)
    {
        // Ejercicio N°7 - Practica N°1
        // Ejercicio N°9 - Practica N°1
        Pila pila = new Pila();
        Cola cola = new Cola();
        ColeecionMultiple multiple = new ColeecionMultiple(pila, cola);

        llenar(pila);
        llenar(cola);

        informar(pila);
        informar(cola);
        informar(multiple);
        // codigo programa
    }

    public static void llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int contador = 1; contador < 21; contador++)
        {
            Comparable numero = new Numero(random.Next(1, 100));
            c.agregar(numero);
        }
    }

    // Ejericio N°6 - Practica N°1
    public static void informar(Coleccionable c)
    {
        Console.WriteLine(c.cuantos);
        Console.WriteLine(c.minimo);
        Console.WriteLine(c.maximo);
        Console.WriteLine("Ingrese un numero para determinar si esta en la lista: ");
        int valorIngresado = int.Parse(Console.ReadLine());
        Comparable numero = new Numero(valorIngresado);

        if (c.contiene(numero))
        {
            Console.WriteLine("Contiene el elemento ingresado");
        }
        else
        {
            Console.WriteLine("No contiene el elemento ingresado");
        }
    }

    // Ejercicio N°13 - Practica N°1
    public void llenarAlumnos(Coleccionable c)
    {
        // Extra para nombres al azar
        string[] listaNombres = { "Juan", "María", "Carlos", "Laura", "Pedro", "Sofía", "Fernando", "Ana", "Diego", "Marta", "Luis", "Elena", "Ricardo", "Gabriela", "Miguel", "Patricia", "Javier", "Isabel", "Roberto", "Silvia", "Daniel", "Victoria", "Alejandro", "Cristina", "Héctor", "Julia", "Eduardo", "Sara", "Pablo", "Beatriz", "Alberto", "Cecilia", "Raúl", "Lorena", "Francisco", "Natalia", "Andrés", "Verónica", "Emilio", "Adriana", "Gustavo", "Liliana", "Oscar", "Mercedes", "Iván", "Paula", "Manuel", "Esther", "Jesús", "Camila" };
        Random nombreRandom = new Random();
        Random dniRandom = new Random();
        Random legajoRandom = new Random();
        Random promedioRandom = new Random();

        for (int contador = 1;contador < 21; contador++)
        {
            Comparable alumno = new Alumno(listaNombres[nombreRandom.Next(listaNombres.Length)], dniRandom.Next(10000, 50000), legajoRandom.Next(1000, 9999), promedioRandom.Next(1, 11));
            c.agregar(alumno);
        }
    }
}


