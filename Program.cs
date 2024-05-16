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

//PUNTO 3
string numero;
Console.WriteLine("Ingrese un numero: ");
numero = Console.ReadLine();
int.TryParse(numero, out num); 

int abs;
if(num > 0){
    abs=num;
}else{
    abs=-num;
}
 double anguloRadianes = num * Math.PI / 180;
Console.WriteLine($"El valor absoluto es {abs}");
Console.WriteLine($"El cuadrado del numero es {num*num}");
Console.WriteLine($"La raiz cuadrada es {Math.Sqrt(num)}");
Console.WriteLine($"El seno es {Math.Sin(anguloRadianes)}");
Console.WriteLine($"El coseno es {Math.Cos(anguloRadianes)}");
Console.WriteLine($"La parte entera de un float es {(int)num}");

Console.WriteLine("Ingrese dos numeros:");
string numero1 = Console.ReadLine();
string numero2 = Console.ReadLine();
int num1, num2;
int.TryParse(numero1, out num1);
int.TryParse(numero2, out num2);
if (num1 > num2)
{
    Console.WriteLine($"El mayor es {num1}");
    Console.WriteLine($"El menor es {num2}");
}else{
    Console.WriteLine($"El mayor es {num2}");
    Console.WriteLine($"El menor es {num1}");
}



