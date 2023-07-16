using static System.Net.Mime.MediaTypeNames;

namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Разделяем текст на слова
        /// </summary>
        /// <param name="text">Введенное пользователем предложение</param>
        /// <returns>Массив из разделенных слов</returns>
        static string[] SplitText(string text)
        {
            string[] word = text.Split(' ');

            foreach (var e in word)
            {
                Console.WriteLine($"{e}");
            }
            return word;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            SplitText(Console.ReadLine());
        }
    }
}