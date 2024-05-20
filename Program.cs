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

//Ejercicio 4

Console.WriteLine("Ingrese un texto: ");

string cadena1 = Console.ReadLine();
int longitud = cadena1.Length;
Console.WriteLine($"La longitud del texto es {longitud}");

Console.WriteLine("Ingrese otro texto: ");
string cadena2 = Console.ReadLine();

string cadenas = cadena1 + cadena2;
Console.WriteLine($"La cadena concatenada es {cadenas}");

string subcadena = cadena1.Substring(2, longitud-2);

Console.WriteLine($"La subcadena del primer texto ingresado es {subcadena}");

foreach (char c in cadena1)
{
            Console.WriteLine(c);
}


Console.WriteLine("Ingrese la palabra a buscar en el texto:");
string palabra = Console.ReadLine();

        // Buscar la ocurrencia de la palabra en la cadena ingresada
bool contienePalabra = cadena1.Contains(palabra);

        // Mostrar el resultado
if (contienePalabra)
{
     Console.WriteLine($"La cadena contiene la palabra '{palabra}'.");
}
else
{
    Console.WriteLine($"La cadena no contiene la palabra '{palabra}'.");
}

string mayusculas = cadena1.ToUpper();
Console.WriteLine($"La cadena en mayúsculas es: {mayusculas}");

        
string minusculas = cadena1.ToLower();
Console.WriteLine($"La cadena en minúsculas es: {minusculas}");


Console.WriteLine("Por favor, ingrese una cadena de texto con separadores:");
string cadena11 = Console.ReadLine(); // Ejemplo de entrada: "manzana,banana,naranja,pera"

        
Console.WriteLine("Ingrese el carácter separador:");
char separador = Console.ReadLine()[0]; // Ejemplo de entrada: ','

string[] partes = cadena11.Split(separador);

        // Mostrar las partes resultantes por pantalla
Console.WriteLine("Las partes de la cadena son:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}
