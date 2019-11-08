using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NestorAnchundiaA3B.clases
{
    public class Nodo
    {
        private Nodo luego;
        public Nodo Luego
        {
            get { return luego; }
            set { luego = value; }
        }
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
    }

    //ATRIBUTOS DE LA PILA
    public class NodoPila
    {
        private NodoPila luegopila;

        public NodoPila Luegopila
        {
            get { return luegopila; }
            set { luegopila = value; }
        }
        private int datopila;

        public int Datopila
        {
            get { return datopila; }
            set { datopila = value; }
        }
    }
}
