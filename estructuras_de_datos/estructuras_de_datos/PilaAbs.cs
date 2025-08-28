using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class PilaAbs
    {
        protected ListaImp _lista;

        public PilaAbs(MemoriaImp mem)
        {
            _lista = new ListaImp(mem);
        }

        public abstract bool vacia();
        public abstract string cima();
        public abstract void meter(string dato);
        public abstract string sacar();
        public abstract string mostrar();
        public abstract int cantidad();

    }
}
