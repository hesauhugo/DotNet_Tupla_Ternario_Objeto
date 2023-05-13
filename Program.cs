using DotnetTuplaTernarioObjeto.Models;

int numero = 15;
bool ehPar = false;

// if ternario
ehPar = numero % 2 ==0;
Console.WriteLine($" O número {numero} é " + (ehPar ? "par":"impar"));

