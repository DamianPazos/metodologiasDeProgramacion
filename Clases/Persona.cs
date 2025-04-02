using MetodologiasDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion.Clases
{
    // Ejercicio N°11 - Practica N°1
    public abstract class Persona: Comparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getDni()
        {
            return dni;
        }

        public bool sosIgual(Comparable c)
        {
            return this.getDni() == ((Persona)c).getDni();
        }

        public bool sosMayor(Comparable c)
        {
            return this.getDni() > ((Persona)c).getDni(); ;
        }

        public bool sosMenor(Comparable c)
        {
            return this.getDni() < ((Persona)c).getDni();
        }
    }
}
