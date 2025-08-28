namespace computadora
{
    class Principal
    {
        static void Main()
        {
            //MemoriaImp computadoraDiego = new MemoriaImp();
            //PilaAbs pilaLibros = new PilaImp(computadoraDiego);   // tu implementación de pila
            //ColaAbs colaClientes = new ColaImp(computadoraDiego); // tu implementación de cola

            //int opcion = -1;

            //while (opcion != 0)
            //{
            //    Console.WriteLine("\n--------- Biblioteca ---------");
            //    Console.WriteLine("1. Ingresar nuevo libro");
            //    Console.WriteLine("2. Ingresar cliente");
            //    Console.WriteLine("3. Prestar libro");
            //    Console.WriteLine("4. Devolver libro");
            //    Console.WriteLine("5. Verificar alcance");
            //    Console.WriteLine("6. Voltear pila");
            //    Console.WriteLine("7. Mostrar memoria");
            //    Console.WriteLine("0. Salir");
            //    Console.WriteLine("------------------------------");
            //    Console.Write("Seleccione una opción: ");

            //    if (!int.TryParse(Console.ReadLine(), out opcion))
            //    {
            //        Console.WriteLine("Entrada inválida.");
            //        continue;
            //    }

            //    switch (opcion)
            //    {
            //        case 1: // ingresar libro
            //            Console.Write("Ingrese el nombre del libro: ");
            //            string libro = Console.ReadLine();
            //            pilaLibros.meter(libro);
            //            Console.WriteLine($"Libro '{libro}' ingresado.");
            //            break;

            //        case 2: // ingresar cliente
            //            Console.Write("Ingrese el nombre del cliente: ");
            //            string cliente = Console.ReadLine();
            //            colaClientes.poner(cliente);
            //            Console.WriteLine($"Cliente '{cliente}' ingresado.");
            //            break;

            //        case 3: // prestar libro
            //            if (colaClientes.vacia())
            //            {
            //                Console.WriteLine("No hay clientes en la cola.");
            //            }
            //            else if (pilaLibros.vacia())
            //            {
            //                string clienteSinLibro = colaClientes.sacar();
            //                Console.WriteLine($"Lo sentimos {clienteSinLibro}, no hay libros disponibles.");
            //            }
            //            else
            //            {
            //                string clienteAtendido = colaClientes.sacar();
            //                string libroPrestado = pilaLibros.sacar();
            //                Console.WriteLine($"Se prestó el libro '{libroPrestado}' a {clienteAtendido}.");
            //            }
            //            break;

            //        case 4: // devolver libro
            //            if (colaClientes.vacia())
            //            {
            //                Console.WriteLine("No hay clientes en la cola para devolver libro.");
            //            }
            //            else
            //            {
            //                Console.Write("Ingrese el nombre del libro a devolver: ");
            //                string libroDevuelto = Console.ReadLine();
            //                string clienteDevuelve = colaClientes.sacar();
            //                pilaLibros.meter(libroDevuelto);
            //                Console.WriteLine($"{clienteDevuelve} devolvió el libro '{libroDevuelto}'.");
            //            }
            //            break;

            //        case 5: // verificar alcance
            //            string[] librosArr = pilaLibros.mostrar().Split(',');
            //            string[] clientesArr = colaClientes.mostrar_cola().Split(',');
            //            int cantLibros = (librosArr[0] == "") ? 0 : librosArr.Length;
            //            int cantClientes = (clientesArr[0] == "") ? 0 : clientesArr.Length;

            //            if (cantLibros >= cantClientes)
            //                Console.WriteLine("Alcance suficiente: hay libros para todos los clientes.");
            //            else
            //                Console.WriteLine("No hay suficientes libros para todos los clientes.");
            //            break;

            //        case 6: // voltear pila
            //            ColaImp aux = new ColaImp(computadoraDiego);
            //            while (!pilaLibros.vacia())
            //            {
            //                string pilalibro = pilaLibros.sacar();
            //                aux.poner(pilalibro);
            //            }
            //            while (!aux.vacia())
            //            {
            //                string colalibro = aux.sacar();
            //                pilaLibros.meter(colalibro);
            //            }

            //            //PilaAbs pilaTemp = new PilaImp(computadoraDiego);

            //            //while (!pilaLibros.vacia())
            //            //{
            //            //    pilaTemp.meter(pilaLibros.sacar());
            //            //}

            //            //while (!pilaTemp.vacia())
            //            //{
            //            //    pilaLibros.meter(pilaTemp.sacar());
            //            //}

            //            //Console.WriteLine("La pila de libros ha sido volteada.");
            //            break;

            //        case 7: // mostrar memoria
            //            Console.WriteLine("\n--- Estado Actual ---");
            //            Console.WriteLine("Cola de clientes: " + colaClientes.mostrar_cola());
            //            Console.WriteLine("Pila de libros: " + pilaLibros.mostrar());
            //            Console.WriteLine("---------------------\n");
            //            break;

            //        case 0:
            //            Console.WriteLine("Saliendo del sistema...");
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida.");
            //            break;
            //    }
            //}


            //Console.WriteLine("Ingrese una palabra o frase:");
            //string texto = Console.ReadLine();

            //// 1. Normalizar el texto (sacar espacios y poner en minúscula)
            //string limpio = "";
            //for (int i = 0; i < texto.Length; i++)
            //{
            //    if (texto[i] != ' ') // ignoramos espacios
            //    {
            //        limpio += Char.ToLower(texto[i]);
            //    }
            //}

            //// 2. Crear pila y cola usando tus clases
            //PilaImp pila = new PilaImp(computadoraDiego);   // tu implementación
            //ColaImp cola = new ColaImp(new MemoriaImp()); // tu implementación

            //// 3. Llenar pila y cola con cada carácter
            //for (int i = 0; i < limpio.Length; i++)
            //{
            //    string caracter = limpio[i].ToString();
            //    pila.meter(caracter);
            //    cola.poner(caracter);
            //}

            //// 4. Comparar sacando de pila y cola
            //bool esPalindromo = true;
            //while (!pila.vacia() && !cola.vacia())
            //{
            //    string dePila = pila.sacar();
            //    string deCola = cola.sacar();

            //    if (dePila != deCola)
            //    {
            //        esPalindromo = false;
            //        break;
            //    }
            //}

            //// 5. Mostrar resultado
            //if (esPalindromo)
            //{
            //    Console.WriteLine("Es un palíndromo.");
            //}
            //else
            //{
            //    Console.WriteLine("No es un palíndromo.");
            //}

            //Console.ReadLine();








            //PilaImp pila = new PilaImp(computadoraDiego);
            //PilaImp pila2 = new PilaImp(computadoraDiego);

            //bool resultado = pila.vacia();

            //pila.meter("a");
            //pila.meter("b");
            //pila.meter("c");
            //pila2.meter("x");
            //pila2.meter("y");

            //string dato = pila.cima();
            //Console.WriteLine("dato cima: " + dato);

            //string datoSacado = pila2.sacar();
            //pila.meter("d");
            //Console.WriteLine("dato 1 sacado: " + datoSacado);

            //datoSacado = pila2.sacar();
            //Console.WriteLine("dato 2 sacado: " + datoSacado);


            //computadoraDiego.mostrar();














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