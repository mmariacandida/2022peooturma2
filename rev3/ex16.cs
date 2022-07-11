using System;
class Program{
  public static void Main(){
    Console.WriteLine("digite sua frase:");
		string x = Console.ReadLine();
    int qtdA = 0;
    int qtdE = 0;
    int qtdI = 0;
    int qtdO = 0;
    int qtdU = 0;
		//int s1, s2, s3, s4, s5;
    foreach (char c in x)
    {
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
    
    
    
    /*s1 = x.IndexOf('a');
    s2 = x.IndexOf('e');
    s3 = x.IndexOf('i');
    s4 = x.IndexOf('o');
    s5 = x.IndexOf('u');
		while (s1 != -1) { 
			qtdA = qtdA + 1;
			s1 = x.IndexOf('a'); 
    }
    while (s2 != -1) { 
			qtdE = qtdE + 1; 
			s2 = x.IndexOf('e'); 
    }
    while (s3 != -1) { 
			qtdI = qtdI + 1; 
			s3 = x.IndexOf('i'); 
    }
    while (s4 != -1) { 
			qtdO = qtdO + 1; 
			s4 = x.IndexOf('o'); 
    }
    while (s5 != -1) { 
			qtdU = qtdU + 1; 
			s5 = x.IndexOf('u'); 
    }
*/
    Console.WriteLine($"A - {qtdA}");
    Console.WriteLine($"E - {qtdE}");
    Console.WriteLine($"I - {qtdI}");
    Console.WriteLine($"O - {qtdO}");
    Console.WriteLine($"U - {qtdU}");
  }
}
//saida:
//A – 4
//E – 4
//I – 4
//O – 2
//U – 0