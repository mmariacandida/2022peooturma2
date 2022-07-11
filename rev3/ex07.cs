using System;
class Program{
  public static void Main(){
   Console.WriteLine("digite sua frase:");
		string x = Console.ReadLine();

		int s1;

    s1 = x.IndexOf(' '); //busca pelo caractere especificado e retorna sua posição, caso não encontre ele retorna -1.
		while (s1 != -1) { //-1 pq se o valor de cima der falso ele termina o código, caso contrário ele faz o while.
			x = x.Substring(s1 + 1); //substring pega daquela posição pra frente, só execulta depois da posição determinada pra frente.
			Console.WriteLine(x);
			s1 = x.IndexOf(' '); //ele verifica se o valor deu -1 pra continuar ou não.
    }
  }
}