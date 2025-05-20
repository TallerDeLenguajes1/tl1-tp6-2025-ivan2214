// interfaz con do while

int a = 0;
int b = 0;
int operacion = 0;

do
{
    Console.WriteLine("Ingrese una operación: ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");

    string? tempOperacion = Console.ReadLine();

    if (tempOperacion != null)
    {
        bool isNum = int.TryParse(tempOperacion, out operacion);

        if (!isNum)
        {
            operacion = 0;
        }

    }

    if (operacion == 5)
    {
        break;
    }


    Console.WriteLine("Ingrese el primer número: ");
    string? temp1 = Console.ReadLine();
    if (temp1 != null)
    {
        bool isNum = int.TryParse(temp1, out a);

        if (!isNum)
        {
            a = 0;
        }

    }
    Console.WriteLine("Ingrese el segundo número: ");
    string? temp2 = Console.ReadLine();
    if (temp2 != null)
    {
        bool isNum = int.TryParse(temp2, out b);

        if (!isNum)
        {
            b = 0;
        }
    }


    int resultado = calculadora(a, b, operacion);
    Console.WriteLine($"El resultado es: {resultado}");

} while (operacion != 5);


int calculadora(int a, int b, int operacion)
{
    switch (operacion)
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