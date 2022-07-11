using System;
class Program{
  public static void Main(){
    Console.WriteLine("Digite uma sequência de números inteiros separados por vírgula:");
    string numeros = Console.ReadLine();
    string[] numeros_array=numeros.Split(',');
    int soma=0;
    foreach (string c in numeros_array ){
      soma=soma+int.Parse(c);
    }
    Console.WriteLine($" Soma = {soma}");
  }
}
/*
Ler uma sequência de números inteiros separados por vírgula e calcula a soma destes valores.
Digite uma sequência de números separados por vírgula:
1,2,3,4,5
Soma = 15
*/