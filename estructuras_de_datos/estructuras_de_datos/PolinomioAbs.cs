using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class PolinomioAbs
    {
        protected MemoriaImp _mem;
        protected int inicio;
        protected int longitud;

        public PolinomioAbs()
        {
            _mem = new MemoriaImp();
            inicio = -1;
            longitud = 0;
        }

        public abstract void CrearPolinomio();
        public abstract void PonerTermino(int coeficiente, int exponente);
        public abstract int GradoPolinomio();
        public abstract string Derivada();
        public abstract double Area(double a, double b);
        public abstract string MostrarPolinomio();
    }
}
