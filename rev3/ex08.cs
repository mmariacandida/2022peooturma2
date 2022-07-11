using System;
class Program{
  public static void Main(){
    Console.WriteLine("digite sua frase:");
		string x = Console.ReadLine();

		int s1;
    char c;
    s1 = x.IndexOf(' '); //busca pelo caractere especificado e retorna sua posição, caso não encontre ele retorna -1.
		while (s1 != -1) { //-1 pq se o valor de cima der falso ele termina o código, caso contrário ele faz o while.
			c = x[s1-1];
			Console.WriteLine(c); //tá pegando a última letra (q vem antes do espaço entre uma palavra e outra, esse x é a variável e  dentro do [] está a posição q deve ser exibida na tela)
			s1 = x.IndexOf(' '); //ele verifica se o valor deu -1 pra continuar ou não. pra fazer uma nova busca (uma verificiação) pra saber se encerra ou não.
   //tá dando erro n sei pq.
    }
  }
}