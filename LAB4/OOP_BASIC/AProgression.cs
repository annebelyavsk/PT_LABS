using System; 

namespace ProgressionLibrary 
{
    public class AProgression 
    { 

       //конструктор (метод внутри класса, вызывается автоматически при создании объекта,
       //  задаёт начальные значения, его задача - инициализация)
        public AProgression(double first, double step)
        {
            First = first; 
            Step = step;   
        }

        
        public double First { get; set; }
        public double Step { get; set; }

        public double GetSum(int n)
        {
            if (n <= 0) 
                throw new ArgumentException("Количество членов должно быть положительным.");

            return n / 2.0 * (2 * First + (n - 1) * Step);
        }

        public void PrintFirstN(int n)
        {
            if (n <= 0) 
            {
                Console.WriteLine("Невозможно вывести неположительное количество членов.");
                return; 
            }

            Console.Write("Первые " + n + " членов: "); 

            for (int i = 0; i < n; i++) 
            {
                double term = First + i * Step;

                Console.Write(term); 
                if (i < n - 1) Console.Write(", "); 
            }

            Console.WriteLine(); 
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Арифметическая прогрессия: первый член = {First}, шаг = {Step}");
        }
    }
}