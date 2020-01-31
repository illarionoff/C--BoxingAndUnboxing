using System;

namespace Boxing
{
    struct MyStruct:IInterface
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayBye()
        {
            Console.WriteLine("Bye");
        }
    }

    interface IInterface
    {
        void SayBye();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 120;

            // Boxing
            object obj = i;
            // Unboxing
            int j = (int) obj;

            Console.WriteLine(j);

            MyStruct mS = new MyStruct();

            //Boxing 1
            object boxed1 = mS;
            //Unboxing
            MyStruct unboxed1 = (MyStruct) boxed1;
            unboxed1.SayHello();

            //Boxing2
            ValueType boxed2 = mS;
            //Unboxin2
            MyStruct unboxed2 = (MyStruct) boxed2;
            unboxed1.SayHello();

            //Boxing3
            IInterface boxed3 = mS;
            //Unboxing3
            MyStruct unboxed3 = (MyStruct) boxed3;
            unboxed3.SayHello();
            unboxed3.SayBye();
        }
    }
}
