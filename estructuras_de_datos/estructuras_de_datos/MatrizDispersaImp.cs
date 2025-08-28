using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class MatrizDispersaImp : MatrizDispersaAbs
    {
        public MatrizDispersaImp()
        {
            _mem = new MemoriaImp();
        }

        public override void CrearMatriz(int f, int c)
        {
            filas = f;
            columnas = c;
            inicio = -1;
            longitud = 0;
        }

        public override void DefinirValorDefecto(string valor)
        {
            valorDefecto = valor;
        }

        public override void Dimensionar(int f, int c)
        {
            filas = f;
            columnas = c;
        }

        public override string MostrarAtributos()
        {
            return $"Filas: {filas}, Columnas: {columnas}, Valor por defecto: {valorDefecto}, Nodos ocupados: {longitud}";
        }

        public override string MostrarMatriz()
        {
            string res = "";
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    res += ObtenerElemento(i, j) + "\t";
                }
                res += "\n";
            }
            return res;
        }

        public override string ObtenerElemento(int fila, int col)
        {
            int x = inicio;
            int buscado = fila * 1000 + col;
            while (x != -1)
            {
                if (_mem.mem[x].id == buscado)
                {
                    return _mem.obtener_dato(x, 0);
                }
                x = _mem.mem[x].link;
            }
            return valorDefecto;
        }

        public override void Poner(int fila, int col, string valor)
        {
            if (fila < 0 || fila >= filas || col < 0 || col >= columnas)
            {
                Console.WriteLine("Posición fuera de rango.");
                return;
            }

            if (valor == valorDefecto) return;

            int dir = _mem.espacio_libre();
            _mem.new_espacio(1);

            //  fila y columna en id (fila*1000+col) y dato como valor
            _mem.poner_dato(dir, 0, valor);
            _mem.mem[dir].id = fila * 1000 + col;

            _mem.modificar_link(dir, inicio);
            inicio = dir;
            longitud++;
        }

        public override double PromedioElementos()
        {
            int suma = 0;
            int count = 0;
            int x = inicio;
            while (x != -1)
            {
                if (int.TryParse(_mem.obtener_dato(x, 0), out int val))
                {
                    suma += val;
                    count++;
                }
                x = _mem.mem[x].link;
            }
            return (count == 0) ? 0 : (double)suma / count;
        }
    }
}