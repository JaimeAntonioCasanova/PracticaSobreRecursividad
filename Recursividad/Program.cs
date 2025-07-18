using Recursividad;

//Inicializar string para la eleccion de el usuario y proceder a tomar la informacion
string eleccion;

Console.WriteLine("Buen dia, que algoritmo de recursividad desea revisar?");
Console.WriteLine("a. Numero Natural     b. Interes Bancario");
eleccion = Convert.ToString(Console.ReadLine());


//Condicional if para elegir entre uno de los dos algoritmos de recursividad
if (eleccion == "a")
{
    //Inicializando la variable para el input de el usuario y convertirlo a int como natural entero
    int numOriginal;
    Console.WriteLine("Introduzca el numero que desea utilizar:");
    numOriginal = Convert.ToInt32(Console.ReadLine());

    //Confirmar que el numero utilizado por el usuario sea mayor que 0, 
    //siendo que los numeros naturales son siempre positivos enteros
    if (numOriginal > 0)
    {
        int resultadoRecursivo = numNatural.sumaRecursiva(numOriginal);
        Console.WriteLine($"Suma (método recursivo): {resultadoRecursivo}");

    } else //Arrojar error en caso de que el input no sea mayor a cero
    {
        Console.WriteLine("Error: Ingrese un número natural válido (entero positivo)");
    }

} else if (eleccion == "b")
{
    //Inicializando las variables que seran utilizadas en la funcion
    double capital;
    double intereses;
    int cantAños;

    //Obteniendo el input de el usuario
    Console.WriteLine("Introduzca el capital que desea utilizar:");
    capital = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Introduzca los intereses a calcular:");
    intereses = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Introduzca los Años que duraran:");
    cantAños = Convert.ToInt32(Console.ReadLine());

    //llamando a la funcion de calculo y luego a la funcion de desglose
    bancaria.interesAnual(capital, intereses, cantAños);
    bancaria.desglose(capital, intereses, cantAños);

} else //En caso de que el usuario no introduzca 'a' o 'b' al inicio se ejecuta error
{
    Console.WriteLine("Error. Ingrese una opcion valida.");
}
