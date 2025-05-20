// interfaz con do while

int operacionInicial = 0;

do
{

    Console.WriteLine("Ingrese una operación: ");
    Console.WriteLine("1: Calculadora");
    Console.WriteLine("2: Calculadora Cientifica");
    Console.WriteLine("3: Calcular el maximo y el minimo entre dos numeros");
    Console.WriteLine("0: Salir");

    string? tempOperacion = Console.ReadLine();

    if (tempOperacion != null)
    {
        bool isNum = int.TryParse(tempOperacion, out operacionInicial);

        if (!isNum)
        {
            operacionInicial = 0;
        }

    }


    switch (operacionInicial)
    {
        case 1:
            Console.WriteLine(calculadora());
            break;
        case 2:
            Console.WriteLine(calculadoraAvanzada());
            break;
        case 3:
            calcularMaximoMinimoEntreDosNumeros();
            break;
        default:
            Console.WriteLine("Operación no reconocida");
            break;
    }



} while (operacionInicial != 0);


int calculadora()
{

    int a = 0;
    int b = 0;
    int operacionCalculadora = 0;

    do
    {
        Console.WriteLine("Ingrese una operación: ");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Dividir");

        Console.WriteLine("0. Salir");

        string? tempOperacion = Console.ReadLine();

        if (tempOperacion != null)
        {
            bool isNum = int.TryParse(tempOperacion, out operacionCalculadora);

            if (!isNum)
            {
                operacionCalculadora = 0;
            }

        }




        Console.WriteLine("Ingrese el primer numero: ");
        string? temp1 = Console.ReadLine();
        if (temp1 != null)
        {
            bool isNum = int.TryParse(temp1, out a);

            if (!isNum)
            {
                a = 0;
            }

        }
        Console.WriteLine("Ingrese el segundo numero: ");
        string? temp2 = Console.ReadLine();
        if (temp2 != null)
        {
            bool isNum = int.TryParse(temp2, out b);

            if (!isNum)
            {
                b = 0;
            }
        }



    } while (operacionCalculadora == 0);

    switch (operacionCalculadora)
    {
        case 1:
            return sumar(a, b);
        case 2:
            return restar(a, b);
        case 3:
            return multiplicar(a, b);
        case 4:
            return dividir(a, b);

        default:
            return 0;
    }
}

int calculadoraAvanzada()
{
    int a = 0;
    int operacionCalculadoraAvanzada = 0;

    do
    {
        Console.WriteLine("Ingrese una operación: ");
        Console.WriteLine("1. Valor Absoluto de un numero");
        Console.WriteLine("2. El cuadrado de un numero");
        Console.WriteLine("3. La raiz cuadrada de un numero");
        Console.WriteLine("4. El seno de un numero");
        Console.WriteLine("5. El coseno de un numero");
        Console.WriteLine("6. La parte entera de un tipo float");

        Console.WriteLine("0. Salir");

        string? tempOperacion = Console.ReadLine();

        if (tempOperacion != null)
        {
            bool isNum = int.TryParse(tempOperacion, out operacionCalculadoraAvanzada);

            if (!isNum)
            {
                operacionCalculadoraAvanzada = 0;
            }

        }




        Console.WriteLine("Ingrese el numero: ");
        string? tempNum = Console.ReadLine();
        if (tempNum != null)
        {
            bool isNum = int.TryParse(tempNum, out a);

            if (!isNum)
            {
                a = 0;
            }

        }



    } while (operacionCalculadoraAvanzada == 0);

    switch (operacionCalculadoraAvanzada)
    {
        case 1:
            return valorAbsoluto(a);
        case 2:
            return cuadrado(a);
        case 3:
            if (a < 0)
            {
                Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
                return 0;
            }
            return raizCuadrada(a);
        case 4:
            return seno(a);
        case 5:
            return coseno(a);
        case 6:
            return parteEntera((float)a);
        default:
            return 0;
    }

}


void calcularMaximoMinimoEntreDosNumeros()
{
    int a = 0;
    int b = 0;

    Console.WriteLine("Ingrese el primer numero: ");
    string? temp1 = Console.ReadLine();
    if (temp1 != null)
    {
        bool isNum = int.TryParse(temp1, out a);

        if (!isNum)
        {
            a = 0;
        }

    }
    Console.WriteLine("Ingrese el segundo numero: ");
    string? temp2 = Console.ReadLine();
    if (temp2 != null)
    {
        bool isNum = int.TryParse(temp2, out b);

        if (!isNum)
        {
            b = 0;
        }
    }

    string mMax = $"El mayor numero es: {Math.Max(a, b)}";
    string mMin = $"El menor numero es: {Math.Min(a, b)}";
    Console.WriteLine(mMax);
    Console.WriteLine(mMin);


}


int valorAbsoluto(int a)
{
    return Math.Abs(a);
}

int cuadrado(int a)
{
    return a * a;
}

int raizCuadrada(int a)
{

    return (int)Math.Sqrt(a);
}

int seno(int a)
{
    return (int)Math.Sin(a);
}

int coseno(int a)
{
    return (int)Math.Cos(a);
}

int parteEntera(float a)
{
    return (int)Math.Truncate(a);
}

int restar(int a, int b)
{
    return a - b;
}

int multiplicar(int a, int b)
{
    return a * b;
}

int dividir(int a, int b)
{
    return a / b;
}

int sumar(int a, int b)
{
    return a + b;

}