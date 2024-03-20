//Clase 6 - Ejercicios de Clase 
//#1
namespace EJERCICIOS_EN_CLASE_6
{
    internal class Program
    {

        static void EJERCICIO1()
{
    int[] num;
    num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
    int sumaPares = 0;

    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0)
        {
            sumaPares += num[i];
        }
    }
            Console.WriteLine();
            Console.WriteLine("La suma de los elementos pares es: " + sumaPares);
    Console.ReadKey();
    Console.Clear();
}
static void Despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}

static int[] InvertirArreglo(int[] original)
{
    int[] invertido = new int[original.Length];
    int j = original.Length - 1;

    for (int i = 0; i < original.Length; i++)
    {
        invertido[i] = original[j];
        j--;
    }

    return invertido;
}

//#2
static void EJERCICIO2()
{
    int[] Elem = new int[] { 100, 50, 90, 60, 20, 80, };
            Console.WriteLine();
            Console.WriteLine("Original:");
    Despliegue(Elem);

            Console.WriteLine();
            Console.WriteLine("Invertido:");
    int[] inveR = InvertirArreglo(Elem);
    Despliegue(inveR);

    Console.WriteLine();

    Console.ReadKey();
    Console.Clear();
}
static void despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}

//#3
static int EnconMaximo(int[] arreglo)
{
    int maX = arreglo[0];

    for (int i = 1; i < arreglo.Length; i++)
    {
        if (arreglo[i] > maX)
        {
            maX = arreglo[i];
        }
    }

    return maX;
}

static void EJERCICIO3()
{
    int[] numeros = new int[] { 18, 2, 45, 12, 43, 66, 5 };

    int max = EnconMaximo(numeros);
            Console.WriteLine();
            Console.WriteLine("El valor máximo del arreglo es: {0}", max);

    Console.ReadKey();
    Console.Clear();
}

//#4
static void lista(int[] arreglo1)
{
    foreach (int item in arreglo1)
    {
        Console.WriteLine(item);
    }
}

static int Encontrarmaximo(int[] arreglo1)
{
    int maximo = arreglo1[0];

    for (int i = 1; i < arreglo1.Length; i++)
    {
        if (arreglo1[i] > maximo)
        {
            maximo = arreglo1[i];
        }
    }

    return maximo;
}

static int BuscarElemento(int[] arreglo1, int valor)
{
    for (int i = 0; i < arreglo1.Length; i++)
    {
        if (arreglo1[i] == valor)
        {
            return i;
        }
    }

    return -1;
}

static void EJERCICIO4()
{
    int[] numero = new int[] { 5, 15, 36, 78, 9 };
    int Val = 2;

    int posicion = BuscarElemento(numero, Val);
            Console.WriteLine();

            if (posicion == -1)
    {
        Console.WriteLine("El valor {0} no se encuentra en el arreglo.", Val);
    }
    else
    {
        Console.WriteLine("El valor {0} se encuentra en la posición {1}.", Val, posicion);
    }

    Console.ReadKey();
    Console.Clear();
}

//#5
static void Lista2(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}

static int[] EncontraMaxim(int[] arreglo2)
{
    int maximo = arreglo2[0];

    for (int i = 1; i < arreglo2.Length; i++)
    {
        if (arreglo2[i] > maximo)
        {
            maximo = arreglo2[i];
        }
    }

    int[] resultado = new int[] { maximo };
    return resultado;
}

static int elemen(int[] arreglo2, int valor)
{
    for (int i = 0; i < arreglo2.Length; i++)
    {
        if (arreglo2[i] == valor)
        {
            return i;
        }
    }

    return -1;
}


static int[] OrdenarAscendente(int[] arreglo2)
{
    Array.Sort(arreglo2);
    return arreglo2;
}

static void EJERCICIO5()
{
    int[] numeros = new int[] { 10, 29, 33, 1, 55 };
            Console.WriteLine();
            Console.WriteLine("Original:");
    Despliegue(numeros);
            Console.WriteLine();
            Console.WriteLine("Ordenado ascendentemente:");
    int[] orden= OrdenarAscendente(numeros);
    Despliegue(orden);

    Console.WriteLine("");

    Console.ReadKey();
    Console.Clear();
}

//#6
static void Despliegue6(string[] arreglo6)
{
    foreach (string nombre6 in arreglo6)
    {
        Console.WriteLine(nombre6);
    }
}
static void EJERCICIO6()
{

    string[] nombres;
    int canNom;
            Console.WriteLine();
            Console.WriteLine("---ORDEN DE NOMBRES---");

            Console.WriteLine();
            Console.Write("¿Cuántos nombres desea ingresar?: ");
    canNom = int.Parse(Console.ReadLine());


    nombres = new string[canNom];


    for (int i = 0; i < canNom; i++)
    {
        Console.Write("Ingrese el nombre {0}: ", i + 1);
        nombres[i] = Console.ReadLine();
    }

            Console.WriteLine();
            Console.WriteLine("Lista de nombres original:");
    Despliegue6(nombres);


    Array.Sort(nombres);

            Console.WriteLine();
            Console.WriteLine("Lista de nombres ordenada alfabéticamente:");
    Despliegue6(nombres);


    Console.ReadKey();
    Console.Clear();
}

//#7
static void EJERCICIO7()
{

    int[] numeros;
    int canunmeR;
            Console.WriteLine();
            Console.WriteLine("--- MÁXIMO Y MÍNIMO ---");

            Console.WriteLine();
            Console.Write("¿Cantidad de números que deseas ingresar?: ");
    canunmeR = int.Parse(Console.ReadLine());

    numeros = new int[canunmeR];

    for (int i = 0; i < canunmeR; i++)
    {
        Console.Write("Ingrese el número {0}: ", i + 1);
        numeros[i] = int.Parse(Console.ReadLine());
    }
 
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] > max)
        {
            max = numeros[i];
        }
        if (numeros[i] < min)
        {
            min = numeros[i];
        }
    }

            Console.WriteLine();
            Console.WriteLine("El valor Máximo es: {0}", max);
            Console.WriteLine("El valor Mínimo es: {0}", min);

    Console.ReadKey();
    Console.Clear();
}

//#8
static void EJERCICIO8()
{

    string[] paises = { "Jamaica", "Venezuela", "Peru", "Belice", "Guatemala" };

            Console.WriteLine();
            Console.Write("Ingrese el nombre del país a buscar: ");
    string Buspaises = Console.ReadLine();


    int indice = Array.IndexOf(paises, Buspaises);

        Console.WriteLine();

    if (indice >= 0)
    {
        Console.WriteLine("El país {0} se encuentra en el arreglo en la posición {1}", Buspaises, indice);
    }
    else
    {
        Console.WriteLine("El país {0} no se encuentra en el arreglo", Buspaises);
    }

    Console.ReadKey();
    Console.Clear();
}

//#9
static void Despliegue9(int[] arreglo9)
{
    foreach (int numero in arreglo9)
    {
        Console.Write("{0} ", numero);
    }
    Console.WriteLine();
}
static void EJERCICIO9()
{

    int[] number = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };


    Console.WriteLine("Arreglo Original:");
    Despliegue9(number);

    Array.Reverse(number);


    Console.WriteLine("Arreglo Invertido:");
    Despliegue9(number);

    Console.ReadKey();
    Console.Clear();
}

//NUMERO 10

static void EJERCICIO10()
{
    int cantidadCalif;
    float[] Notas;

    Console.WriteLine("--- CALIFICACIONES SOBRESALIENTES ---");

    Console.Write("¿Cuántas calificaciones desea ingresar?: ");
    cantidadCalif = int.Parse(Console.ReadLine());

    Notas = new float[cantidadCalif];


    for (int i = 0; i < cantidadCalif; i++)
    {
        Console.Write("Ingrese la calificación {0}: ", i + 1);
        Notas[i] = float.Parse(Console.ReadLine());
    }


    bool Exsobre = Array.Exists(Notas, x => x >= 90);


    if (Exsobre)
    {
        Console.WriteLine("Existe una calificación sobresaliente");
    }
    else
    {
        Console.WriteLine("Mejoremos chicos que no hay notas sobresalientes");
    }

    Console.ReadKey();
    Console.Clear();
}

        static void Main(string[] args)
        {
            int opcion;

            try
            {
                do
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ResetColor();
                    Console.WriteLine("             MENU             ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ResetColor();

                    Console.WriteLine("1. Suma de Elementos Pares");
                    Console.WriteLine();
                    Console.WriteLine("2. Invertir el orden de un Arreglo");
                    Console.WriteLine();
                    Console.WriteLine("3. Encontrar el Valor Máximo en un Arreglo");
                    Console.WriteLine();
                    Console.WriteLine("4. Buscar un elemento en un arreglo");
                    Console.WriteLine();
                    Console.WriteLine("5. Ordenar un arreglo de forma ascendente ");
                    Console.WriteLine();
                    Console.WriteLine("6. Ordenar nombres alfabéticamente:");
                    Console.WriteLine();
                    Console.WriteLine("7. Encuentra el valor máximo y el valor mínimo:");
                    Console.WriteLine();
                    Console.WriteLine("8. Buscar el país en el arreglo");
                    Console.WriteLine();
                    Console.WriteLine("9. Invertir el orden de los elementos.");
                    Console.WriteLine();
                    Console.WriteLine("10. Idicando si hay calificaciones sobresalientes o no.");
                    Console.WriteLine();
                    Console.WriteLine("11. Finalización del programas de CLASE #6");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-------------------------------------------------------");
                    Console.ResetColor();

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            EJERCICIO1();
                            break;
                        case 2:
                            EJERCICIO2();
                            break;
                        case 3:
                            EJERCICIO3();
                            break;
                        case 4:
                            EJERCICIO4();
                            break;
                        case 5:
                            EJERCICIO5();
                            break;
                        case 6:
                            EJERCICIO6();
                            break;
                        case 7:
                            EJERCICIO7();
                            break;

                        case 8:
                            EJERCICIO8();
                            break;
                        case 9:
                            EJERCICIO9();
                            break;
                        case 10:
                            EJERCICIO10();
                            break;
                        case 11:
                            Console.WriteLine("Finalizo con exito el programa");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Seleccione Nuevamente.");
                            break;
                    }

                    Console.ReadKey(); 

                } while (opcion != 11);


            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un número válido.");

            }
            Console.ReadKey();
        }
    }
}