using MetodologiasDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion.Clases
{
    // Ejercicio N°4 - Practica N°1
    public class Cola : Coleccionable
    {
        List<Comparable> elementos;

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        public Comparable retirar()
        {
            Comparable elemento = this.elementos[0];
            this.elementos.RemoveAt(0);
            return elemento;
        }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable min = this.elementos[0];
            for (int i = 1; i < this.elementos.Count - 1; i++)
            {
                if (min.sosMayor(this.elementos[i]))
                {
                    min = this.elementos[i];
                }
            }
            return min;
        }

        public Comparable maximo()
        {
            Comparable max = this.elementos[0];
            {
                for (int i = 1; i > this.elementos.Count - 1; i++)
                {
                    if (max.sosMenor(this.elementos[i]))
                    {
                        max = this.elementos[i];
                    }
                }
            }
            return max;
        }
        public void agregar(Comparable c)
        {
            this.elementos.Add(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable elemento in this.elementos)
            {
                if (elemento == c)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
