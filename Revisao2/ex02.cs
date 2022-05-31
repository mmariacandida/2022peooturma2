using System;
class Program {
	public static void Main (string[] args) {
		Console.WriteLine("Digite as quatro notas do bimestre");
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());
			int n3 = int.Parse(Console.ReadLine());
			int n4 = int.Parse(Console.ReadLine());
	
			int media = (n1 + n2 + n3 + n4) / 4 ;
			Console.WriteLine($"MEDIA = {media}");
			
			Console.WriteLine("maior numero ou igual das notas");
			if (n1 > n2) Console.WriteLine(n1);
			if (n2 > n3) Console.WriteLine(n2);
			if (n3 > n4) Console.WriteLine(n3);
			else Console.WriteLine(n4);
	
			if (n1 == media || n2 == media || n3 == media || n4 == media) Console.WriteLine("tem numero igual ao resultado da media");
	}
}