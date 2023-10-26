using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Song
    {
        public string Name { get; set; } 
        public string Author { get; set; }
        public Song Prev {  get; set; }

        public Song(string name, string author) { }

        // метод для печати названия песни и ее исполнителя
        public void PrintInfo()
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Автор: " + Author);
        }

        // метод, который сравнивает между собой два объекта-песни
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;

            return Name == otherSong.Name && Author == otherSong.Author;
        }
    }
}
