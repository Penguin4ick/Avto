using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Avto
    {
        //зарандомить расстояние, если проедет, то рандом, пока в баке не закончится бенз.  
        private string NumberAvto; //номер авто
        private int MaxBenz; // максимальный объем бака
        private float Rashod; //расход бенза на 100км
        private float NowBak; // сколько сейчас в баке литров
        public int km; //количество км
        public int vsegokm; //суммарное кол-во км

        public void Info()
        {
            Console.WriteLine("Введите номер машины: ");
            this.NumberAvto = Console.ReadLine();
            Console.WriteLine("Введите максимальный объем бака: ");
            this.MaxBenz = int.Parse(Console.ReadLine());
            if (MaxBenz < 1)
            {
                Console.WriteLine("Вы ввели неверное значение");
                Console.WriteLine("Введите максимальный объем бака: ");
                this.MaxBenz = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите количество бензина в баке: ");
            this.NowBak = float.Parse(Console.ReadLine());
            
            if (NowBak < 0 || NowBak > MaxBenz) //не может быть вписано число меньше 0
            {
                Console.WriteLine("Вы ввели неверное значение");
                Console.WriteLine("Введите количество бензина в баке: ");
                this.NowBak = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите расход топлива на 100 км");
            this.Rashod = float.Parse(Console.ReadLine());
            
        }

        public void Out()
        {
            Console.Clear();
            Console.WriteLine("");
        }
        public void Zapravka()//сколько залить, нельзя больше объема бака
        {
            bool eze = false;
            do
            {
                Console.WriteLine("Введите сколько нужно залить бензина в бак: ");
                eze = false;
                float fail = float.Parse(Console.ReadLine());
                this.NowBak += fail;
                if (fail < 0)
                {
                    Console.WriteLine("Вы ввели неверное значение");
                    eze = true;
                }
                if (this.NowBak > this.MaxBenz)
                {
                    Console.WriteLine("Вы ввели слишком много ");
                    eze = true;
                    this.NowBak -= fail;
                }
            } while (eze == true);
            Console.WriteLine("Всего в баке: " + this.NowBak);

        }
        public void Move() // 
        {
            Random rn = new Random();
             this.km = rn.Next(100,200000);

        } 
        private int Ostatok(int suda)
        {

            return suda;
        }
        private int Chislo(int km)
        {
            Random rn = new Random();
            km = rn.Next(1000, 10000);
            return km;
        }
    }
}
