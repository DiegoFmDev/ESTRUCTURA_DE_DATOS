using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class ColaAbs
    {
        protected ListaImp _lista;

        public ColaAbs(MemoriaImp mem) {
            _lista = new ListaImp(mem);
        }

        public abstract bool vacia();
        public abstract string primero();
        public abstract void poner(string dato);
        public abstract string sacar();
        public abstract string mostrar_cola();
        public abstract int cantidad();
    }
}
