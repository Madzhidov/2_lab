using System.Linq;
namespace _1_lab
{
    /// <summary>
    /// Чтение и запись текстовых файлов
    /// </summary>
    public static class Reader
    {
        /// <summary>
        /// Чтение файла
        /// </summary>
        /// <param name="path">Путь</param>
        /// <returns>Строка, ситанная из файла </returns>
        public static string Read(string path)
        {
            string s = System.IO.File.ReadAllText(path).Replace("\n", " ");
            return s;
        }
        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="path">Путь</param>
        /// <param name="data">Строка</param>
        /// <param name="method">a - добавить в конец файла, n - создать и записать в файл</param>
        public static void  Write(string path, string data, string method)
        {
            switch(method)
            {
            case "a":
            System.IO.File.AppendAllText(path,data);
            break;
            case "n":
            System.IO.File.WriteAllText(path,data);
            break;
            }
        }
                /// <summary>
        /// Количество палиндромов в файле
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Количество слов - палиндромов</returns>
        public static int Palindrom(string path)
        {
            int temp = 0;
            string[] words = System.IO.File.ReadAllText(path).Split(" ");
            foreach (string word in words)
            {
               if (word.SequenceEqual(word.Reverse()))
               {
                   System.Console.WriteLine(word);
                   temp++;
               }
            }
            return temp;
        }

    }
}