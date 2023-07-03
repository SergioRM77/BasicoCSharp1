//RECORRER MATRICES

//DO-WHILE y WHILE
int numero = 0;
do
{
    numero++;
    Console.Write(numero);
} while (numero < 7);
Console.WriteLine();

//Continue salta y pasa al siguiente
//Break finaliza
numero = 0;
while (numero < 10)
{
    if (numero == 3)
    {
        numero++;
        continue;
    }
    Console.Write(numero);
    numero++;
    if (numero == 5) break;
}
Console.WriteLine();



//FOREACH
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
    Console.WriteLine(name);

/**IMPORTANTE -> no se puede cambiar el valor de un elemento con foreach
 * para poder hacerlo se tiene que usar un for, porque hay que acceder a su 
 * posición, no al nombre que hace referencia en foreach
 * **/

//FOR sirve para iterar sobre una matriz la cual podemos modificar durante el proceso
/*
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);// esto es lo simple
    }
*/

int[] nums = { 10, 20, 30, 40, 50, 60, 70 };

foreach (var item in nums)
{
    Console.Write(item + " ");//10 20 30 40 50 60 70
}
Console.WriteLine();

for (int i = 0; i < nums.Length; i++)
    nums[i] += 5;

foreach (var item in nums)
    Console.Write(item + " ");//15 25 35 45 55 65 75

//podemos usar break para finalizar la iteración
for (int i = 0; i < 5; i++)
{
    //    Console.WriteLine(i);//1,2
    if (i == 3) break;
}
