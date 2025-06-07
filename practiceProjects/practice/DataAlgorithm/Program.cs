#region reverseArray
// public class Example
// {
//     public static void Main()
//     {
//         string? input;
//         Console.WriteLine("Digite a palavra a ser invertida: ");
//         input = Console.ReadLine();
//         if (input != "")
//         {

//             string reverse = ReversedString(input);
//             Console.WriteLine(reverse);

//         }
//         else
//         {
//             Console.WriteLine("Valor Inválido!");
//         }

//     }

//     public static String ReversedString(string input)
//     {
//         char[] reversed = new char[input.Length];
//         for (int i = 0; i < input.Length; i++)
//         {
//             reversed[i] = input[input.Length - 1 - i];
//         }
//         return new string(reversed);
//     }

// }
#endregion

#region palindromeWord

// public class Test
// {
//     public static void Main()
//     {
//         string word = "Ovo";
//         word = word.ToLower();
//         string result = reverseWord(word);
//         Console.WriteLine($"The original word: {word}");
//         Console.WriteLine($"The reversed word: {result}");
//         Console.WriteLine($"Is it palindrome? {palindromeWord(result, word)}");
//     }

//     public static String reverseWord(string word)
//     {
//         char[] reverseWord = new char[word.Length];
//         for (int i = 0; i < word.Length; i++)
//         {
//             reverseWord[i] = word[word.Length - 1 - i];
//         }
//         return new string(reverseWord);
//     }

//     public static Boolean palindromeWord(string result, string word)
//     {
//         return result == word;
//     }

// }

#endregion