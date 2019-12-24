using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace laba_12
{
    class A
    {
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "Объекты класса Software: ";
        }
    }

    sealed class Developer //бесплодный
    {
        readonly string name = null;
        readonly string surname = null;
        int age = 0;
        readonly string country = null;
        readonly string city = null;
        readonly string creationDate = null;
        readonly string laba = null;

        Developer()
        {
            this.name = "Tony";
            this.surname = "Osipenko";
            this.age = 18;
            this.country = "Belarus";
            this.city = "Minsk";
            this.creationDate = "14.10.2019";
            this.laba = "OOП С#";
        }
    }

    // пользователь
    abstract public class User : WordProcessor
    {
        public string name = null;
        public readonly int ID;

        public User(int len, int b)
        {
            // генерация ID
            for (int i = 0; i < len; i++)
            {
                Random rand = new Random();
                int value = rand.Next(3000000);
                ID = value * 2;
            }
            Console.WriteLine("Введите имя пользователя:  ");
            name = Console.ReadLine();
            if (name == "Tony" || name == "Boris")
            {

            }
            else
            {
                Console.WriteLine("Данный пользователь не существует");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

    }

    // ПО
    public class Software : User
    {

        public readonly string nameCOMP;
        string nameWin = null;
        string nameCPU = null;
        int memory = 0;
        int RAM = 0;
        string nameAntiv = null;


        public Software() : base(5, 5) //Переопределение
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_________________________________Запускаем ПК__________________________________");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("добро пожаловать " + name);

            Console.Write("Введите название компьютера: ");
            nameCOMP = Console.ReadLine();




            Console.WriteLine("Информация о ПК " + nameCOMP + ":");
            nameAntiv = "360 total security ";
            nameWin = "Windows 7";
            nameCPU = "Intel CORE i7";
            memory = 2;
            RAM = 10;

        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("OC: " + nameWin);
            Console.WriteLine("CPU: " + nameCPU);
            Console.WriteLine("hard drive: " + memory + "ТБ");
            Console.WriteLine("RAM: " + RAM + "ГБ");
            Console.WriteLine("Антивирус: " + nameAntiv);

            Console.WriteLine("///////////////////////////////");
        }

    }
    // абстрактый класс текстовый редактор(библиотека)
    abstract public class WordProcessor : Word
    {
        static int numOperation;


        public void HelloUser()
        {

            Console.WriteLine(" Вы попали в командный центр вашего ПК");
            Console.WriteLine(" Выберите команду: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1)Выключить компьютер");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 2)Сыграть в Игру");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 3)Показать ПО компьютера");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 4)Поиск нужного ПО");

            numOperation = Int32.Parse(Console.ReadLine());
            if (numOperation == 1)
            {
                Operation_1();
            }
            if (numOperation == 2)
            {
                Operation_2();
            }
            if (numOperation == 3)
            {
                Operation_3();
            }
            if (numOperation == 4)
            {
                Operation_4();
            }
        }

    }
    // Первая команда(слово)

    interface IAction
    {
        void MoveOFF();
    }
    interface IBction
    {
        void MovePlay();
    }


    public class Word : Game, IAction, IBction
    {
        //
        public static string forPO = null;
        public static string _forPO = null;
        //

        /////////////////////
        public void Operation_1()
        {
            Console.WriteLine("off the computer");
            MoveOFF();
        }
        public void MoveOFF()
        {
            Console.WriteLine("____________________________Завершение работы ПК________________________________");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        /////////////////////
        public void Operation_2()
        {
            Console.WriteLine("play game");
            MovePlay();
        }

        public void MovePlay()
        {
            _Game();
        }

        ///////////////////
        public void Operation_3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Работа с ПО");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<string> strings = new List<string>() { "Notepad++", "Visual Studio 2017", "Wireshark", "AnyDesk", "Intel-Driver", "VirtualBox", "360 Total Security" };
            strings.Sort();
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Хотите скачать дополнительное ПО на ваш компьютер?");
            Console.WriteLine("1)Да");
            Console.WriteLine("2)нет");
            int tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp == 1)
            {
                Console.Write("");
                Console.Write("Введите название программы: ");
                forPO = Console.ReadLine();
                strings.Add(forPO);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Успешно загружено " + forPO + " на ваш компьютер ");
                Console.WriteLine("");
                strings.Sort();
                foreach (string item in strings)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                Console.WriteLine("Ваш ПК нуждаетсяв перезагрузке");
                Thread.Sleep(2000);
                Console.WriteLine("____________________________Завершение работы ПК________________________________");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("____________________________Завершение работы ПК________________________________");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }

        public void Operation_4()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите искомую прогамму");
            Console.WriteLine("");

            List<string> strings = new List<string>() { "Notepad++", "Visual Studio 2017", "Wireshark", "AnyDesk", "Intel-Driver", "VirtualBox", "360 Total Security" };

            strings.Sort();

            _forPO = Console.ReadLine();
            string subString = _forPO;
            Console.Write("Вы можете обратиться к данной программе по индексу: ");
            Console.ForegroundColor = ConsoleColor.Red;
            int indexOfSubstring = strings.IndexOf(subString);
            Console.WriteLine(indexOfSubstring);
            switch (indexOfSubstring)
            {
                case 1:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("AnyDesk");
                    break;
                case 2:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("Intel-Driver");
                    break;
                case 3:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("Notepad++");
                    break;
                case 4:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("VirtualBox");
                    break;
                case 5:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("Visual Studio 2017");
                    break;
                case 6:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("Wireshark");
                    break;
                case 7:
                    Console.Write("Данная программа найдена на компьютере:");
                    Console.WriteLine("360 Total Security");
                    break;
            }


        }

    }

    public class Game : Virus
    {
        static int again = 'y';

        public void _Game()
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);
            Random rand = new Random();
            while (again == 'y')
            {
                int i = rand.Next(30);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Компьютер загадал число от 0 до 30");
                Console.WriteLine("Подсказка:");
                if (i < 15) Console.WriteLine("Число меньше 15");
                else Console.WriteLine("Число больше или равно 15");

                int x = Convert.ToInt32(Console.ReadLine());

                if (i == x) Console.WriteLine("Поздравляем! Вы победили свой компьютер!");

                else Console.WriteLine("Вы проиграли! Компьютер загадал число {0}", i);

                Console.WriteLine("Попробовать еще? (y = Да, n = Нет)");
                again = Convert.ToChar(Console.ReadLine());
                if (again == 'n')
                {
                    Destruction();
                }
            }

        }
    }

    // уголок вирусов
    public class Virus : Antivirus
    {
        static string Worm = "Worm";
        static string TrojanProgram = "TrojanProgram";
        static string Spyware = "Spyware";
        static string BootVirus = "BootVirus";
        static string Rootkit = "Rootkit";

        public void Destruction()
        {
            Random rand = new Random();
            int i = rand.Next(4);
            if (i == 0)
            {
                do
                {
                    for (int cur = 0; cur < 10; cur++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Beep(784, 150);

                        Thread.Sleep(100);
                        Console.WriteLine("ВНИМАНИЕ!!! ERROR!!! ВНИМАНИЕ!!! ERROR!!!");
                        Console.WriteLine("ПК заражено вирусом: " + Worm);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!!Нажмите Escape,чтобы вызвать антивирус!!!");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Help();
            }

            if (i == 1)
            {
                do
                {
                    for (int cur = 0; cur < 10; cur++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Beep(784, 150);

                        Thread.Sleep(100);
                        Console.WriteLine("ВНИМАНИЕ!!! ERROR!!! ВНИМАНИЕ!!! ERROR!!!");
                        Console.WriteLine("ПК заражено вирусом: " + TrojanProgram);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!!Нажмите Escape,чтобы вызвать антивирус!!!");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Help();

            }

            if (i == 2)
            {
                do
                {
                    for (int cur = 0; cur < 10; cur++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Beep(784, 150);


                        Thread.Sleep(100);

                        Console.WriteLine("ВНИМАНИЕ!!! ERROR!!! ВНИМАНИЕ!!! ERROR!!!");
                        Console.WriteLine("ПК заражено вирусом: " + Spyware);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!!Нажмите Escape,чтобы вызвать антивирус!!!");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Help();

            }

            if (i == 3)
            {
                do
                {
                    for (int cur = 0; cur < 10; cur++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Beep(784, 150);

                        Thread.Sleep(100);

                        Console.WriteLine("ВНИМАНИЕ!!! ERROR!!! ВНИМАНИЕ!!! ERROR!!!");
                        Console.WriteLine("ПК заражено вирусом: " + BootVirus);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!!Нажмите Escape,чтобы вызвать антивирус!!!");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Help();

            }

            if (i == 4)
            {
                do
                {
                    for (int cur = 0; cur < 10; cur++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Beep(784, 150);

                        Thread.Sleep(100);
                        Console.WriteLine("ВНИМАНИЕ!!! ERROR!!! ВНИМАНИЕ!!! ERROR!!!");
                        Console.WriteLine("ПК заражено вирусом: " + Rootkit);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!!Нажмите Escape,чтобы вызвать антивирус!!!");
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
                Help();

            }

        }

    }
    public class Antivirus
    {
        static char HelpEROR = 'y';
        public string File1 = null;
        string File2 = null;
        string File3 = null;
        string File4 = null;

        public void Help()
        {

            Console.WriteLine("вызван антивирус 360 total security");


            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);
            Random rand = new Random();
            while (HelpEROR == 'y')
            {
                int i = rand.Next(4);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("ВСЕ ЗАВИСИТ ОТ ВАС!!! ВАМ ВСЕГО-ТО НУЖНО ВЫБРАТЬ НОМЕР ФАЙЛА, КОТОРЫЙ ЗАРАЖЕН   ВИРУСОМ!!! ИЛИ ВАША ОС БУДЕТ УНИЧТОЖЕНА");
                Console.ForegroundColor = ConsoleColor.Red;
                File1 = "C:Program Files(x86)->Opera";
                File2 = "C:Program Files(x86)->NetCracker Professional";
                File3 = "C:Program Files(x86)->Wireshark";
                File4 = "C:Program Files(x86)->Microsoft Visual Studio 10.0";

                Console.WriteLine("1)" + File1);
                Console.WriteLine("2)" + File2);
                Console.WriteLine("3)" + File3);
                Console.WriteLine("4)" + File4);

                int input = Convert.ToInt32(Console.ReadLine());

                if (i == input)
                {
                    Console.WriteLine("Поздравляем! Вы победили ВИРУС!");
                    Console.WriteLine("____________________________Перезагрузка ПК________________________________");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else Console.WriteLine("Файл пуст! Ваша ОС разрушена ");
                Thread.Sleep(2000);
                for (int _i = 0; i < 10000000000; i--)
                { Console.WriteLine("ERRRRROOOOORRRRR"); }

            }

        }

    }
    struct IUser
    {
        public string name;
        public int age;
        public IUser(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Разработчик: ");
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
}
