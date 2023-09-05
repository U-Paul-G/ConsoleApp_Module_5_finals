using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp_Module_5_finals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ////const string myName = "Paul";
            ////Console.WriteLine(myName);
            //Console.WriteLine("\t Привет, \n мир");
            ////Console.WriteLine('\x23');
            ////Console.WriteLine(0x0A);
            ////Console.ReadKey();

            //string MyName = "Paul";
            //byte MyAge = 36;
            //bool HaveIApet = false;
            //double MyShoeSize = 42.5;

            //Console.WriteLine("My name is " + MyName);
            //Console.WriteLine("MyAge " + MyAge);
            //Console.WriteLine("Do I have a pet? " + HaveIApet);
            //Console.WriteLine("My shoe size is " + MyShoeSize);


            //        enum DaysOfWeek : byte
            //{
            //    Tuesday,
            //    Monday,
            //    Wednesday,
            //    Friday
            //}
            //enum Semaphore
            //{
            //    Red = 100,
            //    Yellow = 200,
            //    Green = 300
            //}

            var age = 27;
            var weight = 50;
            string MyName = "Евгения";
            string favcolor = "red";
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine($"Меня зовут {MyName}");
            Console.WriteLine($"Мой возраст {age}");
            Console.WriteLine("Возраст {0} \n Вес {1}", age, weight);
            Console.WriteLine("Имя {0} \n Возраст {1} \n Любимый цвет {2}", MyName, age, favcolor);


            string YourName = Console.ReadLine();
            Console.Write("Рад встрече, {0} ", YourName);
            Console.ReadKey();


            double result = 5.0 / 2.0;
            Console.WriteLine("5 / 2 = {0}", result);

            int counter = 10;
            Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);



            //Преобразование типов
            int olddata = 6;
            byte data = (byte)olddata;
            string data_1 = olddata.ToString();


            //Convert.ToInt32
            Console.Write("Enter your age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age1);

            //ver2 Parse
            int age3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is {0} ", age3);
            Console.ReadKey();


            //Анкета
            Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            //byte age4 = (byte)int.Parse(Console.ReadLine());
            var age4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age4);
            Console.ReadKey();

            //Вывод на экран
            Console.WriteLine("Your name is {0} and age is {1} ", name, age4);




            //Анкета 2
            var name1 = "Jane";
            var age5 = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name1, age5);
            Console.Write("What is your favorite day of week? ");
            var day1 = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day1);





            ///Module 4
            //logic
            var a = 5 + 6;
            var b = 7 + 8;

            var c = (b != a) & (b > a + 1);
            var d = (b != a) && (b > a + 1);
            var e = (a > b) ^ (a != b);

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);


            //Условия
            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
                
                if (a == b)
                {
                    Console.WriteLine("Условие истинно");
                }
                else
                {
                    Console.WriteLine("Условие ложно");
                }
            }



            //2
            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b < 10)
            {
                Console.WriteLine("Значение b = {0} меньше 10", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }


            //3
            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }

            //4 Тернарная запись
            var f = a != b ? a + b : b;
            Console.WriteLine(f);




            //5 Пример
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");

            }

            //6 switch
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
            }


            //7 switch
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }



            //////////////////  Циклы
            for (int j = 1; j < 5; j++)
            {
                Console.WriteLine("Iteration {0}", j);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }


            //Ver2
            int i = 1;
            for (; i < 5; i++)
            {
            }

            //Бесконечный цикл
            //while (true)
            //{
            //}


            //while
            int k = 0;
            while (k < 3)
            {
            k++;
            }

            //Do While
            int t = 0;
            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 3);



            // Стоп-слово и бесконечный цикл))
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(k);

                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                  k++;

            }


            //Continue
            var text1 = Console.ReadLine();
            switch (text1)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                
                //default:
                    //continue;
            }




            ////// Массивы

            string[] favcolors = new string[3];

            for (int m = 0; m < favcolors.Length; m++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", m + 1);
                favcolors[m] = Console.ReadLine();
            }

                foreach (var color1 in favcolors)
                {
                    //switch (color1)
                }


            //Размерность массива 
            var arr = new int[] { 1, 2, 3, 4 };
            var l = arr.Length;

            //Разные виды инициализации массива
            int[] arr1 = new int[4] { 1, 2, 3, 5 };
            int[] arr2 = new int[] { 1, 2, 3, 5 };
            int[] arr3 = new[] { 1, 2, 3, 5 };
            int[] arr4 = { 1, 2, 3, 5 };



            // Пример 1 (найти наименьшее число в массиве и его индекс)
            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000,
            minIndex = -1;

            for (int n = 0; n < numbers.Length; n++)
            {
                if (numbers[n] < minValue)
                {
                    minValue = numbers[n];
                    minIndex = n;
                }
            }

            Console.WriteLine("Наименьший элемент массива имеет индекс {0}, значение этого элемента = {1}", minIndex, numbers[minIndex]);




            // Пример 2  - Имя по буквам с пробелами
            Console.WriteLine("Введите своё имя");

            var name2 = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name2)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name2[name2.Length - 1]);



            // Двумерные массивы
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.WriteLine(array[0, 0]);

            //перечисление всех элементов (в один ряд)
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            //длина массива
            Console.WriteLine(array.Length);

            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ")


            //перечисление всех элементов по отдельным строкам
            int[,] array1 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int ii = 0; ii < array1.GetUpperBound(0) + 1; ii++)
            {
                for (int kk = 0; kk < array1.GetUpperBound(1) + 1; kk++)
                    Console.Write(array1[ii, kk] + " ");

                Console.WriteLine();
            }




            //Сортировка массива
            var arrv = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int p = 0; p < arrv.Length; p++)
            {
                for (int j = p + 1; j < arrv.Length; j++)
                {
                    if (arrv[p] > arrv[j])
                    {
                        temp = arrv[p];
                        arrv[p] = arrv[j];
                        arrv[j] = temp;
                    }
                }
            }

            foreach (var item in arrv)
            {
                Console.Write(item);
            }


            //Сумма элементов массива
            int sum = 0;

            for (int r = 0; r < arr.Length; r++)
            {
                sum += arr[r];
            }

            Console.WriteLine(sum);




            //return every item in multi-length array of arrays
            foreach (var color1 in favcolors)
            {
                foreach (var item in color1)
                {
                    Console.Write(item + " ");
                }
            }


            //(various length)
            int[][] array2 = new int[3][];

            array2[0] = new int[2] { 1, 2 };
            array2[1] = new int[3] { 1, 2, 3 };
            array2[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array2)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }




            //CORTEGES
            var anketa0 = (name: "Jane", age: 27);

            Console.WriteLine("Ваше имя: {0}", anketa0.name);
            Console.WriteLine("Ваш возраст: {0}", anketa0.age);
            //or
            Console.WriteLine("Ваше имя: {0}", anketa0.Item1);
            Console.WriteLine("Ваш возраст: {0}", anketa0.Item2);


            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.ReadKey();

            //another variant
            var (name6, age6) = ("Евгения", 27);

            Console.WriteLine("Моё имя: {0}", name6);
            Console.WriteLine("Мой возраст: {0}", age6);

            Console.Write("Введите имя: ");
            name6 = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name6);
            Console.WriteLine("Ваш возраст: {0}", age6);


            //Example Pet
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возрас питомца");
            Pet.Age = double.Parse(Console.ReadLine());



            //Practicum: Great Example
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int x = 0; x < 3; x++)
            {

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var result_x = Console.ReadLine();

                if (result_x == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int z = 0; z < User.favcolors.Length; z++)
                {
                    User.favcolors[z] = Console.ReadLine();
                }
            }






        }
    }

    //Перечисления
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday = 2
    }



}