using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_12
{
    public class MyVector : IEquatable<MyVector>
    {

        public int[] Arr { get; }
        public int Capacity { get; }
        public string name { get; }
        public int Length { get; }
        public int Max { get; private set; }
        public int Min { get; private set; }


        //констрик еще один
        public MyVector(string _name, int n, int[] Arr)
        {
            Length = n;
            Capacity = Length + 1;
            Arr = new int[Capacity];
        }

        // Конструктор с передачей вместимости вектора
        public MyVector(int length)
        {
            Length = length;
            Arr = new int[Length];
        }

        // Конструктор с передачей вместимости вектора и значения по умолчанию
        public MyVector(int length, int defaultValue)
              : this(length)
        {
            for (int index = 0; index < Length; index++)
                Arr[index] = defaultValue;
            Max = defaultValue;
            Min = defaultValue;
        }
        // Конструктор с передачей значений массива
        public MyVector(IEnumerable<int> values)
              : this(values.Count())
        {
            int index = 0;
            foreach (int item in values)
                Arr[index++] = item;
            Max = Arr.Max();
            Min = Arr.Min();
        }

        public int this[int index]
        {
            get => Arr[index];
            set
            {
                Arr[index] = value;
                Max = Arr.Max();
                Min = Arr.Min();
            }
        }

        public bool Equals(MyVector other)
        {
            if (Length != other.Length || Max != other.Max || Min != other.Min)
                return false;

            for (int index = 0; index < Length; index++)
                if (Arr[index] != other.Arr[index])
                    return false;
            return true;
        }

        public override bool Equals(object obj)
              => (obj is MyVector vector) && Equals(vector);

        public override int GetHashCode()
        {
            int hash = Length.GetHashCode();
            for (int index = 0; index < Length; index++)
                hash ^= Arr[index].GetHashCode();
            return hash;
        }

        private static readonly char[] separators = { ',', ' ', '/', '\\' };
        public static MyVector Parse(string source, params char[] separators)
             => new MyVector(source.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
        public static MyVector Parse(string source)
             => Parse(source, separators);


        public override string ToString()
        {
            return $"Length : {Length }\r\n{string.Join(", ", Arr)}";
        }


        public static void Print(string NewVector, string NewLastVector)
        {
            Console.WriteLine($"Первый параметр = {NewVector}");
            Console.WriteLine($"Второй параметр = {NewLastVector}");
        }


    }
}