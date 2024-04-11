using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1; double a2; double a3; double a4; double a5; double a6; double a7; double a8; double a9; double a10; double a11; double a12; double a13; double a14;
            double S = 0;
            

            Console.WriteLine("Шановний лiкарю, введiть вiдповiдi пацiєнта на наданi питання. \nКожне питання оцiнюється за 5-бальною шкалою вiд 0 (вiдсутня) до 4 (важкий).");
            Console.WriteLine("\n");
            Console.WriteLine("Бланк з вiдповiдями до шкали Гамiльтона (HARS) \n");
            
            //1
            Console.WriteLine("Перше питання \nТривожний настрiй (заклопотанiсть, очiкування найгiршого, тривожнi побоювання, дратiвливiсть)");

            Console.ForegroundColor = Console.BackgroundColor; 
            a1 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a1 > -1 && a1 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a1);
            } 
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a1 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a1);
            }

            //2
            Console.WriteLine("Друге питання \nНапруга (вiдчуття напруги, плаксивiсть, що легко виникає, тремтiння, вiдчуття неспокою, нездатнiсть розслабитися)");  

            Console.ForegroundColor = Console.BackgroundColor; 
            a2 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a2 > -1 && a2 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a2);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a2 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a2);
            }
            
            //3
            Console.WriteLine("Третє питання \nСтрахи (темряви, незнайомцiв, самоти, тварин, натовпу, транспорту)");

            Console.ForegroundColor = Console.BackgroundColor;
            a3 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a3 > -1 && a3 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a3);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a3 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a3);
            }

            //4
            Console.WriteLine("Четверте питання \nIнсомiя (утруднене засипання, переривчастий сон, що не приносить вiдпочинку, вiдчуття розбитостi та слабкостi при пробудженнi, кошмарнi сни)");
            
            Console.ForegroundColor = Console.BackgroundColor;
            a4 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a4 > -1 && a4 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a4);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a4 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a4);
            }

            //5
            Console.WriteLine("П'яте питання \nIнтелектуальнi порушення (утруднення концентрацiї уваги, погiршення пам'ятi)"); 

            Console.ForegroundColor = Console.BackgroundColor;
            a5 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a5 > -1 && a5 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a5);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a5 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a5);
            }

            //6
            Console.WriteLine("Шосте питання \nДепресивний настрiй (втрата звичайних iнтересiв i вiдчуття задоволення вiд хобi, пригнiченiсть, раннi пробудження, добовi коливання настрою)");

            Console.ForegroundColor = Console.BackgroundColor;
            a6 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a6 > -1 && a6 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a6);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a6 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a6);
            }
            //7
            Console.WriteLine("Сьоме питання \nСоматичнi м'язовi симптоми (болi, сiпання, напруга, судоми клонiчнi, скрипiння зубами, голос, що зривається, пiдвищений м'язовий тонус)");

            Console.ForegroundColor = Console.BackgroundColor;
            a7 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a7 > -1 && a7 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a7);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a7 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a7);
            }

            //8
            Console.WriteLine("Восьме питання \nСоматичнi сенсорнi симптоми (дзвiн у вухах, нечiткiсть зору, приливи жару та холоду, вiдчуття слабкостi, поколювання)");

            Console.ForegroundColor = Console.BackgroundColor;
            a8 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a8 > -1 && a8 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a8);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a8 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a8);
            }

            //9
            Console.WriteLine("Дев'яте питання \nСерцево-судиннi симптоми (тахiкардiя, серцебиття, бiль у грудях, пульсацiя в судинах, частi зiтхання)");

            Console.ForegroundColor = Console.BackgroundColor;
            a9 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a9 > -1 && a9 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a9);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a9 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a9);
            }

            //10
            Console.WriteLine("Десяте питання \nРеспiраторнi симптоми (тиск i стиснення у грудях, задуха, частi зiтхання)");

            Console.ForegroundColor = Console.BackgroundColor;
            a10 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a10 > -1 && a10 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a10);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a10 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a10);
            }

            //11
            Console.WriteLine("Одинадцяте питання \nГастро-iнтестинальнi симптоми (утруднене ковтання, метеоризм, бiль у животi, печiя, вiдчуття переповненого шлунку, нудота, блювання, бурчання у животi, дiарея, закрепи,зниження маси тiла)");

            Console.ForegroundColor = Console.BackgroundColor;
            a11 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a11 > -1 && a11 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a11);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a11 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a11);
            }

            //12
            Console.WriteLine("Дванадцяте питання \nСечостатевi симптоми (прискорене сечовипускання, сильнi позиви до сечовипускання, аменорея, менорагiя, фригiднiсть, передчасна еякуляцiя, втрата лiбiдо, iмпотенцiя)"); 

            Console.ForegroundColor = Console.BackgroundColor;
            a12 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a2 > -1 && a12 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a2);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a12 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a12);
            }

            //13
            Console.WriteLine("Тринадцяте питання \nВегетативнi симптоми (сухiсть у ротi, почервонiння або блiдiсть шкiри, пiтливiсть, головний бiль з вiдчуттям напруги)");

            Console.ForegroundColor = Console.BackgroundColor;
            a13 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a13 > -1 && a13 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0} \n", a13);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a13 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0} \n", a13);
            }

            //14
            Console.WriteLine("Чотирнадцяте питання \nПоведiнка при оглядi (совається на стiльцi, неспокiйнi жестикуляцiя та хода,тремор, похмуре обличчя, напружений вираз обличчя, зiтхання або прискорене дихання, часте глитання слини)");

            Console.ForegroundColor = Console.BackgroundColor;
            a14 = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (a14 > -1 && a14 < 5)
            {
                Console.WriteLine("Вiдповiдь: {0}", a14);
            }
            else
            {
                Console.WriteLine("Невiрне значення!!! Введiть правильну вiдповiдь!");

                Console.ForegroundColor = Console.BackgroundColor;
                a14 = double.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine("Вiдповiдь: {0}", a14);
            }

            //Результат
            Console.WriteLine("\n");
            S = S + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14;
            Console.WriteLine("Результат: {0}", S);
            Console.WriteLine("\n");

            //Iнтерпритацiя результатiв
            if (S < 18) { Console.WriteLine("У пацiєнта легка ступiнь тривожностi"); }
            else if (S < 25) { Console.WriteLine("У пацiєнта ступiнь тривожностi вiд легкої до помiрної"); }
            else if (S < 31) { Console.WriteLine("У пацiєнта ступiнь тривожностi вiд помiрної до важкої"); }
            else { Console.WriteLine("У пацiєнта сильне занепокоєння"); }

            Console.ReadKey();
        }
    }
}
