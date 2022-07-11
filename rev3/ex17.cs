using System;
class Program{
  public static void Main(){
    Console.WriteLine("digite sua frase:");
		string x = Console.ReadLine();
    string [] palavras;
    x=x.ToLower();//Passar tudo para minusculo, para a comparacao de vogais darem certo.
    palavras=x.Split();
    int qtdA = 0;
    int qtdE = 0;
    int qtdI = 0;
    int qtdO = 0;
    int qtdU = 0;
		//int s1, s2, s3, s4, s5;
    foreach (string p in palavras)
    {
      foreach (char c in p){
      if (c == 'a'){
        qtdA=qtdA+1;
      }
      else if (c == 'e'){
        qtdE=qtdE+1;
      }
      else if (c == 'i'){
        qtdI=qtdI+1;
      }
      else if (c == 'o'){
        qtdO=qtdO+1;
      }
      else if (c == 'u'){
        qtdU=qtdU+1;
      }
      }
      for (int i =1; i <= (qtdA+qtdE+qtdI+qtdO+qtdU);i++){
        Console.Write($"{p} ");
      }
      qtdA = 0;
      qtdE = 0;
      qtdI = 0;
      qtdO = 0;
      qtdU = 0;
        
    }
    
  }
}