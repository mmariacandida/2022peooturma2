using System;
class Program{
  public static void Main(){
    string palavra = Console.ReadLine();
    string[] palavras;
    palavras = palavra.Split(); //tô dizendo q os             elementos do vetor são o conjunto de palavras lidas       separadas por espaço.
    int qtd = 0; //qtd é a quantidade.
    foreach (string p in palavras) {
      qtd = qtd + 1;
    }
    Console.WriteLine($"{qtd}");
    }
  }
