using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion.Clases
{
    // Ejercicio N°12 - Practica N°1
    public class Alumno : Persona
    {
        private int legajo;
        private float promedio;

        public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public float getPromedio()
        {
            return promedio;
        }
    }
}
