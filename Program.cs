using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);


//CalculadoraV1

Console.WriteLine("QUE OPERACION DESEA REALIZAR? ");
Console.WriteLine("1. SUMAR");
Console.WriteLine("2. RESTAR");
Console.WriteLine("3. MULTIPLICAR");
Console.WriteLine("4. DIVIDIR");

string opcion = Console.ReadLine();

Console.WriteLine("Ingrese los dos valores a operar: ");
int num1=0;
int num2=0;
string numero1=Console.ReadLine();
int.TryParse(numero1, out num1); 
string numero2=Console.ReadLine();
int.TryParse(numero2, out num2); 



switch (opcion)
{
    case "1":

    Console.WriteLine($"La suma es {num1+num2}");
    break;

    case "2":
    Console.WriteLine($"La resta es {num1-num2}");
    break;

    case "3":
    Console.WriteLine($"La multiplicacion es {num1*num2}");
    break;

    case "4":
    Console.WriteLine($"La division es {num1/num2}");
    break;
    
}

