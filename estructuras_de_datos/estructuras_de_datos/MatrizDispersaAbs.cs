using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class MatrizDispersaAbs
    {
        protected int filas;
        protected int columnas;
        protected string valorDefecto;
        protected MemoriaImp _mem;
        protected int inicio; 
        protected int longitud;

        public MatrizDispersaAbs()
        {
            filas = 0;
            columnas = 0;
            valorDefecto = "0";
            inicio = -1;
            longitud = 0;
        }

        public abstract void CrearMatriz(int f, int c);
        public abstract void DefinirValorDefecto(string valor);
        public abstract void Dimensionar(int f, int c);
        public abstract void Poner(int fila, int col, string valor);
        public abstract string ObtenerElemento(int fila, int col);
        public abstract double PromedioElementos();
        public abstract string MostrarMatriz();
        public abstract string MostrarAtributos();
    }
}
