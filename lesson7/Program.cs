using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson7
{
    enum BankAccountType
    {
        Current,
        Savings
    }
    public class Account
    {
        
    }
    public static class Extensions
    {
        public static string Reverse(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

    internal class Program
    {
        static void ExtractEmails(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string email = SearchMail(ref line);
                    writer.WriteLine(email);
                }
            }
        }

        static string SearchMail(ref string s)
        {
            int startIndex = s.IndexOf("#") + 1;
            string email = s.Substring(startIndex).Trim();
            s = email;
            return email;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Упражнения 8.1. Создание класса <Счет в банке>. Добавлен метод, который переводит деньги с одного счета на другой.\n");
            BankAccount bankAccount1 = new BankAccount(100000, BankAccountType.Current);
            bankAccount1.Print();
            BankAccount bankAccount2 = new BankAccount(200000, BankAccountType.Savings);
            bankAccount1.Transfer(bankAccount2, 7000);
            bankAccount1.Print();


            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.2. Программа реализует метод, который в качестве входного параметра принимает строку и возвращает новую строку, буквы в которой идут в обратном порядке.\n");
            string str = Console.ReadLine();
            string reverse = str.Reverse();
            Console.WriteLine("Перевернутая строка: " + reverse);
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();


            Console.WriteLine("\nУпражнение 8.3. Программа переписывает в выходной файл содержимое исходного файла, но заглавными буквами.\n");
            string file = "C:\\Users\\Айгуль\\Desktop\\8.3.txt";
            string newFile = "C:\\Users\\Айгуль\\Desktop\\new_8.3.txt";
            if (!File.Exists(file))
            {
                Console.WriteLine("Файл не существует!");
                
            }
            File.Create(newFile).Close();
            string content = File.ReadAllText(file);
            string uppercaseContent = content.ToUpper();
            File.WriteAllText(newFile, uppercaseContent);
            Console.WriteLine($"Содержимое файла {file} было записано в файл {newFile} заглавными буквами.");
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();

            
            Console.WriteLine("Упражнение 8.4. Программа реализует метод, который проверяет, реализует ли входной параметр метода интерфейс System.IFormattable.\n");
            Checker check = new Checker(); 
            string st = "Hello";
            Console.WriteLine("{0}\n{1}", st, check.Check(st)); 
            int num = 10;
            Console.WriteLine("{0}\n{1}", check.Check(st)); 
            DateTime d = DateTime.Now;
            Console.WriteLine(check.Check(st)); Console.WriteLine(check.Check(num));
            Console.WriteLine(check.Check(d));
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();
            


            Console.WriteLine("Д.з 8.1 . Программа");
            string inputFilePath = "C:\\Users\\Айгуль\\Desktop\\lab8.1.txt";
            string outputFilePath = "C:\\Users\\Айгуль\\Desktop\\new_lab8.1.txt";
            File.Create(outputFilePath).Close();
            ExtractEmails(inputFilePath, outputFilePath);
            Console.WriteLine("Новый файл с адресами email создан.");
            Console.WriteLine("Нажмите Enter, чтобы перейти к следующей задаче.");
            Console.ReadKey();


            Console.WriteLine("Д.з 8.2. Программа сравнивает между собой первую и вторую песню в списке.");
            List<Song> songs = new List<Song>();

            Song song1 = new Song("Царица", "Anna Asti");
            songs.Add(song1);

            Song song2 = new Song("Каждй раз", "монеточка");
            songs.Add(song2);

            Song song3 = new Song("Кайф ты поймала", "Konfuz");
            songs.Add(song3);

            Song song4 = new Song("Знаешь ли ты", "Макsим");
            songs.Add(song4);

            foreach (Song song in songs)
            {
                song.PrintInfo();
                Console.WriteLine();
            }

            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Первая и вторая песни равны");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни не равны");
            }

            Console.ReadLine();






        }
    }
}
