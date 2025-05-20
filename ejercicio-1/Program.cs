Console.Write("Ingrese un número: ");
string? entrada = Console.ReadLine();


bool esNumero = int.TryParse(entrada, out int numero);

if (esNumero)
{
    if (numero > 0)
    {
        string numeroInvertido = InvertirNumero(numero);
        Console.WriteLine($"El número invertido es: {numeroInvertido}");
    }
    else
    {
        Console.WriteLine("El número debe ser mayor a 0.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
}



string InvertirNumero(int numero)
{
    string numeroStr = numero.ToString(); //convierto el numero a string
    string invertido = ""; // es para almacenar el numero invertido

    for (int i = numeroStr.Length - 1; i >= 0; i--) // recorro el string al reves
    {
        invertido += numeroStr[i]; // voy guardando el numero de atras para adelante
    }

    return invertido;
}