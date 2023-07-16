namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string inputSentence = Console.ReadLine();

            string reversedWords = ReverseWords(inputSentence);
            Console.WriteLine("Перевернутые слова: " + reversedWords);

        }

        static string ReverseWords(string inputPhrase)
        {
            string[] words = SeparateWords(inputPhrase);
            string reversedSentence = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedSentence += words[i] + " ";
            }

            return reversedSentence;
        }

        static string[] SeparateWords(string inputPhrase)
        {
            string[] words = inputPhrase.Split(' ');

            return words;
        }

            

        
    }
}