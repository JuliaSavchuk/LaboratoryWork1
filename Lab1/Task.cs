namespace Lab1
{
    public static class FileName
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1:");
            Console.WriteLine("\"It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\"");
            Console.WriteLine("Bjarne Stroustrup");

        }
        public static void Task2()
        {
            Console.WriteLine("Task 2:");
            // Оголошення змінних для суми, максимуму, мінімуму та добутку
            int sum = 0;
            int min = 0;
            int max = 0;
            int product = 1;

            Console.WriteLine("Enter five numbers:");

            // Цикл для отримання введених чисел
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number {0}: ", i + 1);
                //вираз Convert.ToInt32(Console.ReadLine()) приймає рядок, який користувач ввів у консоль,
                //та перетворює його у ціле число
                int num = Convert.ToInt32(Console.ReadLine());

                // Додавання числа до суми
                sum += num;

                // Перевірка, чи це новий максимум або мінімум
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;

                // Множення числа на добуток
                product *= num;
            }

            // Виведення результату
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Product: {product}");

        }
        public static void Task3()
        {
            Console.WriteLine("Enter a six-digit number:");
            string input = Console.ReadLine();

            // Обертання числа
            string reversedNumber = ReverseNumber(input);
            // Виведення результату
            Console.WriteLine("The result of rotating a number: " + reversedNumber);

        }

        // Функція для обертання числа
        static string ReverseNumber(string number)
        {
            //Вхідний рядок перетворюється на масив символів.
            char[] charArray = number.ToCharArray();
            //Метод Reverse використовується для зворотнього перетворення масиву
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Task4()
        {
            Console.WriteLine("Enter the numeric range limits:");

            // Отримання нижньої межі діапазону
            Console.Write("Lower limit: ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());

            // Отримання верхньої межі діапазону
            Console.Write("Upper border: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            // Виклик функції для виведення чисел Фібоначчі у вказаному діапазоні
            PrintFibonacciInRange(lowerBound, upperBound);
        }

        // Функція для виведення чисел Фібоначчі у заданому діапазоні
        static void PrintFibonacciInRange(int lowerBound, int upperBound)
        {
            // Ініціалізація змінних для перших двох чисел Фібоначчі
            int a = 0, b = 1;

            // Виведення першого числа Фібоначчі, яке задовольняє умову діапазону
            if (a >= lowerBound && a <= upperBound)
                Console.Write($"{a}, ");

            // Виведення наступних чисел Фібоначчі, які задовольняють умову діапазону
            while (b <= upperBound)
            {
                if (b >= lowerBound)
                    Console.Write($"{b}, ");

                // Обчислення наступного числа Фібоначчі та оновлення значень для наступної ітерації
                int temp = a + b;
                a = b;
                b = temp;
            }

        }
        public static void Task5()
        {
            Console.WriteLine("Enter two integers A and B (A < B):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            // Вивід чисел згідно з умовою
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Task6()
        {
            // Запитуємо користувача про довжину лінії
            Console.Write("Enter the length of the line: ");
            int length = Convert.ToInt32(Console.ReadLine());

            // Запитуємо користувача про символ заповнювач
            Console.Write("Enter a placeholder character: ");
            char fillChar = Console.ReadLine()[0]; // Беремо лише перший символ

            // Запитуємо користувача про напрямок лінії
            Console.Write("Enter the direction of the line (horizontal - h, vertical - v): ");
            char direction = Console.ReadLine()[0]; // Беремо лише перший символ

            // Відображення лінії в залежності від введених параметрів
            if (direction == 'h')
            {
                // Горизонтальна лінія
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillChar);
                }
            }
            else if (direction == 'v')
            {
                // Вертикальна лінія
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillChar);
                }
            }
            else
            {
                Console.WriteLine("Incorrect line direction. Enter 'h' for a horizontal line or 'v' for a vertical line.");
            }
        }
    }
}
