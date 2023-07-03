/**
 * Las conversiones puedenser de 3 tipos, implícitas, explícitas y de clases asistentes
 * Implícitas: no requieren sintxist especial, no pierden información, por ejemplo pasar
 *      un int a decimal
 * Explícitas o de restricción: las conversiones explícitas requieren una expresión Cast. 
 *      La conversión es necesaria si es posible que se pierda información en la conversión, 
 *      o cuando es posible que la conversión no sea correcta por otros motivos, por  ejemplo
 *      pasar un decimal a un int, se pierden los decimales
 * Clases asistentes: hay unas clases y métodos ya creados que ayudan cambiar el tipo y nos
 *      pueden ayudar a evitar excepciones, por ejemplo pasar un string a formato fecha, o
 *      string a número... pero si pasamos una cadena de texto a int puede producir excepción
 */

int a = 123456;
float b = a;//Implcícito

double c = 12454.54;
int d = (int)c;//Explícito, se pierdendecimales

string s = "12453,57";
//int f = (int)s;//ESTO DA ERROR

float fs = float.Parse(s);//Clases asistentes
float fs2 = Convert.ToInt32(s);

string ns = Convert.ToString(fs2);
string ns2 = fs2.ToString();//Esto es lo habitual

//Esto puede dar un problema, si por lo que sea da error produce excepción
//sobre todo cuando intentamos un string a número y no es compatible
//Lo correcto es un TryParse, intenta parsearlo y si es True lo guarda en una
//variable definida anteriormente

float valor;
string s2 = "213485,54g";

float.TryParse(s, out valor);//True 12453,57
Console.WriteLine(valor);
float.TryParse(s2, out valor);//False... 0
Console.WriteLine(valor);


