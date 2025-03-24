    namespace ConsoleApp41;

    internal class Program
    {
    /// <summary>
    /// Кротов Кирилл П23-2.2
    static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №6");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

        double A, B, C, D,  N, S, n, m, k, l, math, phys, info, a, b, c, d;

           switch (sm)
           {
            case 1:
                Console.WriteLine("Введите значение A");
                 A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение B");
                B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение C");
                C = Convert.ToDouble(Console.ReadLine());

                NumberChecker checker = new NumberChecker(A, B, C);

                if (checker.IsOnlyOneEven())
                {
                    Console.WriteLine("Только одно из чисел А и В четное");
                }
                else
                {
                    Console.WriteLine("Либо оба числа четные, либо оба  нечетные");
                }


                if (checker.AreAllMultiplesOfThree())
                {
                    Console.WriteLine("Каждое из чисел A, b, c кратно трем.");
                }
                else
                {
                    Console.WriteLine("Хотя бы одно из чисел A,B,C не кратно трем");
                }
                break;

            case 2:
                Console.WriteLine("Введите значение N");
                 N = Convert.ToDouble(Console.ReadLine());

                MyTaskClass2 checker2 = new MyTaskClass2(N);

                //bool a = (N  % 4 == 0) || (N % 7 == 0);
                if (checker2.A2())
                {
                    Console.WriteLine("Целое N кратно четырем или семи");
                }
                else
                {
                    Console.WriteLine("Целое N некратно четырем или семи");
                }

                //bool b = (N % 5 == 0) && (N % 10 != 0);
                if (checker2.B2())
                {
                    Console.WriteLine("Целое N кратно пяти и не оканчивается нулём");
                }
                else
                {
                    Console.WriteLine("Одно из условий не выполнено!");
                }
                break;

            case 3:
                Console.WriteLine("Введите значение n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение m");
                m = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение k");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение l");
                l = Convert.ToDouble(Console.ReadLine());


                Calculator3 checker3 = new Calculator3(n, m, k, l);

                if (checker3.CalculatorA())
                {
                    Console.WriteLine("Выражение является истинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");
                }

                break;

            case 4:
                Console.WriteLine("Введите значение N");
                N = Convert.ToDouble(Console.ReadLine());

                Calculator4 checker4 = new Calculator4(N);

                if (checker4.CalculatorA())
                {
                    Console.WriteLine("Выражение является инстинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");
                }

                break;

            case 5:
                Console.WriteLine("Введите значение k");
                k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение l");
                l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение m");
                m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите значение n");
                n = Convert.ToDouble(Console.ReadLine());

                Calculator5 calculator5 = new Calculator5(k, l, m, n);
                if (calculator5.CalculatorA()) Console.WriteLine("Истинна");
                else Console.WriteLine("Ложь");
                break;

            case 6:
                Console.WriteLine("Введите сумму покупки от 0 до 100000");
                A = Convert.ToDouble(Console.ReadLine());

                Calculator6 calculator6 = new Calculator6(A);
                if (calculator6.CalculateA() > 0) Console.WriteLine($"Плата по депозиту равна: {calculator6.CalculateA()} рублей");
                else Console.WriteLine("Введите число от 0 до 100000");
                break;

            case 7:
                Console.WriteLine("Введите значение N");
                N = Convert.ToDouble(Console.ReadLine());

                Calculator7 checker7 = new Calculator7(N);

                if (checker7.CalculatorA())
                {
                    Console.WriteLine("Выражение является истинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");

                }

                break;

            case 8:
                Console.WriteLine("Введите значение N");
                N = Convert.ToDouble(Console.ReadLine());

                Calculator8 checker8 = new Calculator8(N);

                if (checker8.CalculatorA())
                {
                    Console.WriteLine("Выражение является истинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");
                }

                break;

            case 9:
                Console.WriteLine("Введите значение n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение m");
                m = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение k");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение l");
                l = Convert.ToDouble(Console.ReadLine());

                Calculator9 checker9 = new Calculator9(n, m, k, l);

                if (checker9.CalculatorA())
                {
                    Console.WriteLine("Выражение является истинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");
                }

                break;

            case 10:
                Console.WriteLine("Введите значение N");
                N = Convert.ToDouble(Console.ReadLine());

                Calculator10 checker10 = new Calculator10(N);

                if (checker10.CalculatorA())
                {
                    Console.WriteLine("Выражение является истинным");
                }
                else
                {
                    Console.WriteLine("Выражение является ложным");
                }
                break;

            case 11:
                Console.WriteLine("Введите стоимость покупки");
                N = Convert.ToDouble(Console.ReadLine());

                Calculator11 checker11 = new Calculator11(N);
                Console.WriteLine();

                break;

            case 12:

                Console.WriteLine("Введите значение k");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение l");
                l = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение m");
                m = Convert.ToDouble(Console.ReadLine());

                Calculator12 checker12 = new Calculator12(k, l, n, m);

                Console.WriteLine(checker12.CalculatorA());

                break;

            case 13:

                Console.WriteLine("Введите время разговора (0-24):");
                double time = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите продолжительность разговора в минутах");
                double duration = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите стоимость минуты разговора:");
                double costPerMinut = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите день недели (1-7, где 1 - понедельник, 7 - воскресенье)");
                int dayOfWeek = int.Parse(Console.ReadLine()); 

                Calculator13 checker13 = new Calculator13(time,  duration, costPerMinut, dayOfWeek);

                double totalCost = checker13.CalculatorA();
                Console.WriteLine($"Общая стоимость разговора: {totalCost:F2}");
                break;

            case 14:
                Calculator14 checker14 = new Calculator14();
                checker14.CalculatorB();
                break;
                
            case 15:

                Console.Write("Введите оценку по математике: ");
                math = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите оценку по информатике: ");
                phys = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите оценку по информатике: ");
                info = Convert.ToDouble(Console.ReadLine());

                Calculator15 checker15 = new Calculator15(math, phys, info);
                if (checker15.CalculatorA())
                    Console.WriteLine("Студент получилает стипендию");
                else
                    Console.WriteLine("хахаха лашара без стипендии");
                break;

            case 16:
                Console.Write("Введите значени A: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени B: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени C: ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени D: ");
                d = Convert.ToDouble(Console.ReadLine());

                Calculator16 checker16 = new Calculator16(a, b, c, d);
                if (checker16.CalculatorA()) Console.WriteLine("Два числа из четырёх - чётные");
                else Console.WriteLine("Либо меньше двух чисел четные, либо больше");
                break;

            case 17:
                Console.Write("Введите значени A: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени B: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени C: ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значени D: ");
                d = Convert.ToDouble(Console.ReadLine());

                Calculator17 checker17 = new Calculator17(a, b, c, d);
                if (checker17.CalculatorA()) Console.WriteLine("Из четырёх чисел, одно делится - на 5, второе - на 3");
                else Console.WriteLine("Из четырех чисел ни одно не делится на 3, либо не делится на 5");
                break;

            case 18:
                Console.WriteLine("Введите сумму покупки от 0 до 50000:");
                a = Convert.ToDouble(Console.ReadLine());

                Calculator18 checker18 = new Calculator18(a);
                Console.WriteLine($"Стоимость покупки равна: {checker18.CalculateA()}");
                break;

            case 19:
                Console.WriteLine("Введите ваш стаж от 0 до 10 лет:");
                a = Convert.ToDouble(Console.ReadLine());

                Calculator19 checker19 = new Calculator19(a);
                Console.WriteLine($"Ваша надбавка за стаж составляет: {checker19.CalculateA()}%");
                break;

            case 20:
                Calculator20 checker20 = new Calculator20();
                checker20.CalculatorB();
                break;

            case 21:
                Console.WriteLine("Введите ваш стаж от 0 до 10 лет:");
                a = Convert.ToDouble(Console.ReadLine());

                Calculator21 checker21 = new Calculator21(a);
                Console.WriteLine($"Ваш коэффициент составляет: {checker21.CalculateA()}");
                break;
        }
        }
    }
