using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class PilaImp : PilaAbs
    {
        public PilaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int cantidad()
        {
            return _lista.ver_longitud();
        }

        public override string cima()
        {
            if (vacia())
            {
                return "pila vacia";
            }
            return _lista.mostrar_dato(_lista.ver_longitud()-1);
        }

        public override void meter(string dato)
        {
            _lista.insertar(_lista.ver_longitud(), dato);
        }

        public override string mostrar()
        {
            return _lista.mostrar_lista();
        }

        public override string sacar()
        {
            if (vacia())
            {
                return "pila vacia";
            }
            string respuesta = _lista.mostrar_dato(_lista.ver_longitud() - 1);
            _lista.suprimir(_lista.ver_longitud() - 1);
            return respuesta;
        }

        public override bool vacia()
        {
            return _lista.vacia();
        }
    }
}
