//Condicionales if, if-else, if-else-if

int a = 2;
int b = 3;
int c = 4;

if (a <= b)
{
    Console.WriteLine("1 Entra aquí");
}
if (c > b)
    Console.WriteLine("2 Entra aquí");

//Los operadores || de cortociruito, si se cumple la condición de la izquierda no evaluea la derecha
if (a > b || b > c || c > a) 
    Console.WriteLine("3 Entra en condición encadenada, si el primero es true no comprueba el resto");

if (b < c | c < a | true | false)
    Console.WriteLine("4 Entra en condición pero evalua todo");

if (false && true)
    Console.WriteLine("5 No entra porque el primero es false pero al ser cortocircuito no evalúa el segundo ");

if (false & true)
    Console.WriteLine("6 No entra, pero si evalúa el segundo");

//Hay métodos que te evuelven booleano por ejemplo string.Contains()
string cadena = "Esto es una cadena";
if (cadena.Contains("Esto "))
    Console.WriteLine("7 Si entra");

if (false)
{
    //No entra al ser false
}
else if (false)
{
    //No entra porque tambien es false
}
else
{
    Console.WriteLine("8 Si entra como última opción por defecto");
}

//SWITCH condicionales según el caso entregado
string fruta = "pera";

switch (fruta)
{
    case "platano":
        //Muestra este mensaje
        break;
    case "manzana":
        //...
        break;
    case "pera":
        Console.WriteLine("Es una pera");
        break;
    default:
        //...
        break;
}

int numeroSW = 5;

switch (numeroSW)
{
    case 1:
    case 2: 
    case 3:
        Console.WriteLine("Valores pequeños");
        break;

    case 4: case 5:
        Console.WriteLine("Valor superior a 3");
        break;
    default:
        break;
}

int numeroSW2 = 10;

switch (numeroSW2)
{
    //Comparando valor
    case < 5:
        Console.WriteLine("Es menor a 5");
        break;

    //Si se quiere encadenar más de una condición
    case int valor when valor < 20 && valor > 7:
        Console.WriteLine("El valor está entre 7 y 20");
        break;

    default:
        break;
}

//hay una versión más corta para guardar un resultado

int nota = 7;

var notaAlumno = nota switch { 
    < 5 => "Suspenso",
    5 => "Aprobado",
    int valor when valor > 6 && valor < 10 => "Notable",
    10 => "Sobresaliente",
    _ => "Nota no válida"// _ -> es un default
};

Console.WriteLine(notaAlumno);
