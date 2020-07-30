using System;
using System.Diagnostics;
using System.Threading;

namespace Test
{
    class IndexerTest
    {
        private const int MAX = 10;
        private string name;
        private int[] data = new int[MAX];

        public int this[int index]
        {
            get
            {
                if (index <0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                } else
                {
                    return data[index];
                }
            }
            set
            {
                if(!(index <0 || index >= MAX))
                {
                    // set 에는 암시적 매개변수인 value 가 포함되어있다...
                    data[index] = value;
                }
            }
        }
    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            IndexerTest it = new IndexerTest();

            // setter ..
            it[1] = 1024;

            // getter ..
            int i = it[1];

            Console.WriteLine(i);

        }
    }

}
