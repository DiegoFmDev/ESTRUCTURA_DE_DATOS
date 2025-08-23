using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class ListaAbs
    {
        protected int _longitud;
        protected int _inicio;
        protected int _final;
        protected MemoriaImp _mem;

        public ListaAbs(MemoriaImp mem)
        {
            _longitud = 0;
            _inicio = -1;
            _final = -1;
            _mem = mem;
        }


        public abstract void insertar(int pos, string dato);
        public abstract void suprimir(int pos);
        public abstract void modificarDato(int pos, string dato);
        public abstract bool vacia();
        public abstract int primero();
        public abstract int fin();
        public abstract int anterior(int dir);
        public abstract int posterior(int dir);
        public abstract string mostrar_Lista();
        public abstract string mostrar_dato(int pos);
        public abstract int ver_longitud();

    }
}