using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class PolinomioImp : PolinomioAbs
    {
        public PolinomioImp()
        {
            _mem = new MemoriaImp();
            inicio = -1;
            longitud = 0;
        }

        public override void CrearPolinomio()
        {
            inicio = -1;
            longitud = 0;
        }

        public override void PonerTermino(int coeficiente, int exponente)
        {
            if (coeficiente == 0) return;

            int dir = _mem.espacio_libre();
            _mem.new_espacio(1);
            _mem.poner_dato(dir, 0, coeficiente.ToString());
            _mem.mem[dir].id = exponente; // id para guardar el exponente

            _mem.modificar_link(dir, inicio);
            inicio = dir;
            longitud++;
        }

        public override int GradoPolinomio()
        {
            int max = 0;
            int x = inicio;
            while (x != -1)
            {
                if (_mem.mem[x].id > max) max = _mem.mem[x].id;
                x = _mem.mem[x].link;
            }
            return max;
        }

        public override string Derivada()
        {
            string res = "";
            int x = inicio;
            while (x != -1)
            {
                int coef = int.Parse(_mem.obtener_dato(x, 0));
                int exp = _mem.mem[x].id;
                if (exp > 0)
                {
                    int nuevoCoef = coef * exp;
                    int nuevoExp = exp - 1;
                    res += $"{nuevoCoef}x^{nuevoExp} + ";
                }
                x = _mem.mem[x].link;
            }
            if (res.EndsWith(" + ")) res = res.Substring(0, res.Length - 3);
            return res == "" ? "0" : res;
        }

        public override double Area(double a, double b)
        {
            // integración por regla de potencia simple
            double suma = 0;
            int x = inicio;
            while (x != -1)
            {
                int coef = int.Parse(_mem.obtener_dato(x, 0));
                int exp = _mem.mem[x].id;
                double integral = coef / (double)(exp + 1) * (Math.Pow(b, exp + 1) - Math.Pow(a, exp + 1));
                suma += integral;
                x = _mem.mem[x].link;
            }
            return suma;
        }

        public override string MostrarPolinomio()
        {
            string res = "";
            int x = inicio;
            while (x != -1)
            {
                int coef = int.Parse(_mem.obtener_dato(x, 0));
                int exp = _mem.mem[x].id;
                res += $"{coef}x^{exp} + ";
                x = _mem.mem[x].link;
            }
            if (res.EndsWith(" + ")) res = res.Substring(0, res.Length - 3);
            return res == "" ? "0" : res;
        }
    }
}
