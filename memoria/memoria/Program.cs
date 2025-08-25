namespace computadora
{
    class Principal
    {
        static void Main()
        {
            MemoriaImp computadoraDiego = new MemoriaImp();
            PilaImp pila = new PilaImp(computadoraDiego);
            PilaImp pila2 = new PilaImp(computadoraDiego);

            bool resultado = pila.vacia();

            pila.meter("a");
            pila.meter("b");
            pila.meter("c");
            pila2.meter("x");
            pila2.meter("y");

            string dato = pila.cima();
            Console.WriteLine("dato cima: " + dato);

            string datoSacado = pila2.sacar();
            pila.meter("d");
            Console.WriteLine("dato 1 sacado: " + datoSacado);

            datoSacado = pila2.sacar();
            Console.WriteLine("dato 2 sacado: " + datoSacado);


            computadoraDiego.mostrar();














            //ColaImp cola_auto = new ColaImp(computadoraDiego);
            //int seleccion = 1;
            //while (seleccion != 0)
            //{
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.WriteLine("        Programa de gasolinera        ");
            //    Console.WriteLine("______________________________________");
            //    Console.WriteLine("1.- agregar un auto a lista de espera");
            //    Console.WriteLine("2.- atender un automóvil");
            //    Console.WriteLine("3. verificar la placa del siguiente");
            //    Console.WriteLine("4. mostrar los autos pendientes");
            //    Console.WriteLine("0.- Salir");
            //    Console.WriteLine("//////////////////////////////////////");

            //    seleccion = int.Parse(Console.ReadLine());
            //    Console.Clear();

            //    if (seleccion == 1)
            //    {
            //        Console.WriteLine("agregar un auto a lista de espera");
            //        Console.WriteLine("Ingrese Placa: ");
            //        string placa = Console.ReadLine();
            //        cola_auto.poner(placa);
            //        Console.WriteLine("Oprima cualquier tecla");
            //        Console.ReadLine();
            //    }
            //    else if (seleccion == 2)
            //    { 
            //        string sacado = cola_auto.sacar();
            //        Console.WriteLine("El siguiente es: " + sacado);
            //        Console.ReadLine();

            //    }
            //    else if (seleccion == 3)
            //    {
            //        string sacado = cola_auto.primero();
            //        Console.WriteLine("Placa del siguiente auto: " + sacado);
            //        Console.ReadLine();

            //    }
            //    else if (seleccion == 4)
            //    {
            //        string lista = cola_auto.mostrar_cola();
            //        string[] lista_v = lista.Split("\n");

            //        foreach (var item in lista_v)
            //        {
            //            Console.WriteLine("Auto pendiente: " +  item);
            //        }
            //        Console.ReadLine();
            //    }
            //}







            //ListaImp lista1 = new ListaImp(computadoraAlvaro);
            //ListaImp lista2 = new ListaImp(computadoraAlvaro);


            //ListaImp lista_compras = new ListaImp(computadoraDiego);

            //lista_compras.insertar(0, "p");
            //lista_compras.insertar(1, "t");
            //lista_compras.insertar(2, "b");
            //lista_compras.insertar(2, "z");
            //lista_compras.insertar(4, "e");
            //lista_compras.insertar(2, "r");

            //Console.WriteLine("Lista completa: " + lista_compras.mostrar_Lista());


            //ColaImp c1 = new ColaImp(computadoraDiego);
            //ColaImp c2 = new ColaImp(computadoraDiego);

            //c1.poner("a");
            //c1.poner("b");
            //c1.poner("c");
            //c2.poner("9");
            //c2.poner("8");

            //listacompras.





            //lista1.insertar(0, "a");
            //lista1.insertar(0, "b");
            //lista1.insertar(2, "c");
            //lista1.insertar(1, "d");
            //lista1.suprimir(1);
            //lista1.modificarDato(0, "x");

            ////Console.WriteLine("anterior" + lista1.anterior);
            //Console.WriteLine("anterior " + lista1.anterior(0));
            //Console.WriteLine("posterior " + lista1.posterior(1));
            //Console.WriteLine("inicio " + lista1.primero());
            //Console.WriteLine("final " + lista1.fin());


            //computadoraDiego.mostrar();

            //lista1.mem.esp


            //computadoraAlvaro.mostrar();

            //computadoraAlvaro.new_espacio(4);
            //computadoraAlvaro.new_espacio(3);
            //computadoraAlvaro.mostrar();
            //computadoraAlvaro.new_espacio(4);
            //computadoraAlvaro.espacio_disponible();
            //computadoraAlvaro.espacio_ocupado();
            //computadoraAlvaro.dir_libre(1);
            //computadoraAlvaro.mostrar();
            //Console.WriteLine(computadoraAlvaro.espacio_disponible());
            //Console.WriteLine(computadoraAlvaro.espacio_ocupado());
            //Console.WriteLine(computadoraAlvaro.dir_libre(4));


            //int a = computadoraAlvaro.espacio_libre();
            //computadoraAlvaro.new_espacio(3); // a = 0
            //int b = computadoraAlvaro.espacio_libre();
            //computadoraAlvaro.new_espacio(5); // b = 3
            //int c = computadoraAlvaro.espacio_libre();
            //computadoraAlvaro.new_espacio(2); // c = 8

            //computadoraAlvaro.delete_espacio(3);

            //int d = computadoraAlvaro.espacio_libre();
            //computadoraAlvaro.new_espacio(6); // d = 3
            //computadoraAlvaro.mostrar();

            //computadoraAlvaro.poner_dato(3, 2, "H");
            //computadoraAlvaro.poner_dato(0, 0, "G");

            //computadoraAlvaro.mostrar();




            //computadoraAlvaro.new_espacio(4);

            //computadoraAlvaro.espacio_palabra("casa");
            //computadoraAlvaro.delete_espacio(0);
            //computadoraAlvaro.poner_dato(4, 1, "o");
            //computadoraAlvaro.espacio_palabra("bonita");
            //computadoraAlvaro.mostrar();





            //examen
            //computadoraAlvaro.espacio_palabra("toro");
            //computadoraAlvaro.espacio_palabra("perro");
            //computadoraAlvaro.delete_espacio(3);
            //computadoraAlvaro.dir_libre(0);
            //computadoraAlvaro.new_espacio(4);
            //computadoraAlvaro.espacio_palabra("azar");
            //computadoraAlvaro.mostrar();
        }
    }

}