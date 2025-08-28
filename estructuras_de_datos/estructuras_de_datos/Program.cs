using System;
using System.Security.Claims;

namespace computadora
{
    class Principal
    {
        static void Main()
        {
            MemoriaImp computadora = new MemoriaImp();

            //PARENTESIS
            while (true) // Permitir ingresar varias cadenas
            {
                Console.WriteLine("\nIngrese la cadena de paréntesis a verificar (o 'salir' para terminar):");
                string cadena = Console.ReadLine();

                if (cadena.ToLower() == "salir")
                    break;

                PilaImp pila = new PilaImp(computadora);

                bool correcta = true;

                for (int i = 0; i < cadena.Length; i++)
                {
                    string c = cadena[i].ToString(); 

                    if (c == "(")
                    {
                        pila.meter(c); 
                    }
                    else if (c == ")")
                    {
                        if (pila.vacia())
                        {
                            correcta = false; 
                            break;
                        }
                        else
                        {
                            pila.sacar(); 
                        }
                    }
                }

                // Si quedaron '(' pendientes
                if (!pila.vacia())
                    correcta = false;

                if (correcta)
                    Console.WriteLine("La cadena de paréntesis es correcta.");
                else
                    Console.WriteLine("La cadena de paréntesis es incorrecta.");

                Console.WriteLine("Contenido final de la pila:");
                Console.WriteLine(pila.mostrar());
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Programa terminado. Presione cualquier tecla para salir...");
            Console.ReadKey();















            //POLINOMIO

            //PolinomioImp polinomio = new PolinomioImp();
            //int seleccion = -1;

            //while (seleccion != 0)
            //{
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.WriteLine("        Programa Área Polinomio       ");
            //    Console.WriteLine("______________________________________");
            //    Console.WriteLine("1.- Crear Polinomio");
            //    Console.WriteLine("2.- Poner término");
            //    Console.WriteLine("3.- Grado del Polinomio");
            //    Console.WriteLine("4.- Derivada");
            //    Console.WriteLine("5.- Área en intervalo [a,b]");
            //    Console.WriteLine("8.- Mostrar Polinomio");
            //    Console.WriteLine("0.- Salir");
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.Write("Seleccione una opción: ");

            //    seleccion = int.Parse(Console.ReadLine() ?? "0");
            //    Console.Clear();

            //    switch (seleccion)
            //    {
            //        case 1:
            //            polinomio.CrearPolinomio();
            //            Console.WriteLine("Polinomio creado.");
            //            break;

            //        case 2:
            //            Console.Write("Coeficiente: ");
            //            int coef = int.Parse(Console.ReadLine());
            //            Console.Write("Exponente: ");
            //            int exp = int.Parse(Console.ReadLine());
            //            polinomio.PonerTermino(coef, exp);
            //            Console.WriteLine("Término insertado.");
            //            break;

            //        case 3:
            //            Console.WriteLine($"Grado del polinomio: {polinomio.GradoPolinomio()}");
            //            break;

            //        case 4:
            //            Console.WriteLine($"Derivada: {polinomio.Derivada()}");
            //            break;

            //        case 5:
            //            Console.Write("Intervalo a: ");
            //            double a = double.Parse(Console.ReadLine());
            //            Console.Write("Intervalo b: ");
            //            double b = double.Parse(Console.ReadLine());
            //            Console.WriteLine($"Área entre [{a},{b}]: {polinomio.Area(a, b)}");
            //            break;

            //        case 8:
            //            Console.WriteLine($"Polinomio: {polinomio.MostrarPolinomio()}");
            //            break;

            //        case 0:
            //            Console.WriteLine("Saliendo del programa...");
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida.");
            //            break;
            //    }

            //    if (seleccion != 0)
            //    {
            //        Console.WriteLine("\nOprima cualquier tecla para continuar...");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}

            //Console.WriteLine("Programa finalizado.");















            //MATRIZ DISPERSA

            //MatrizDispersaImp matriz = new MatrizDispersaImp();
            //int seleccion = -1;

            //while (seleccion != 0)
            //{
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.WriteLine("        Programa Matriz Dispersa       ");
            //    Console.WriteLine("______________________________________");
            //    Console.WriteLine("1.- Crear Matriz");
            //    Console.WriteLine("2.- Definir Valor por Defecto");
            //    Console.WriteLine("3.- Dimensionar Matriz");
            //    Console.WriteLine("4.- Poner Valor");
            //    Console.WriteLine("5.- Obtener Elemento");
            //    Console.WriteLine("6.- Promedio de Elementos");
            //    Console.WriteLine("7.- Mostrar Matriz");
            //    Console.WriteLine("8.- Mostrar Atributos");
            //    Console.WriteLine("0.- Salir");
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.Write("Seleccione una opción: ");

            //    seleccion = int.Parse(Console.ReadLine() ?? "0");
            //    Console.Clear();

            //    switch (seleccion)
            //    {
            //        case 1:
            //            Console.Write("Ingrese número de filas: ");
            //            int filas = int.Parse(Console.ReadLine());
            //            Console.Write("Ingrese número de columnas: ");
            //            int columnas = int.Parse(Console.ReadLine());
            //            matriz.CrearMatriz(filas, columnas);
            //            Console.WriteLine("Matriz creada.");
            //            break;

            //        case 2:
            //            Console.Write("Ingrese valor por defecto: ");
            //            string valorDef = Console.ReadLine();
            //            matriz.DefinirValorDefecto(valorDef);
            //            Console.WriteLine("Valor por defecto definido.");
            //            break;

            //        case 3:
            //            Console.Write("Ingrese nuevas filas: ");
            //            int f = int.Parse(Console.ReadLine());
            //            Console.Write("Ingrese nuevas columnas: ");
            //            int c = int.Parse(Console.ReadLine());
            //            matriz.Dimensionar(f, c);
            //            Console.WriteLine("Matriz dimensionada.");
            //            break;

            //        case 4:
            //            Console.Write("Fila: ");
            //            int fila = int.Parse(Console.ReadLine());
            //            Console.Write("Columna: ");
            //            int col = int.Parse(Console.ReadLine());
            //            Console.Write("Valor: ");
            //            string valor = Console.ReadLine();
            //            matriz.Poner(fila, col, valor);
            //            Console.WriteLine("Valor insertado.");
            //            break;

            //        case 5:
            //            Console.Write("Fila: ");
            //            int fr = int.Parse(Console.ReadLine());
            //            Console.Write("Columna: ");
            //            int cl = int.Parse(Console.ReadLine());
            //            string elem = matriz.ObtenerElemento(fr, cl);
            //            Console.WriteLine($"Elemento en ({fr},{cl}): {elem}");
            //            break;

            //        case 6:
            //            double prom = matriz.PromedioElementos();
            //            Console.WriteLine($"Promedio de los elementos: {prom}");
            //            break;

            //        case 7:
            //            Console.WriteLine("Matriz:");
            //            Console.WriteLine(matriz.MostrarMatriz());
            //            break;

            //        case 8:
            //            Console.WriteLine("Atributos de la matriz:");
            //            Console.WriteLine(matriz.MostrarAtributos());
            //            break;

            //        case 0:
            //            Console.WriteLine("Saliendo del programa...");
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida.");
            //            break;
            //    }

            //    if (seleccion != 0)
            //    {
            //        Console.WriteLine("\nOprima cualquier tecla para continuar...");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //}

            //Console.WriteLine("Programa finalizado.");









            //ATENCION COLAS

            //ColaImp colaPrioridad = new ColaImp(computadora);

            //int frecuencia = 1;
            //int contadorAtendidos = 0;
            //int opcion = -1;

            //while (opcion != 0)
            //{
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.WriteLine("        Sistema Atención Colas        ");
            //    Console.WriteLine("______________________________________");
            //    Console.WriteLine("1.- Crear Cola Prioridad");
            //    Console.WriteLine("2.- Definir frecuencia de atención");
            //    Console.WriteLine("3.- Poner ColaP");
            //    Console.WriteLine("4.- Sacar ColaP");
            //    Console.WriteLine("5.- Mostrar Memoria");
            //    Console.WriteLine("0.- Salir");
            //    Console.WriteLine("//////////////////////////////////////");
            //    Console.Write("Seleccione una opción: ");

            //    opcion = int.Parse(Console.ReadLine() ?? "0");
            //    Console.Clear();

            //    if (opcion == 1)
            //    {
            //        colaPrioridad = new ColaImp(computadora);
            //        Console.WriteLine("Cola de Prioridad creada.");
            //    }
            //    else if (opcion == 2)
            //    {
            //        Console.Write("Ingrese la frecuencia (ej. 2 = cada 2 clientes se aplica prioridad): ");
            //        frecuencia = int.Parse(Console.ReadLine() ?? "1");
            //        Console.WriteLine("Frecuencia definida: " + frecuencia);
            //    }
            //    else if (opcion == 3)
            //    {
            //        if (colaPrioridad == null)
            //        {
            //            Console.WriteLine("Primero debe crear la cola de prioridad (opción 1).");
            //        }
            //        else
            //        {
            //            Console.Write("Nombre del cliente: ");
            //            string cliente = Console.ReadLine();

            //            if (string.IsNullOrWhiteSpace(cliente))
            //            {
            //                Console.WriteLine("Error: Ingrese un cliente");
            //            }
            //            colaPrioridad.poner(cliente);
            //            Console.WriteLine("Cliente ingresado a la Cola Prioridad.");

            //        }
            //    }
            //    else if (opcion == 4)
            //    {
            //        if (colaPrioridad == null || colaPrioridad.vacia())
            //        {
            //            Console.WriteLine("No hay clientes en la cola.");
            //        }
            //        else
            //        {
            //            string atendido = colaPrioridad.sacar();
            //            contadorAtendidos++;
            //            Console.WriteLine("Cliente atendido: " + atendido);

            //            if (contadorAtendidos % frecuencia == 0)
            //            {
            //                Console.WriteLine(">> Aplicando regla de frecuencia: se da prioridad en esta atención.");
            //            }
            //        }
            //    }
            //    else if (opcion == 5)
            //    {
            //        Console.WriteLine("Contenido de la memoria:");
            //        computadora.mostrar();
            //    }

            //    Console.WriteLine("\nOprima cualquier tecla para continuar...");
            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //Console.WriteLine("Programa finalizado.");






            //PALIMDRONO

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
            //PilaImp pila = new PilaImp(computadora);   // tu implementación
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







            //    ColaImp clientes = new ColaImp(computadora);
            //    PilaImp libros = new PilaImp(computadora);

            //    int seleccion = 1;

            //    while (seleccion != 0)
            //    {
            //        Console.WriteLine("//////////////////////////////////////");
            //        Console.WriteLine("        Programa de gasolinera        ");
            //        Console.WriteLine("______________________________________");
            //        Console.WriteLine("1.- Ingresar nuevo libro ");
            //        Console.WriteLine("2.- ingresar cliente");
            //        Console.WriteLine("3.- prestar libro");
            //        Console.WriteLine("4.- devolver libro");
            //        Console.WriteLine("5.- verificar alcance");
            //        Console.WriteLine("6.- voltear al pila");
            //        Console.WriteLine("7.- mostrar memoria");
            //        Console.WriteLine("0.- Salir");
            //        Console.WriteLine("//////////////////////////////////////");

            //        seleccion = int.Parse(Console.ReadLine());
            //        Console.Clear();
            //        if (seleccion == 1)
            //        {
            //            Console.Write("agregar un libro: ");                    
            //            String libro = Console.ReadLine();
            //            libros.meter(libro);
            //            Console.WriteLine("oprima cualquier tecla");
            //            Console.ReadLine();
            //        }
            //        else if (seleccion == 2)
            //        {
            //            Console.Write("agregar un cliente: ");
            //            String cliente = Console.ReadLine();
            //            clientes.poner(cliente);
            //            Console.WriteLine("oprima cualquier tecla");
            //            Console.ReadLine();
            //        }
            //        else if (seleccion == 3)
            //        {
            //            string cliente_sacado = clientes.sacar();
            //            string libro_sacado = libros.sacar();
            //            Console.WriteLine("el cliente " + cliente_sacado + " se llevo " +
            //                " el libro " + libro_sacado);
            //            Console.WriteLine("oprima cualquier tecla");
            //            Console.ReadLine();
            //        }
            //        else if (seleccion == 4)
            //        {
            //            Console.Write("agregar un libro: ");
            //            String libro = Console.ReadLine();
            //            libros.meter(libro);
            //            string cliente_sacado = clientes.sacar();
            //            Console.WriteLine("el cliente " + cliente_sacado + " se ingreso " +
            //                " el libro " + libros.cima());
            //            Console.WriteLine("oprima cualquier tecla");
            //            Console.ReadLine();
            //        }
            //        else if (seleccion == 5)
            //        {
            //        //    ColaImp copia_cliente = clientes;
            //        //    PilaImp libro_copia = libros;

            //        //    while (!copia_cliente.vacia() && !libro_copia.vacia())
            //        //    {
            //        //        copia_cliente.sacar();
            //        //        libro_copia.sacar();
            //        //    }
            //        //    if(copia_cliente.vacia() && !libro_copia.vacia())
            //        //    {
            //        //        Console.WriteLine("hay suficientes libros);";
            //        //    }
            //        //    else
            //        //    {
            //        //        Console.WriteLine("no hay suficientes libros);";
            //        //    }
            //            if(clientes.cantidad() < libros.cantidad())
            //            {
            //                Console.WriteLine("hay suficientes libros");
            //            }
            //            else
            //            {
            //                Console.WriteLine("no hay suficientes libros");
            //            }
            //        }
            //            Console.Clear();
            //    }

            //    Console.WriteLine("Programa finalizado");


        }
    }
}