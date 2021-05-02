using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("izmir");
            sehirler2.Add("izmir");
            sehirler2.Add("izmir");
            sehirler2.Add("izmir");
            sehirler2.Add("izmir");
            sehirler2.Add("izmir");
            Console.WriteLine(sehirler2.Count);

            MyList<int> sehirler3 = new MyList<int>();
            sehirler3.Add(1);
            sehirler3.Add(2);
            Console.WriteLine(sehirler3.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0]; // 0 elemanlı bir array oluşturduk
        }

        public void Add(T item)
        {
            
            _tempArray = _array;//yani temparray arrayin referansını tutar burada
            _array = new T[_array.Length + 1]; //arraydaki eleman sayısını artırınca eski datalar uçup gider. o sebeple üstte geçici arraye ekledik.
            for(int i=0;i<_tempArray.Length;i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
