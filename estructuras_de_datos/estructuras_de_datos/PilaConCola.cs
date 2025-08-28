using computadora;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    public abstract class PilaConCola
    {

        protected PilaImp _lista;

        public PilaConCola(MemoriaImp mem)
        {
            _lista = new PilaImp(mem);
        }

        public abstract bool vacia();
        public abstract string cima();
        public abstract void meter(string dato);
        public abstract string sacar();
        public abstract string mostrar();
    }
}
