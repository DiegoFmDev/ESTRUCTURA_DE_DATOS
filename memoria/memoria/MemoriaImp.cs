using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    public class MemoriaImp : MemoriaABC
    {
        public override void mostrar()
        {
            Console.WriteLine("DIR DATO ID LINK");
            Console.WriteLine("#-----------------------------#");
            foreach (var espacio in mem)
            {
                Console.WriteLine("|" + espacio.dir + "\t" +
                "|" + espacio.dato + "\t" +
                "|" + espacio.id + "\t" +
                "|" + espacio.link);
            }
            Console.WriteLine("libre :" + libre);
        }

        public override void new_espacio(int cantidad)
        {
            int dir = libre;
            int apuntador = libre;
            for (int i = 0; i < cantidad - 1; i++)
            {
                mem[apuntador].id = i;
                apuntador = mem[apuntador].link;
            }
            libre = mem[apuntador].link;
            mem[apuntador].id = cantidad - 1;
            mem[apuntador].link = NULL;
        }
        public override void delete_espacio(int dir)
        {
            int x = dir;
            while (mem[x].link != -1)
            {
                x = mem[x].link;
            }
            mem[x].link = libre;
            libre = dir;
        }

        public override bool dir_libre(int dir)
        {
            int x = libre;
            bool c = false;
            while (x != 1 && c == false)
            {
                if (x == dir)
                {
                    c = true;
                }
                x = mem[x].link;
            }
            return c;
        }

        public override int espacio_disponible()
        {
            int x = libre;
            int c = 0;
            while (x != -1)
            {
                c++;
                x = mem[x].link;
            }
            return c;
        }

        public override int espacio_ocupado()
        {
            int cantidad = MAX - espacio_disponible();
            return cantidad;
        }

        public override void modificar_link(int dir, int nuevo_link)
        {
            if (dir < 0 || dir >= MAX)
            {
                Console.WriteLine("Dirección inválida.");
                return;
            }

            mem[dir].link = nuevo_link;
        }
        public override string obtener_dato(int dir, int lugar)
        {
            if (dir < 0 || dir >= mem.Length)
                return null;  // Pila vacía o índice inválido

            if (lugar < 0)
                return null;  // Lugar negativo no tiene sentido

            int z = dir;

            for (int i = 0; i < lugar; i++)
            {
                if (mem[z].link == -1)
                    return null;  // fin de la lista
                z = mem[z].link;
            }

            return mem[z].dato;
        }

        public override void poner_dato(int dir, int lugar, string valor)
        {
            int z = dir;
            while (mem[z].link != NULL)
            {
                if (mem[z].id == lugar)
                {
                    break;
                }
                z = mem[z].link;
            }
            if (mem[z].id == lugar)
            {
                mem[z].dato = valor;
            }
        }

        public override void espacio_palabra(string cadena)
        {
            int longitud = cadena.Length; //obtenga la longitud de la cadena 
            int inicio = libre;   // obtener la posicion inicial
            new_espacio(longitud); // reservo la cadena 
            int posicion = 0;
            foreach (char letra in cadena)
            {
                poner_dato(inicio, posicion, letra.ToString());
                posicion++;
            }
        }
        public override int espacio_libre()
        {
            return libre;
        }
    }
}