using System;

namespace GarbageTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            Garbage data = new Garbage();
            Garbage testGarbage = new Garbage();
            data.Name = "dataGarbage";
            data.Type = "Large Object Heap";
            testGarbage.Name = "1";
            testGarbage.Value = 11;
            testGarbage.Weight = 2.5;
            testGarbage.Type = "Тестовый мусор";
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(data.Name));
            Console.WriteLine(GC.GetGeneration(testGarbage.Name));
            GC.Collect();
            Test(data);
            Console.WriteLine(GC.GetGeneration(data.Name));
            Console.WriteLine(GC.GetGeneration(testGarbage.Name));
        }

        public static void Test(Garbage garbage)
        {
            garbage.Value = 19;
            garbage.Weight = 88.4;
        }
    }
}
