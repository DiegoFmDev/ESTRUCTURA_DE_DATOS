using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class ColaImp : ColaAbs
    {
        public ColaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int cantidad()
        {
            return _lista.ver_longitud();
        }

        public override string mostrar_cola()
        {
            return _lista.mostrar_lista();
        }

        public override void poner(string dato)
        {
            _lista.insertar(_lista.ver_longitud(), dato);
        }

        public override string primero()
        {
            if (vacia())
            {
                return "cola vacia";
            }
            return _lista.mostrar_dato(0);
        }

        public override string sacar()
        {
            if (vacia())
            {
                return "cola vacia";
            }
            string respuesta = _lista.mostrar_dato(0);
            _lista.suprimir(0);
            return respuesta;
        }

        public override bool vacia()
        {
            return _lista.vacia();
        }
    }
}
