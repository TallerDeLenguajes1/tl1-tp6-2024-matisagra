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

//CalculadoraV2
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
int num3, num4;
int.TryParse(numero1, out num1);
int.TryParse(numero2, out num2);
if (num1 > num2)
{
    Console.WriteLine($"El mayor es {num3}");
    Console.WriteLine($"El menor es {num4}");
}else{
    Console.WriteLine($"El mayor es {num4}");
    Console.WriteLine($"El menor es {num3}");
}



