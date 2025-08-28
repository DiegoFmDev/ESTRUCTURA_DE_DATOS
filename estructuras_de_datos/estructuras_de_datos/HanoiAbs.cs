using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public abstract class HanoiAbs
    {
        PilaImp pilaA;
        PilaImp pilaB;
        PilaImp pilaC;
       

        public HanoiAbs(MemoriaImp mem)
        {
            pilaA = new PilaImp(mem);
            pilaB= new PilaImp(mem);
            pilaC = new PilaImp(mem);
        }

    }
}
