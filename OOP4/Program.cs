using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class Health
    {
        double temperature;
        public double Temperature
        {
            get
            {
                return (temperature);

            }
            set
            {
                if (value < 31) temperature = 31;
                else if (value > 41) temperature = 41;
                else temperature = value;
            }
        }
    }
    class Book
    {
        int bookEdition;
        public int Edition
        {
            get
            {
                return (bookEdition);
            }
            set
            {
                if (value < 1940) bookEdition = 1940;
                else if (value < 2020) bookEdition = 2020;
                else bookEdition = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру - ");
            Health health1 = new Health();
            health1.Temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура - " + health1.Temperature);
            Console.WriteLine("");
            Console.Write("Введите год выпуска книги -  ");
            Book book1 = new Book();
            book1.Edition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Год  выпуска - " + book1.Edition);
            Console.ReadLine();
        }
    }
}
