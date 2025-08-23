using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class MemoriaABC
    {
        protected const int MAX = 30;
        protected const int NULL = -1;

        public struct Nodo
        {
            public string dato;
            public int id;
            public int link;
            public int dir;
        }
        public Nodo[] mem = new Nodo[MAX];
        protected int libre;

        public MemoriaABC()
        {
            int i = 0;
            while (i < MAX)
            {
                mem[i].dir = i;
                mem[i].id = 0;
                mem[i].dato = "";
                mem[i].link = i + 1;
                i++;
            }
            libre = 0;
            mem[MAX - 1].link = NULL;
        }
        public abstract void mostrar();
        public abstract void new_espacio(int cantidad);
        public abstract void delete_espacio(int dir);
        public abstract int espacio_disponible();
        public abstract int espacio_ocupado();
        public abstract bool dir_libre(int dir);
        public abstract void poner_dato(int dir, int lugar, string valor);
        public abstract string obtener_dato(int dir, int lugar);
        public abstract void espacio_palabra(string cadena);
        public abstract void modificar_link(int dir, int nuevo_link);
        public abstract int espacio_libre();


      
    }
}