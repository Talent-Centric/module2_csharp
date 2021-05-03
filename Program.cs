using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace module_2_csharp
{
    class Program
    {
        private const char V = 'A';

        static void Main(string[] args)
        {
            //Generics
            Console.WriteLine("---------------Generics------------------");
            Generics<int> generics = new Generics<int>();
            Generics<double> generics2 = new Generics<double>();
            Console.WriteLine(generics.subs(12, 11));
            Console.WriteLine(generics.adds(12, 11));
            Console.WriteLine(generics2.devides(12, 11));
            Console.WriteLine(generics.multi(12, 11));

            Console.WriteLine("---------------NULLABLE------------------");
            //NULLABLE DATATYPES
            //checkHasValue();
            Console.WriteLine("---------------DELEGATES------------------");
            //Delegates
            //Event driven programming 
            //callbacks in C#
            double s = 10;
            double l = 10;
            double h = 5;
            AreaSqDelegate sqDelegate = new AreaSqDelegate(computeSquareArea);
            double calculateSqArea = sqDelegate.Invoke(s);
            AreaRecDelegate recDelegate = new AreaRecDelegate(computeRectangleArea);
            double calculateRecArea = recDelegate.Invoke(l, h);
            Console.WriteLine("Square area:" + calculateSqArea);
            Console.WriteLine("Reactangle area:" + calculateRecArea);

            Console.WriteLine("---------------ITERATORS------------------");

            int[] wages = new int[] { 100, 400, 500, 40, 50, 1000 };

            IEnumerable<int> enumerable=
            from wage in wages where wage <= 100 select wage;

            IEnumerable<double> enumerableScores = getStudentScores();

            Console.WriteLine("---wages---");
            foreach (int element in enumerable)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---scores---");
            foreach (int element in enumerableScores)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------SWITCH------------------");

            int grade='F';

            switch(grade){
                case 'A':
                  Console.WriteLine("You are first class");
                  break;
                case 'B':
                  Console.WriteLine("You are second class");
                  break;
                case 'C':
                  Console.WriteLine("You are middle class");
                  break;
                default:
                  Console.WriteLine("Not accepted!");
                  break;
            }
        }

        public static IEnumerable<double> getStudentScores()
        {
            // yield return 80;
            // yield return 70;
            // yield return 90;
            // yield return 100;
            int score=50;
            while(score<=70){
                yield return score;
                score++;
            }
        }

        //NULLABLE VALUES IN C#
        public static Boolean checkHasValue()
        {
            //Yes it has value , if the actual value is part of the underlying 

            //declaration

            int? x;

            //defining

            x = null;

            //declaration vs definition

            //When it comes to backend development
            //
            if (x.HasValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double computeSquareArea(double s)
        {
            return s * s;
        }
        public static double computeRectangleArea(double l, double h)
        {
            return l * h;
        }
    }

    //Delegates
    public delegate double AreaSqDelegate(double a);
    public delegate double AreaRecDelegate(double l, double h);
    //Generics
    class Generics<T>
    {
        public T subs(T a, T b)
        {
            dynamic a1 = a;
            dynamic a2 = b;
            return a1 - a2;
        }
        public T adds(T a, T b)
        {
            dynamic a1 = a;
            dynamic a2 = b;
            return a1 + a2;
        }
        public T devides(T a, T b)
        {
            dynamic a1 = a;
            dynamic a2 = b;
            return a1 / a2;
        }
        public T multi(T a, T b)
        {
            dynamic a1 = a;
            dynamic a2 = b;
            return a1 * a2;
        }
    }
}
