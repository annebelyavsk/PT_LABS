using System; // Базовое пространство имён
using ProgressionLibrary; // Подключаем нашу библиотеку прогрессий

namespace ConsoleApp1 // Пространство имён для консольного приложения
{
    class Program
    {
        static void Main(string[] args) // Точка входа программы
        {
            // Создаём несколько объектов прогрессий для тестирования
            AProgression p1 = new AProgression(1, 2);       // Прогрессия: 1, 3, 5, 7, ...
            AProgression p2 = new AProgression(-5, 0.5);    // Прогрессия: -5, -4.5, -4, ...
            AProgression p3 = new AProgression(10, -3);     // Прогрессия: 10, 7, 4, 1, ...

            Console.WriteLine("=== Прогрессия 1 ==="); // Заголовок
            p1.PrintInfo(); // Выводим параметры прогрессии
            p1.PrintFirstN(5); // Выводим первые 5 членов
            Console.WriteLine($"Сумма первых 5 членов: {p1.GetSum(5)}"); // Выводим сумму
            Console.WriteLine(); // Пустая строка

            Console.WriteLine("=== Прогрессия 2 ==="); // Заголовок
            p2.PrintInfo(); // Информация
            p2.PrintFirstN(4); // Вывод 4 элементов
            Console.WriteLine($"Сумма первых 4 членов: {p2.GetSum(4)}"); // Сумма
            Console.WriteLine(); // Пустая строка

            Console.WriteLine("=== Прогрессия 3 ==="); // Заголовок
            p3.PrintInfo(); // Информация
            p3.PrintFirstN(6); // Вывод 6 элементов
            Console.WriteLine($"Сумма первых 6 членов: {p3.GetSum(6)}"); // Сумма
            Console.WriteLine(); // Пустая строка

            // Демонстрация изменения свойств
            Console.WriteLine("=== Изменение параметров прогрессии 1 ===");
            p1.First = 0; // Меняем первый член
            p1.Step = 10; // Меняем шаг
            p1.PrintInfo(); // Вывод обновлённой информации
            p1.PrintFirstN(3); // Выводим первые 3 элемента уже новой прогрессии
            Console.WriteLine($"Сумма первых 3 членов: {p1.GetSum(3)}"); // Сумма

            // Проверка обработки ошибки при неверном параметре
            try
            {
                p1.GetSum(0); // Пытаемся вычислить сумму при n = 0 → должно вызвать исключение
            }
            catch (ArgumentException ex) // Ловим ошибку
            {
                Console.WriteLine("Обработка ошибки: " + ex.Message); // Печатаем сообщение
            }
        }
    }
}
