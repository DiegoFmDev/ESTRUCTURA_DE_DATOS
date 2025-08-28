using computadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class ListaImp : ListaAbs
    {
        public ListaImp(MemoriaImp mem) : base(mem)
        {
        }

        public override int anterior(int pos)
        {
            if (vacia())
            {
                return -1;
            }
            if(pos == 0)
            {
                return -1;
            }
            int actual = 1;
            int x = _inicio;
            while (actual < pos)
            {
                x = _mem.mem[x].link;
                actual++;
            }
            return x;
        }

        public override int fin()
        {
            return _final;
        }

        public override void insertar(int pos, string dato)
        {
            int espacio = _mem.espacio_libre();
            _mem.new_espacio(1);
            _mem.poner_dato(espacio,0, dato);

            if (vacia())
            {
                _inicio = espacio;
                _final = espacio;                
            }
            else if (pos == 0)
            {                
                _mem.modificar_link(espacio, _inicio);
                _inicio = espacio;   
            }
            else if(pos == _longitud)
            {
                _mem.modificar_link(_final, espacio);
                _final = espacio;
            }
            else
            {
                int ant = anterior(pos);
                int linkAnterior = _mem.mem[ant].link;
                _mem.modificar_link(ant, espacio);
                _mem.modificar_link(espacio, linkAnterior);
            }
            _longitud++;
        }

        public override void modificarDato(int pos, string dato)
        {
            _mem.poner_dato(_inicio,pos, dato);
                
        }

        public override string mostrar_dato(int pos)
        {
            return _mem.obtener_dato(_inicio,pos);
        }

        public override string mostrar_lista()
        {
            if (vacia())
            {
                return "La lista esta vacia";
            }
            int x = _mem.mem[_inicio].dir;
            string lista = "";
            while(x != -1)
            {
                lista = lista + " " + _mem.mem[x].dato;
                x = _mem.mem[x].link;
            }
            return lista;
        }

        public override int posterior(int pos)
        {
            if (vacia())
            {
                return -1;
            }
            if (pos == _longitud-1)
            {
                return -1;
            }
            int actual = 0;
            int x = _inicio;
            while (actual < pos)
            {
                x = _mem.mem[x].link;
                actual++;
            }
            return _mem.mem[x].link;
        }

        public override int primero()
        {
            return _inicio;
        }

        public override void suprimir(int pos)
        {
            if (vacia()) { 
            
            }
            else if (_longitud == 1)
            {                
                _mem.delete_espacio(_inicio);
                _inicio = -1;
                _final = -1;
                //_longitud = 0;
            }
            else if(pos == 0)
            {
                int post= posterior(0);
                _mem.modificar_link(_inicio, -1);
                _mem.delete_espacio(_inicio);
                _inicio = post;    
            }
            else if(pos == _longitud -1)
            {
                int ant = anterior(pos);
                _mem.delete_espacio(_final);
                _mem.modificar_link(ant, -1);
                _final = ant;
            }
            else
            {
                int ant = anterior(pos);
                int post = posterior(pos);
                _mem.modificar_link(ant, post);

                int actual = posterior(pos-1);
                _mem.delete_espacio(actual);
            }
            _longitud--;
        }

        public override bool vacia()
        {
            if (_longitud == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public override int ver_longitud()
        {
            return _longitud;
        }
    }
}
