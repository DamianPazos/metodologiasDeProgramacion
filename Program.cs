// See https://aka.ms/new-console-template for more information
// Ejercicio N°5 - Practica N°1

using MetodologiasDeProgramacion.Clases;
using MetodologiasDeProgramacion.Interfaces;

namespace MetodologiasDeProgramacion;
public class Program
{
    static void Main(string[] args)
    {
        // codigo programa
    }

    public void llenar(Coleccionable c)
    {
        Random random = new Random();
        for (int contador = 1; contador < 21; contador++)
        {
            Comparable numero = new Numero(random.Next(1, 100000));
            c.agregar(numero);
        }
    }
}


