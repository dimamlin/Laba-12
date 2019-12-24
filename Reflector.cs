using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace laba_12
{
    class Reflector
    {
        public static Type GetTypeByString(string name)
        {
            return Type.GetType("Рефлексия." + name);
        }

        // №1

        public static void ToFile(string ClassName, string name)
        {
            StreamWriter writer = new StreamWriter(@"D:/laba/" + name + ".txt");
            Console.WriteLine(ClassName); 
            Type t1 = ClassName.GetType();                                                  // получаем тип 
            writer.WriteLine($"Класс {t1.Name}");
            foreach (var x in t1.GetConstructors())                                         // конструкторы
            {
                writer.WriteLine(x);
            }
            writer.WriteLine("Методы:");
            foreach (var x in t1.GetMethods())                                              // методы
            {
                writer.WriteLine(x);
            }
            writer.WriteLine("Поля:");
            foreach (var x in t1.GetFields())                                               // массив объектов
            {
                writer.WriteLine(x);
            }
            writer.Close();
        }

        // №2

        public static void GetPublicMethods(string ClassName)
        {
            Type t = ClassName.GetType();
            Console.WriteLine($"Public методы класса {t.Name}:");
            foreach (var x in t.GetMethods())
            {
                if (x.IsPublic)
                    Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        // №3

        public static void GetField(string ClassName)
        {
            Type t = ClassName.GetType();
            Console.WriteLine($"Поля и свойства класса {t.Name}");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        // №4

        public static void GetInterfaces(string ClassName)
        {
            Type t = ClassName.GetType();
            Console.WriteLine($"Интерфейсы класса {t.Name}");
            foreach (var x in t.GetInterfaces())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        // №5

        public static void GetMethodsByParam(string ClassName, string param)
        {

            Type t = ClassName.GetType();
            Console.WriteLine($"Методы класса {t.Name} с параметром {param}");
            foreach (var x in t.GetMethods())
            {
                foreach (var q in x.GetParameters())
                {
                    if (q.ParameterType.ToString() == param)
                        Console.WriteLine(x);
                }
            }
            Console.WriteLine();
        }
 
        // №6

        public static void _CallMethodFromFile<T>(T obj)
        {
            StreamReader reader = new StreamReader(@"D:/laba/arg.txt", Encoding.Default);
            string line1, line2, line3;
            line1 = reader.ReadLine();
            line2 = reader.ReadLine();
            line3 = reader.ReadLine();
            reader.Close();
            Time.TestPrint(line1, Convert.ToInt32(line2), Convert.ToInt32(line3));
        }
    }
}
