using System;
class Program{
public static void Main (){
  Console.WriteLine("Digite dois valores inteiros");
  int n1=int.Parse(Console.ReadLine());
  int n2=int.Parse(Console.ReadLine());

  Console.WriteLine("numero maior ou igual");
  if (n1 > n2) Console.WriteLine($"{n1}");
		if (n2 > n1) Console.WriteLine($"{n2}");
		if (n1 == n2) Console.WriteLine("sao numeros iguais");
  
      }
  }
