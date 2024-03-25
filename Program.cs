using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("програма называеться 'угадай число' ");
            Random random = new Random();
            int randomNumber = random.Next(0, 100); //рандом числа
            while(true) //закончиться, когда станет true
            {
                Console.WriteLine("введите число");
                int x = Convert.ToInt32(Console.ReadLine());  //Convert это конвертировать вписанные данные пользывателя
                if(randomNumber == x)  //если правильно
                {
                    Console.WriteLine("Правильно, Спасибо что протестировали моё обучающее приложение");
                    Console.ReadLine();
                    break;
                }
                else if (randomNumber > x) //если больше
                {
                    Console.WriteLine("Больше");
                }
                else if (randomNumber < x) //если меньше
                {
                    Console.WriteLine("меньше");
                }
            }


        }
    }
}
