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
        Pila pila = new Pila();
        Cola cola = new Cola();

        llenar(pila);
        llenar(cola);

        informar(pila);
        informar(cola);
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
}


