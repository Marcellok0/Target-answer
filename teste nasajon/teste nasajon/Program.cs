using System;

public class program {


  public static string SumMultiplier(int[] arr) {
    //calcula a soma de todos os elementos da matriz
  int sum = arr.Sum();
//calcula o dobro da soma de todos os lementos da matriz
  int doubleSum = sum*2;

//percorre todos os pares de elementos da matriz
for (int i = 0; i < arr.Length - 1; i++) 
{
  for (int j = i + 1; j < arr.Length; j++) 
  {
    //verifica se o produto dos elementos é maior que o dobro da soma
    if (arr[i] * arr[j] > doubleSum) {
      return "true";
    }
  }
}
 return "false";
 }

  static void Main(string[] args) {
        int[] arr = new int[] { 2, 5, 6, -6, 16, 2, 3, 6, 5, 3 };

    // keep this function call here
    Console.WriteLine(SumMultiplier(arr));
    
  } 

}