using System;
class Program{
  public static void Main(){
    string palavra = Console.ReadLine();
    string[] palavras;
    string senha = "";
    palavras = palavra.Split(); //tô dizendo q os             elementos do vetor são o conjunto de palavras lidas       separadas por espaço.
    int qtd = 0; //qtd é a quantidade.
    foreach (string p in palavras) { //tá pegando cada palavra.
      foreach (char c in p){ //tá pegando cara caractere de cada palavra, por isso char C in P.
        qtd = qtd + 1; //para cada palavra ele vai somando. a palavra no vetor é computada sem espaço (ex:maria,candida) onde p é separado em duas repetições, uma é maria e a outra é candida, ai primeiro ele faz m(q é igual a 1), mas a q tb é igual a 1 (m+a=2) e assim por diante, quando finaliza maria ele faz tudo do inicio com candida, sem o c o 1 dnv.
      }
      senha = senha + qtd;
      qtd = 0; 
    }
    Console.WriteLine($"{senha}");
    }
  }