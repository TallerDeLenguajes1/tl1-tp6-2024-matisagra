using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);



Console.WriteLine("Ingrese un numero: ");
string texto = Console.ReadLine();
int num;


bool resultado = int.TryParse(texto, out num);

if (resultado){
    int aux=0;
    int dig=0;
    while (num > 0)
    {
        aux = aux*10;
        dig=num%10;
        aux = aux + dig;
        num=num/10;
    }
    Console.WriteLine($"El numero invertido es:  {aux}");
}

