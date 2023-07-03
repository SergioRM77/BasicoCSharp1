//Los literales enteros son int
Console.WriteLine(123);


/**FLOAT, DOUBLE y DECIMAL
 * Float Type    Precision
    ----------------------------
    float         ~6-9 digits
    double        ~15-17 digits
    decimal        28-29 digits
*/

/**
 * FLOAT es el decimal menos preciso
 * se puede indicar con con f o F al 
 * final del número
 */
Console.WriteLine(0.25F);

/**DOUBLE es algo más preciso
 * viene por defecto en el compilador
 * no hace falta poner d o D al final
 */
Console.WriteLine(2.625);

/**DECIMAL es el más preciso aunque hay que
 * gastar cuidado porque es muy pesado si hay 
 * demasiados decimal
 * 
 * se puede poner m o M al final
 */
Console.WriteLine(12.398161452523424453274564324m);

int num = 12;
float numFloat = 12.54f;
double numDouble = 12.65324;//Se puede poner d o D
decimal numDecimal = 1542.398161424563454M;

//Tipo implicito, usar var para que el compilador decida el tipo según el valor entregado
var num2 = 78.325;


//OPERACIONES

int a = 7;
int b = 5;
int c = a + b;//12
Console.WriteLine("No es suma, es concatenación: " + a + b);//No es suma, es concatenación: 75
Console.WriteLine("esto si es suma: " + (a + b));//esto si es suma: 12

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
/**
    Sum: 12
    Difference: 2
    Product: 35
    Quotient: 1
 */
//Las operaciones con enteros si producen decimales los desecha, solo devuleven enteros

//Para dividir dos números enteros y que respeten los decimales, debemos guardarlos en un
//variable de coma flotante y al menos uno de los operandos debe ser de tipo flotante
decimal operacion = 7.0m / 5;//es igual -> 7 / 5.0m
Console.WriteLine($"División decimal: {operacion}");//División decimal: 1.4

//para divisiones con operandos int debemos hacer conversión de tipo, al menos uno
Console.WriteLine((decimal)a / (decimal)b);//1.4


// % -> Resto de una división
Console.WriteLine(a % b);//2


//INCREPENNTO Y DECREMENTO
int valor = 5;
valor = valor + 5;
valor += 5;
valor = valor - 5;
valor -= 5;
valor++;
valor--;
//incrementar o decrementar antes de realizar operación
++valor;
--valor;
