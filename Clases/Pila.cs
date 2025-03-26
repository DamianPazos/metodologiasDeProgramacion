using MetodologiasDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion.Clases
{
    public class Pila : Coleccionable
    {
        List<Comparable> elementos;

        public Pila()
        {
            elementos = new List<Comparable>();
        }
        // Utilizamos el metodo de la interfaz 
        /*public void agregarElemento(Comparable c)
        {
            elementos.Add(c);
        } */

       public Comparable retirar()
       {
            Comparable elemento = this.elementos[this.elementos.Count - 1];
            elementos.RemoveAt(this.elementos.Count - 1);
            return elemento;
       }

        public int cuantos()
        {
            return this.elementos.Count;
        }

        public Comparable minimo()
        {
            Comparable min = this.elementos[0];
            for(int i = 1; i<this.elementos.Count -1; i++)
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
                for(int i = 1; i>this.elementos.Count -1; i++)
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
            foreach(Comparable elemento in this.elementos)
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

