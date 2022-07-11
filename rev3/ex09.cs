using System;
class Program{
  public static void Main(){
    string palavra = Console.ReadLine();
    int qtd = 0; //qtd é a quantidade.
    foreach (char p in palavra) { //char é a variável para caractere (p cada caractere da palavra, faça isso).
      qtd = qtd + 1;
      Console.WriteLine($"{qtd} - {palavra}");
    }
    }
  }
