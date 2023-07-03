//Desde .NET 6 ya no es necesario poner todo el código dentro del main
//Esto pertenece a la clase System, que viene implementada por defecto.
using System.Globalization;
using System.Text;

Console.WriteLine("Hello, World!");

//Comentarios en la misma línea
Console.Write("Hola ");
Console.Write("desde la misma ");
Console.Write("línea");

//Están la cadena de literales, agrupación de caracteres que forman palabras o frases
Console.WriteLine("Esto es una cadena de caracteres");
//También están los literales de un solo char, con comillas simples
Console.WriteLine('h');

/*
Todas las cadenas de string son campos no calculados, incluso lo que solicitamos de 
 Entrada con un ReadLine se considera string, si se quiere cambiar el tipo se debe 
 hacer un parseo.
 */

//para la declaración de variables no se admite símbolos o caracteres especiales como ·,#,$...
//tampoco usar palabras reservadas como string string;
string nombre;
nombre= "Pepe";

string nombre2 = "Jose";

//Tipo implicito, usar var para que el compilador decida el tipo según el valor entregado
var nombre3 = "Lola";

//CARACTERES DE ESCAPE

// \n -> salto de linea, \t -> tabulación
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
/*
    Hello
    World!
    Hello   World!
 */

// \" -> Añadir comillas dobles 
Console.WriteLine("Hello \"World\"!");//Hello "World"!

// \\ -> para usar barra invertida
Console.WriteLine("c:\\source\\repos");//c:\source\repos

// @ -> Literal de cadena textual, respeta los espacios, saltos de línea, símbolos...
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
/*
 * c:\source\repos    
 *      (this is where your code goes)
 */

// \u... -> seguido del código Unicode muestra el carácter UTF-16
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");//こんにちは World!

//Concatenar cadenas de manera simple
string firstName = "María";
string saludo = "Hola";
Console.WriteLine(saludo + " " + firstName + "!");
string mensaje = saludo + " " + firstName + "!";
Console.WriteLine(mensaje);

//Interpolación de cadenas para unir cadenas en una sola ${...}
string mensaje2 = $"{firstName} {saludo}!";

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");//C:\Output\First-Project\Data

//También podemos concatenar usando funciones de String



string p1 = "Hola";
string p2 = " ";
string p3 = "Jose";
string pT = String.Concat(p1, p2, p3);
Console.WriteLine(pT);// Hola Jose

string miNombre = "Sergio";
int edad = 30;
string saludo2 = string.Format("hola {0}, soy {1}, tengo: {2} años", p3, miNombre, edad);
Console.WriteLine(saludo); //hola Jose, soy Sergio, tengo: 30 años

StringBuilder sb = new StringBuilder();
sb.Append("Hola");//Append añade texto
sb.AppendLine(" Soy Sergio");//AppendLine añade un salto de línea
sb.Append("Tengo 30 años");
Console.WriteLine(sb);
/*
 * Hola Soy Sergio
 * Tengo 30 años
 */